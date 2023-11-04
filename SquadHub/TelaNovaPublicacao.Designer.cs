
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaNovaPublicacao));
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
            this.btVoltarTelaPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaPrincipal.FlatAppearance.BorderSize = 0;
            this.btVoltarTelaPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btVoltarTelaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(144, 88);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(61, 37);
            this.btVoltarTelaPrincipal.TabIndex = 0;
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = false;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // boxImagem
            // 
            this.boxImagem.BackColor = System.Drawing.Color.Transparent;
            this.boxImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxImagem.Location = new System.Drawing.Point(497, 237);
            this.boxImagem.Name = "boxImagem";
            this.boxImagem.Size = new System.Drawing.Size(762, 397);
            this.boxImagem.TabIndex = 1;
            this.boxImagem.TabStop = false;
            this.boxImagem.Click += new System.EventHandler(this.boxImagem_Click);
            // 
            // txtLegenda
            // 
            this.txtLegenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLegenda.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLegenda.Location = new System.Drawing.Point(497, 663);
            this.txtLegenda.Name = "txtLegenda";
            this.txtLegenda.Size = new System.Drawing.Size(927, 68);
            this.txtLegenda.TabIndex = 2;
            this.txtLegenda.TextChanged += new System.EventHandler(this.txtLegenda_TextChanged);
            // 
            // btPublicar
            // 
            this.btPublicar.BackColor = System.Drawing.Color.Transparent;
            this.btPublicar.FlatAppearance.BorderSize = 0;
            this.btPublicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btPublicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btPublicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPublicar.Location = new System.Drawing.Point(1489, 972);
            this.btPublicar.Name = "btPublicar";
            this.btPublicar.Size = new System.Drawing.Size(287, 64);
            this.btPublicar.TabIndex = 3;
            this.btPublicar.UseVisualStyleBackColor = false;
            this.btPublicar.Click += new System.EventHandler(this.btPublicar_Click);
            // 
            // btSelecionarImagem
            // 
            this.btSelecionarImagem.BackColor = System.Drawing.Color.Transparent;
            this.btSelecionarImagem.FlatAppearance.BorderSize = 0;
            this.btSelecionarImagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSelecionarImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btSelecionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSelecionarImagem.Location = new System.Drawing.Point(1350, 237);
            this.btSelecionarImagem.Name = "btSelecionarImagem";
            this.btSelecionarImagem.Size = new System.Drawing.Size(72, 78);
            this.btSelecionarImagem.TabIndex = 4;
            this.btSelecionarImagem.UseVisualStyleBackColor = false;
            this.btSelecionarImagem.Click += new System.EventHandler(this.btSelecionarImagem_Click);
            // 
            // TelaNovaPublicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btSelecionarImagem);
            this.Controls.Add(this.btPublicar);
            this.Controls.Add(this.txtLegenda);
            this.Controls.Add(this.boxImagem);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaNovaPublicacao";
            this.Text = "TelaNovaPublicacao";
            this.Load += new System.EventHandler(this.TelaNovaPublicacao_Load);
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