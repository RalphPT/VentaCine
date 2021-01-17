using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VentaCine
{
    public partial class frmEntradas : Form
    {
        public frmEntradas()
        {
            InitializeComponent();
        }
        int nEntradas, total = 0, a = 0, b = 0, c = 0;
        private void frmEntradas_Load(object sender, EventArgs e)
        {
            gbDetalles.Location = new Point(287, 12);
            gbEntrada.Location = new Point(287, 12);
            nEntradas = Convert.ToInt16(lblEntrada2.Text);

        }
        
        private void btnVolverEntradas_Click(object sender, EventArgs e)
        {
            
            this.Close();
            

        }

        private void btnSiguienteEntradas_Click(object sender, EventArgs e)
        {

            if (int.Parse(lblMayores60.Text) + int.Parse(lblNiños.Text) + int.Parse(lblGeneral.Text) != int.Parse(lblEntrada2.Text))
            {
                MessageBox.Show("Entradas no asignadas!", "ERROR");
            }
            else
            {
                int costoMayores60 = 0, costogeneral = 0, costoNiños = 0;

                gbDetalles.Visible = true;
                gbEntrada.Visible = false;
                if (int.Parse(lblGeneral.Text) != 0)
                {
                    costogeneral = int.Parse(lblGeneral.Text) * 11;
                    lblCostoEGeneral.Text = costogeneral.ToString() + ".00";
                }
                else
                {
                    lblCantGeneral.Visible = false;
                    lblNGeneral.Visible = false;
                    lblSGeneral.Visible = false;
                    lblEGeneral.Visible = false;
                    lblCostoEGeneral.Visible = false;
                }

                if (int.Parse(lblMayores60.Text) != 0)
                {
                    costoMayores60 = int.Parse(lblMayores60.Text) * 9;
                    lblCostoEMayores60.Text = costoMayores60.ToString() + ".00";
                }
                else
                {
                    lblCantMayores60.Visible = false;
                    lblNMayores60.Visible = false;
                    lblEMayores60.Visible = false;
                    lblSMayor60.Visible = false;
                    lblCostoEMayores60.Visible = false;
                }
                if (int.Parse(lblNiños.Text) != 0)
                {
                    costoNiños = int.Parse(lblNiños.Text) * 8;
                    lblCostoENiños.Text = costoNiños.ToString() + ".00";
                }
                else
                {
                    lblCantNiños.Visible = false;
                    lblNNiños.Visible = false;
                    lblSNiños.Visible = false;
                    lblENiños.Visible = false;
                    lblCostoENiños.Visible = false;
                }

                lblEMayores60.Text = lblMayores60.Text;
                lblEGeneral.Text = lblGeneral.Text;
                lblENiños.Text = lblNiños.Text;

                int costoSubTotal = costogeneral + costoNiños + costoMayores60;
                lblCostoETotal.Text = costoSubTotal.ToString() + ".00";
                lblSubTotal.Text = costoSubTotal.ToString() + ".00";
                lblButacas.Text = lblEntrada2.Text;
            }
        }

        private void btnMas1_Click(object sender, EventArgs e)
        {
            a++;
            total = total + 1;
            lblMayores60.Text = a.ToString();


            if (total == nEntradas)
            {
                btnMas1.Enabled = false;
                btnMas2.Enabled = false;
                btnMas3.Enabled = false;
            }
            if (a > 0)
            {
                btnMenos1.Enabled = true;
            }
        }

        private void btnMas2_Click(object sender, EventArgs e)
        {
            b++;
            total = total + 1;
            lblNiños.Text = b.ToString();



            if (total == nEntradas)
            {
                btnMas1.Enabled = false;
                btnMas2.Enabled = false;
                btnMas3.Enabled = false;

            }
            if (b > 0)
            {
                btnMenos2.Enabled = true;
            }

        }

        private void btnMas3_Click(object sender, EventArgs e)
        {
            c++;
            total = total + 1;
            lblGeneral.Text = c.ToString();



            if (total == nEntradas)
            {
                btnMas1.Enabled = false;
                btnMas2.Enabled = false;
                btnMas3.Enabled = false;

            }
            if (c > 0)
            {
                btnMenos3.Enabled = true;
            }
        }

        private void btnMenos1_Click(object sender, EventArgs e)
        {
            a--;
            total = total - 1;
            if (int.Parse(lblMayores60.Text) > 0)
            {
                btnMas1.Enabled = true;
                btnMas2.Enabled = true;
                btnMas3.Enabled = true;
                if (a == 0)
                {
                    btnMenos1.Enabled = false;
                    lblMayores60.Text = a.ToString();
                }
                else
                {
                    btnMenos1.Enabled = true;
                    lblMayores60.Text = a.ToString();
                }
            }
        }

        private void btnMenos2_Click(object sender, EventArgs e)
        {
            b--;
            total = total - 1;
            if (int.Parse(lblNiños.Text) > 0)
            {
                btnMas1.Enabled = true;
                btnMas2.Enabled = true;
                btnMas3.Enabled = true;
                if (b == 0)
                {
                    btnMenos2.Enabled = false;
                    lblNiños.Text = b.ToString();
                }
                else
                {
                    btnMenos2.Enabled = true;
                    lblNiños.Text = b.ToString();
                }
            }
        }

        private void btnMenos3_Click(object sender, EventArgs e)
        {
            c--;
            total = total - 1;
            if (int.Parse(lblGeneral.Text) > 0)
            {
                btnMas1.Enabled = true;
                btnMas2.Enabled = true;
                btnMas3.Enabled = true;
                if (c == 0)
                {
                    btnMenos3.Enabled = false;
                    lblGeneral.Text = c.ToString();
                }
                else
                {
                    btnMenos3.Enabled = true;
                    lblGeneral.Text = c.ToString();
                }
            }
        }

        private void btnvolverDetalles_Click(object sender, EventArgs e)
        {
            gbDetalles.Visible = false;
            gbEntrada.Visible = true;
            lblCantGeneral.Visible = true;
            lblNGeneral.Visible = true;
            lblSGeneral.Visible = true;
            lblEGeneral.Visible = true;
            lblCostoEGeneral.Visible = true;
            lblCantNiños.Visible = true;
            lblNNiños.Visible = true;
            lblSNiños.Visible = true;
            lblENiños.Visible = true;
            lblCostoENiños.Visible = true;
            lblCantMayores60.Visible = true;
            lblNMayores60.Visible = true;
            lblEMayores60.Visible = true;
            lblSMayor60.Visible = true;
            lblCostoEMayores60.Visible = true;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
           



            MessageBox.Show("Compra Existosa!!!","Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            string Linea;
            
            if (File.Exists(@"D:\REPORTE.txt")) 
            {
                StreamWriter Archivos = File.AppendText(@"D:\REPORTE.txt");

                Linea = lblNombrePelicula.Text.PadRight(31, ' ') + "|" + lblButacas.Text.PadRight(11, ' ') + "|" + lblCostoEGeneral.Text.PadRight(18, ' ') + "|" +
               lblCostoENiños.Text.PadRight(18, ' ') + "|" + lblCostoEMayores60.Text.PadRight(17, ' ') + "|" + lblCostoETotal.Text.PadRight(10, ' '); 
                Archivos.WriteLine(Linea); 
                Archivos.Close();
                this.Close();
    
                
            } 
            else 
            {
                StreamWriter Archivos = File.AppendText(@"D:\REPORTE.txt");

                Linea = lblNombrePelicula.Text.PadRight(31, ' ') + "|" + lblButacas.Text.PadRight(11, ' ') + "|" + lblCostoEGeneral.Text.PadRight(18, ' ') + "|" +
               lblCostoENiños.Text.PadRight(18, ' ') + "|" + lblCostoEMayores60.Text.PadRight(17, ' ') + "|" + lblCostoETotal.Text.PadRight(10, ' ');
                Archivos.WriteLine(Linea);
                Archivos.Close();
                this.Close();
                
        
            }
           
        }




    }
}
