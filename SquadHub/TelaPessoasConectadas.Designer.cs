﻿
namespace SquadHub
{
    partial class TelaPessoasConectadas
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
            this.listViewUsuarios = new System.Windows.Forms.ListView();
            this.Usuários = new System.Windows.Forms.ColumnHeader();
            this.btEnviarSolicitacao = new System.Windows.Forms.Button();
            this.btVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewUsuarios
            // 
            this.listViewUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Usuários});
            this.listViewUsuarios.HideSelection = false;
            this.listViewUsuarios.Location = new System.Drawing.Point(188, 129);
            this.listViewUsuarios.Name = "listViewUsuarios";
            this.listViewUsuarios.Size = new System.Drawing.Size(382, 180);
            this.listViewUsuarios.TabIndex = 0;
            this.listViewUsuarios.UseCompatibleStateImageBehavior = false;
            this.listViewUsuarios.View = System.Windows.Forms.View.Details;
            this.listViewUsuarios.SelectedIndexChanged += new System.EventHandler(this.listViewUsuarios_SelectedIndexChanged);
            // 
            // Usuários
            // 
            this.Usuários.Text = "Nomes";
            // 
            // btEnviarSolicitacao
            // 
            this.btEnviarSolicitacao.Location = new System.Drawing.Point(467, 253);
            this.btEnviarSolicitacao.Name = "btEnviarSolicitacao";
            this.btEnviarSolicitacao.Size = new System.Drawing.Size(92, 46);
            this.btEnviarSolicitacao.TabIndex = 1;
            this.btEnviarSolicitacao.Text = "Enviar pedido de amizade";
            this.btEnviarSolicitacao.UseVisualStyleBackColor = true;
            this.btEnviarSolicitacao.Click += new System.EventHandler(this.btEnviarSolicitacao_Click);
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
            // TelaPessoasConectadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Controls.Add(this.btEnviarSolicitacao);
            this.Controls.Add(this.listViewUsuarios);
            this.Name = "TelaPessoasConectadas";
            this.Text = "TelaPessoasConectadas";
            this.Load += new System.EventHandler(this.TelaPessoasConectadas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUsuarios;
        private System.Windows.Forms.ColumnHeader Usuários;
        private System.Windows.Forms.Button btEnviarSolicitacao;
        private System.Windows.Forms.Button btVoltarTelaPrincipal;
    }
}