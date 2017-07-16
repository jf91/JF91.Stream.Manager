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
    public partial class FORM_CANAIS : Form
    {
        FORM_CANAIS FormCanais_Objects = (FORM_CANAIS)Application.OpenForms["FORM_CANAIS"];
        FORM_CANAIS_CRIAR FormCanaisCriar_Objects = (FORM_CANAIS_CRIAR)Application.OpenForms["FORM_CANAIS_CRIAR"];
        FORM_INICIO FormInicio_Objects = (FORM_INICIO)Application.OpenForms["FORM_INICIO"];
        FORM_STREAMERS FormStreamers_Objects = (FORM_STREAMERS)Application.OpenForms["FORM_STREAMERS"];
        FORM_STREAMERS_NOVO_CANAL FormStreamersNovoCanal_Objects = (FORM_STREAMERS_NOVO_CANAL)Application.OpenForms["FORM_STREAMERS_NOVO_CANAL"];
        FORM_STREAMERS_NOVO_STREAMER FormStreamersNovoStreamer_Objects = (FORM_STREAMERS_NOVO_STREAMER)Application.OpenForms["FORM_STREAMERS_NOVO_STREAMER"];

        MySqlConnection LigacaoDB = new MySqlConnection(Windows.StreamManager.V2.Properties.Settings.Default.server);

        MySqlDataAdapter Adapter = new MySqlDataAdapter();

        MySqlDataReader Reader;

        DataTable TabelaDados = new DataTable();

        public FORM_CANAIS()
        {
            InitializeComponent();
            LoadListView();
        }

        private void BUTTON_CRIAR_NOVO_Click(object sender, EventArgs e)
        {
            try
            {
                string ChannelName = TEXTBOX_NOME.Text;
                string FlashID = TEXTBOX_FLASH_ID.Text;
                bool Repetido = false;

                foreach(ListViewItem LVI in LISTVIEW_CHANNELS.Items)
                {
                    if (LVI.Text == ChannelName && LVI.SubItems[1].Text == FlashID)
                    {
                        MessageBox.Show("Canal e FlashID Repetido!", "FlashID Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Repetido = true;

                        return;
                    }

                    if(LVI.Text == ChannelName)
                    {
                        MessageBox.Show("Canal Repetido!", "Canal Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Repetido = true;

                        return;
                    }

                    if(LVI.SubItems[1].Text == FlashID)
                    {
                        MessageBox.Show("FlashID Repetido!", "FlashID Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Repetido = true;

                        return;
                    }                    

                    else
                    {
                        Repetido = false;
                    }
                }

                if(Repetido == false)
                {


                    CreateChannel(ChannelName, FlashID);
                    Reset();
                    LoadListView();
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

        private void BUTTON_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                if(LISTVIEW_CHANNELS.SelectedIndices.Count != 0)
                {

                    string Name = TEXTBOX_NOME.Text;
                    string FlashID = TEXTBOX_FLASH_ID.Text;

                    EditChannel(Name, FlashID);
                    Reset();
                    LoadListView();
                    FormInicio_Objects.Reset();
                    FormInicio_Objects.Load_WebsiteChannels();
                    FormInicio_Objects.Load_Streamers();
                }

                else
                {
                    MessageBox.Show("Tens de escolher o canal que queres guardar", "Escolher Canal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            catch (Exception EX)
            {
            }
        }

        private void BUTTON_APAGAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (LISTVIEW_CHANNELS.SelectedIndices.Count != 0)
                {
                    DeleteChannel(WebsiteChannel_ID);
                    Reset();
                    LoadListView();
                    FormInicio_Objects.Reset();
                    FormInicio_Objects.Load_WebsiteChannels();
                    FormInicio_Objects.Load_Streamers();
                }

                else
                {
                    MessageBox.Show("Tens de escolher o canal que queres apagar", "Escolher Canal", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
            }

            catch (Exception EX)
            {
            }
        }

        public static string WebsiteChannel_ID = "";
        private void LISTVIEW_CHANNELS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (LISTVIEW_CHANNELS.SelectedIndices.Count != 0)
                {
                    string Name = LISTVIEW_CHANNELS.SelectedItems[0].Text;
                    string FlashID = LISTVIEW_CHANNELS.SelectedItems[0].SubItems[1].Text;
                    string ID = "";

                    TEXTBOX_NOME.Text = Name;
                    TEXTBOX_FLASH_ID.Text = FlashID;

                    string Query_ID = "SELECT ID FROM website_channels" + PARAMETERS.Project + " WHERE name = '" + Name + "' AND flash_id = '" + FlashID + "'";
                    MySqlCommand Command_ID = new MySqlCommand(Query_ID, LigacaoDB);
                    LigacaoDB.Open();
                    ID = Command_ID.ExecuteScalar().ToString();
                    LigacaoDB.Close();
                    WebsiteChannel_ID = ID;

                    BUTTON_GUARDAR.Enabled = true;
                    BUTTON_APAGAR.Enabled = true;
                }
            }

            catch (Exception EX)
            {
                LigacaoDB.Close();
            }
        }

        public void Reset()
        {
            TEXTBOX_NOME.Text = "";
            TEXTBOX_FLASH_ID.Text = "";

            LISTVIEW_CHANNELS.Items.Clear();
        }

        public void LoadListView()
        {
            try
            {
                LigacaoDB.Open();

                MySqlCommand Command = new MySqlCommand(PARAMETERS.Q_Search_WebsiteChannels, LigacaoDB);

                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    var ROW = new ListViewItem();
                    ROW.Text = Reader["name"].ToString();
                    ROW.SubItems.Add(Reader["flash_id"].ToString());

                    LISTVIEW_CHANNELS.Items.Add(ROW);
                }

                LigacaoDB.Close();
            }

            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void CreateChannel(string Name, string FlashID)
        {
            try
            {
                LigacaoDB.Open();

                string Query_CreateChannel = "INSERT INTO website_channels" + PARAMETERS.Project + "(name, flash_id) VALUES('" + Name + "','" + FlashID + "')";
                MySqlCommand Command_CreateChannel = new MySqlCommand(Query_CreateChannel, LigacaoDB);
                Command_CreateChannel.ExecuteNonQuery();

                LigacaoDB.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void EditChannel(string Name, string FlashID)
        {
            try
            {
                LigacaoDB.Open();

                string Query_EditChannel = "UPDATE website_channels" + PARAMETERS.Project + " SET name = '" + Name + "', flash_id = '" + FlashID + "' WHERE ID = " + WebsiteChannel_ID + "";
                MySqlCommand Command_Edit = new MySqlCommand(Query_EditChannel, LigacaoDB);
                Command_Edit.ExecuteNonQuery();

                LigacaoDB.Close();
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void DeleteChannel(string ID)
        {
            try
            {
                LigacaoDB.Open();

                string Query_DeleteChannel = "DELETE FROM website_channels" + PARAMETERS.Project + " WHERE ID = " + ID + "";
                MySqlCommand Command_DeleteChannel = new MySqlCommand(Query_DeleteChannel, LigacaoDB);
                Command_DeleteChannel.ExecuteNonQuery();

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
            if(TEXTBOX_NOME.Text != "")
            {
                if(TEXTBOX_FLASH_ID.Text != "")
                {
                    BUTTON_APAGAR.Enabled = true;
                    BUTTON_GUARDAR.Enabled = true;
                }
            }

            else
            {
                BUTTON_APAGAR.Enabled = false;
                BUTTON_GUARDAR.Enabled = false;

                LISTVIEW_CHANNELS.SelectedIndices.Clear();
            }
        }

        private void TEXTBOX_FLASH_ID_TextChanged(object sender, EventArgs e)
        {
            if (TEXTBOX_FLASH_ID.Text != "")
            {
                if (TEXTBOX_NOME.Text != "")
                {
                    BUTTON_APAGAR.Enabled = true;
                    BUTTON_GUARDAR.Enabled = true;
                }
            }

            else
            {
                BUTTON_APAGAR.Enabled = false;
                BUTTON_GUARDAR.Enabled = false;

                LISTVIEW_CHANNELS.SelectedIndices.Clear();
            }
        }
    }
}
