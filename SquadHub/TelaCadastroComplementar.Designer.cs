
namespace SquadHub
{
    partial class TelaCadastroComplementar
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
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblFotoPerfil = new System.Windows.Forms.Label();
            this.lblBiografia = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.txtBiografia = new System.Windows.Forms.TextBox();
            this.boxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSelecionarImagemPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxFotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(92, 52);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(64, 15);
            this.lblNickname.TabIndex = 0;
            this.lblNickname.Text = "Nickname:";
            // 
            // lblFotoPerfil
            // 
            this.lblFotoPerfil.AutoSize = true;
            this.lblFotoPerfil.Location = new System.Drawing.Point(76, 177);
            this.lblFotoPerfil.Name = "lblFotoPerfil";
            this.lblFotoPerfil.Size = new System.Drawing.Size(80, 15);
            this.lblFotoPerfil.TabIndex = 1;
            this.lblFotoPerfil.Text = "Foto de Perfil:";
            // 
            // lblBiografia
            // 
            this.lblBiografia.AutoSize = true;
            this.lblBiografia.Location = new System.Drawing.Point(59, 302);
            this.lblBiografia.Name = "lblBiografia";
            this.lblBiografia.Size = new System.Drawing.Size(97, 15);
            this.lblBiografia.TabIndex = 2;
            this.lblBiografia.Text = "Escolha uma Bio:";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(192, 49);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(187, 23);
            this.txtNickname.TabIndex = 3;
            // 
            // txtBiografia
            // 
            this.txtBiografia.Location = new System.Drawing.Point(192, 299);
            this.txtBiografia.Name = "txtBiografia";
            this.txtBiografia.Size = new System.Drawing.Size(187, 23);
            this.txtBiografia.TabIndex = 4;
            // 
            // boxFotoPerfil
            // 
            this.boxFotoPerfil.Location = new System.Drawing.Point(192, 122);
            this.boxFotoPerfil.Name = "boxFotoPerfil";
            this.boxFotoPerfil.Size = new System.Drawing.Size(170, 136);
            this.boxFotoPerfil.TabIndex = 5;
            this.boxFotoPerfil.TabStop = false;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(640, 365);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(98, 52);
            this.btCadastrar.TabIndex = 6;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSelecionarImagemPerfil
            // 
            this.btSelecionarImagemPerfil.Location = new System.Drawing.Point(400, 152);
            this.btSelecionarImagemPerfil.Name = "btSelecionarImagemPerfil";
            this.btSelecionarImagemPerfil.Size = new System.Drawing.Size(63, 67);
            this.btSelecionarImagemPerfil.TabIndex = 7;
            this.btSelecionarImagemPerfil.Text = "Escolha uma imagem";
            this.btSelecionarImagemPerfil.UseVisualStyleBackColor = true;
            this.btSelecionarImagemPerfil.Click += new System.EventHandler(this.btSelecionarImagemPerfil_Click);
            // 
            // TelaCadastroComplementar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSelecionarImagemPerfil);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.boxFotoPerfil);
            this.Controls.Add(this.txtBiografia);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.lblBiografia);
            this.Controls.Add(this.lblFotoPerfil);
            this.Controls.Add(this.lblNickname);
            this.Name = "TelaCadastroComplementar";
            this.Text = "TelaCadastroComplementar";
            ((System.ComponentModel.ISupportInitialize)(this.boxFotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label lblFotoPerfil;
        private System.Windows.Forms.Label lblBiografia;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.TextBox txtBiografia;
        private System.Windows.Forms.PictureBox boxFotoPerfil;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btSelecionarImagemPerfil;
    }
}