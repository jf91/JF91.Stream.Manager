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
    public partial class FORM_LOGIN : Form
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

        public FORM_LOGIN()
        {
            InitializeComponent();
            LoadProjects();
        }

        private void BUTTON_FECHAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FORM_LOGIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BUTTON_GERIR_PROJECTOS_Click(object sender, EventArgs e)
        {
            FORM_PROJECTOS FormProjectos = new FORM_PROJECTOS();
            FormProjectos.ShowDialog();
        }

        private void BUTTON_ENTRAR_Click(object sender, EventArgs e)
        {
            if (COMBOBOX_PROJECTOS.SelectedIndex == -1)
            {
                MessageBox.Show("Tens de escolher um projecto", "Escolher Projecto", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            else
            {
                string Project = "_" + COMBOBOX_PROJECTOS.Text;
                PARAMETERS.Project = Project;
                PARAMETERS.Q_Search_WebsiteChannels = "SELECT * FROM website_channels" + Project + "";
                PARAMETERS.Q_Search_Streamers = "SELECT * FROM streamers" + Project + "";
                PARAMETERS.Q_Search_StreamersChannels = "SELECT * FROM streamers_channels" + Project + "";

                IniciarSessao();
            }
        }

        public void Reset()
        {
            COMBOBOX_PROJECTOS.Items.Clear();
        }

        public void LoadProjects()
        {
            try
            {
                LigacaoDB.Open();

                MySqlCommand LoadProjects = new MySqlCommand(PARAMETERS.Q_Search_Projects, LigacaoDB);

                Reader = LoadProjects.ExecuteReader();

                while(Reader.Read())
                {
                    COMBOBOX_PROJECTOS.Items.Add(Reader["name"].ToString());
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

                LigacaoDB.Close();
            }
        }

        public void IniciarSessao()
        {
            this.Hide();

            FORM_INICIO FormInicio = new FORM_INICIO();
            FormInicio.Show();
        }
    }
}
