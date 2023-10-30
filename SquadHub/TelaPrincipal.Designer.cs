
namespace SquadHub
{
    partial class TelaPrincipal
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
            this.btTelaConfig = new System.Windows.Forms.Button();
            this.btTelaPerfil = new System.Windows.Forms.Button();
            this.btTelaPessoasConectadas = new System.Windows.Forms.Button();
            this.btTelaNovaPublicacao = new System.Windows.Forms.Button();
            this.FlowLayoutPublicacoes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btTelaConfig
            // 
            this.btTelaConfig.Location = new System.Drawing.Point(676, 29);
            this.btTelaConfig.Name = "btTelaConfig";
            this.btTelaConfig.Size = new System.Drawing.Size(95, 66);
            this.btTelaConfig.TabIndex = 0;
            this.btTelaConfig.Text = "Configurações";
            this.btTelaConfig.UseVisualStyleBackColor = true;
            this.btTelaConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // btTelaPerfil
            // 
            this.btTelaPerfil.Location = new System.Drawing.Point(12, 12);
            this.btTelaPerfil.Name = "btTelaPerfil";
            this.btTelaPerfil.Size = new System.Drawing.Size(72, 68);
            this.btTelaPerfil.TabIndex = 1;
            this.btTelaPerfil.Text = "Perfil";
            this.btTelaPerfil.UseVisualStyleBackColor = true;
            this.btTelaPerfil.Click += new System.EventHandler(this.btTelaPerfil_Click);
            // 
            // btTelaPessoasConectadas
            // 
            this.btTelaPessoasConectadas.Location = new System.Drawing.Point(738, 196);
            this.btTelaPessoasConectadas.Name = "btTelaPessoasConectadas";
            this.btTelaPessoasConectadas.Size = new System.Drawing.Size(50, 139);
            this.btTelaPessoasConectadas.TabIndex = 2;
            this.btTelaPessoasConectadas.Text = "Online";
            this.btTelaPessoasConectadas.UseVisualStyleBackColor = true;
            this.btTelaPessoasConectadas.Click += new System.EventHandler(this.btTelaPessoasConectadas_Click);
            // 
            // btTelaNovaPublicacao
            // 
            this.btTelaNovaPublicacao.Location = new System.Drawing.Point(500, 25);
            this.btTelaNovaPublicacao.Name = "btTelaNovaPublicacao";
            this.btTelaNovaPublicacao.Size = new System.Drawing.Size(91, 42);
            this.btTelaNovaPublicacao.TabIndex = 3;
            this.btTelaNovaPublicacao.Text = "Nova Publicação";
            this.btTelaNovaPublicacao.UseVisualStyleBackColor = true;
            this.btTelaNovaPublicacao.Click += new System.EventHandler(this.btTelaNovaPublicacao_Click);
            // 
            // FlowLayoutPublicacoes
            // 
            this.FlowLayoutPublicacoes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPublicacoes.Location = new System.Drawing.Point(123, 161);
            this.FlowLayoutPublicacoes.Name = "FlowLayoutPublicacoes";
            this.FlowLayoutPublicacoes.Size = new System.Drawing.Size(500, 235);
            this.FlowLayoutPublicacoes.TabIndex = 4;
            this.FlowLayoutPublicacoes.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPublicacoes_Paint);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FlowLayoutPublicacoes);
            this.Controls.Add(this.btTelaNovaPublicacao);
            this.Controls.Add(this.btTelaPessoasConectadas);
            this.Controls.Add(this.btTelaPerfil);
            this.Controls.Add(this.btTelaConfig);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTelaConfig;
        private System.Windows.Forms.Button btTelaPerfil;
        private System.Windows.Forms.Button btTelaPessoasConectadas;
        private System.Windows.Forms.Button btTelaNovaPublicacao;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPublicacoes;
    }
}