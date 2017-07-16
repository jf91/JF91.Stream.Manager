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
    public partial class FORM_STREAMERS : Form
    {
        FORM_CANAIS FormCanais_Objects = (FORM_CANAIS)Application.OpenForms["FORM_CANAIS"];
        FORM_CANAIS_CRIAR FormCanaisCriar_Objects = (FORM_CANAIS_CRIAR)Application.OpenForms["FORM_CANAIS_CRIAR"];
        FORM_INICIO FormInicio_Objects = (FORM_INICIO)Application.OpenForms["FORM_INICIO"];
        FORM_STREAMERS FormStreamers_Objects = (FORM_STREAMERS)Application.OpenForms["FORM_STREAMERS"];
        FORM_STREAMERS_NOVO_CANAL FormStreamersNovoCanal_Objects = (FORM_STREAMERS_NOVO_CANAL)Application.OpenForms["FORM_STREAMERS_NOVO_CANAL"];
        FORM_STREAMERS_NOVO_STREAMER FormStreamersNovoStreamer_Objects = (FORM_STREAMERS_NOVO_STREAMER)Application.OpenForms["FORM_STREAMERS_NOVO_STREAMER"];

        MySqlConnection LigacaoDB = new MySqlConnection(Windows.StreamManager.V2.Properties.Settings.Default.server);

        MySqlDataAdapter Adapter = new MySqlDataAdapter();
        MySqlDataAdapter Adapter2 = new MySqlDataAdapter();

        MySqlDataReader Reader;
        MySqlDataReader Reader2;

        DataTable TabelaDados = new DataTable();
        DataTable TabelaDados2 = new DataTable();

        public FORM_STREAMERS()
        {
            InitializeComponent();
            LoadStreamers();
        }

        private void BUTTON_NOVO_STREAMER_Click(object sender, EventArgs e)
        {
            try
            {
                string StreamerName = TEXTBOX_STREAMER.Text;
                string PageURL = TEXTBOX_URL_PAGINA.Text;
                string PlayerURL = TEXTBOX_URL_PLAYER.Text;
                string Token = TEXTBOX_TOKEN.Text;

                bool Repetido = false;

                foreach (ListViewItem LVI in LISTVIEW_STREAMERS.Items)
                {
                    if (LVI.Text == StreamerName)
                    {
                        MessageBox.Show("Streamer Repetido!", "Streamer Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Repetido = true;

                        return;
                    }

                    else
                    {
                        Repetido = false;
                    }
                }

                if (Repetido == false)
                {
                    CreateStreamer(StreamerName, PageURL, PlayerURL, Token);
                    Reset();
                    LoadStreamers();
                    FormInicio_Objects.Reset();
                    FormInicio_Objects.Load_WebsiteChannels();
                    FormInicio_Objects.Load_Streamers();
                }
            }

            catch (Exception EX)
            {
                
            }
        }

        private void BUTTON_NOVO_CANAL_Click(object sender, EventArgs e)
        {
            try
            {
                string ChannelName = COMBOBOX_CANAIS.Text;
                string ChannelRMTP = TEXTBOX_RMTP.Text;
                string CasterRMTP = TEXTBOX_CASTER_RMTP.Text;

                bool Repetido = false;

                foreach(var Item in COMBOBOX_CANAIS.Items)
                {
                    if(Item.ToString() == ChannelName)
                    {
                        MessageBox.Show("Canal Repetido!", "Canal Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Repetido = true;

                        return;
                    }

                    else
                    {
                        Repetido = false;
                    }
                }

                if (Repetido == false)
                {
                    CreateStreamerChannel(ChannelName, ChannelRMTP, CasterRMTP, Streamer_ID);
                    Reset();
                    LoadStreamers();
                    FormInicio_Objects.Reset();
                    FormInicio_Objects.Load_WebsiteChannels();
                    FormInicio_Objects.Load_Streamers();
                }
            }

            catch (Exception EX)
            {

            }
        }

        private void BUTTON_FECHAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string Streamer_ID = "";
        private void LISTVIEW_STREAMERS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                COMBOBOX_CANAIS.Items.Clear();
                TabelaDados.Clear();
                TabelaDados2.Clear();

                if (LISTVIEW_STREAMERS.SelectedIndices.Count != 0)
                {
                    string Name = LISTVIEW_STREAMERS.SelectedItems[0].Text;
                    string ID = "";

                    string Query_ID = "SELECT ID FROM streamers" + PARAMETERS.Project + " WHERE name = '" + Name + "'";                    
                    MySqlCommand Command_ID = new MySqlCommand(Query_ID, LigacaoDB);
                    LigacaoDB.Open();
                    ID = Command_ID.ExecuteScalar().ToString();
                    LigacaoDB.Close();

                    Streamer_ID = ID;

                    FillTextBox(Name, ID);

                    BUTTON_APAGAR.Enabled = true;
                    BUTTON_GUARDAR.Enabled = true;
                }

                if(LISTVIEW_STREAMERS.SelectedItems.Count == 0)
                {
                    BUTTON_APAGAR.Enabled = false;
                    BUTTON_GUARDAR.Enabled = false;
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public static string StreamerChannelName = "";
        private void COMBOBOX_CANAIS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(COMBOBOX_CANAIS.SelectedIndex != -1)
                {
                    BUTTON_GUARDAR_CANAL_STREAMER.Enabled = true;
                    BUTTON_APAGAR_CANAL_STREAMER.Enabled = true;

                    MatchStreamerChannelRMTP(COMBOBOX_CANAIS.SelectedItem.ToString(), Streamer_ID);
                    StreamerChannelName = COMBOBOX_CANAIS.SelectedItem.ToString();
                }

                if(COMBOBOX_CANAIS.SelectedIndex == -1)
                {
                    BUTTON_GUARDAR_CANAL_STREAMER.Enabled = false;
                    BUTTON_APAGAR_CANAL_STREAMER.Enabled = false;
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        private void BUTTON_GUARDAR_STREAMER_Click(object sender, EventArgs e)
        {
            try
            {
                if (TEXTBOX_STREAMER.Text != "")
                {
                    if (LISTVIEW_STREAMERS.SelectedIndices.Count != 0)
                    {
                        string Name = TEXTBOX_STREAMER.Text;
                        string PageURL = TEXTBOX_URL_PAGINA.Text;
                        string PlayerURL = TEXTBOX_URL_PLAYER.Text;
                        string Token = TEXTBOX_TOKEN.Text;

                        EditStreamer(Name, PageURL, PlayerURL, Token);
                        Reset();
                        LoadStreamers();
                        FormInicio_Objects.Reset();
                        FormInicio_Objects.Load_WebsiteChannels();
                        FormInicio_Objects.Load_Streamers();
                    }
                }

                else
                {
                    MessageBox.Show("Nome de Streamer em Branco", "Nome em Branco", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            catch (Exception EX)
            {
            }
        }

        private void BUTTON_GUARDAR_CANAL_STREAMER_Click(object sender, EventArgs e)
        {
            try
            {
                if (COMBOBOX_CANAIS.Text != "")
                {
                    string Name = COMBOBOX_CANAIS.Text;
                    string ChannelRMTP = TEXTBOX_RMTP.Text;
                    string CasterRMTP = TEXTBOX_CASTER_RMTP.Text;

                    EditStreamerChannel(StreamerChannelName, Name, ChannelRMTP, CasterRMTP);
                    Reset();
                    LoadStreamers();
                    FormInicio_Objects.Reset();
                    FormInicio_Objects.Load_WebsiteChannels();
                    FormInicio_Objects.Load_Streamers();
                }
            }

            catch (Exception EX)
            {
            }
        }

        private void BUTTON_APAGAR_STREAMER_Click(object sender, EventArgs e)
        {
            try
            {
                if (LISTVIEW_STREAMERS.SelectedIndices.Count != 0)
                {
                    DeleteStreamer();
                    Reset();
                    LoadStreamers();
                    FormInicio_Objects.Reset();
                    FormInicio_Objects.Load_WebsiteChannels();
                    FormInicio_Objects.Load_Streamers();
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        private void BUTTON_APAGAR_CANAL_STREAMER_Click(object sender, EventArgs e)
        {
            try
            {
                if (COMBOBOX_CANAIS.SelectedIndex != -1)
                {
                    DeleteStreamercChannel(COMBOBOX_CANAIS.SelectedItem.ToString());
                    Reset();
                    LoadStreamers();
                    FormInicio_Objects.Reset();
                    FormInicio_Objects.Load_WebsiteChannels();
                    FormInicio_Objects.Load_Streamers();
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void Reset()
        {
            TEXTBOX_RMTP.Text = "";
            TEXTBOX_STREAMER.Text = "";
            TEXTBOX_TOKEN.Text = "";
            TEXTBOX_URL_PAGINA.Text = "";
            TEXTBOX_URL_PLAYER.Text = "";
            TEXTBOX_CASTER_RMTP.Text = "";

            COMBOBOX_CANAIS.SelectedIndex = -1;
            COMBOBOX_CANAIS.Text = "";
            COMBOBOX_CANAIS.Items.Clear();
            

            TabelaDados.Clear();
            TabelaDados2.Clear();

            foreach(ListViewItem LVI in LISTVIEW_STREAMERS.Items)
            {
                LVI.Selected = false;
            }
            LISTVIEW_STREAMERS.Items.Clear();
        }

        public void LoadStreamers()
        {
            try
            {
                LigacaoDB.Open();

                MySqlCommand Command_LoadStreamers = new MySqlCommand(PARAMETERS.Q_Search_Streamers, LigacaoDB);

                Reader = Command_LoadStreamers.ExecuteReader();

                while (Reader.Read())
                {
                    var ROW = new ListViewItem();
                    ROW.Text = Reader["name"].ToString();

                    LISTVIEW_STREAMERS.Items.Add(ROW);
                }

                LigacaoDB.Close();
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void FillTextBox(string Name, string ID)
        {
            try
            {
                LigacaoDB.Open();

                string Query_FillTextBox = "SELECT * FROM streamers" + PARAMETERS.Project + " WHERE ID = " + ID + "";
                MySqlCommand Command_FillTextBox = new MySqlCommand(Query_FillTextBox, LigacaoDB);

                Reader = Command_FillTextBox.ExecuteReader();

                while (Reader.Read())
                {
                    TEXTBOX_STREAMER.Text = Reader["name"].ToString();
                    TEXTBOX_URL_PAGINA.Text = Reader["page_url"].ToString();
                    TEXTBOX_URL_PLAYER.Text = Reader["player_url"].ToString();
                    TEXTBOX_TOKEN.Text = Reader["token"].ToString();
                }

                Reader.Close();

                string Query_SearchStreamerChannels = "SELECT * FROM streamers_channels" + PARAMETERS.Project + " WHERE streamer_id = " + ID + "";
                MySqlCommand Command_SearchStreamerChannels = new MySqlCommand(Query_SearchStreamerChannels, LigacaoDB);

                Reader2 = Command_SearchStreamerChannels.ExecuteReader();

                while (Reader2.Read())
                {
                    COMBOBOX_CANAIS.Items.Add(Reader2["name"].ToString());
                }

                Reader2.Close();

                LigacaoDB.Close();
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void MatchStreamerChannelRMTP(string ChannelName, string StreamerID)
        {
            try
            {
                LigacaoDB.Open();

                string ChannelRMTP = "";
                string CasterRMTP = "";

                string Query_ChannelRMTP = "SELECT rmtp_url FROM streamers_channels" + PARAMETERS.Project + " WHERE name = '" + ChannelName + "' AND streamer_id = '" + Streamer_ID + "'";

                string Query_CasterRMTP = "SELECT caster_rmtp FROM streamers_channels" + PARAMETERS.Project + " WHERE name = '" + ChannelName + "' AND streamer_id = '" + Streamer_ID + "'";


                MySqlCommand Command_ChannelRMTP = new MySqlCommand(Query_ChannelRMTP, LigacaoDB);
                MySqlCommand Command_CasterRMTP = new MySqlCommand(Query_CasterRMTP, LigacaoDB);

                ChannelRMTP = Command_ChannelRMTP.ExecuteScalar().ToString();
                CasterRMTP = Command_CasterRMTP.ExecuteScalar().ToString();

                TEXTBOX_RMTP.Text = ChannelRMTP;
                TEXTBOX_CASTER_RMTP.Text = CasterRMTP;

                LigacaoDB.Close();
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void CreateStreamer(string Name, string PageURL, string PlayerURL, string Token)
        {
            try
            {
                LigacaoDB.Open();

                string Query_CreateStreamer = "INSERT INTO streamers" + PARAMETERS.Project + "(name, page_url, player_url, token) VALUES('" + Name + "','" + PageURL + "', '" + PlayerURL + "', '" + Token + "')";
                MySqlCommand Command_CreateStreamer = new MySqlCommand(Query_CreateStreamer, LigacaoDB);
                Command_CreateStreamer.ExecuteNonQuery();

                LigacaoDB.Close();
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void DeleteStreamer()
        {
            try
            {
                LigacaoDB.Open();

                string Query_DeleteStreamer = "DELETE FROM streamers" + PARAMETERS.Project + " WHERE ID = " + Streamer_ID + "";
                MySqlCommand Command_DeleteStreamer = new MySqlCommand(Query_DeleteStreamer, LigacaoDB);
                Command_DeleteStreamer.ExecuteNonQuery();

                LigacaoDB.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void CreateStreamerChannel(string ChannelName, string ChannelRMTP, string CasterRMTP, string ChannelTag)
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

        public void DeleteStreamercChannel(string ChannelName)
        {
            try
            {
                LigacaoDB.Open();

                string Query_DeleteStreamerChannel = "DELETE FROM streamers_channels" + PARAMETERS.Project + " WHERE name = '" + ChannelName + "' AND streamer_id = " + Streamer_ID + "";
                MySqlCommand Command_DeleteStreamerChannel = new MySqlCommand(Query_DeleteStreamerChannel, LigacaoDB);
                Command_DeleteStreamerChannel.ExecuteNonQuery();

                LigacaoDB.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void EditStreamer(string Name, string PageURL, string PlayerURL, string Token)
        {
            try
            {
                LigacaoDB.Open();

                string Query_EditStreamer = "UPDATE streamers" + PARAMETERS.Project + " SET name = '" + Name + "', page_url = '" + PageURL + "', player_url = '" + PlayerURL + "', token = '" + Token + "' WHERE ID = " + Streamer_ID + "";
                MySqlCommand Command_EditStreamer = new MySqlCommand(Query_EditStreamer, LigacaoDB);
                Command_EditStreamer.ExecuteNonQuery();

                LigacaoDB.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void EditStreamerChannel(string OldName, string NewName, string RMTP, string CasterRMTP)
        {
            try
            {
                LigacaoDB.Open();

                string Query_EditStreamerChannel = "UPDATE streamers_channels" + PARAMETERS.Project + " SET name = '" + NewName + "', rmtp_url = '" + RMTP + "', caster_rmtp = '" + CasterRMTP + "' WHERE streamer_id = " + Streamer_ID + " AND name = '" + OldName + "'";
                MySqlCommand Command_EditStreamerChannel = new MySqlCommand(Query_EditStreamerChannel, LigacaoDB);
                Command_EditStreamerChannel.ExecuteNonQuery();

                LigacaoDB.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }
    }
}
