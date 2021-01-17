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
    public partial class Butacas : Form
    {
        public Butacas()
        {
            InitializeComponent();
        }

        int entradas = 0;
        private void chkA1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkA1.Checked == true)
            {
                chkA1.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkA1.Text);
            }
            else
            {
                chkA1.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkA1.Text);
            }

            lblEntrada.Text = entradas.ToString();
        }

        private void chkA2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA2.Checked == true)
            {
                chkA2.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkA2.Text);
            }
            else
            {
                chkA2.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkA2.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkA3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA3.Checked == true)
            {
                chkA3.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkA3.Text);
            }
            else
            {
                chkA3.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkA3.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkA4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkA4.Checked == true)
            {
                chkA4.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkA4.Text);
            }
            else
            {
                chkA4.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkA4.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkB1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB1.Checked == true)
            {
                chkB1.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkB1.Text);
            }
            else
            {
                chkB1.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkB1.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkB2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB2.Checked == true)
            {
                chkB2.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkB2.Text);
            }
            else
            {
                chkB2.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkB2.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkB3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB3.Checked == true)
            {
                chkB3.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkB3.Text);
            }
            else
            {
                chkB3.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkB3.Text);
            }
            lblEntrada.Text = entradas.ToString();           
        }

        private void chkB4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB4.Checked == true)
            {
                chkB4.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkB4.Text);
            }
            else
            {
                chkB4.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkB4.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkB5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB5.Checked == true)
            {
                chkB5.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkB5.Text);
            }
            else
            {
                chkB5.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkB5.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkB6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB6.Checked == true)
            {
                chkB6.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkB6.Text);
            }
            else
            {
                chkB6.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkB6.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkB7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB7.Checked == true)
            {
                chkB7.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkB7.Text);
            }
            else
            {
                chkB7.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkB7.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkB8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkB8.Checked == true)
            {
                chkB8.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkB8.Text);
            }
            else
            {
                chkB8.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkB8.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkC1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC1.Checked == true)
            {
                chkC1.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkC1.Text);
            }
            else
            {
                chkC1.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkC1.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkC2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC2.Checked == true)
            {
                chkC2.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkC2.Text);
            }
            else
            {
                chkC2.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkC2.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkC3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC3.Checked == true)
            {
                chkC3.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkC3.Text);
            }
            else
            {
                chkC3.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkC3.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkC4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC4.Checked == true)
            {
                chkC4.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkC4.Text);
            }
            else
            {
                chkC4.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkC4.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkC5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC5.Checked == true)
            {
                chkC5.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkC5.Text);
            }
            else
            {
                chkC5.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkC5.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkC6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC6.Checked == true)
            {
                chkC6.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkC6.Text);
            }
            else
            {
                chkC6.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkC6.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkC7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC7.Checked == true)
            {
                chkC7.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkC7.Text);
            }
            else
            {
                chkC7.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkC7.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkC8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC8.Checked == true)
            {
                chkC8.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkC8.Text);
            }
            else
            {
                chkC8.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkC8.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkC9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC9.Checked == true)
            {
                chkC9.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkC9.Text);
            }
            else
            {
                chkC9.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkC9.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkC10_CheckedChanged(object sender, EventArgs e)
        {
            if (chkC10.Checked == true)
            {
                chkC10.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkC10.Text);
            }
            else
            {
                chkC10.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkC10.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkD1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD1.Checked == true)
            {
                chkD1.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkD1.Text);
            }
            else
            {
                chkD1.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkD1.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkD2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD2.Checked == true)
            {
                chkD2.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkD2.Text);
            }
            else
            {
                chkD2.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkD2.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkD3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD3.Checked == true)
            {
                chkD3.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkD3.Text);
            }
            else
            {
                chkD3.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkD3.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkD4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD4.Checked == true)
            {
                chkD4.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkD4.Text);
            }
            else
            {
                chkD4.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkD4.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkD5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD5.Checked == true)
            {
                chkD5.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkD5.Text);
            }
            else
            {
                chkD5.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkD5.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkD6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD6.Checked == true)
            {
                chkD6.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkD6.Text);
            }
            else
            {
                chkD6.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkD6.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkD7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD7.Checked == true)
            {
                chkD7.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkD7.Text);
            }
            else
            {
                chkD7.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkD7.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkD8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD8.Checked == true)
            {
                chkD8.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkD8.Text);
            }
            else
            {
                chkD8.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkD8.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkD9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD9.Checked == true)
            {
                chkD9.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkD9.Text);
            }
            else
            {
                chkD9.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkD9.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkD10_CheckedChanged(object sender, EventArgs e)
        {
            if (chkD10.Checked == true)
            {
                chkD10.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkD10.Text);
            }
            else
            {
                chkD10.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkD10.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkE1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE1.Checked == true)
            {
                chkE1.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkE1.Text);
            }
            else
            {
                chkE1.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkE1.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkE2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE2.Checked == true)
            {
                chkE2.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkE2.Text);
            }
            else
            {
                chkE2.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkE2.Text);
            }
            lblEntrada.Text = entradas.ToString();

        }

        private void chkE3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE3.Checked == true)
            {
                chkE3.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkE3.Text);
            }
            else
            {
                chkE3.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkE3.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkE4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE4.Checked == true)
            {
                chkE4.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkE4.Text);
            }
            else
            {
                chkE4.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkE4.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkE5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE5.Checked == true)
            {
                chkE5.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkE5.Text);
            }
            else
            {
                chkE5.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkE5.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkE6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE6.Checked == true)
            {
                chkE6.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkE6.Text);
            }
            else
            {
                chkE6.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkE6.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkE7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE7.Checked == true)
            {
                chkE7.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkE7.Text);
            }
            else
            {
                chkE7.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkE7.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkE8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE8.Checked == true)
            {
                chkE8.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkE8.Text);
            }
            else
            {
                chkE8.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkE8.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkE9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE9.Checked == true)
            {
                chkE9.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkE9.Text);
            }
            else
            {
                chkE9.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkE9.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkE10_CheckedChanged(object sender, EventArgs e)
        {
            if (chkE10.Checked == true)
            {
                chkE10.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkE10.Text);
            }
            else
            {
                chkE10.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkE10.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkF1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkF1.Checked == true)
            {
                chkF1.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkF1.Text);
            }
            else
            {
                chkF1.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkF1.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkF2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkF2.Checked == true)
            {
                chkF2.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkF2.Text);
            }
            else
            {
                chkF2.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkF2.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkF3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkF3.Checked == true)
            {
                chkF3.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkF3.Text);
            }
            else
            {
                chkF3.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkF3.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkF4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkF4.Checked == true)
            {
                chkF4.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkF4.Text);
            }
            else
            {
                chkF4.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkF4.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkF5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkF5.Checked == true)
            {
                chkF5.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkF5.Text);
            }
            else
            {
                chkF5.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkF5.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkF6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkF6.Checked == true)
            {
                chkF6.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkF6.Text);
            }
            else
            {
                chkF6.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkF6.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkF7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkF7.Checked == true)
            {
                chkF7.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkF7.Text);
            }
            else
            {
                chkF7.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkF7.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkF8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkF8.Checked == true)
            {
                chkF8.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkF8.Text);
            }
            else
            {
                chkF8.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkF8.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkF9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkF9.Checked == true)
            {
                chkF9.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkF9.Text);
            }
            else
            {
                chkF9.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkF9.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkF10_CheckedChanged(object sender, EventArgs e)
        {
            if (chkF10.Checked == true)
            {
                chkF10.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkF10.Text);
            }
            else
            {
                chkF10.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkF10.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkG1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkG1.Checked == true)
            {
                chkG1.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkG1.Text);
            }
            else
            {
                chkG1.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkG1.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkG2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkG2.Checked == true)
            {
                chkG2.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkG2.Text);
            }
            else
            {
                chkG2.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkG2.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkG3_CheckedChanged(object sender, EventArgs e)
        {
            if (chkG3.Checked == true)
            {
                chkG3.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkG3.Text);
            }
            else
            {
                chkG3.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkG3.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkG4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkG4.Checked == true)
            {
                chkG4.BackColor = Color.Aqua;
                entradas++; lbAsientos.Items.Add(chkG4.Text);
            }
            else
            {
                chkG4.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkG4.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkG5_CheckedChanged(object sender, EventArgs e)
        {
            if (chkG5.Checked == true)
            {
                chkG5.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkG5.Text);
            }
            else
            {
                chkG5.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkG5.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkG6_CheckedChanged(object sender, EventArgs e)
        {
            if (chkG6.Checked == true)
            {
                chkG6.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkG6.Text);
            }
            else
            {
                chkG6.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkG6.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkG7_CheckedChanged(object sender, EventArgs e)
        {
            if (chkG7.Checked == true)
            {
                chkG7.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkG7.Text);
            }
            else
            {
                chkG7.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkG7.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkG8_CheckedChanged(object sender, EventArgs e)
        {
            if (chkG8.Checked == true)
            {
                chkG8.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkG8.Text);
            }
            else
            {
                chkG8.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkG8.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkG9_CheckedChanged(object sender, EventArgs e)
        {
            if (chkG9.Checked == true)
            {
                chkG9.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkG9.Text);
            }
            else
            {
                chkG9.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkG9.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void chkG10_CheckedChanged(object sender, EventArgs e)
        {
            if (chkG10.Checked == true)
            {
                chkG10.BackColor = Color.Aqua;
                entradas++;
                lbAsientos.Items.Add(chkG10.Text);
            }
            else
            {
                chkG10.BackColor = Color.Lime;
                entradas--;
                lbAsientos.Items.Remove(chkG10.Text);
            }
            lblEntrada.Text = entradas.ToString();
        }

        private void btnSiguienteAsientos_Click(object sender, EventArgs e)
        {

            if (int.Parse(lblEntrada.Text) == 0)
            {
                MessageBox.Show("No se ha seleccionado Butacas!", "ERROR");
            }
            else
            {
                frmEntradas entradas = new frmEntradas();
                entradas.lblEntrada2.Text = lblEntrada.Text;
                entradas.imgDetalles.Image = imgButacas.Image;
                entradas.lblNombrePelicula.Text = lblNombrePelicula.Text;
                entradas.Show();
                this.Close();

            }
            
        }

        private void btnRegresarButacas_Click(object sender, EventArgs e)
        {
            Portada portada = new Portada();
            portada.Show();
            this.Dispose();
        }

        private void Butacas_Load(object sender, EventArgs e)
        {

        }
    }
}
