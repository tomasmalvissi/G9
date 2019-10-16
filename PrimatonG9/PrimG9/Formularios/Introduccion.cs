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
        Usuario user;
        public Introduccion()
        {
            InitializeComponent();
            user = new Usuario();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            user.Agregar(txtUser.Text);
            this.Hide();
            Preguntas preg = new Preguntas(user);
            preg.Show();
        }
    }
}
