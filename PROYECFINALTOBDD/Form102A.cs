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
using System.Data.SqlClient;

namespace PryFinalBDDII
{
    public partial class Form102A : Form
    {
        REGISTRO_102A nRegistro = null;
        public Form102A(string cedula)
        {
            this.cedula = cedula;
            InitializeComponent();
        }

        public string cedula;
        public string sqlquery = "select ID_102A from registro_102A where CED102A = '@var'";
        private void cargaDatos(string ced)
        {
            using (ProyectoBDDEntities db = new ProyectoBDDEntities())
            {
                //Devuelve un booleano para saber si existe o no un registro asociado a la cedula proporcionada
                //var resultado = db.REGISTRO_102A.Select(d => d.CED102A == ced).ToList();

                
                //var id = db.REGISTRO_102A.SqlQuery(sqlquery, cedula);

                var sel = db.REGISTRO_102A.Where(p => p.CED102A == ced).Select(p => p.ID_102A).ToList();

                
                int id = 0;
                foreach(var x in sel)
                {
                    id = x;
                }

                nRegistro = db.REGISTRO_102A.Find(id);
                txt102.Text = nRegistro.A102;
                txt104.Text = nRegistro.A104;
                txt105.Text = nRegistro.A105.ToString();
                txt201.Text = nRegistro.A201;
                txt202.Text = nRegistro.A202;
                txt481.Text = nRegistro.A481.ToString();
                txt491.Text = nRegistro.A491.ToString();
                txt703.Text = nRegistro.A703.ToString();
                txt704.Text = nRegistro.A704.ToString();
                txt705.Text = nRegistro.A705.ToString();
                txt710.Text = nRegistro.A710.ToString();
                txt711.Text = nRegistro.A711.ToString();
                txt712.Text = nRegistro.A712.ToString();
                txt713.Text = nRegistro.A713.ToString();
                txt714.Text = nRegistro.A714.ToString();
                txt715.Text = nRegistro.A715.ToString();
                txt716.Text = nRegistro.A716.ToString();
                txt717.Text = nRegistro.A717.ToString();
                txt718.Text = nRegistro.A718.ToString();
                txt719.Text = nRegistro.A719.ToString();
                txt720.Text = nRegistro.A720.ToString();
                txt730.Text = nRegistro.A730.ToString();
                txt729.Text = nRegistro.A729.ToString();
                txt721.Text = nRegistro.A721.ToString();
                txt722.Text = nRegistro.A722.ToString();
                txt723.Text = nRegistro.A723.ToString();
                txt724.Text = nRegistro.A724.ToString();
                txt725.Text = nRegistro.A725.ToString();
                txt731.Text = nRegistro.A731.ToString();
                txt739.Text = nRegistro.A739.ToString();
                txt749.Text = nRegistro.A749.ToString();
                txt741.Text = nRegistro.A741.ToString();
                txt751.Text = nRegistro.A751.ToString();
                txt759.Text = nRegistro.A759.ToString();
                txt769.Text = nRegistro.A769.ToString();
                txt768.Text = nRegistro.A768.ToString();
                txt771.Text = nRegistro.A771.ToString();
                txt772.Text = nRegistro.A772.ToString();
                txt773.Text = nRegistro.A773.ToString();
                txt774.Text = nRegistro.A774.ToString();
                txt775.Text = nRegistro.A775.ToString();
                txt776.Text = nRegistro.A776.ToString();
                txt780.Text = nRegistro.A780.ToString();
                txt740.Text = nRegistro.A740;
                txt750.Text = nRegistro.A750;
                txt760.Text = nRegistro.A760.ToString();
                txt770.Text = nRegistro.A770.ToString();
                txt777.Text = nRegistro.A777.ToString();
                txt778.Text = nRegistro.A778.ToString();
                txt779.Text = nRegistro.A779.ToString();
                txt781.Text = nRegistro.A781.ToString();
                txt782.Text = nRegistro.A782.ToString();
                txt783.Text = nRegistro.A783.ToString();
                txt784.Text = nRegistro.A784.ToString();
                txt786.Text = nRegistro.A786.ToString();
                txt787.Text = nRegistro.A787.ToString();
                txt789.Text = nRegistro.A789.ToString();
                txt832.Text = nRegistro.A832.ToString();
                txt839.Text = nRegistro.A839.ToString();
                txt840.Text = nRegistro.A840.ToString();
                txt842.Text = nRegistro.A842.ToString();
                txt843.Text = nRegistro.A843.ToString();
                txt845.Text = nRegistro.A845.ToString();
                txt846.Text = nRegistro.A846.ToString();
                txt847.Text = nRegistro.A847.ToString();
                txt848.Text = nRegistro.A848.ToString();
                txt849.Text = nRegistro.A849.ToString();
                txt850.Text = nRegistro.A850.ToString();
                txt851.Text = nRegistro.A851.ToString();
                txt852.Text = nRegistro.A852.ToString();
                txt855.Text = nRegistro.A855.ToString();
                txt856.Text = nRegistro.A856.ToString();
                txt857.Text = nRegistro.A857.ToString();
                txt858.Text = nRegistro.A858.ToString();
                txt859.Text = nRegistro.A859.ToString();
                txt869.Text = nRegistro.A869.ToString();
                txt880.Text = nRegistro.A880.ToString();
                txt881.Text = nRegistro.A881.ToString();
                txt882.Text = nRegistro.A882.ToString();
                txt879.Text = nRegistro.A879.ToString();
                txt871.Text = nRegistro.A871.ToString();
                txt872.Text = nRegistro.A872.ToString();
                txt890.Text = nRegistro.A890.ToString();
                txt897.Text = nRegistro.A897.ToString();
                txt898.Text = nRegistro.A898.ToString();
                txt899.Text = nRegistro.A899.ToString();
                txt902.Text = nRegistro.A902.ToString();
                txt903.Text = nRegistro.A903.ToString();
                txt904.Text = nRegistro.A904.ToString();
                txt999.Text = nRegistro.A999.ToString();
                txt905.Text = nRegistro.A905.ToString();
                txt906.Text = nRegistro.A906.ToString();
                txt907.Text = nRegistro.A907.ToString();
                txt908.Text = nRegistro.A908;
                txt909.Text = nRegistro.A909.ToString();
                txt910.Text = nRegistro.A910;
                txt911.Text = nRegistro.A911.ToString();
                txt912.Text = nRegistro.A912;
                txt913.Text = nRegistro.A913.ToString();
                txt915.Text = nRegistro.A915.ToString();
                txt916.Text = nRegistro.A916;
                txt917.Text = nRegistro.A917.ToString();
                txt918.Text = nRegistro.A918;
                txt919.Text = nRegistro.A919.ToString();
                txt920.Text = nRegistro.A920;
                txt198.Text = nRegistro.A198;
                txtnombre.Text = nRegistro.NOMB102A;
            }
        }

