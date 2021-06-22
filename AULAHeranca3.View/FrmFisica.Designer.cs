
using System;

namespace AULAHeranca3.View
{
    partial class FrmFisica
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
            this.TxtNome1 = new System.Windows.Forms.TextBox();
            this.TxtCPF1 = new System.Windows.Forms.TextBox();
            this.BtnFisica = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LblTotalFisica = new System.Windows.Forms.ToolStripStatusLabel();
            this.GridFisica = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFisica)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // TxtNome1
            // 
            this.TxtNome1.Location = new System.Drawing.Point(12, 27);
            this.TxtNome1.Name = "TxtNome1";
            this.TxtNome1.Size = new System.Drawing.Size(189, 23);
            this.TxtNome1.TabIndex = 1;
            // 
            // TxtCPF1
            // 
            this.TxtCPF1.Location = new System.Drawing.Point(12, 83);
            this.TxtCPF1.Name = "TxtCPF1";
            this.TxtCPF1.Size = new System.Drawing.Size(189, 23);
            this.TxtCPF1.TabIndex = 3;
            // 
            // BtnFisica
            // 
            this.BtnFisica.Location = new System.Drawing.Point(270, 61);
            this.BtnFisica.Name = "BtnFisica";
            this.BtnFisica.Size = new System.Drawing.Size(85, 27);
            this.BtnFisica.TabIndex = 4;
            this.BtnFisica.Text = "Criar Classe";
            this.BtnFisica.UseVisualStyleBackColor = true;
            this.BtnFisica.Click += new System.EventHandler(this.BtnFisica_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblTotalFisica});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            // 
            // LblTotalFisica
            // 
            this.LblTotalFisica.Name = "LblTotalFisica";
            this.LblTotalFisica.Size = new System.Drawing.Size(0, 17);
            // 
            // GridFisica
            // 
            this.GridFisica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFisica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF});
            this.GridFisica.Location = new System.Drawing.Point(0, 139);
            this.GridFisica.Name = "GridFisica";
            this.GridFisica.RowTemplate.Height = 25;
            this.GridFisica.Size = new System.Drawing.Size(798, 286);
            this.GridFisica.TabIndex = 7;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(387, 61);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(85, 27);
            this.BtnFechar.TabIndex = 8;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.GridFisica);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnFisica);
            this.Controls.Add(this.TxtCPF1);
            this.Controls.Add(this.TxtNome1);
            this.Controls.Add(this.label1);
            this.Name = "FrmFisica";
            this.Text = "Fisica";
            this.Load += new System.EventHandler(this.FrmFisica_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFisica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void FrmFisica_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome1;
        private System.Windows.Forms.TextBox TxtCPF1;
        private System.Windows.Forms.Button BtnFisica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblTotalFisica;
        private System.Windows.Forms.DataGridView GridFisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.Button BtnFechar;
    }
}