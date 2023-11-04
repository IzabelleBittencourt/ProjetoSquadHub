
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.btTelaConfig = new System.Windows.Forms.Button();
            this.btTelaPerfil = new System.Windows.Forms.Button();
            this.btTelaPessoasConectadas = new System.Windows.Forms.Button();
            this.btTelaNovaPublicacao = new System.Windows.Forms.Button();
            this.FlowLayoutPublicacoes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btTelaConfig
            // 
            this.btTelaConfig.BackColor = System.Drawing.Color.Transparent;
            this.btTelaConfig.FlatAppearance.BorderSize = 0;
            this.btTelaConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTelaConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTelaConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaConfig.Location = new System.Drawing.Point(1863, 1);
            this.btTelaConfig.Name = "btTelaConfig";
            this.btTelaConfig.Size = new System.Drawing.Size(43, 48);
            this.btTelaConfig.TabIndex = 0;
            this.btTelaConfig.UseVisualStyleBackColor = false;
            this.btTelaConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // btTelaPerfil
            // 
            this.btTelaPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btTelaPerfil.FlatAppearance.BorderSize = 0;
            this.btTelaPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTelaPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTelaPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaPerfil.Location = new System.Drawing.Point(147, 61);
            this.btTelaPerfil.Name = "btTelaPerfil";
            this.btTelaPerfil.Size = new System.Drawing.Size(90, 93);
            this.btTelaPerfil.TabIndex = 1;
            this.btTelaPerfil.UseVisualStyleBackColor = false;
            this.btTelaPerfil.Click += new System.EventHandler(this.btTelaPerfil_Click);
            // 
            // btTelaPessoasConectadas
            // 
            this.btTelaPessoasConectadas.BackColor = System.Drawing.Color.Transparent;
            this.btTelaPessoasConectadas.FlatAppearance.BorderSize = 0;
            this.btTelaPessoasConectadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTelaPessoasConectadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTelaPessoasConectadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaPessoasConectadas.Location = new System.Drawing.Point(1518, 1020);
            this.btTelaPessoasConectadas.Name = "btTelaPessoasConectadas";
            this.btTelaPessoasConectadas.Size = new System.Drawing.Size(229, 49);
            this.btTelaPessoasConectadas.TabIndex = 2;
            this.btTelaPessoasConectadas.UseVisualStyleBackColor = false;
            this.btTelaPessoasConectadas.Click += new System.EventHandler(this.btTelaPessoasConectadas_Click);
            // 
            // btTelaNovaPublicacao
            // 
            this.btTelaNovaPublicacao.BackColor = System.Drawing.Color.Transparent;
            this.btTelaNovaPublicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTelaNovaPublicacao.FlatAppearance.BorderSize = 0;
            this.btTelaNovaPublicacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btTelaNovaPublicacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btTelaNovaPublicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTelaNovaPublicacao.Location = new System.Drawing.Point(1245, 139);
            this.btTelaNovaPublicacao.Name = "btTelaNovaPublicacao";
            this.btTelaNovaPublicacao.Size = new System.Drawing.Size(183, 36);
            this.btTelaNovaPublicacao.TabIndex = 3;
            this.btTelaNovaPublicacao.UseVisualStyleBackColor = false;
            this.btTelaNovaPublicacao.Click += new System.EventHandler(this.btTelaNovaPublicacao_Click);
            // 
            // FlowLayoutPublicacoes
            // 
            this.FlowLayoutPublicacoes.BackColor = System.Drawing.Color.Transparent;
            this.FlowLayoutPublicacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlowLayoutPublicacoes.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPublicacoes.Location = new System.Drawing.Point(471, 419);
            this.FlowLayoutPublicacoes.Name = "FlowLayoutPublicacoes";
            this.FlowLayoutPublicacoes.Size = new System.Drawing.Size(979, 643);
            this.FlowLayoutPublicacoes.TabIndex = 4;
            this.FlowLayoutPublicacoes.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPublicacoes_Paint);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1061);
            this.Controls.Add(this.FlowLayoutPublicacoes);
            this.Controls.Add(this.btTelaNovaPublicacao);
            this.Controls.Add(this.btTelaPessoasConectadas);
            this.Controls.Add(this.btTelaPerfil);
            this.Controls.Add(this.btTelaConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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