using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimG9.Clases
{
    public class Usuario
    {
        #region PROPIEDADES
        private string[] nombre = new string[1];
        private int proxNom;
        #endregion

        #region METODOS
        private void ArregloInfinito(int proxNom)
        {
            string[] Temp = new string[nombre.Length + proxNom];
            nombre = Copia(nombre,Temp);

        }
        private string[] Copia(string[] Origen , string[] Destino)
        {
            for (int i = 0; i < proxNom; i++)
            {
                Destino[i] = Origen[i];
            }
            return Destino;
        }
        public bool Agregar(string name)
        {
            bool Resp = false;
            try
            {
                if (proxNom == nombre.Length)
                {
                    this.ArregloInfinito(1);
                }

                nombre[proxNom] = name;
                proxNom++;
                Resp = true;
            }
            catch (Exception err)
            {
                throw err;
            }

            return Resp;
        }
        public string MostrarLista()
        {
            string Lista = "";
            if (proxNom > 0)
            {
                Lista = nombre[0];
                for (int i = 1; i < proxNom; i++)
                {
                    Lista = "Felicitaciones " + nombre[nombre.Length - 1]+ " eres...";
                }
            }
            return Lista;
        }
        #endregion
    }
}
