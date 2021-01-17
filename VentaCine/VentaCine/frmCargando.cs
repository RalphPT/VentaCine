using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentaCine
{
    public partial class frmCargando : Form
    {
        public frmCargando()
        {
        
            InitializeComponent();
            this.cargando.Start();

            
        }

        private void frmCargando_Load(object sender, EventArgs e)
        {
           //pictureBox1.Image = Image.FromFile (@"E:\WILMER\Ricardo2.gif");
           // pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }

        private void cargando_Tick(object sender, EventArgs e)
        {
            this.barracargando.Increment(1);
            label1.Text = barracargando.Value.ToString() + "%";
            if (barracargando.Value == barracargando.Maximum)
            {
                cargando.Stop();
                this.Hide();
                Portada portada = new Portada();
                portada.Show();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    
    }
}
