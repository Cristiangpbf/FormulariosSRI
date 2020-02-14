using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECFINALTOBDD.models;

namespace PryFinalBDDII
{
    public partial class Form106 : Form
    {
        REGISTRO_106 nRegistro = null;
        public Form106(string cedula)
        {
            this.cedula = cedula;
            InitializeComponent();
        }

        public string cedula;

        private void cargaDatos(string ced)
        {
            using (ProyectoBDDEntities db = new ProyectoBDDEntities())
            {
                //Devuelve un booleano para saber si existe o no un registro asociado a la cedula proporcionada
                //var resultado = db.REGISTRO_102A.Select(d => d.CED102A == ced).ToList();


                //var id = db.REGISTRO_102A.SqlQuery(sqlquery, cedula);

                var sel = db.REGISTRO_106.Where(p => p.CED106 == ced).Select(p => p.ID_106).ToList();


                int id = 0;
                foreach (var x in sel)
                {
                    id = x;
                }

                nRegistro = db.REGISTRO_106.Find(id);
                txt101.Text = nRegistro.B101;
                txt102.Text = nRegistro.B102;
                txt201.Text = nRegistro.B201;
                txt202.Text = nRegistro.B202;
                txt203.Text = nRegistro.B203;
                txt204.Text = nRegistro.B204;
                txt205.Text = nRegistro.B205;
                txt301.Text = nRegistro.B301;
                txt302.Text = nRegistro.B302;
                txt303.Text = nRegistro.B303;
                txt304.Text = nRegistro.B304;
                txt305.Text = nRegistro.B305;
                txt306.Text = nRegistro.B306;
                txt902.Text = nRegistro.B902.ToString();
                txt903.Text = nRegistro.B903.ToString();
                txt904.Text = nRegistro.B904.ToString();
                txt999.Text = nRegistro.B999.ToString();
                txt905.Text = nRegistro.B905.ToString();
                txt906.Text = nRegistro.B906.ToString();
                txt907.Text = nRegistro.B907.ToString();
                txt925.Text = nRegistro.B925.ToString();
                txt908.Text = nRegistro.B908;
                txt909.Text = nRegistro.B909.ToString();
                txt910.Text = nRegistro.B910;
                txt911.Text = nRegistro.B911.ToString();
                txt912.Text = nRegistro.B912;
                txt913.Text = nRegistro.B913.ToString();
                txt914.Text = nRegistro.B914;
                txt915.Text = nRegistro.B915.ToString();
                txt916.Text = nRegistro.B916;
                txt917.Text = nRegistro.B917.ToString();
                txt918.Text = nRegistro.B918;
                txt919.Text = nRegistro.B919.ToString();
                txt920.Text = nRegistro.B920.ToString();
            }
        }
        public Boolean verificar(string ced)
        {
            bool res = false;
            using (ProyectoBDDEntities db = new ProyectoBDDEntities())
            {
                var resultado = db.REGISTRO_106.Select(d => d.CED106 == cedula).ToList();
                foreach (var x in resultado)
                {
                    res = x;
                }
            }
            return res;
        }

        private void Form106_Load(object sender, EventArgs e)
        {
            using (ProyectoBDDEntities db = new ProyectoBDDEntities())
            {
                //Devuelve un booleano para saber si existe o no un registro asociado a la cedula proporcionada
                var resultado = db.REGISTRO_106.Select(d => d.CED106 == cedula).ToList();
                bool res = false;
                foreach (var x in resultado)
                {
                    res = x;
                }
                if (res)
                {
                    cargaDatos(cedula);
                }
            }
        }

