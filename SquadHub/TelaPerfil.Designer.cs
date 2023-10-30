
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
            this.lblNomePerfil = new System.Windows.Forms.Label();
            this.lblEmailPerfil = new System.Windows.Forms.Label();
            this.btVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomePerfil
            // 
            this.lblNomePerfil.AutoSize = true;
            this.lblNomePerfil.Location = new System.Drawing.Point(95, 68);
            this.lblNomePerfil.Name = "lblNomePerfil";
            this.lblNomePerfil.Size = new System.Drawing.Size(0, 15);
            this.lblNomePerfil.TabIndex = 0;
            // 
            // lblEmailPerfil
            // 
            this.lblEmailPerfil.AutoSize = true;
            this.lblEmailPerfil.Location = new System.Drawing.Point(95, 147);
            this.lblEmailPerfil.Name = "lblEmailPerfil";
            this.lblEmailPerfil.Size = new System.Drawing.Size(0, 15);
            this.lblEmailPerfil.TabIndex = 1;
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
            // TelaPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Controls.Add(this.lblEmailPerfil);
            this.Controls.Add(this.lblNomePerfil);
            this.Name = "TelaPerfil";
            this.Text = "TelaPerfil";
            this.Load += new System.EventHandler(this.TelaPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomePerfil;
        private System.Windows.Forms.Label lblEmailPerfil;
        private System.Windows.Forms.Button btVoltarTelaPrincipal;
    }
}