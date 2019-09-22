using PrimG9.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimG9.Formularios
{
    public partial class Introduccion : Form
    {
        public Introduccion()
        {
            InitializeComponent();
        }

        private void BtnEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Preguntas preg = new Preguntas();
            preg.Show();
            //Usuario.Agregar(txtUser.Text);
            txtUser.SelectAll();
        }
    }
}
