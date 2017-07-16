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
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace Windows.StreamManager
{
    public partial class FORM_INICIO : Form
    {
        FORM_CANAIS FormCanais_Objects = (FORM_CANAIS)Application.OpenForms["FORM_CANAIS"];
        FORM_CANAIS_CRIAR FormCanaisCriar_Objects = (FORM_CANAIS_CRIAR)Application.OpenForms["FORM_CANAIS_CRIAR"];
        FORM_STREAMERS FormStreamers_Objects = (FORM_STREAMERS)Application.OpenForms["FORM_STREAMERS"];
        FORM_STREAMERS_NOVO_CANAL FormStreamersNovoCanal_Objects = (FORM_STREAMERS_NOVO_CANAL)Application.OpenForms["FORM_STREAMERS_NOVO_CANAL"];
        FORM_STREAMERS_NOVO_STREAMER FormStreamersNovoStreamer_Objects = (FORM_STREAMERS_NOVO_STREAMER)Application.OpenForms["FORM_STREAMERS_NOVO_STREAMER"];

        MySqlConnection LigacaoDB = new MySqlConnection(Windows.StreamManager.V2.Properties.Settings.Default.server);

        MySqlDataAdapter Adapter = new MySqlDataAdapter();
        MySqlDataAdapter Adapter2 = new MySqlDataAdapter();

        MySqlDataReader Reader;

        DataTable TabelaDados = new DataTable();
        DataTable TabelaDados2 = new DataTable();

        public FORM_INICIO()
        {
            InitializeComponent();
            Load_WebsiteChannels();
            Load_Streamers();

            if (!Directory.Exists(PARAMETERS.L_BAT))
            {
                System.IO.Directory.CreateDirectory(PARAMETERS.L_BAT);
            }
        }

        private void BUTTON_STREAMERS_Click(object sender, EventArgs e)
        {
            FORM_STREAMERS FormStreamers = new FORM_STREAMERS();
            FormStreamers.ShowDialog();
        }

        private void BUTTON_CANAIS_Click(object sender, EventArgs e)
        {
            FORM_CANAIS FormCanais = new FORM_CANAIS();
            FormCanais.ShowDialog();
        }

        private void BUTTON_FECHAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FORM_INICIO_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BUTTON_LIGAR_Click(object sender, EventArgs e)
        {
            if (COMBOBOX_CANAIS.SelectedIndex == -1)
            {
                MessageBox.Show("Tens de escolher um canal no teu site", "Escolher Canal de Website", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            else
            {
                bool NodeSelected = false;

                foreach(TreeNode TN in TREEVIEW_STREAMERS.Nodes)
                {
                    foreach(TreeNode TN2 in TN.Nodes)
                    {
                        if(TN2.IsSelected == true)
                        {
                            NodeSelected = true;
                        }
                    }
                }

                if (NodeSelected == false)
                {
                    MessageBox.Show("Tens de escolher o canal do Broadcaster que queres transmitir", "Escolher Canal de Broadcaster", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                if (NodeSelected == true)
                {
                    CreateScriptFile();
                }
            }
        }

        public void Reset()
        {
            COMBOBOX_CANAIS.SelectedItem = 0;
            COMBOBOX_CANAIS.Items.Clear();
            TREEVIEW_STREAMERS.Nodes.Clear();
        }

        public void Load_WebsiteChannels()
        {
            try
            {
                LigacaoDB.Open();

                string Query = PARAMETERS.Q_Search_WebsiteChannels;

                MySqlCommand Command = new MySqlCommand(Query, LigacaoDB);

                Adapter.SelectCommand = Command;

                Adapter.Fill(TabelaDados);

                foreach(DataRow DR in TabelaDados.Rows)
                {
                    COMBOBOX_CANAIS.Items.Add(DR[1].ToString());
                }

                TabelaDados.Clear();

                LigacaoDB.Close();
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
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
                                    TN2.Tag = ROW["name"].ToString();

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

        public void CreateScriptFile()
        {
            try
            {
                LigacaoDB.Open();

                string FileName = "";
                string FileTitle = "";
                string ChannelName = COMBOBOX_CANAIS.SelectedItem.ToString();
                string StreamerName = "";
                string StreamerChannelName = "";

                string StreamerID = "";
                string FlashID = "";
                string RMTP = "";
                string CasterRMTP = "";
                string PageURL = "";
                string PlayerURL = "";
                string Token = "";

                string Query_StreamerID = "";
                string Query_FlashID = "";
                string Query_RMTP = "";
                string Query_CasterRMTP = "";
                string Query_PageURL = "";
                string Query_PlayerURL = "";
                string Query_Token = "";

                foreach (TreeNode TN in TREEVIEW_STREAMERS.Nodes)
                {
                    foreach (TreeNode TN2 in TN.Nodes)
                    {
                        if (TN2.IsSelected == true)
                        {
                            StreamerName = TN.Text;
                            StreamerChannelName = TN2.Text;
                        }
                    }
                }

                Query_StreamerID = "SELECT ID FROM streamers" + PARAMETERS.Project + " WHERE name = '" + StreamerName + "'";
                Query_FlashID = "SELECT flash_id FROM website_channels" + PARAMETERS.Project + " WHERE name = '" + COMBOBOX_CANAIS.SelectedItem.ToString() + "'";
                Query_PageURL = "SELECT page_url FROM streamers" + PARAMETERS.Project + " WHERE name = '" + StreamerName + "'";
                Query_PlayerURL = "SELECT player_url FROM streamers" + PARAMETERS.Project + " WHERE name = '" + StreamerName + "'";
                Query_Token = "SELECT token FROM streamers" + PARAMETERS.Project + " WHERE name = '" + StreamerName + "'";

                MySqlCommand Command_StreamerID = new MySqlCommand(Query_StreamerID, LigacaoDB);
                MySqlCommand Command_FlashID = new MySqlCommand(Query_FlashID, LigacaoDB);
                MySqlCommand Command_PageURL = new MySqlCommand(Query_PageURL, LigacaoDB);
                MySqlCommand Command_PlayerURL = new MySqlCommand(Query_PlayerURL, LigacaoDB);
                MySqlCommand Command_Token = new MySqlCommand(Query_Token, LigacaoDB);

                StreamerID = Command_StreamerID.ExecuteScalar().ToString();
                FlashID = Command_FlashID.ExecuteScalar().ToString();
                PageURL = Command_PageURL.ExecuteScalar().ToString();
                PlayerURL = Command_PlayerURL.ExecuteScalar().ToString();
                Token = Command_Token.ExecuteScalar().ToString();

                Query_RMTP = "SELECT rmtp_url FROM streamers_channels" + PARAMETERS.Project + " WHERE name = '" + StreamerChannelName + "' AND streamer_id = '" + StreamerID + "'";
                Query_CasterRMTP = "SELECT caster_rmtp FROM streamers_channels" + PARAMETERS.Project + " WHERE name = '" + StreamerChannelName + "' AND streamer_id = '" + StreamerID + "'";

                MySqlCommand Command_RMTP = new MySqlCommand(Query_RMTP, LigacaoDB);
                RMTP = Command_RMTP.ExecuteScalar().ToString();

                MySqlCommand Command_CasterRMTP = new MySqlCommand(Query_CasterRMTP, LigacaoDB);
                CasterRMTP = Command_CasterRMTP.ExecuteScalar().ToString();

                LigacaoDB.Close();

                FileTitle = "" + StreamerName + "-" + StreamerChannelName + "" + " On " + ChannelName + "";
                FileName = "" + StreamerName + "-" + StreamerChannelName + "" + " On " + ChannelName + ".bat";

                string RMTPCode = @"rtmpdump --live -r  """ + RMTP + @""" -p """ + PageURL + @""" -W """ + PlayerURL + @""" -T """ + Token + @""" -q | ffmpeg -re -i - -r 20 -isync -acodec aac -strict -2 -b:a 128000 -ar 32000 -vcodec libx264 -preset veryfast -b:v 300k -f flv """ + CasterRMTP + FlashID + @"""";

                string[] FileCode = { "TITLE " + FileName + "", "@echo off", "cls", ":start", RMTPCode, "goto start" };

                System.IO.File.WriteAllLines(PARAMETERS.L_BAT + @"/" + FileName + "", FileCode);

                RunScriptFile(PARAMETERS.L_BAT + @"/" + FileName + "");
            }

            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void RunScriptFile(string File)
        {
            Process.Start(File);
        }

        
    }
}
