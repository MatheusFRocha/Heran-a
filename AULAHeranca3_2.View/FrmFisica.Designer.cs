
namespace AULAHeranca3_2.View
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCPF1 = new System.Windows.Forms.TextBox();
            this.BtnCriarfisica = new System.Windows.Forms.Button();
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
            this.TxtNome1.Size = new System.Drawing.Size(192, 23);
            this.TxtNome1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // TxtCPF1
            // 
            this.TxtCPF1.Location = new System.Drawing.Point(12, 71);
            this.TxtCPF1.Name = "TxtCPF1";
            this.TxtCPF1.Size = new System.Drawing.Size(192, 23);
            this.TxtCPF1.TabIndex = 3;
            // 
            // BtnCriarfisica
            // 
            this.BtnCriarfisica.Location = new System.Drawing.Point(246, 49);
            this.BtnCriarfisica.Name = "BtnCriarfisica";
            this.BtnCriarfisica.Size = new System.Drawing.Size(98, 23);
            this.BtnCriarfisica.TabIndex = 4;
            this.BtnCriarfisica.Text = "Criar Classe";
            this.BtnCriarfisica.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCriarfisica);
            this.Controls.Add(this.TxtCPF1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNome1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CPF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCPF1;
        private System.Windows.Forms.Button BtnCriarfisica;
    }
}