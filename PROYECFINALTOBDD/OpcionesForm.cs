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
    public partial class OpcionesForm : Form
    {
        public OpcionesForm(string cedula)
        {
            this.cedula = cedula;
            InitializeComponent();
        }

        public string cedula;
        private void OpcionesForm_Load(object sender, EventArgs e)
        {
            LblNombre.Text = cedula;
        }

        private void OpcionesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form102A(cedula).Show();
;        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form106(cedula).Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }
    }
}
