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
    public partial class DescripciónPelis : Form
    {
        
        public DescripciónPelis()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            Butacas butacas = new Butacas();          
            butacas.lblNombrePelicula.Text = lblPelicula.Text;
            butacas.imgButacas.Image = pbImagPelis.Image;
            butacas.Show();
            this.Dispose();

        }

        private void DescripciónPelis_Load(object sender, EventArgs e)
        {

        }
    }
}
