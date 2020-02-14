using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryFinalBDDII
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            InitializeMyControl();
        }

        private void InitializeMyControl()
        {
            textBoxPass.Text = "";
            textBoxPass.PasswordChar = '*';
            textBoxPass.MaxLength = 20;
        }

        //Conexion con la base de datos mediante Npgsql

        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0}; " +
            "User Id={1};Password={2};Database={3};Port={4};",
            "localhost", "postgres", "cqsis1998", "LoginPry","5432");
        //private DataTable dt;
        private NpgsqlCommand cmd;
        private string sql = null;


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //new OpcionesForm(textBoxCedRuc.Text).Show();

            try
            {
                conn.Open();
                sql = @"select * from u_login(:_cedula, :_pass)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_cedula",textBoxCedRuc.Text);
                cmd.Parameters.AddWithValue("_pass", textBoxPass.Text);

                int result = (int)cmd.ExecuteScalar();

                conn.Close();

                if (result == 1)// Login exitoso
                {
                    this.Hide();
                    new OpcionesForm(textBoxCedRuc.Text).Show();
                }
                else
                {
                    MessageBox.Show("Revise su cedula/ruc y su contraseña","Ingreso falló", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    return;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Algo salió mal ",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        //Validación del campo para cedula o ruc
        //Si se ingresa un caractér o un espacio salta una alerta
        private void textBoxCedRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if(!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo acepta números sin espacios");
            }
        }
    }
}
