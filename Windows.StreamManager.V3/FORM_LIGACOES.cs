using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.StreamManager.V3
{
    public partial class FORM_LIGACOES : Form
    {
        FORM_CANAIS FormCanais_Objects = (FORM_CANAIS)Application.OpenForms["FORM_CANAIS"];
        FORM_CANAIS_CRIAR FormCanaisCriar_Objects = (FORM_CANAIS_CRIAR)Application.OpenForms["FORM_CANAIS_CRIAR"];
        FORM_LOGIN FormLogin_Objects = (FORM_LOGIN)Application.OpenForms["FORM_LOGIN"];
        FORM_STREAMERS FormStreamers_Objects = (FORM_STREAMERS)Application.OpenForms["FORM_STREAMERS"];
        FORM_STREAMERS_NOVO_CANAL FormStreamersNovoCanal_Objects = (FORM_STREAMERS_NOVO_CANAL)Application.OpenForms["FORM_STREAMERS_NOVO_CANAL"];
        FORM_STREAMERS_NOVO_STREAMER FormStreamersNovoStreamer_Objects = (FORM_STREAMERS_NOVO_STREAMER)Application.OpenForms["FORM_STREAMERS_NOVO_STREAMER"];

        public FORM_LIGACOES()
        {
            InitializeComponent();
        }

        private void BUTTON_FECHAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUTTON_GUARDAR_Click(object sender, EventArgs e)
        {
            string Endereco = TEXTBOX_ENDERECO.Text;
            string Porta = TEXTBOX_PORTA.Text;
            string BD = TEXTBOX_BD.Text;
            string Username = TEXTBOX_USERNAME.Text;
            string Password = TEXTBOX_PASSWORD.Text;

            string Server = "datasource=" + Endereco + ";port=" + Porta + ";Initial Catalog='" + BD + "';username=" + Username + ";password=" + Password + "";

            Properties.Settings.Default.server = Server;
            Properties.Settings.Default.Save();

            FormLogin_Objects.LoadProjects();

            this.Close();
        }
    }
}
