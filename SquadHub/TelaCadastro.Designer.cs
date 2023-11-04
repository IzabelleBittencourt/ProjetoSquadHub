﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btVoltarTelaLogin = new System.Windows.Forms.Button();
            this.txtConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.dataNascimentoPicker = new System.Windows.Forms.DateTimePicker();
            this.btMostrarSenha = new System.Windows.Forms.Button();
            this.btMostrarConfirmacaoSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.MediumOrchid;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(1007, 306);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(625, 66);
            this.txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.MediumOrchid;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(1007, 397);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(625, 66);
            this.txtEmail.TabIndex = 6;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.MediumOrchid;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(1007, 635);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(625, 66);
            this.txtSenha.TabIndex = 7;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCadastrar.FlatAppearance.BorderSize = 0;
            this.btCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Location = new System.Drawing.Point(1337, 841);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(294, 61);
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btVoltarTelaLogin
            // 
            this.btVoltarTelaLogin.BackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaLogin.FlatAppearance.BorderSize = 0;
            this.btVoltarTelaLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltarTelaLogin.Location = new System.Drawing.Point(24, 24);
            this.btVoltarTelaLogin.Name = "btVoltarTelaLogin";
            this.btVoltarTelaLogin.Size = new System.Drawing.Size(61, 37);
            this.btVoltarTelaLogin.TabIndex = 9;
            this.btVoltarTelaLogin.UseVisualStyleBackColor = false;
            this.btVoltarTelaLogin.Click += new System.EventHandler(this.btVoltarTelaLogin_Click);
            // 
            // txtConfirmacaoSenha
            // 
            this.txtConfirmacaoSenha.BackColor = System.Drawing.Color.MediumOrchid;
            this.txtConfirmacaoSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmacaoSenha.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmacaoSenha.ForeColor = System.Drawing.Color.White;
            this.txtConfirmacaoSenha.Location = new System.Drawing.Point(1007, 727);
            this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            this.txtConfirmacaoSenha.Size = new System.Drawing.Size(625, 66);
            this.txtConfirmacaoSenha.TabIndex = 13;
            this.txtConfirmacaoSenha.UseSystemPasswordChar = true;
            // 
            // dataNascimentoPicker
            // 
            this.dataNascimentoPicker.CustomFormat = "dd/MM/yyyy";
            this.dataNascimentoPicker.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataNascimentoPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataNascimentoPicker.Location = new System.Drawing.Point(1007, 544);
            this.dataNascimentoPicker.Name = "dataNascimentoPicker";
            this.dataNascimentoPicker.Size = new System.Drawing.Size(625, 64);
            this.dataNascimentoPicker.TabIndex = 14;
            // 
            // btMostrarSenha
            // 
            this.btMostrarSenha.BackColor = System.Drawing.Color.Transparent;
            this.btMostrarSenha.FlatAppearance.BorderSize = 0;
            this.btMostrarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btMostrarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btMostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMostrarSenha.Location = new System.Drawing.Point(1648, 655);
            this.btMostrarSenha.Name = "btMostrarSenha";
            this.btMostrarSenha.Size = new System.Drawing.Size(43, 30);
            this.btMostrarSenha.TabIndex = 16;
            this.btMostrarSenha.UseVisualStyleBackColor = false;
            this.btMostrarSenha.Click += new System.EventHandler(this.btMostrarSenha_Click);
            // 
            // btMostrarConfirmacaoSenha
            // 
            this.btMostrarConfirmacaoSenha.BackColor = System.Drawing.Color.Transparent;
            this.btMostrarConfirmacaoSenha.FlatAppearance.BorderSize = 0;
            this.btMostrarConfirmacaoSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btMostrarConfirmacaoSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btMostrarConfirmacaoSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMostrarConfirmacaoSenha.Location = new System.Drawing.Point(1648, 744);
            this.btMostrarConfirmacaoSenha.Name = "btMostrarConfirmacaoSenha";
            this.btMostrarConfirmacaoSenha.Size = new System.Drawing.Size(43, 30);
            this.btMostrarConfirmacaoSenha.TabIndex = 17;
            this.btMostrarConfirmacaoSenha.UseVisualStyleBackColor = false;
            this.btMostrarConfirmacaoSenha.Click += new System.EventHandler(this.btMostrarConfirmacaoSenha_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btMostrarConfirmacaoSenha);
            this.Controls.Add(this.btMostrarSenha);
            this.Controls.Add(this.dataNascimentoPicker);
            this.Controls.Add(this.txtConfirmacaoSenha);
            this.Controls.Add(this.btVoltarTelaLogin);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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