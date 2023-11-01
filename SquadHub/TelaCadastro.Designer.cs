
namespace SquadHub
{
    partial class TelaCadastro
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btVoltarTelaLogin = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblConfirmacaoSenha = new System.Windows.Forms.Label();
            this.txtConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.dataNascimentoPicker = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.btMostrarSenha = new System.Windows.Forms.Button();
            this.btMostrarConfirmacaoSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(123, 147);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(119, 193);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 15);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(213, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(161, 23);
            this.txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(213, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 23);
            this.txtEmail.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(213, 185);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(161, 23);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(514, 332);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(128, 62);
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btVoltarTelaLogin
            // 
            this.btVoltarTelaLogin.Location = new System.Drawing.Point(74, 332);
            this.btVoltarTelaLogin.Name = "btVoltarTelaLogin";
            this.btVoltarTelaLogin.Size = new System.Drawing.Size(87, 41);
            this.btVoltarTelaLogin.TabIndex = 9;
            this.btVoltarTelaLogin.Text = "Voltar";
            this.btVoltarTelaLogin.UseVisualStyleBackColor = true;
            this.btVoltarTelaLogin.Click += new System.EventHandler(this.btVoltarTelaLogin_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(119, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 15);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            // 
            // lblConfirmacaoSenha
            // 
            this.lblConfirmacaoSenha.AutoSize = true;
            this.lblConfirmacaoSenha.Location = new System.Drawing.Point(62, 251);
            this.lblConfirmacaoSenha.Name = "lblConfirmacaoSenha";
            this.lblConfirmacaoSenha.Size = new System.Drawing.Size(99, 15);
            this.lblConfirmacaoSenha.TabIndex = 12;
            this.lblConfirmacaoSenha.Text = "Confirmar Senha:";
            // 
            // txtConfirmacaoSenha
            // 
            this.txtConfirmacaoSenha.Location = new System.Drawing.Point(213, 243);
            this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            this.txtConfirmacaoSenha.Size = new System.Drawing.Size(161, 23);
            this.txtConfirmacaoSenha.TabIndex = 13;
            this.txtConfirmacaoSenha.UseSystemPasswordChar = true;
            // 
            // dataNascimentoPicker
            // 
            this.dataNascimentoPicker.CustomFormat = "dd/MM/yyyy";
            this.dataNascimentoPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataNascimentoPicker.Location = new System.Drawing.Point(203, 95);
            this.dataNascimentoPicker.Name = "dataNascimentoPicker";
            this.dataNascimentoPicker.Size = new System.Drawing.Size(252, 23);
            this.dataNascimentoPicker.TabIndex = 14;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(45, 101);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(117, 15);
            this.lblDataNascimento.TabIndex = 15;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // btMostrarSenha
            // 
            this.btMostrarSenha.Location = new System.Drawing.Point(390, 186);
            this.btMostrarSenha.Name = "btMostrarSenha";
            this.btMostrarSenha.Size = new System.Drawing.Size(32, 29);
            this.btMostrarSenha.TabIndex = 16;
            this.btMostrarSenha.Text = "Ver";
            this.btMostrarSenha.UseVisualStyleBackColor = true;
            this.btMostrarSenha.Click += new System.EventHandler(this.btMostrarSenha_Click);
            // 
            // btMostrarConfirmacaoSenha
            // 
            this.btMostrarConfirmacaoSenha.Location = new System.Drawing.Point(390, 239);
            this.btMostrarConfirmacaoSenha.Name = "btMostrarConfirmacaoSenha";
            this.btMostrarConfirmacaoSenha.Size = new System.Drawing.Size(32, 29);
            this.btMostrarConfirmacaoSenha.TabIndex = 17;
            this.btMostrarConfirmacaoSenha.Text = "Ver";
            this.btMostrarConfirmacaoSenha.UseVisualStyleBackColor = true;
            this.btMostrarConfirmacaoSenha.Click += new System.EventHandler(this.btMostrarConfirmacaoSenha_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMostrarConfirmacaoSenha);
            this.Controls.Add(this.btMostrarSenha);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.dataNascimentoPicker);
            this.Controls.Add(this.txtConfirmacaoSenha);
            this.Controls.Add(this.lblConfirmacaoSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btVoltarTelaLogin);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Name = "TelaCadastro";
            this.Text = "TelaCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btVoltarTelaLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblConfirmacaoSenha;
        private System.Windows.Forms.TextBox txtConfirmacaoSenha;
        private System.Windows.Forms.DateTimePicker dataNascimentoPicker;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Button btMostrarSenha;
        private System.Windows.Forms.Button btMostrarConfirmacaoSenha;
    }
}