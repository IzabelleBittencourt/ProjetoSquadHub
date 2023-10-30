using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SquadHub
{
    public partial class PublicacaoControl : UserControl
    {
        private PictureBox pictureBox;
        private Label labelLegenda;

        public PublicacaoControl()
        {
            InitializeComponent();

            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Top;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            labelLegenda = new Label();
            labelLegenda.Dock = DockStyle.Top;

            this.Controls.Add(labelLegenda);
            this.Controls.Add(pictureBox);
        }

        public void SetPublicacao(Publicacao publicacao)
        {
            pictureBox.Image = publicacao.Imagem;

            labelLegenda.Text = publicacao.Legenda;
        }

        private void PublicacaoControl_Load(object sender, EventArgs e)
        {

        }
    }
}
