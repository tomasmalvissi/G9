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
    public partial class Resultado : Form
    {
        #region PROPIEDADES
        int resp = 0;
        private readonly Usuario user;
        CarrerasCBA ccba;
        #endregion
        public Resultado(int respuesta, Usuario user)
        {
            InitializeComponent();
            resp = respuesta;
            this.user = user;
        }
        #region METODOS
        private void Resultado_Load(object sender, EventArgs e)
        {
            ccba = new CarrerasCBA();
            lblNombre.Text = user.MostrarLista();
            switch (resp)
            {
                case 1:
                    lblRes.Text = "HUMANISTA!!! significa que eres compatible con carreras como literatura,\r\n historia, psicología, filosofía, etc.";
                    lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
                    lblCarr.Text = ccba.cHumanidades[0];
                    break;
                case 2:
                    lblRes.Text = "CIENTIFICO!!! compatible con carreras como medicina,\r\n enfermería, biología, química, etc.";
                    lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
                    lblCarr.Text = ccba.cCiencias[0];
                    break;
                case 3:
                    lblRes.Text = "MATEMATICO!!! significa que eres compatible con carreras como ingeniería,\r\n contabilidad, matemáticas, etc.";
                    lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
                    lblCarr.Text = ccba.cMatematicas[0];
                    break;
                case 4:
                    lblRes.Text = "ARTISTICO!!! significa que eres compatible con carreras como estética,\r\n artes visuales, música, diseño, etc."; lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
                    lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
                    lblCarr.Text = ccba.cArte[0];
                    break;
            }
        }
        #endregion
    }
}
