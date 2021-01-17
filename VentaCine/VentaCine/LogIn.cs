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
    public partial class LogIn : Form
    {
        int time=1;
        public LogIn()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");              
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            int muestra;
            

            if (txtUsuario.Text == "empleado" && txtContraseña.Text == "123" && cboNivel.SelectedItem.ToString()=="Empleado")
            {
                
                frmCargando cargando = new frmCargando();

                cargando.Show();
                this.Hide();
            }
            else if (txtUsuario.Text == "administrador" && txtContraseña.Text == "123" && cboNivel.SelectedItem.ToString() == "Administrador")
            {
                Root root= new Root();
                root.Show();
            }
            else
            {

                muestra = 3 - time;
                time = time + 1;

                if (muestra == 0)
                {
                    MessageBox.Show("Se te acabaron las Oportunidades", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                if (txtUsuario.Text != "empleado" && txtContraseña.Text != "123")
                {
                    MessageBox.Show("Te quedan " + muestra + " Oportunidades", "USUARIO O CONTRASEÑA INCORRECTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    txtContraseña.Clear();
                    textvisiblecontra.Clear();
                }
                    else
                    {
                        MessageBox.Show("Te quedan " + muestra + " Oportunidades", "CONTRASEÑA INCORRECTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textvisiblecontra.Clear();
                        txtContraseña.Clear();
                        txtUsuario.Clear();
                        txtUsuario.Focus();

                        btncontranovisible.Visible = true;
                        btncontravisible.Visible = false;

                        txtContraseña.Visible = true;
                        textvisiblecontra.Visible = false;
                        
                    }
            }
            
        }
        private void btncontranovisible_Click_1(object sender, EventArgs e)
        {
            
            btncontranovisible.Visible = false;
            btncontravisible.Visible = true;

            txtContraseña.Visible = false;
            textvisiblecontra.Visible = true;

            textvisiblecontra.Text = txtContraseña.Text;
  

            textvisiblecontra.Focus();
        }

        private void btncontravisible_Click_1(object sender, EventArgs e)
        {
            
            btncontravisible.Visible = false;
            btncontranovisible.Visible = true;

            textvisiblecontra.Visible = false;
            txtContraseña.Visible = true;
            
            
            txtContraseña.Focus();
            
    
            txtContraseña.Text = textvisiblecontra.Text;


            
        }

        private void textvisiblecontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }


        private void textvisiblecontra_Enter(object sender, EventArgs e)
        {
            if (textvisiblecontra.Text == "CONTRASEÑA VISIBLE")
            {
                textvisiblecontra.Text = "";
                textvisiblecontra.ForeColor = Color.LightGray;
            
            }
       
        }

   
        private void textvisiblecontra_Leave(object sender, EventArgs e)
        {
            if (textvisiblecontra.Text == "")
            {
                textvisiblecontra.Text = "CONTRASEÑA VISIBLE";
                textvisiblecontra.ForeColor = Color.LightGray;
            
            }
        }

        private void contraseñadar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {



            if (MessageBox.Show("USUARIO : empleado  CONTRASEÑA : 123" + "\n ¿DESEA RELLENAR USUARIO Y CONTRASEÑA?", "AVISO DEL SISTEMA ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                txtContraseña.ForeColor = Color.LightGray;
                txtUsuario.ForeColor = Color.LightGray;
                txtContraseña.Text = "123";
                txtUsuario.Text = "empleado";
                cboNivel.SelectedIndex=0;
               
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            /*gifentrada.Image = Image.FromFile(@"E:\WILMER\binarios.gif");
            gifentrada.SizeMode = PictureBoxSizeMode.StretchImage;*/
        }

        private void gifentrada_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
