
namespace SquadHub
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btTelaCad = new System.Windows.Forms.Button();
            this.lblEmailLogin = new System.Windows.Forms.Label();
            this.lblSenhaLogin = new System.Windows.Forms.Label();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.btEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTelaCad
            // 
            this.btTelaCad.Location = new System.Drawing.Point(134, 296);
            this.btTelaCad.Name = "btTelaCad";
            this.btTelaCad.Size = new System.Drawing.Size(173, 53);
            this.btTelaCad.TabIndex = 0;
            this.btTelaCad.Text = "Novo Usuário";
            this.btTelaCad.UseVisualStyleBackColor = true;
            this.btTelaCad.Click += new System.EventHandler(this.btTelaCad_Click);
            // 
            // lblEmailLogin
            // 
            this.lblEmailLogin.AutoSize = true;
            this.lblEmailLogin.Location = new System.Drawing.Point(166, 86);
            this.lblEmailLogin.Name = "lblEmailLogin";
            this.lblEmailLogin.Size = new System.Drawing.Size(39, 15);
            this.lblEmailLogin.TabIndex = 1;
            this.lblEmailLogin.Text = "Email:";
            // 
            // lblSenhaLogin
            // 
            this.lblSenhaLogin.AutoSize = true;
            this.lblSenhaLogin.Location = new System.Drawing.Point(166, 136);
            this.lblSenhaLogin.Name = "lblSenhaLogin";
            this.lblSenhaLogin.Size = new System.Drawing.Size(42, 15);
            this.lblSenhaLogin.TabIndex = 2;
            this.lblSenhaLogin.Text = "Senha:";
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Location = new System.Drawing.Point(269, 83);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(142, 23);
            this.txtEmailLogin.TabIndex = 3;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(269, 133);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.Size = new System.Drawing.Size(142, 23);
            this.txtSenhaLogin.TabIndex = 4;
            // 
            // btEntrar
            // 
            this.btEntrar.Location = new System.Drawing.Point(442, 296);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(187, 53);
            this.btEntrar.TabIndex = 5;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = true;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.txtSenhaLogin);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.lblSenhaLogin);
            this.Controls.Add(this.lblEmailLogin);
            this.Controls.Add(this.btTelaCad);
            this.Name = "TelaLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTelaCad;
        private System.Windows.Forms.Label lblEmailLogin;
        private System.Windows.Forms.Label lblSenhaLogin;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.Button btEntrar;
    }
}

