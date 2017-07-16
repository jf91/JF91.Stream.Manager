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
    public partial class FORM_CANAIS_CRIAR : Form
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

        public FORM_CANAIS_CRIAR()
        {
            InitializeComponent();
        }

        private void BUTTON_FECHAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUTTON_CRIAR_Click(object sender, EventArgs e)
        {
            string Name = TEXTBOX_NOME.Text;
            string FlashID = TEXTBOX_FLASH_ID.Text;

            CreateChannel(Name, FlashID);
            Reset();

            FormCanais_Objects.Reset();
            FormCanais_Objects.LoadListView();

            FormInicio_Objects.Reset();
            FormInicio_Objects.Load_WebsiteChannels();
            FormInicio_Objects.Load_Streamers();
        }

        public void Reset()
        {
            TEXTBOX_NOME.Text = "";
            TEXTBOX_FLASH_ID.Text = "";
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
    }
}
