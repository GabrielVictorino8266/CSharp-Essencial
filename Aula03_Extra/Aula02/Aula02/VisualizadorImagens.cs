using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03
{
    public partial class VisualizadorImagens : Form
    {
        public VisualizadorImagens()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Show an selected image
        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            if(ofdImagens.ShowDialog() == DialogResult.OK)
            {
                pbImagens.Visible = true;
                pbImagens.Load(ofdImagens.FileName);
                btnMostrar.Enabled = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Define a non image, but it doesn't set Visible property to false.
            pbImagens.Image = null;
            btnMostrar.Enabled = true;
        }

        private void rbStretch_CheckedChanged(object sender, EventArgs e)
        {
            pbImagens.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            pbImagens.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
