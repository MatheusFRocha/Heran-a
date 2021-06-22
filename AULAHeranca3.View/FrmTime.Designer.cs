
using System;

namespace AULAHeranca3.View
{
    partial class FrmTime
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
            this.TxtNomeTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTime = new System.Windows.Forms.TextBox();
            this.BtnCriarTime = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LblTotalTimes = new System.Windows.Forms.ToolStripStatusLabel();
            this.GridTime = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTime)).BeginInit();
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
            // TxtNomeTime
            // 
            this.TxtNomeTime.Location = new System.Drawing.Point(12, 27);
            this.TxtNomeTime.Name = "TxtNomeTime";
            this.TxtNomeTime.Size = new System.Drawing.Size(172, 23);
            this.TxtNomeTime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time";
            // 
            // TxtTime
            // 
            this.TxtTime.Location = new System.Drawing.Point(12, 80);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Size = new System.Drawing.Size(172, 23);
            this.TxtTime.TabIndex = 3;
            // 
            // BtnCriarTime
            // 
            this.BtnCriarTime.Location = new System.Drawing.Point(244, 54);
            this.BtnCriarTime.Name = "BtnCriarTime";
            this.BtnCriarTime.Size = new System.Drawing.Size(96, 23);
            this.BtnCriarTime.TabIndex = 4;
            this.BtnCriarTime.Text = "Criar Time";
            this.BtnCriarTime.UseVisualStyleBackColor = true;
            this.BtnCriarTime.Click += new System.EventHandler(this.BtnCriarTime_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.Location = new System.Drawing.Point(356, 54);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(96, 23);
            this.BtnFechar.TabIndex = 5;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblTotalTimes});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LblTotalTimes
            // 
            this.LblTotalTimes.Name = "LblTotalTimes";
            this.LblTotalTimes.Size = new System.Drawing.Size(0, 17);
            // 
            // GridTime
            // 
            this.GridTime.AllowUserToAddRows = false;
            this.GridTime.AllowUserToDeleteRows = false;
            this.GridTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.tIME});
            this.GridTime.Location = new System.Drawing.Point(-13, 127);
            this.GridTime.Name = "GridTime";
            this.GridTime.RowTemplate.Height = 25;
            this.GridTime.Size = new System.Drawing.Size(801, 298);
            this.GridTime.TabIndex = 7;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // tIME
            // 
            this.tIME.HeaderText = "Time";
            this.tIME.Name = "tIME";
            // 
            // FrmTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnCriarTime);
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNomeTime);
            this.Controls.Add(this.label1);
            this.Name = "FrmTime";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmTime_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmTime_Load(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomeTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTime;
        private System.Windows.Forms.Button BtnCriarTime;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LblTotalTimes;
        private System.Windows.Forms.DataGridView GridTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIME;
    }
}