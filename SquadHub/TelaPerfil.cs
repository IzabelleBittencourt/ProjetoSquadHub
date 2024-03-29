﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class TelaPerfil : Form
    {
        private Usuario usuarioLogado;
        private int usuarioLogadoIndex;

        public TelaPerfil(Usuario usuario, int usuarioIndex)
        {
            InitializeComponent();
            usuarioLogado = usuario;
            usuarioLogadoIndex = usuarioIndex;
        }

        private void TelaPerfil_Load(object sender, EventArgs e)
        {
            if (usuarioLogadoIndex >= 0 && usuarioLogadoIndex < ListaUsuarios.Instance.Usuarios.Count)
            {
                Usuario usuario = ListaUsuarios.Instance.Usuarios[usuarioLogadoIndex];

                lblNomePerfil.Text = "Nome: " + usuario.Nome;
                lblEmailPerfil.Text = "Email: " + usuario.Email;
                lblNicknamePerfil.Text = "Nickname: " + usuario.Nickname;
                lblBiografiaPerfil.Text = "Bio: " + usuario.Biografia;
                boxFotoPerfil.Image = usuario.FotoPerfil;
                boxFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btVoltarTelaPrincipal_Click(object sender, EventArgs e)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal(usuarioLogado, usuarioLogadoIndex);
            telaPrincipal.Show();
            this.Hide();
        }
    }
}
