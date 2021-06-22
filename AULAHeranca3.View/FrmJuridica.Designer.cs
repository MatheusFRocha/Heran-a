
using System;
using System.Windows.Forms;

namespace AULAHeranca3.View
{
    partial class FrmJuridica
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCNPJ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomeFantasma = new System.Windows.Forms.TextBox();
            this.BtnJuridica = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LblTotalJuridica = new System.Windows.Forms.ToolStripStatusLabel();
            this.GridJuridica = new System.Windows.Forms.DataGridView();
            this.RazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFantasma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridJuridica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNPJ";
            // 
            // TxtCNPJ
            // 
            this.TxtCNPJ.Location = new System.Drawing.Point(12, 27);
            this.TxtCNPJ.Name = "TxtCNPJ";
            this.TxtCNPJ.Size = new System.Drawing.Size(144, 23);
            this.TxtCNPJ.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razão Social";
            // 
            // TxtRazaoSocial
            // 
            this.TxtRazaoSocial.Location = new System.Drawing.Point(12, 82);
            this.TxtRazaoSocial.Name = "TxtRazaoSocial";
            this.TxtRazaoSocial.Size = new System.Drawing.Size(144, 23);
            this.TxtRazaoSocial.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome Fantasma";
            // 
            // TxtNomeFantasma
            // 
            this.TxtNomeFantasma.Location = new System.Drawing.Point(262, 27);
            this.TxtNomeFantasma.Name = "TxtNomeFantasma";
            this.TxtNomeFantasma.Size = new System.Drawing.Size(144, 23);
            this.TxtNomeFantasma.TabIndex = 5;
            // 
            // BtnJuridica
            // 
            this.BtnJuridica.Location = new System.Drawing.Point(274, 81);
            this.BtnJuridica.Name = "BtnJuridica";
            this.BtnJuridica.Size = new System.Drawing.Size(94, 23);
            this.BtnJuridica.TabIndex = 6;
            this.BtnJuridica.Text = "Criar Classe";
            this.BtnJuridica.UseVisualStyleBackColor = true;
            this.BtnJuridica.Click += new System.EventHandler(this.BtnJuridica_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(399, 82);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(87, 23);
            this.BtnFechar.TabIndex = 7;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblTotalJuridica});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LblTotalJuridica
            // 
            this.LblTotalJuridica.Name = "LblTotalJuridica";
            this.LblTotalJuridica.Size = new System.Drawing.Size(0, 17);
            // 
            // GridJuridica
            // 
            this.GridJuridica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridJuridica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RazaoSocial,
            this.NomeFantasma,
            this.CNPJ});
            this.GridJuridica.Location = new System.Drawing.Point(0, 158);
            this.GridJuridica.Name = "GridJuridica";
            this.GridJuridica.RowTemplate.Height = 25;
            this.GridJuridica.Size = new System.Drawing.Size(799, 270);
            this.GridJuridica.TabIndex = 9;
            this.GridJuridica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridJuridica_CellContentClick);
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.HeaderText = "Razão Social";
            this.RazaoSocial.Name = "RazaoSocial";
            // 
            // NomeFantasma
            // 
            this.NomeFantasma.FillWeight = 1000F;
            this.NomeFantasma.HeaderText = "Nome Fantasma";
            this.NomeFantasma.Name = "NomeFantasma";
            // 
            // CNPJ
            // 
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            // 
            // FrmJuridica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridJuridica);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnJuridica);
            this.Controls.Add(this.TxtNomeFantasma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtRazaoSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCNPJ);
            this.Controls.Add(this.label1);
            this.Name = "FrmJuridica";
            this.Text = "Jurídica";
            this.Load += new System.EventHandler(this.FrmJuridica_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridJuridica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GridJuridica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmJuridica_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRazaoSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNomeFantasma;
        private System.Windows.Forms.Button BtnJuridica;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblTotalJuridica;
        private System.Windows.Forms.DataGridView GridJuridica;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFantasma;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
    }
}