        private void Form102A_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void label96_Click(object sender, EventArgs e)
        {

        }

        private void label121_Click(object sender, EventArgs e)
        {

        }

        private void label289_Click(object sender, EventArgs e)
        {

        }
        public Boolean verificar(string ced)
        {
            bool res = false;
            using (ProyectoBDDEntities db = new ProyectoBDDEntities())
            {
                var resultado = db.REGISTRO_102A.Select(d => d.CED102A == cedula).ToList();                
                foreach (var x in resultado)
                {
                    res = x;
                }
            }
            return res;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (ProyectoBDDEntities db = new ProyectoBDDEntities())
            {
                txt102.Focus();
                txt104.Focus();
                txt201.Focus();
                txt202.Focus();
                txt740.Focus();
                txt750.Focus();
                txt908.Focus();
                txt910.Focus();
                txt912.Focus();
                txt916.Focus();
                txt918.Focus();
                txt920.Focus();
                txt198.Focus();
                txtnombre.Focus();
                txt105.Focus();
                txt481.Focus();
                txt491.Focus();
                txt703.Focus();
                txt704.Focus();
                txt705.Focus();
                txt710.Focus();
                txt711.Focus();
                txt712.Focus();
                txt713.Focus();
                txt714.Focus();
                txt715.Focus();
                txt716.Focus();
                txt717.Focus();
                txt718.Focus();
                txt719.Focus();
                txt720.Focus();
                txt730.Focus();
                txt729.Focus();
                txt721.Focus();
                txt722.Focus();
                txt723.Focus();
                txt724.Focus();
                txt725.Focus();
                txt731.Focus();
                txt739.Focus();
                txt749.Focus();
                txt741.Focus();
                txt751.Focus();
                txt759.Focus();
                txt769.Focus();
                txt768.Focus();
                txt771.Focus();
                txt772.Focus();
                txt773.Focus();
                txt774.Focus();
                txt775.Focus();
                txt776.Focus();
                txt780.Focus();
                txt760.Focus();
                txt770.Focus();
                txt777.Focus();
                txt778.Focus();
                txt779.Focus();
                txt781.Focus();
                txt782.Focus();
                txt783.Focus();
                txt784.Focus();
                txt786.Focus();
                txt787.Focus();
                txt789.Focus();
                txt832.Focus();
                txt839.Focus();
                txt840.Focus();
                txt842.Focus();
                txt843.Focus();
                txt845.Focus();
                txt846.Focus();
                txt847.Focus();
                txt848.Focus();
                txt849.Focus();
                txt850.Focus();
                txt851.Focus();
                txt852.Focus();
                txt855.Focus();
                txt856.Focus();
                txt857.Focus();
                txt858.Focus();
                txt859.Focus();
                txt869.Focus();
                txt880.Focus();
                txt881.Focus();
                txt882.Focus();
                txt879.Focus();
                txt871.Focus();
                txt872.Focus();
                txt890.Focus();
                txt897.Focus();
                txt898.Focus();
                txt899.Focus();
                txt902.Focus();
                txt903.Focus();
                txt904.Focus();
                txt999.Focus();
                txt905.Focus();
                txt906.Focus();
                txt907.Focus();
                txt909.Focus();
                txt911.Focus();
                txt913.Focus();
                txt915.Focus();
                txt917.Focus();
                txt919.Focus();
                txt102.Focus();
                if (verificar(cedula))
                {
                    var sel = db.REGISTRO_102A.Where(p => p.CED102A == cedula).Select(p => p.ID_102A).ToList();

                    int id = 0;
                    foreach (var x in sel)
                    {
                        id = x;
                    }
                    nRegistro = db.REGISTRO_102A.Find(id);
                    nRegistro.A102 = txt102.Text;
                    nRegistro.A104 = txt104.Text;
                    nRegistro.A201 = txt201.Text;
                    nRegistro.A202 = txt202.Text;
                    nRegistro.A740 = txt740.Text;
                    nRegistro.A750 = txt750.Text;
                    nRegistro.A908 = txt908.Text;
                    nRegistro.A910 = txt910.Text;
                    nRegistro.A912 = txt912.Text;
                    nRegistro.A916 = txt916.Text;
                    nRegistro.A918 = txt918.Text;
                    nRegistro.A920 = txt920.Text;
                    nRegistro.A198 = txt198.Text;
                    nRegistro.NOMB102A = txtnombre.Text;

                    nRegistro.A105 = int.Parse(txt105.Text);

                    nRegistro.A481 = decimal.Parse(txt481.Text);
                    nRegistro.A491 = decimal.Parse(txt491.Text);
                    nRegistro.A703 = decimal.Parse(txt703.Text);
                    nRegistro.A704 = decimal.Parse(txt704.Text);
                    nRegistro.A705 = decimal.Parse(txt705.Text);
                    nRegistro.A710 = decimal.Parse(txt710.Text);
                    nRegistro.A711 = decimal.Parse(txt711.Text);
                    nRegistro.A712 = decimal.Parse(txt712.Text);
                    nRegistro.A713 = decimal.Parse(txt713.Text);
                    nRegistro.A714 = decimal.Parse(txt714.Text);
                    nRegistro.A715 = decimal.Parse(txt715.Text);
                    nRegistro.A716 = decimal.Parse(txt716.Text);
                    nRegistro.A717 = decimal.Parse(txt717.Text);
                    nRegistro.A718 = decimal.Parse(txt718.Text);
                    nRegistro.A719 = decimal.Parse(txt719.Text);
                    nRegistro.A720 = decimal.Parse(txt720.Text);
                    nRegistro.A730 = decimal.Parse(txt730.Text);
                    nRegistro.A729 = decimal.Parse(txt729.Text);
                    nRegistro.A721 = decimal.Parse(txt721.Text);
                    nRegistro.A722 = decimal.Parse(txt722.Text);
                    nRegistro.A723 = decimal.Parse(txt723.Text);
                    nRegistro.A724 = decimal.Parse(txt724.Text);
                    nRegistro.A725 = decimal.Parse(txt725.Text);
                    nRegistro.A731 = decimal.Parse(txt731.Text);
                    nRegistro.A739 = decimal.Parse(txt739.Text);
                    nRegistro.A749 = decimal.Parse(txt749.Text);
                    nRegistro.A741 = decimal.Parse(txt741.Text);
                    nRegistro.A751 = decimal.Parse(txt751.Text);
                    nRegistro.A759 = decimal.Parse(txt759.Text);
                    nRegistro.A769 = decimal.Parse(txt769.Text);
                    nRegistro.A768 = decimal.Parse(txt768.Text);
                    nRegistro.A771 = decimal.Parse(txt771.Text);
                    nRegistro.A772 = decimal.Parse(txt772.Text);
                    nRegistro.A773 = decimal.Parse(txt773.Text);
                    nRegistro.A774 = decimal.Parse(txt774.Text);
                    nRegistro.A775 = decimal.Parse(txt775.Text);
                    nRegistro.A776 = decimal.Parse(txt776.Text);
                    nRegistro.A780 = decimal.Parse(txt780.Text);
                    nRegistro.A760 = decimal.Parse(txt760.Text);
                    nRegistro.A770 = decimal.Parse(txt770.Text);
                    nRegistro.A777 = decimal.Parse(txt777.Text);
                    nRegistro.A778 = decimal.Parse(txt778.Text);
                    nRegistro.A779 = decimal.Parse(txt779.Text);
                    nRegistro.A781 = decimal.Parse(txt781.Text);
                    nRegistro.A782 = decimal.Parse(txt782.Text);
                    nRegistro.A783 = decimal.Parse(txt783.Text);
                    nRegistro.A784 = decimal.Parse(txt784.Text);
                    nRegistro.A786 = decimal.Parse(txt786.Text);
                    nRegistro.A787 = decimal.Parse(txt787.Text);
                    nRegistro.A789 = decimal.Parse(txt789.Text);
                    nRegistro.A832 = decimal.Parse(txt832.Text);
                    nRegistro.A839 = decimal.Parse(txt839.Text);
                    nRegistro.A840 = decimal.Parse(txt840.Text);
                    nRegistro.A842 = decimal.Parse(txt842.Text);
                    nRegistro.A843 = decimal.Parse(txt843.Text);
                    nRegistro.A845 = decimal.Parse(txt845.Text);
                    nRegistro.A846 = decimal.Parse(txt846.Text);
                    nRegistro.A847 = decimal.Parse(txt847.Text);
                    nRegistro.A848 = decimal.Parse(txt848.Text);
                    nRegistro.A849 = decimal.Parse(txt849.Text);
                    nRegistro.A850 = decimal.Parse(txt850.Text);
                    nRegistro.A851 = decimal.Parse(txt851.Text);
                    nRegistro.A852 = decimal.Parse(txt852.Text);
                    nRegistro.A855 = decimal.Parse(txt855.Text);
                    nRegistro.A856 = decimal.Parse(txt856.Text);
                    nRegistro.A857 = decimal.Parse(txt857.Text);
                    nRegistro.A858 = decimal.Parse(txt858.Text);
                    nRegistro.A859 = decimal.Parse(txt859.Text);
                    nRegistro.A869 = decimal.Parse(txt869.Text);
                    nRegistro.A880 = decimal.Parse(txt880.Text);
                    nRegistro.A881 = decimal.Parse(txt881.Text);
                    nRegistro.A882 = decimal.Parse(txt882.Text);
                    nRegistro.A879 = decimal.Parse(txt879.Text);
                    nRegistro.A871 = decimal.Parse(txt871.Text);
                    nRegistro.A872 = decimal.Parse(txt872.Text);
                    nRegistro.A890 = decimal.Parse(txt890.Text);
                    nRegistro.A897 = decimal.Parse(txt897.Text);
                    nRegistro.A898 = decimal.Parse(txt898.Text);
                    nRegistro.A899 = decimal.Parse(txt899.Text);
                    nRegistro.A902 = decimal.Parse(txt902.Text);
                    nRegistro.A903 = decimal.Parse(txt903.Text);
                    nRegistro.A904 = decimal.Parse(txt904.Text);
                    nRegistro.A999 = decimal.Parse(txt999.Text);
                    nRegistro.A905 = decimal.Parse(txt905.Text);
                    nRegistro.A906 = decimal.Parse(txt906.Text);
                    nRegistro.A907 = decimal.Parse(txt907.Text);
                    nRegistro.A909 = decimal.Parse(txt909.Text);
                    nRegistro.A911 = decimal.Parse(txt911.Text);
                    nRegistro.A913 = decimal.Parse(txt913.Text);
                    nRegistro.A915 = decimal.Parse(txt915.Text);
                    nRegistro.A917 = decimal.Parse(txt917.Text);
                    nRegistro.A919 = decimal.Parse(txt919.Text);

                    db.Entry(nRegistro).State = System.Data.Entity.EntityState.Modified;

                    db.SaveChanges();
                    MessageBox.Show("Registro actualizado");
                }
                else
                {
                    nRegistro = new REGISTRO_102A();

                    //Asignar cedula para identificacion en registro para futura edicion

                    nRegistro.CED102A = cedula;
                    nRegistro.A102 = txt102.Text;
                    nRegistro.A104 = txt104.Text;
                    nRegistro.A201 = txt201.Text;
                    nRegistro.A202 = txt202.Text;
                    nRegistro.A740 = txt740.Text;
                    nRegistro.A750 = txt750.Text;
                    nRegistro.A908 = txt908.Text;
                    nRegistro.A910 = txt910.Text;
                    nRegistro.A912 = txt912.Text;
                    nRegistro.A916 = txt916.Text;
                    nRegistro.A918 = txt918.Text;
                    nRegistro.A920 = txt920.Text;
                    nRegistro.A198 = txt198.Text;
                    nRegistro.NOMB102A = txtnombre.Text;

                    nRegistro.A105 = int.Parse(txt105.Text);

                    nRegistro.A481 = decimal.Parse(txt481.Text);
                    nRegistro.A491 = decimal.Parse(txt491.Text);
                    nRegistro.A703 = decimal.Parse(txt703.Text);
                    nRegistro.A704 = decimal.Parse(txt704.Text);
                    nRegistro.A705 = decimal.Parse(txt705.Text);
                    nRegistro.A710 = decimal.Parse(txt710.Text);
                    nRegistro.A711 = decimal.Parse(txt711.Text);
                    nRegistro.A712 = decimal.Parse(txt712.Text);
                    nRegistro.A713 = decimal.Parse(txt713.Text);
                    nRegistro.A714 = decimal.Parse(txt714.Text);
                    nRegistro.A715 = decimal.Parse(txt715.Text);
                    nRegistro.A716 = decimal.Parse(txt716.Text);
                    nRegistro.A717 = decimal.Parse(txt717.Text);
                    nRegistro.A718 = decimal.Parse(txt718.Text);
                    nRegistro.A719 = decimal.Parse(txt719.Text);
                    nRegistro.A720 = decimal.Parse(txt720.Text);
                    nRegistro.A730 = decimal.Parse(txt730.Text);
                    nRegistro.A729 = decimal.Parse(txt729.Text);
                    nRegistro.A721 = decimal.Parse(txt721.Text);
                    nRegistro.A722 = decimal.Parse(txt722.Text);
                    nRegistro.A723 = decimal.Parse(txt723.Text);
                    nRegistro.A724 = decimal.Parse(txt724.Text);
                    nRegistro.A725 = decimal.Parse(txt725.Text);
                    nRegistro.A731 = decimal.Parse(txt731.Text);
                    nRegistro.A739 = decimal.Parse(txt739.Text);
                    nRegistro.A749 = decimal.Parse(txt749.Text);
                    nRegistro.A741 = decimal.Parse(txt741.Text);
                    nRegistro.A751 = decimal.Parse(txt751.Text);
                    nRegistro.A759 = decimal.Parse(txt759.Text);
                    nRegistro.A769 = decimal.Parse(txt769.Text);
                    nRegistro.A768 = decimal.Parse(txt768.Text);
                    nRegistro.A771 = decimal.Parse(txt771.Text);
                    nRegistro.A772 = decimal.Parse(txt772.Text);
                    nRegistro.A773 = decimal.Parse(txt773.Text);
                    nRegistro.A774 = decimal.Parse(txt774.Text);
                    nRegistro.A775 = decimal.Parse(txt775.Text);
                    nRegistro.A776 = decimal.Parse(txt776.Text);
                    nRegistro.A780 = decimal.Parse(txt780.Text);
                    nRegistro.A760 = decimal.Parse(txt760.Text);
                    nRegistro.A770 = decimal.Parse(txt770.Text);
                    nRegistro.A777 = decimal.Parse(txt777.Text);
                    nRegistro.A778 = decimal.Parse(txt778.Text);
                    nRegistro.A779 = decimal.Parse(txt779.Text);
                    nRegistro.A781 = decimal.Parse(txt781.Text);
                    nRegistro.A782 = decimal.Parse(txt782.Text);
                    nRegistro.A783 = decimal.Parse(txt783.Text);
                    nRegistro.A784 = decimal.Parse(txt784.Text);
                    nRegistro.A786 = decimal.Parse(txt786.Text);
                    nRegistro.A787 = decimal.Parse(txt787.Text);
                    nRegistro.A789 = decimal.Parse(txt789.Text);
                    nRegistro.A832 = decimal.Parse(txt832.Text);
                    nRegistro.A839 = decimal.Parse(txt839.Text);
                    nRegistro.A840 = decimal.Parse(txt840.Text);
                    nRegistro.A842 = decimal.Parse(txt842.Text);
                    nRegistro.A843 = decimal.Parse(txt843.Text);
                    nRegistro.A845 = decimal.Parse(txt845.Text);
                    nRegistro.A846 = decimal.Parse(txt846.Text);
                    nRegistro.A847 = decimal.Parse(txt847.Text);
                    nRegistro.A848 = decimal.Parse(txt848.Text);
                    nRegistro.A849 = decimal.Parse(txt849.Text);
                    nRegistro.A850 = decimal.Parse(txt850.Text);
                    nRegistro.A851 = decimal.Parse(txt851.Text);
                    nRegistro.A852 = decimal.Parse(txt852.Text);
                    nRegistro.A855 = decimal.Parse(txt855.Text);
                    nRegistro.A856 = decimal.Parse(txt856.Text);
                    nRegistro.A857 = decimal.Parse(txt857.Text);
                    nRegistro.A858 = decimal.Parse(txt858.Text);
                    nRegistro.A859 = decimal.Parse(txt859.Text);
                    nRegistro.A869 = decimal.Parse(txt869.Text);
                    nRegistro.A880 = decimal.Parse(txt880.Text);
                    nRegistro.A881 = decimal.Parse(txt881.Text);
                    nRegistro.A882 = decimal.Parse(txt882.Text);
                    nRegistro.A879 = decimal.Parse(txt879.Text);
                    nRegistro.A871 = decimal.Parse(txt871.Text);
                    nRegistro.A872 = decimal.Parse(txt872.Text);
                    nRegistro.A890 = decimal.Parse(txt890.Text);
                    nRegistro.A897 = decimal.Parse(txt897.Text);
                    nRegistro.A898 = decimal.Parse(txt898.Text);
                    nRegistro.A899 = decimal.Parse(txt899.Text);
                    nRegistro.A902 = decimal.Parse(txt902.Text);
                    nRegistro.A903 = decimal.Parse(txt903.Text);
                    nRegistro.A904 = decimal.Parse(txt904.Text);
                    nRegistro.A999 = decimal.Parse(txt999.Text);
                    nRegistro.A905 = decimal.Parse(txt905.Text);
                    nRegistro.A906 = decimal.Parse(txt906.Text);
                    nRegistro.A907 = decimal.Parse(txt907.Text);
                    nRegistro.A909 = decimal.Parse(txt909.Text);
                    nRegistro.A911 = decimal.Parse(txt911.Text);
                    nRegistro.A913 = decimal.Parse(txt913.Text);
                    nRegistro.A915 = decimal.Parse(txt915.Text);
                    nRegistro.A917 = decimal.Parse(txt917.Text);
                    nRegistro.A919 = decimal.Parse(txt919.Text);

                    db.REGISTRO_102A.Add(nRegistro);

                    db.SaveChanges();

                    MessageBox.Show("Registro creado");
                }
            }
        }

