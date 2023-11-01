
namespace SquadHub
{
    partial class TelaPerfil
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
            this.btVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.lblNomePerfil = new System.Windows.Forms.Label();
            this.lblEmailPerfil = new System.Windows.Forms.Label();
            this.lblNicknamePerfil = new System.Windows.Forms.Label();
            this.lblBiografiaPerfil = new System.Windows.Forms.Label();
            this.boxFotoPerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boxFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltarTelaPrincipal
            // 
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btVoltarTelaPrincipal.TabIndex = 2;
            this.btVoltarTelaPrincipal.Text = "Voltar";
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = true;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // lblNomePerfil
            // 
            this.lblNomePerfil.AutoSize = true;
            this.lblNomePerfil.Location = new System.Drawing.Point(82, 107);
            this.lblNomePerfil.Name = "lblNomePerfil";
            this.lblNomePerfil.Size = new System.Drawing.Size(43, 15);
            this.lblNomePerfil.TabIndex = 3;
            this.lblNomePerfil.Text = "Nome:";
            // 
            // lblEmailPerfil
            // 
            this.lblEmailPerfil.AutoSize = true;
            this.lblEmailPerfil.Location = new System.Drawing.Point(86, 155);
            this.lblEmailPerfil.Name = "lblEmailPerfil";
            this.lblEmailPerfil.Size = new System.Drawing.Size(39, 15);
            this.lblEmailPerfil.TabIndex = 4;
            this.lblEmailPerfil.Text = "Email:";
            // 
            // lblNicknamePerfil
            // 
            this.lblNicknamePerfil.AutoSize = true;
            this.lblNicknamePerfil.Location = new System.Drawing.Point(61, 200);
            this.lblNicknamePerfil.Name = "lblNicknamePerfil";
            this.lblNicknamePerfil.Size = new System.Drawing.Size(64, 15);
            this.lblNicknamePerfil.TabIndex = 5;
            this.lblNicknamePerfil.Text = "Nickname:";
            // 
            // lblBiografiaPerfil
            // 
            this.lblBiografiaPerfil.AutoSize = true;
            this.lblBiografiaPerfil.Location = new System.Drawing.Point(98, 239);
            this.lblBiografiaPerfil.Name = "lblBiografiaPerfil";
            this.lblBiografiaPerfil.Size = new System.Drawing.Size(27, 15);
            this.lblBiografiaPerfil.TabIndex = 6;
            this.lblBiografiaPerfil.Text = "Bio:";
            // 
            // boxFotoPerfil
            // 
            this.boxFotoPerfil.Location = new System.Drawing.Point(578, 94);
            this.boxFotoPerfil.Name = "boxFotoPerfil";
            this.boxFotoPerfil.Size = new System.Drawing.Size(147, 144);
            this.boxFotoPerfil.TabIndex = 7;
            this.boxFotoPerfil.TabStop = false;
            // 
            // TelaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxFotoPerfil);
            this.Controls.Add(this.lblBiografiaPerfil);
            this.Controls.Add(this.lblNicknamePerfil);
            this.Controls.Add(this.lblEmailPerfil);
            this.Controls.Add(this.lblNomePerfil);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Name = "TelaPerfil";
            this.Text = "TelaPerfil";
            this.Load += new System.EventHandler(this.TelaPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltarTelaPrincipal;
        private System.Windows.Forms.Label lblNomePerfil;
        private System.Windows.Forms.Label lblEmailPerfil;
        private System.Windows.Forms.Label lblNicknamePerfil;
        private System.Windows.Forms.Label lblBiografiaPerfil;
        private System.Windows.Forms.PictureBox boxFotoPerfil;
    }
}