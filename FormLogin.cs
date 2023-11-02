using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteleSys
{
    public partial class FormLogin : Form
    {
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowPass_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.UseSystemPasswordChar==true)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //try
            //{
                //comando.Connection = conexion;

                //String txtusuario = textBoxUser.Text;
                //String txtpass = textBoxPassword.Text;
                //comando.CommandText = "select * from Tecnico where tecnicoID = " + txtusuario + "and tecnico = " + txtpass;
                
                //conexion.Open();
                //leer = comando.ExecuteReader();
                //leer.Read();
                //String User1 = leer.GetString(0);
                //String Pass1 = leer.GetString(1);
                //if (txtusuario == User1 && txtpass == Pass1)
                //{
                    FormHome v1 = new FormHome();
                    v1.Show();
                    this.Hide();
                //}
                //else
                //    MessageBox.Show("Error", "Usuario o Contraseña incorrecto.");
                //conexion.Close();
                //comando.Dispose();

            //}
            //catch (SqlException ex)s
            //{
            //    MessageBox.Show("Error" +ex);
            //}
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            conexion.ConnectionString = @"Data Source=DESKTOP-00COILF;Initial Catalog=Proyecto;Integrated Security=True";
        }



    }
}