        private void Form106_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (ProyectoBDDEntities db = new ProyectoBDDEntities())
            {                
                txt102.Focus();
                txt201.Focus();
                txt202.Focus();
                txt203.Focus();
                txt204.Focus();
                txt205.Focus();
                txt301.Focus();
                txt302.Focus();
                txt303.Focus();
                txt304.Focus();
                txt305.Focus();
                txt306.Focus();
                txt902.Focus();
                txt903.Focus();
                txt904.Focus();
                txt999.Focus();
                txt905.Focus();
                txt906.Focus();
                txt907.Focus();
                txt925.Focus();
                txt908.Focus();
                txt909.Focus();
                txt910.Focus();
                txt911.Focus();
                txt912.Focus();
                txt913.Focus();
                txt914.Focus();
                txt915.Focus();
                txt916.Focus();
                txt917.Focus();
                txt918.Focus();
                txt919.Focus();
                txt920.Focus();
                txt101.Focus();
                if (verificar(cedula))
                {
                    var sel = db.REGISTRO_106.Where(p => p.CED106 == cedula).Select(p => p.ID_106).ToList();
                    int id = 0;
                    foreach (var x in sel)
                    {
                        id = x;
                    }

                    nRegistro = db.REGISTRO_106.Find(id);
                    nRegistro.B101 = txt101.Text;
                    nRegistro.B102 = txt102.Text;
                    nRegistro.B201 = txt201.Text;
                    nRegistro.B202 = txt202.Text;
                    nRegistro.B203 = txt203.Text;
                    nRegistro.B204 = txt204.Text;
                    nRegistro.B205 = txt205.Text;
                    nRegistro.B301 = txt301.Text;
                    nRegistro.B302 = txt302.Text;
                    nRegistro.B303 = txt303.Text;
                    nRegistro.B304 = txt304.Text;
                    nRegistro.B305 = txt305.Text;
                    nRegistro.B306 = txt306.Text;
                    nRegistro.B908 = txt908.Text;
                    nRegistro.B910 = txt910.Text;
                    nRegistro.B912 = txt912.Text;
                    nRegistro.B914 = txt914.Text;
                    nRegistro.B916 = txt916.Text;
                    nRegistro.B918 = txt918.Text;

                    nRegistro.B902 = decimal.Parse(txt902.Text);
                    nRegistro.B903 = decimal.Parse(txt903.Text);
                    nRegistro.B904 = decimal.Parse(txt904.Text);
                    nRegistro.B999 = decimal.Parse(txt999.Text);
                    nRegistro.B905 = decimal.Parse(txt905.Text);
                    nRegistro.B906 = decimal.Parse(txt906.Text);
                    nRegistro.B907 = decimal.Parse(txt907.Text);
                    nRegistro.B925 = decimal.Parse(txt925.Text);
                    nRegistro.B909 = decimal.Parse(txt909.Text);
                    nRegistro.B911 = decimal.Parse(txt911.Text);
                    nRegistro.B913 = decimal.Parse(txt913.Text);
                    nRegistro.B915 = decimal.Parse(txt915.Text);
                    nRegistro.B917 = decimal.Parse(txt917.Text);
                    nRegistro.B919 = decimal.Parse(txt919.Text);
                    nRegistro.B920 = decimal.Parse(txt920.Text);

                    db.Entry(nRegistro).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();

                    MessageBox.Show("Registro actualizado");
                }
                else
                {
                    nRegistro = new REGISTRO_106();

                    //Asignar cedula para identificacion en registro para futura edicion
                    
                    nRegistro.B101 = txt101.Text;
                    nRegistro.B102 = txt102.Text;
                    nRegistro.B201 = txt201.Text;
                    nRegistro.B202 = txt202.Text;
                    nRegistro.B203 = txt203.Text;
                    nRegistro.B204 = txt204.Text;
                    nRegistro.B205 = txt205.Text;
                    nRegistro.B301 = txt301.Text;
                    nRegistro.B302 = txt302.Text;
                    nRegistro.B303 = txt303.Text;
                    nRegistro.B304 = txt304.Text;
                    nRegistro.B305 = txt305.Text;
                    nRegistro.B306 = txt306.Text;
                    nRegistro.B908 = txt908.Text;
                    nRegistro.B910 = txt910.Text;
                    nRegistro.B912 = txt912.Text;
                    nRegistro.B914 = txt914.Text;
                    nRegistro.B916 = txt916.Text;
                    nRegistro.B918 = txt918.Text;

                    nRegistro.B902 = decimal.Parse(txt902.Text);
                    nRegistro.B903 = decimal.Parse(txt903.Text);
                    nRegistro.B904 = decimal.Parse(txt904.Text);
                    nRegistro.B999 = decimal.Parse(txt999.Text);
                    nRegistro.B905 = decimal.Parse(txt905.Text);
                    nRegistro.B906 = decimal.Parse(txt906.Text);
                    nRegistro.B907 = decimal.Parse(txt907.Text);
                    nRegistro.B925 = decimal.Parse(txt925.Text);
                    nRegistro.B909 = decimal.Parse(txt909.Text);
                    nRegistro.B911 = decimal.Parse(txt911.Text);
                    nRegistro.B913 = decimal.Parse(txt913.Text);
                    nRegistro.B915 = decimal.Parse(txt915.Text);
                    nRegistro.B917 = decimal.Parse(txt917.Text);
                    nRegistro.B919 = decimal.Parse(txt919.Text);
                    nRegistro.B920 = decimal.Parse(txt920.Text);
                    nRegistro.CED106 = cedula;

                    db.REGISTRO_106.Add(nRegistro);

                    db.SaveChanges();

                    MessageBox.Show("Registro creado");

                }
            }
        }
        private void form106_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OpcionesForm(cedula).Show();
        }

        private void txt201_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo acepta números sin espacios");
            }
        }

        private void txt902_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)
                || e.KeyChar == ',' /*|| e.KeyChar == '.'*/)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo acepta números y comas");
            }
        }
    }
}
