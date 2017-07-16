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
    public partial class FORM_PROJECTOS : Form
    {
        FORM_CANAIS FormCanais_Objects = (FORM_CANAIS)Application.OpenForms["FORM_CANAIS"];
        FORM_CANAIS_CRIAR FormCanaisCriar_Objects = (FORM_CANAIS_CRIAR)Application.OpenForms["FORM_CANAIS_CRIAR"];
        FORM_LOGIN FormLogin_Objects = (FORM_LOGIN)Application.OpenForms["FORM_LOGIN"];
        FORM_STREAMERS FormStreamers_Objects = (FORM_STREAMERS)Application.OpenForms["FORM_STREAMERS"];
        FORM_STREAMERS_NOVO_CANAL FormStreamersNovoCanal_Objects = (FORM_STREAMERS_NOVO_CANAL)Application.OpenForms["FORM_STREAMERS_NOVO_CANAL"];
        FORM_STREAMERS_NOVO_STREAMER FormStreamersNovoStreamer_Objects = (FORM_STREAMERS_NOVO_STREAMER)Application.OpenForms["FORM_STREAMERS_NOVO_STREAMER"];

        MySqlConnection LigacaoDB = new MySqlConnection(Properties.Settings.Default.server);

        MySqlDataAdapter Adapter = new MySqlDataAdapter();
        MySqlDataAdapter Adapter2 = new MySqlDataAdapter();

        MySqlDataReader Reader;

        DataTable TabelaDados = new DataTable();
        DataTable TabelaDados2 = new DataTable();

        public FORM_PROJECTOS()
        {
            InitializeComponent();
        }

        private void TEXTBOX_PROJECTO_TextChanged(object sender, EventArgs e)
        {
            if (TEXTBOX_PROJECTO.Text != "")
            {
                BUTTON_CRIAR_PROJECTO.Enabled = true;
            }

            else
                BUTTON_CRIAR_PROJECTO.Enabled = false;
        }

        private void BUTTON_CRIAR_PROJECTO_Click(object sender, EventArgs e)
        {
            string ProjectName = TEXTBOX_PROJECTO.Text;

            string TableStreamers = "streamers_" + ProjectName;
            string TableStreamersChannel = "streamers_channels_" + ProjectName;
            string TableWebsiteChannels = "website_channels_" + ProjectName;

            CreateProject(TableStreamers, TableStreamersChannel, TableWebsiteChannels, ProjectName);

            FormLogin_Objects.Reset();
            FormLogin_Objects.LoadProjects();

            Reset();
        }

        private void BUTTON_FECHAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Reset()
        {
            TEXTBOX_PROJECTO.Text = "";
        }

        public void CreateProject(string TableStreamers, string TableStreamersChannel, string TableWebsiteChannels, string ProjectName)
        {
            try
            {
                LigacaoDB.Open();

                string Query_CreateTableStreamers = "CREATE TABLE IF NOT EXISTS " + TableStreamers + " (`ID` INT NOT NULL AUTO_INCREMENT, `name` VARCHAR(100) NOT NULL DEFAULT '0', `page_url` VARCHAR(100) NOT NULL DEFAULT '0', `player_url` VARCHAR(100) NOT NULL DEFAULT '0',	`token` VARCHAR(100) NOT NULL DEFAULT '0', PRIMARY KEY (`ID`))";

                string Query_CreateTableStreamersChannels = "CREATE TABLE IF NOT EXISTS " + TableStreamersChannel + " (`ID` INT NOT NULL AUTO_INCREMENT,`name` VARCHAR(100) NOT NULL DEFAULT '0', `rmtp_url` VARCHAR(100) NOT NULL DEFAULT '0', `caster_rmtp` VARCHAR(500) NOT NULL DEFAULT '0', `streamer_id` INT NOT NULL DEFAULT '0', PRIMARY KEY (`ID`))";

                string Query_CreateTableWebsiteChannels = "CREATE TABLE IF NOT EXISTS " + TableWebsiteChannels + " (`ID` INT NOT NULL AUTO_INCREMENT,`name` VARCHAR(100) NOT NULL DEFAULT '0', `flash_id` VARCHAR(100) NOT NULL DEFAULT '0', PRIMARY KEY (`ID`))";

                MySqlCommand Command_CreateTableStreamers = new MySqlCommand(Query_CreateTableStreamers, LigacaoDB);
                MySqlCommand Command_CreateTableStreamersChannels = new MySqlCommand(Query_CreateTableStreamersChannels, LigacaoDB);
                MySqlCommand Command_CreateTableWebsiteChannels = new MySqlCommand(Query_CreateTableWebsiteChannels, LigacaoDB);
                                
                Command_CreateTableStreamers.ExecuteNonQuery();
                Command_CreateTableStreamersChannels.ExecuteNonQuery();
                Command_CreateTableWebsiteChannels.ExecuteNonQuery();

                string Query_CreateProject = "INSERT INTO projects(name) VALUES('" + ProjectName + "')";
                MySqlCommand Command_CreateProject = new MySqlCommand(Query_CreateProject, LigacaoDB);
                Command_CreateProject.ExecuteNonQuery();

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
