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
    public partial class Preguntas : Form
    {
        #region PROPIEDADES
        ClasePreguntas cp;
        CarrerasCBA ccba;
        int preguntaActual;
        private int A;
        private int B;
        private int C;
        private int D;
        public int Resp;
        private readonly Usuario user;
        #endregion
        public Preguntas(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }
        #region METODOS
        private void Preguntas_Load(object sender, EventArgs e)
        {
            cp = new ClasePreguntas();
            ccba = new CarrerasCBA();
            CargarPreg(cp.pregunta1);
            preguntaActual++;
        }
        private void BtnSig_Click(object sender, EventArgs e)
        {
            preguntaActual++;
            switch (preguntaActual)
            {
                case 1:
                    CargarPreg(cp.pregunta2);
                    break;
                case 2:
                    CargarPreg(cp.pregunta3);
                    break;
                case 3:
                    CargarPreg(cp.pregunta4);
                    break;
                case 4:
                    CargarPreg(cp.pregunta5);
                    break;
                case 5:
                    CargarPreg(cp.pregunta6);
                    break;
                case 6:
                    CargarPreg(cp.pregunta7);
                    break;
                case 7:
                    CargarPreg(cp.pregunta8);
                    break;
                case 8:
                    CargarPreg(cp.pregunta9);
                    break;
            }
            if (rbA.Checked == true)
            {
                A++;
            }
            else if (rbB.Checked == true)
            {
                B++;
            }
            else if (rbC.Checked == true)
            {
                C++;
            }
            else if (rbD.Checked == true)
            {
                D++;
            }
            if (preguntaActual>=9)
            {
                MostrarResultado();
            }

           
        }
        private void CargarPreg(string[] pregunta) {
            lblPreg.Text = pregunta[0];
            rbA.Text = pregunta[1];
            rbB.Text = pregunta[2];
            rbC.Text = pregunta[3];
            rbD.Text = pregunta[4];
        }
        private void MostrarResultado()
        {
            if (A > B && A > C && A > D)
            {
                Resp = 1;
            }
            else if (B > A && B > C && B > D)
            {
                Resp = 2;
            }
            else if (C > A && C > B && C > D)
            {
                Resp = 3;
            }
            else if (D > A && D > C && D > B)
            {
                Resp = 4;
            }
            else if (A == B || A == C || A == D || B == A || B == C || B == D || C == A || C == B || C == D)
            {
                Random random = new Random();
                Resp = random.Next(0, 5);
            }
            this.Hide();
            Resultado resu = new Resultado(Resp, user);
            resu.Show();
        }
        #endregion
    }
}