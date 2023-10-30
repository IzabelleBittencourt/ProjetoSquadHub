using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaPrincipal : Form
    {
        private Usuario usuarioLogado;
        private int usuarioLogadoIndex;

        public TelaPrincipal(Usuario usuario, int usuarioIndex)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            usuarioLogadoIndex = usuarioIndex;
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            TelaConfiguracoes telaConfiguracoes = new TelaConfiguracoes(usuarioLogado, usuarioLogadoIndex);
            telaConfiguracoes.Show();
            this.Hide();
        }

        private void btTelaPerfil_Click(object sender, EventArgs e)
        {
            TelaPerfil telaPerfil = new TelaPerfil(usuarioLogado, usuarioLogadoIndex);
            telaPerfil.Show();
            this.Hide();
        }

        private void btTelaPessoasConectadas_Click(object sender, EventArgs e)
        {
            TelaPessoasConectadas telaPessoasConectadas = new TelaPessoasConectadas(usuarioLogado, usuarioLogadoIndex);
            telaPessoasConectadas.Show();
            this.Hide();
        }

        private void btTelaNovaPublicacao_Click(object sender, EventArgs e)
        {
            TelaNovaPublicacao telaNovaPublicacao = new TelaNovaPublicacao(usuarioLogado, usuarioLogadoIndex);
            telaNovaPublicacao.Show();
            this.Hide();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            CarregarPublicacoes();
        }

        private void CarregarPublicacoes()
        {
            foreach (Publicacao publicacao in ListaPublicacoes.Instance.Publicacoes)
            {
                PublicacaoControl publicacaoControl = new PublicacaoControl();
                publicacaoControl.SetPublicacao(publicacao);

                FlowLayoutPublicacoes.Controls.Add(publicacaoControl);
            }
        }

        private void viewPublicacoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewPublicacoes_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPublicacoes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
