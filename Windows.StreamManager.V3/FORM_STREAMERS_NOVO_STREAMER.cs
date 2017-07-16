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
    public partial class FORM_STREAMERS_NOVO_STREAMER : Form
    {
        FORM_CANAIS FormCanais_Objects = (FORM_CANAIS)Application.OpenForms["FORM_CANAIS"];
        FORM_CANAIS_CRIAR FormCanaisCriar_Objects = (FORM_CANAIS_CRIAR)Application.OpenForms["FORM_CANAIS_CRIAR"];
        FORM_INICIO FormInicio_Objects = (FORM_INICIO)Application.OpenForms["FORM_INICIO"];
        FORM_STREAMERS FormStreamers_Objects = (FORM_STREAMERS)Application.OpenForms["FORM_STREAMERS"];
        FORM_STREAMERS_NOVO_CANAL FormStreamersNovoCanal_Objects = (FORM_STREAMERS_NOVO_CANAL)Application.OpenForms["FORM_STREAMERS_NOVO_CANAL"];
        FORM_STREAMERS_NOVO_STREAMER FormStreamersNovoStreamer_Objects = (FORM_STREAMERS_NOVO_STREAMER)Application.OpenForms["FORM_STREAMERS_NOVO_STREAMER"];

        MySqlConnection LigacaoDB = new MySqlConnection(Windows.StreamManager.V3.Properties.Settings.Default.server);

        MySqlDataAdapter Adapter = new MySqlDataAdapter();

        MySqlDataReader Reader;

        DataTable TabelaDados = new DataTable();

        public FORM_STREAMERS_NOVO_STREAMER()
        {
            InitializeComponent();
        }

        private void BUTTON_FECHAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUTTON_GUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (TEXTBOX_NOME.Text != "" && TEXTBOX_URL_PAGINA.Text != "" && TEXTBOX_URL_PLAYER.Text != "" && TEXTBOX_TOKEN.Text != "")
                {
                    string Name = TEXTBOX_NOME.Text;
                    string PageURL = TEXTBOX_URL_PAGINA.Text;
                    string PlayerURL = TEXTBOX_URL_PLAYER.Text;
                    string Token = TEXTBOX_TOKEN.Text;

                    CreateStreamer(Name, PageURL, PlayerURL, Token);

                    Reset();
                    FormStreamers_Objects.Reset();
                    FormStreamers_Objects.LoadStreamers();

                    FormInicio_Objects.Reset();
                    FormInicio_Objects.Load_WebsiteChannels();
                    FormInicio_Objects.Load_Streamers();
                }
            }

            catch (Exception EX)
            {
            }
        }

        public void Reset()
        {
            TEXTBOX_NOME.Text = "";
            TEXTBOX_TOKEN.Text = "";
            TEXTBOX_URL_PAGINA.Text = "";
            TEXTBOX_URL_PLAYER.Text = "";
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
    }
}
