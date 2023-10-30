
namespace SquadHub
{
    partial class TelaNovaPublicacao
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
            this.boxImagem = new System.Windows.Forms.PictureBox();
            this.txtLegenda = new System.Windows.Forms.TextBox();
            this.btPublicar = new System.Windows.Forms.Button();
            this.btSelecionarImagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltarTelaPrincipal
            // 
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btVoltarTelaPrincipal.TabIndex = 0;
            this.btVoltarTelaPrincipal.Text = "Voltar";
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = true;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // boxImagem
            // 
            this.boxImagem.Location = new System.Drawing.Point(105, 43);
            this.boxImagem.Name = "boxImagem";
            this.boxImagem.Size = new System.Drawing.Size(544, 307);
            this.boxImagem.TabIndex = 1;
            this.boxImagem.TabStop = false;
            this.boxImagem.Click += new System.EventHandler(this.boxImagem_Click);
            // 
            // txtLegenda
            // 
            this.txtLegenda.Location = new System.Drawing.Point(105, 372);
            this.txtLegenda.Name = "txtLegenda";
            this.txtLegenda.Size = new System.Drawing.Size(544, 23);
            this.txtLegenda.TabIndex = 2;
            this.txtLegenda.TextChanged += new System.EventHandler(this.txtLegenda_TextChanged);
            // 
            // btPublicar
            // 
            this.btPublicar.Location = new System.Drawing.Point(702, 354);
            this.btPublicar.Name = "btPublicar";
            this.btPublicar.Size = new System.Drawing.Size(86, 84);
            this.btPublicar.TabIndex = 3;
            this.btPublicar.Text = "Publicar";
            this.btPublicar.UseVisualStyleBackColor = true;
            this.btPublicar.Click += new System.EventHandler(this.btPublicar_Click);
            // 
            // btSelecionarImagem
            // 
            this.btSelecionarImagem.Location = new System.Drawing.Point(690, 58);
            this.btSelecionarImagem.Name = "btSelecionarImagem";
            this.btSelecionarImagem.Size = new System.Drawing.Size(60, 68);
            this.btSelecionarImagem.TabIndex = 4;
            this.btSelecionarImagem.Text = "Escolha uma imagem";
            this.btSelecionarImagem.UseVisualStyleBackColor = true;
            this.btSelecionarImagem.Click += new System.EventHandler(this.btSelecionarImagem_Click);
            // 
            // TelaNovaPublicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSelecionarImagem);
            this.Controls.Add(this.btPublicar);
            this.Controls.Add(this.txtLegenda);
            this.Controls.Add(this.boxImagem);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Name = "TelaNovaPublicacao";
            this.Text = "TelaNovaPublicacao";
            ((System.ComponentModel.ISupportInitialize)(this.boxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltarTelaPrincipal;
        private System.Windows.Forms.PictureBox boxImagem;
        private System.Windows.Forms.TextBox txtLegenda;
        private System.Windows.Forms.Button btPublicar;
        private System.Windows.Forms.Button btSelecionarImagem;
    }
}