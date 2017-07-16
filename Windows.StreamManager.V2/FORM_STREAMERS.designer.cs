namespace Windows.StreamManager
{
    partial class FORM_STREAMERS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BUTTON_FECHAR = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_APAGAR = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_APAGAR_STREAMER = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_APAGAR_CANAL_STREAMER = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_GUARDAR = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_GUARDAR_STREAMER = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_GUARDAR_CANAL_STREAMER = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_NOVO = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_NOVO_STREAMER = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_NOVO_CANAL = new System.Windows.Forms.ToolStripMenuItem();
            this.LABEL_NOME_STREAMER = new System.Windows.Forms.Label();
            this.TEXTBOX_STREAMER = new System.Windows.Forms.TextBox();
            this.TEXTBOX_URL_PAGINA = new System.Windows.Forms.TextBox();
            this.LABEL_URL_PAGINA = new System.Windows.Forms.Label();
            this.TEXTBOX_URL_PLAYER = new System.Windows.Forms.TextBox();
            this.LABEL_URL_PLAYER = new System.Windows.Forms.Label();
            this.LABEL_CANAIS = new System.Windows.Forms.Label();
            this.COMBOBOX_CANAIS = new System.Windows.Forms.ComboBox();
            this.LABEL_URL_RMTP = new System.Windows.Forms.Label();
            this.TEXTBOX_RMTP = new System.Windows.Forms.TextBox();
            this.TEXTBOX_TOKEN = new System.Windows.Forms.TextBox();
            this.LABEL_TOKEN = new System.Windows.Forms.Label();
            this.LISTVIEW_STREAMERS = new System.Windows.Forms.ListView();
            this.HEADER_STREAMER = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TEXTBOX_CASTER_RMTP = new System.Windows.Forms.TextBox();
            this.LABEL_CASTER_RMTP = new System.Windows.Forms.Label();
            this.BUTTON_COPIAR = new System.Windows.Forms.Button();
            this.COMBOBOX_PROJECTS = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BUTTON_FECHAR,
            this.BUTTON_APAGAR,
            this.BUTTON_GUARDAR,
            this.BUTTON_NOVO});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(423, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BUTTON_FECHAR
            // 
            this.BUTTON_FECHAR.Name = "BUTTON_FECHAR";
            this.BUTTON_FECHAR.Size = new System.Drawing.Size(54, 20);
            this.BUTTON_FECHAR.Text = "Fechar";
            this.BUTTON_FECHAR.Click += new System.EventHandler(this.BUTTON_FECHAR_Click);
            // 
            // BUTTON_APAGAR
            // 
            this.BUTTON_APAGAR.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUTTON_APAGAR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BUTTON_APAGAR_STREAMER,
            this.BUTTON_APAGAR_CANAL_STREAMER});
            this.BUTTON_APAGAR.Enabled = false;
            this.BUTTON_APAGAR.Name = "BUTTON_APAGAR";
            this.BUTTON_APAGAR.Size = new System.Drawing.Size(57, 20);
            this.BUTTON_APAGAR.Text = "Apagar";
            // 
            // BUTTON_APAGAR_STREAMER
            // 
            this.BUTTON_APAGAR_STREAMER.Name = "BUTTON_APAGAR_STREAMER";
            this.BUTTON_APAGAR_STREAMER.Size = new System.Drawing.Size(170, 22);
            this.BUTTON_APAGAR_STREAMER.Text = "Streamer";
            this.BUTTON_APAGAR_STREAMER.Click += new System.EventHandler(this.BUTTON_APAGAR_STREAMER_Click);
            // 
            // BUTTON_APAGAR_CANAL_STREAMER
            // 
            this.BUTTON_APAGAR_CANAL_STREAMER.Enabled = false;
            this.BUTTON_APAGAR_CANAL_STREAMER.Name = "BUTTON_APAGAR_CANAL_STREAMER";
            this.BUTTON_APAGAR_CANAL_STREAMER.Size = new System.Drawing.Size(170, 22);
            this.BUTTON_APAGAR_CANAL_STREAMER.Text = "Canal de Streamer";
            this.BUTTON_APAGAR_CANAL_STREAMER.Click += new System.EventHandler(this.BUTTON_APAGAR_CANAL_STREAMER_Click);
            // 
            // BUTTON_GUARDAR
            // 
            this.BUTTON_GUARDAR.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUTTON_GUARDAR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BUTTON_GUARDAR_STREAMER,
            this.BUTTON_GUARDAR_CANAL_STREAMER});
            this.BUTTON_GUARDAR.Enabled = false;
            this.BUTTON_GUARDAR.Name = "BUTTON_GUARDAR";
            this.BUTTON_GUARDAR.Size = new System.Drawing.Size(61, 20);
            this.BUTTON_GUARDAR.Text = "Guardar";
            // 
            // BUTTON_GUARDAR_STREAMER
            // 
            this.BUTTON_GUARDAR_STREAMER.Name = "BUTTON_GUARDAR_STREAMER";
            this.BUTTON_GUARDAR_STREAMER.Size = new System.Drawing.Size(170, 22);
            this.BUTTON_GUARDAR_STREAMER.Text = "Streamer";
            this.BUTTON_GUARDAR_STREAMER.Click += new System.EventHandler(this.BUTTON_GUARDAR_STREAMER_Click);
            // 
            // BUTTON_GUARDAR_CANAL_STREAMER
            // 
            this.BUTTON_GUARDAR_CANAL_STREAMER.Enabled = false;
            this.BUTTON_GUARDAR_CANAL_STREAMER.Name = "BUTTON_GUARDAR_CANAL_STREAMER";
            this.BUTTON_GUARDAR_CANAL_STREAMER.Size = new System.Drawing.Size(170, 22);
            this.BUTTON_GUARDAR_CANAL_STREAMER.Text = "Canal de Streamer";
            this.BUTTON_GUARDAR_CANAL_STREAMER.Click += new System.EventHandler(this.BUTTON_GUARDAR_CANAL_STREAMER_Click);
            // 
            // BUTTON_NOVO
            // 
            this.BUTTON_NOVO.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUTTON_NOVO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BUTTON_NOVO_STREAMER,
            this.BUTTON_NOVO_CANAL});
            this.BUTTON_NOVO.Name = "BUTTON_NOVO";
            this.BUTTON_NOVO.Size = new System.Drawing.Size(48, 20);
            this.BUTTON_NOVO.Text = "Novo";
            // 
            // BUTTON_NOVO_STREAMER
            // 
            this.BUTTON_NOVO_STREAMER.Name = "BUTTON_NOVO_STREAMER";
            this.BUTTON_NOVO_STREAMER.Size = new System.Drawing.Size(121, 22);
            this.BUTTON_NOVO_STREAMER.Text = "Streamer";
            this.BUTTON_NOVO_STREAMER.Click += new System.EventHandler(this.BUTTON_NOVO_STREAMER_Click);
            // 
            // BUTTON_NOVO_CANAL
            // 
            this.BUTTON_NOVO_CANAL.Name = "BUTTON_NOVO_CANAL";
            this.BUTTON_NOVO_CANAL.Size = new System.Drawing.Size(121, 22);
            this.BUTTON_NOVO_CANAL.Text = "Canal";
            this.BUTTON_NOVO_CANAL.Click += new System.EventHandler(this.BUTTON_NOVO_CANAL_Click);
            // 
            // LABEL_NOME_STREAMER
            // 
            this.LABEL_NOME_STREAMER.AutoSize = true;
            this.LABEL_NOME_STREAMER.Location = new System.Drawing.Point(233, 39);
            this.LABEL_NOME_STREAMER.Name = "LABEL_NOME_STREAMER";
            this.LABEL_NOME_STREAMER.Size = new System.Drawing.Size(95, 13);
            this.LABEL_NOME_STREAMER.TabIndex = 2;
            this.LABEL_NOME_STREAMER.Text = "Nome do Streamer";
            // 
            // TEXTBOX_STREAMER
            // 
            this.TEXTBOX_STREAMER.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_STREAMER.Location = new System.Drawing.Point(245, 55);
            this.TEXTBOX_STREAMER.Name = "TEXTBOX_STREAMER";
            this.TEXTBOX_STREAMER.Size = new System.Drawing.Size(168, 13);
            this.TEXTBOX_STREAMER.TabIndex = 3;
            // 
            // TEXTBOX_URL_PAGINA
            // 
            this.TEXTBOX_URL_PAGINA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_URL_PAGINA.Location = new System.Drawing.Point(245, 87);
            this.TEXTBOX_URL_PAGINA.Name = "TEXTBOX_URL_PAGINA";
            this.TEXTBOX_URL_PAGINA.Size = new System.Drawing.Size(168, 13);
            this.TEXTBOX_URL_PAGINA.TabIndex = 5;
            // 
            // LABEL_URL_PAGINA
            // 
            this.LABEL_URL_PAGINA.AutoSize = true;
            this.LABEL_URL_PAGINA.Location = new System.Drawing.Point(233, 71);
            this.LABEL_URL_PAGINA.Name = "LABEL_URL_PAGINA";
            this.LABEL_URL_PAGINA.Size = new System.Drawing.Size(106, 13);
            this.LABEL_URL_PAGINA.TabIndex = 4;
            this.LABEL_URL_PAGINA.Text = "URL da Página Web";
            // 
            // TEXTBOX_URL_PLAYER
            // 
            this.TEXTBOX_URL_PLAYER.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_URL_PLAYER.Location = new System.Drawing.Point(245, 119);
            this.TEXTBOX_URL_PLAYER.Name = "TEXTBOX_URL_PLAYER";
            this.TEXTBOX_URL_PLAYER.Size = new System.Drawing.Size(168, 13);
            this.TEXTBOX_URL_PLAYER.TabIndex = 7;
            // 
            // LABEL_URL_PLAYER
            // 
            this.LABEL_URL_PLAYER.AutoSize = true;
            this.LABEL_URL_PLAYER.Location = new System.Drawing.Point(233, 103);
            this.LABEL_URL_PLAYER.Name = "LABEL_URL_PLAYER";
            this.LABEL_URL_PLAYER.Size = new System.Drawing.Size(109, 13);
            this.LABEL_URL_PLAYER.TabIndex = 6;
            this.LABEL_URL_PLAYER.Text = "URL do Player (SWF)";
            // 
            // LABEL_CANAIS
            // 
            this.LABEL_CANAIS.AutoSize = true;
            this.LABEL_CANAIS.Location = new System.Drawing.Point(233, 218);
            this.LABEL_CANAIS.Name = "LABEL_CANAIS";
            this.LABEL_CANAIS.Size = new System.Drawing.Size(39, 13);
            this.LABEL_CANAIS.TabIndex = 8;
            this.LABEL_CANAIS.Text = "Canais";
            // 
            // COMBOBOX_CANAIS
            // 
            this.COMBOBOX_CANAIS.FormattingEnabled = true;
            this.COMBOBOX_CANAIS.Location = new System.Drawing.Point(278, 214);
            this.COMBOBOX_CANAIS.Name = "COMBOBOX_CANAIS";
            this.COMBOBOX_CANAIS.Size = new System.Drawing.Size(135, 21);
            this.COMBOBOX_CANAIS.TabIndex = 9;
            this.COMBOBOX_CANAIS.SelectedIndexChanged += new System.EventHandler(this.COMBOBOX_CANAIS_SelectedIndexChanged);
            // 
            // LABEL_URL_RMTP
            // 
            this.LABEL_URL_RMTP.AutoSize = true;
            this.LABEL_URL_RMTP.Location = new System.Drawing.Point(233, 243);
            this.LABEL_URL_RMTP.Name = "LABEL_URL_RMTP";
            this.LABEL_URL_RMTP.Size = new System.Drawing.Size(78, 13);
            this.LABEL_URL_RMTP.TabIndex = 10;
            this.LABEL_URL_RMTP.Text = "URL de RMTP";
            // 
            // TEXTBOX_RMTP
            // 
            this.TEXTBOX_RMTP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_RMTP.Location = new System.Drawing.Point(245, 259);
            this.TEXTBOX_RMTP.Name = "TEXTBOX_RMTP";
            this.TEXTBOX_RMTP.Size = new System.Drawing.Size(168, 13);
            this.TEXTBOX_RMTP.TabIndex = 11;
            // 
            // TEXTBOX_TOKEN
            // 
            this.TEXTBOX_TOKEN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_TOKEN.Location = new System.Drawing.Point(245, 151);
            this.TEXTBOX_TOKEN.Name = "TEXTBOX_TOKEN";
            this.TEXTBOX_TOKEN.Size = new System.Drawing.Size(168, 13);
            this.TEXTBOX_TOKEN.TabIndex = 13;
            // 
            // LABEL_TOKEN
            // 
            this.LABEL_TOKEN.AutoSize = true;
            this.LABEL_TOKEN.Location = new System.Drawing.Point(233, 135);
            this.LABEL_TOKEN.Name = "LABEL_TOKEN";
            this.LABEL_TOKEN.Size = new System.Drawing.Size(38, 13);
            this.LABEL_TOKEN.TabIndex = 12;
            this.LABEL_TOKEN.Text = "Token";
            // 
            // LISTVIEW_STREAMERS
            // 
            this.LISTVIEW_STREAMERS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HEADER_STREAMER});
            this.LISTVIEW_STREAMERS.FullRowSelect = true;
            this.LISTVIEW_STREAMERS.HideSelection = false;
            this.LISTVIEW_STREAMERS.Location = new System.Drawing.Point(12, 27);
            this.LISTVIEW_STREAMERS.Name = "LISTVIEW_STREAMERS";
            this.LISTVIEW_STREAMERS.Size = new System.Drawing.Size(215, 261);
            this.LISTVIEW_STREAMERS.TabIndex = 14;
            this.LISTVIEW_STREAMERS.UseCompatibleStateImageBehavior = false;
            this.LISTVIEW_STREAMERS.View = System.Windows.Forms.View.Details;
            this.LISTVIEW_STREAMERS.SelectedIndexChanged += new System.EventHandler(this.LISTVIEW_STREAMERS_SelectedIndexChanged);
            // 
            // HEADER_STREAMER
            // 
            this.HEADER_STREAMER.Text = "Streamer";
            this.HEADER_STREAMER.Width = 211;
            // 
            // TEXTBOX_CASTER_RMTP
            // 
            this.TEXTBOX_CASTER_RMTP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXTBOX_CASTER_RMTP.Location = new System.Drawing.Point(245, 291);
            this.TEXTBOX_CASTER_RMTP.Name = "TEXTBOX_CASTER_RMTP";
            this.TEXTBOX_CASTER_RMTP.Size = new System.Drawing.Size(168, 13);
            this.TEXTBOX_CASTER_RMTP.TabIndex = 16;
            // 
            // LABEL_CASTER_RMTP
            // 
            this.LABEL_CASTER_RMTP.AutoSize = true;
            this.LABEL_CASTER_RMTP.Location = new System.Drawing.Point(233, 275);
            this.LABEL_CASTER_RMTP.Name = "LABEL_CASTER_RMTP";
            this.LABEL_CASTER_RMTP.Size = new System.Drawing.Size(71, 13);
            this.LABEL_CASTER_RMTP.TabIndex = 15;
            this.LABEL_CASTER_RMTP.Text = "Caster RMTP";
            // 
            // BUTTON_COPIAR
            // 
            this.BUTTON_COPIAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BUTTON_COPIAR.Location = new System.Drawing.Point(175, 291);
            this.BUTTON_COPIAR.Name = "BUTTON_COPIAR";
            this.BUTTON_COPIAR.Size = new System.Drawing.Size(52, 21);
            this.BUTTON_COPIAR.TabIndex = 17;
            this.BUTTON_COPIAR.Text = "Copiar";
            this.BUTTON_COPIAR.UseVisualStyleBackColor = true;
            // 
            // COMBOBOX_PROJECTS
            // 
            this.COMBOBOX_PROJECTS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.COMBOBOX_PROJECTS.FormattingEnabled = true;
            this.COMBOBOX_PROJECTS.Location = new System.Drawing.Point(13, 291);
            this.COMBOBOX_PROJECTS.Name = "COMBOBOX_PROJECTS";
            this.COMBOBOX_PROJECTS.Size = new System.Drawing.Size(156, 21);
            this.COMBOBOX_PROJECTS.TabIndex = 19;
            // 
            // FORM_STREAMERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 316);
            this.Controls.Add(this.COMBOBOX_PROJECTS);
            this.Controls.Add(this.BUTTON_COPIAR);
            this.Controls.Add(this.TEXTBOX_CASTER_RMTP);
            this.Controls.Add(this.LABEL_CASTER_RMTP);
            this.Controls.Add(this.LISTVIEW_STREAMERS);
            this.Controls.Add(this.TEXTBOX_TOKEN);
            this.Controls.Add(this.LABEL_TOKEN);
            this.Controls.Add(this.TEXTBOX_RMTP);
            this.Controls.Add(this.LABEL_URL_RMTP);
            this.Controls.Add(this.COMBOBOX_CANAIS);
            this.Controls.Add(this.LABEL_CANAIS);
            this.Controls.Add(this.TEXTBOX_URL_PLAYER);
            this.Controls.Add(this.LABEL_URL_PLAYER);
            this.Controls.Add(this.TEXTBOX_URL_PAGINA);
            this.Controls.Add(this.LABEL_URL_PAGINA);
            this.Controls.Add(this.TEXTBOX_STREAMER);
            this.Controls.Add(this.LABEL_NOME_STREAMER);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_STREAMERS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stream Manager: Streamers";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_FECHAR;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_NOVO;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_NOVO_STREAMER;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_NOVO_CANAL;
        private System.Windows.Forms.Label LABEL_NOME_STREAMER;
        private System.Windows.Forms.TextBox TEXTBOX_STREAMER;
        private System.Windows.Forms.TextBox TEXTBOX_URL_PAGINA;
        private System.Windows.Forms.Label LABEL_URL_PAGINA;
        private System.Windows.Forms.TextBox TEXTBOX_URL_PLAYER;
        private System.Windows.Forms.Label LABEL_URL_PLAYER;
        private System.Windows.Forms.Label LABEL_CANAIS;
        private System.Windows.Forms.ComboBox COMBOBOX_CANAIS;
        private System.Windows.Forms.Label LABEL_URL_RMTP;
        private System.Windows.Forms.TextBox TEXTBOX_RMTP;
        private System.Windows.Forms.TextBox TEXTBOX_TOKEN;
        private System.Windows.Forms.Label LABEL_TOKEN;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_APAGAR;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_GUARDAR;
        private System.Windows.Forms.ListView LISTVIEW_STREAMERS;
        private System.Windows.Forms.ColumnHeader HEADER_STREAMER;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_APAGAR_STREAMER;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_APAGAR_CANAL_STREAMER;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_GUARDAR_STREAMER;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_GUARDAR_CANAL_STREAMER;
        private System.Windows.Forms.TextBox TEXTBOX_CASTER_RMTP;
        private System.Windows.Forms.Label LABEL_CASTER_RMTP;
        private System.Windows.Forms.Button BUTTON_COPIAR;
        private System.Windows.Forms.ComboBox COMBOBOX_PROJECTS;
    }
}