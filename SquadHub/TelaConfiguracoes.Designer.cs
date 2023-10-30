
namespace SquadHub
{
    partial class TelaConfiguracoes
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
            this.btTelaLogin = new System.Windows.Forms.Button();
            this.btVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTelaLogin
            // 
            this.btTelaLogin.Location = new System.Drawing.Point(308, 212);
            this.btTelaLogin.Name = "btTelaLogin";
            this.btTelaLogin.Size = new System.Drawing.Size(142, 38);
            this.btTelaLogin.TabIndex = 1;
            this.btTelaLogin.Text = "Sair";
            this.btTelaLogin.UseVisualStyleBackColor = true;
            this.btTelaLogin.Click += new System.EventHandler(this.btTelaLogin_Click);
            // 
            // btVoltarTelaPrincipal
            // 
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(82, 29);
            this.btVoltarTelaPrincipal.TabIndex = 2;
            this.btVoltarTelaPrincipal.Text = "Voltar";
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = true;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // TelaConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Controls.Add(this.btTelaLogin);
            this.Name = "TelaConfiguracoes";
            this.Text = "Configuracoes";
            this.Load += new System.EventHandler(this.TelaConfiguracoes_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btTelaLogin;
        private System.Windows.Forms.Button btVoltarTelaPrincipal;
    }
}