
namespace AULAHeranca3.View
{
    partial class FrmPrincipal
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
            this.MnCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MnPessoa = new System.Windows.Forms.ToolStripMenuItem();
            this.MnFisica = new System.Windows.Forms.ToolStripMenuItem();
            this.MnJuridica = new System.Windows.Forms.ToolStripMenuItem();
            this.MnTime = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnCadastro,
            this.MnFisica,
            this.MnJuridica,
            this.MnTime});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnCadastro
            // 
            this.MnCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnPessoa});
            this.MnCadastro.Name = "MnCadastro";
            this.MnCadastro.Size = new System.Drawing.Size(66, 20);
            this.MnCadastro.Text = "&Cadastro";
            this.MnCadastro.Click += new System.EventHandler(this.MnCadastro_Click);
            // 
            // MnPessoa
            // 
            this.MnPessoa.Name = "MnPessoa";
            this.MnPessoa.Size = new System.Drawing.Size(110, 22);
            this.MnPessoa.Text = "&Pessoa";
            // 
            // MnFisica
            // 
            this.MnFisica.Name = "MnFisica";
            this.MnFisica.Size = new System.Drawing.Size(48, 20);
            this.MnFisica.Text = "&Fisica";
            this.MnFisica.Click += new System.EventHandler(this.MnFisica_Click_1);
            // 
            // MnJuridica
            // 
            this.MnJuridica.Name = "MnJuridica";
            this.MnJuridica.Size = new System.Drawing.Size(59, 20);
            this.MnJuridica.Text = "&Juridica";
            this.MnJuridica.Click += new System.EventHandler(this.MnJuridica_Click);
            // 
            // MnTime
            // 
            this.MnTime.Name = "MnTime";
            this.MnTime.Size = new System.Drawing.Size(45, 20);
            this.MnTime.Text = "&Time";
            this.MnTime.Click += new System.EventHandler(this.MnTime_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnCadastro;
        private System.Windows.Forms.ToolStripMenuItem MnPessoa;
        private System.Windows.Forms.ToolStripMenuItem MnFisica;
        private System.Windows.Forms.ToolStripMenuItem MnJuridica;
        private System.Windows.Forms.ToolStripMenuItem MnTime;
    }
}