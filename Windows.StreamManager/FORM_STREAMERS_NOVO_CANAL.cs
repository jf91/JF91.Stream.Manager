using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Windows.StreamManager
{
    public partial class FORM_STREAMERS_NOVO_CANAL : Form
    {
        FORM_CANAIS FormCanais_Objects = (FORM_CANAIS)Application.OpenForms["FORM_CANAIS"];
        FORM_CANAIS_CRIAR FormCanaisCriar_Objects = (FORM_CANAIS_CRIAR)Application.OpenForms["FORM_CANAIS_CRIAR"];
        FORM_INICIO FormInicio_Objects = (FORM_INICIO)Application.OpenForms["FORM_INICIO"];
        FORM_STREAMERS FormStreamers_Objects = (FORM_STREAMERS)Application.OpenForms["FORM_STREAMERS"];
        FORM_STREAMERS_NOVO_CANAL FormStreamersNovoCanal_Objects = (FORM_STREAMERS_NOVO_CANAL)Application.OpenForms["FORM_STREAMERS_NOVO_CANAL"];
        FORM_STREAMERS_NOVO_STREAMER FormStreamersNovoStreamer_Objects = (FORM_STREAMERS_NOVO_STREAMER)Application.OpenForms["FORM_STREAMERS_NOVO_STREAMER"];

        MySqlConnection LigacaoDB = new MySqlConnection(Properties.Settings.Default.server);

        MySqlDataAdapter Adapter = new MySqlDataAdapter();
        MySqlDataAdapter Adapter2 = new MySqlDataAdapter();

        MySqlDataReader Reader;

        DataTable TabelaDados = new DataTable();
        DataTable TabelaDados2 = new DataTable();

        public FORM_STREAMERS_NOVO_CANAL()
        {
            InitializeComponent();
            Load_Streamers();
        }

        private void BUTTON_FECHAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUTTON_GUARDAR_Click(object sender, EventArgs e)
        {
            string ChannelTag = "";
            string ChannelName = TEXTBOX_NOME.Text;
            string ChannelRMTP = TEXTBOX_URL_RMTP.Text;
            string CasterRMTP = TEXTBOX_CASTER_RMTP.Text;

            if (TEXTBOX_NOME.Text != "")
            {
                foreach (TreeNode TN in TREEVIEW_STREAMERS.Nodes)
                {
                    if (TN.IsSelected == true)
                    {
                        ChannelTag = TN.Tag.ToString();
                    }

                    foreach (TreeNode TN2 in TN.Nodes)
                    {
                        if (TN2.IsSelected == true)
                        {
                            ChannelTag = TN2.Tag.ToString();
                        }
                    }
                }

                if (ChannelTag != "")
                {
                    CreateStreamerChannel(ChannelTag, ChannelName, ChannelRMTP, CasterRMTP);

                    Reset();

                    Load_Streamers();

                    FormStreamers_Objects.Reset();
                    FormStreamers_Objects.LoadStreamers();

                    FormInicio_Objects.Reset();
                    FormInicio_Objects.Load_WebsiteChannels();
                    FormInicio_Objects.Load_Streamers();
                }
            }            
        }

        public void Reset()
        {
            TEXTBOX_NOME.Text = "";
            TEXTBOX_URL_RMTP.Text = "";
            TEXTBOX_CASTER_RMTP.Text = "";

            TREEVIEW_STREAMERS.Nodes.Clear();
        }

        public void Load_Streamers()
        {
            try
            {
                LigacaoDB.Open();

                string Query_Streamers = PARAMETERS.Q_Search_Streamers;
                string Query_StreamersChannels = PARAMETERS.Q_Search_StreamersChannels;

                MySqlCommand Command_Streamers = new MySqlCommand(Query_Streamers, LigacaoDB);
                MySqlCommand Command_StreamersChannels = new MySqlCommand(Query_StreamersChannels, LigacaoDB);

                Adapter.SelectCommand = Command_Streamers;
                Adapter2.SelectCommand = Command_StreamersChannels;

                Adapter.Fill(TabelaDados);
                Adapter2.Fill(TabelaDados2);

                Fill_Streamers(TabelaDados, TabelaDados2, TREEVIEW_STREAMERS.Nodes);

                LigacaoDB.Close();
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void Fill_Streamers(DataTable TabelaDados, DataTable TabelaDados2, TreeNodeCollection NODES)
        {
            try
            {
                foreach (DataRow ROW in TabelaDados.Rows)
                {
                    TreeNode TN = new TreeNode();
                    TN.Text = ROW["name"].ToString();
                    TN.Tag = ROW["ID"].ToString();

                    TREEVIEW_STREAMERS.Nodes.Add(TN);

                    foreach (DataRow ROW2 in TabelaDados2.Rows)
                    {
                        if (ROW2["streamer_id"].ToString() == ROW["ID"].ToString())
                        {
                            foreach (TreeNode Streamer in TREEVIEW_STREAMERS.Nodes)
                            {
                                if (Streamer.Tag.ToString() == ROW2["streamer_id"].ToString())
                                {
                                    TreeNode TN2 = new TreeNode();
                                    TN2.Text = ROW2["name"].ToString();
                                    TN2.Tag = ROW2["streamer_id"].ToString();

                                    Streamer.Nodes.Add(TN2);
                                }
                            }
                        }

                    }
                }

                TabelaDados.Clear();
                TabelaDados2.Clear();
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        public void CreateStreamerChannel(string ChannelTag, string ChannelName, string ChannelRMTP, string CasterRMTP)
        {
            try
            {
                LigacaoDB.Open();

                string Query_CreateStreamerChannel = "INSERT INTO streamers_channels" + PARAMETERS.Project + "(name, rmtp_url, caster_rmtp, streamer_id) VALUES('" + ChannelName + "','" + ChannelRMTP + "', '" + CasterRMTP + "', '" + ChannelTag + "')";
                MySqlCommand Command_CreateStreamerChannel = new MySqlCommand(Query_CreateStreamerChannel, LigacaoDB);
                Command_CreateStreamerChannel.ExecuteNonQuery();

                LigacaoDB.Close();
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        private void TEXTBOX_NOME_TextChanged(object sender, EventArgs e)
        {
            if (TEXTBOX_NOME.Text != "")
            {
                if (TEXTBOX_URL_RMTP.Text != "")
                {
                    BUTTON_GUARDAR.Enabled = true;
                }
            }

            else
                BUTTON_GUARDAR.Enabled = false;
        }

        private void TEXTBOX_URL_RMTP_TextChanged(object sender, EventArgs e)
        {
            if (TEXTBOX_URL_RMTP.Text != "")
            {
                if (TEXTBOX_NOME.Text != "")
                {
                    BUTTON_GUARDAR.Enabled = true;
                }
            }

            else
                BUTTON_GUARDAR.Enabled = false;
        }
    }
}