        private void Form102A_Load(object sender, EventArgs e)
        {
            using (ProyectoBDDEntities db = new ProyectoBDDEntities())
            {
                //Devuelve un booleano para saber si existe o no un registro asociado a la cedula proporcionada
                var resultado = db.REGISTRO_102A.Select(d => d.CED102A == cedula).ToList();
                bool res = false;
                foreach(var x in resultado)
                {
                    res = x;
                }                
                if (res)
                {
                    cargaDatos(cedula);
                }                
            }
                
        }

        private void label85_Click(object sender, EventArgs e)
        {

        }

        private void txt102_Validated(object sender, EventArgs e)
        {
            //if (((TextBox)sender).Text == "")
            //{
            //    ((TextBox)sender).Text = "0";
            //}
        }
        private void abc_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }

        private void txt703_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt481_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt491_Validated(object sender, EventArgs e)
        {

        }

        private void txt704_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt705_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt710_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt711_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt712_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt713_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt714_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt715_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt716_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt717_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt718_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt719_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt720_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt730_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt729_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt721_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt722_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt723_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt724_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt725_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt731_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt739_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt749_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt741_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt751_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt759_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt769_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt768_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt771_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt772_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt773_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt774_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt775_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt776_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt780_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt760_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt770_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt777_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt778_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt779_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt781_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt782_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt783_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt784_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt786_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt787_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt789_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt832_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt839_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt840_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt842_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt843_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt845_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt846_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt847_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt848_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt849_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt850_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt851_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt852_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt855_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt856_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt857_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt858_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt859_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt869_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt880_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt881_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt882_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt879_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt871_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt872_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt890_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt897_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt898_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt899_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt902_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt903_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt904_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt999_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt905_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt906_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt907_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt909_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt911_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt913_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt915_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void txt917_Validated(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "0";
            }
        }
        private void rtxt919_Validated(object sender, EventArgs e)
        {
            if (((TextBox) sender).Text == "")
            {
                ((TextBox) sender).Text = "0";
            }
        }

        private void btmAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OpcionesForm(cedula).Show();
        }

        private void txt481_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt201_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo acepta números sin espacios");
            }
        }
    }
}
