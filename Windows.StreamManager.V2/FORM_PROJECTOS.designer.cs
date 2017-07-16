namespace Windows.StreamManager
{
    partial class FORM_PROJECTOS
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
            this.BUTTON_CRIAR_PROJECTO = new System.Windows.Forms.ToolStripMenuItem();
            this.LABEL_PROJECTO = new System.Windows.Forms.Label();
            this.TEXTBOX_PROJECTO = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BUTTON_FECHAR,
            this.BUTTON_CRIAR_PROJECTO});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
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
            // BUTTON_CRIAR_PROJECTO
            // 
            this.BUTTON_CRIAR_PROJECTO.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUTTON_CRIAR_PROJECTO.Enabled = false;
            this.BUTTON_CRIAR_PROJECTO.Name = "BUTTON_CRIAR_PROJECTO";
            this.BUTTON_CRIAR_PROJECTO.Size = new System.Drawing.Size(91, 20);
            this.BUTTON_CRIAR_PROJECTO.Text = "Criar Projecto";
            this.BUTTON_CRIAR_PROJECTO.Click += new System.EventHandler(this.BUTTON_CRIAR_PROJECTO_Click);
            // 
            // LABEL_PROJECTO
            // 
            this.LABEL_PROJECTO.AutoSize = true;
            this.LABEL_PROJECTO.Location = new System.Drawing.Point(21, 34);
            this.LABEL_PROJECTO.Name = "LABEL_PROJECTO";
            this.LABEL_PROJECTO.Size = new System.Drawing.Size(92, 13);
            this.LABEL_PROJECTO.TabIndex = 1;
            this.LABEL_PROJECTO.Text = "Nome do Projecto";
            // 
            // TEXTBOX_PROJECTO
            // 
            this.TEXTBOX_PROJECTO.Location = new System.Drawing.Point(119, 31);
            this.TEXTBOX_PROJECTO.Name = "TEXTBOX_PROJECTO";
            this.TEXTBOX_PROJECTO.Size = new System.Drawing.Size(153, 20);
            this.TEXTBOX_PROJECTO.TabIndex = 2;
            this.TEXTBOX_PROJECTO.TextChanged += new System.EventHandler(this.TEXTBOX_PROJECTO_TextChanged);
            // 
            // FORM_PROJECTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 58);
            this.Controls.Add(this.TEXTBOX_PROJECTO);
            this.Controls.Add(this.LABEL_PROJECTO);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_PROJECTOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stream Manager Projectos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_FECHAR;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_CRIAR_PROJECTO;
        private System.Windows.Forms.Label LABEL_PROJECTO;
        private System.Windows.Forms.TextBox TEXTBOX_PROJECTO;
    }
}