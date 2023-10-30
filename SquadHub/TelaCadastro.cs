using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = Convert.ToInt32(txtIdade.Text);
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            Usuario novoUsuario = new Usuario
            {
                Nome = nome,
                Idade = idade,
                Email = email,
                Senha = senha
            };

            novoUsuario.Indice = ListaUsuarios.Instance.Usuarios.Count;

            ListaUsuarios.Instance.Usuarios.Add(novoUsuario);

            MessageBox.Show("Cadastro realizado com sucesso!");

            LimparCampos();

            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Hide();
        }

        private void btVoltarTelaLogin_Click(object sender, EventArgs e)
        {
            TelaLogin telaLogin = new TelaLogin();
            telaLogin.Show();
            this.Close();
        }
    }
}
