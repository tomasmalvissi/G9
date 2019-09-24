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
        Preguntas preg;
        CarrerasCBA ccba;
        public Resultado()
        {
            InitializeComponent();
        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            preg = new Preguntas();
            ccba = new CarrerasCBA();
            switch (preg.Resp)
            {
                case 1:
                    lblRes.Text = "eres HUMANISTA significa que eres compatible con carreras como literatura, historia, psicología, filosofía, etc.";
                    lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
                    lblCarr.Text = ccba.cHumanidades[1];
                    break;
                case 2:
                    lblRes.Text = "eres CIENTIFICO compatible con carreras como medicina, enfermería, biología, química, etc.";
                    lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
                    lblCarr.Text = ccba.cCiencias[1];
                    break;
                case 3:
                    lblRes.Text = "eres MATEMATICO significa que eres compatible con carreras como ingeniería, contabilidad, matemáticas, etc.";
                    lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
                    lblCarr.Text = ccba.cMatematicas[1];
                    break;
                case 4:
                    lblRes.Text = "eres ARTISTICO significa que eres compatible con carreras como estética, artes visuales, música, diseño, etc."; lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
                    lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
                    lblCarr.Text = ccba.cArte[1];
                    break;

            }

            //if (preg.Resp==1) //opcion A
            //{
            //    lblRes.Text = "eres HUMANISTA significa que eres compatible con carreras como literatura, historia, psicología, filosofía, etc.";
            //    lblCommon.Text="¡Estas carreras están disponibles en Córdoba segun tu resultado!";
            //    lblCarr.Text = ccba.cHumanidades[1];
            //}
            //else if (preg.Resp == 2) //opcion B
            //{
            //    lblRes.Text = "eres CIENTIFICO compatible con carreras como medicina, enfermería, biología, química, etc.";
            //    lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
            //    lblCarr.Text = ccba.cCiencias[1];
            //}
            //else if (preg.Resp == 3) //opcion C
            //{
            //    lblRes.Text = "eres MATEMATICO significa que eres compatible con carreras como ingeniería, contabilidad, matemáticas, etc.";
            //    lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
            //    lblCarr.Text = ccba.cMatematicas[1];
            //}
            //else if (preg.Resp == 4) //opcion D
            //{
            //    lblRes.Text = "eres ARTISTICO significa que eres compatible con carreras como estética, artes visuales, música, diseño, etc."; lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
            //    lblCommon.Text = "¡Estas carreras están disponibles en Córdoba segun tu resultado!";
            //    lblCarr.Text = ccba.cArte[1];
            //}
        }
    }
}
