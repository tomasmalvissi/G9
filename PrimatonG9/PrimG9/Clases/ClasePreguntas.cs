using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimG9.Clases
{
    public class ClasePreguntas
    {
        #region PROPIEDADES
        /// <summary>
        /// declaracion de arreglos, cada uno con su 
        /// pregunta(pos 0) y sus 4 respuestas
        /// </summary>
        public string[,] preg1 = new string[,] {{"Si te concedieran un deseo relacionado al conocimiento, ¿Qué pedirías?"},
                                          {"Entender por que el ser humano es tan complejo"},
                                          {"Saber las leyes abstractas que rigen al universo"},
                                          {"Inventar las mejores tecnologías del futuro"},
                                          {"Ver todas las cosas hermosas del mundo"}};

        string[,] preg2 = new string[,] {{"Cuando estudias, ¿Qué estrategias usas?"},
                                          {"Subrayo las ideas principales"},
                                          {"Anoto las palabras claves"},
                                          {"Hago un esquema"},
                                          {"No tengo una estrategia"}};

        string[,] preg3 = new string[,] {{"Cuando estudias una materia, ¿Qué es lo más importante?"},
                                         {"Aprender con precisión cada detalle de lo leído"},
                                         {"Comprender las ideas generales"},
                                         {"Relacionarla con otras materias"},
                                         {"Hacer un resumen"}};

        string[,] preg4 = new string[,] {{"Cuando aprendes algo nuevo;"},
                                         {"Trato de ponerlo en práctica inmediatamente"},
                                         {"Analizo su significado y lo dejo guardado en mi mente"},
                                         {"Reflexiono en torno a su utilidad"},
                                         {"No me he puesto a pensar en lo que hago"}};

        string[,] preg5 = new string[,] {{"¿Con cuál de las siguientes actividades en clases te motiva más?"},
                                         {"Debatiendo"},
                                         {"Realizando experimentos"},
                                         {"Resolviendo ecuaciones"},
                                         {"Dibujando o pintando"}};

        string[,] preg6 = new string[,] {{"Si te imaginas en un futuro, ¿Cuál de las siguientes acciones te gustaría que estuvieran presente en tu día a día?"},
                                         {"Escuchar a las personas para entenderlas"},
                                         {"Investigar la naturaleza para entenderla"},
                                         {"Idear nuevas formas para mejorar los procesos"},
                                         {"Diseñar cosas para embellecer los ambientes"}};

        string[,] preg7 = new string[,] {{"¿Cómo te proyectas a futuro?"},
                                         {"Ayudando a que el mundo sea mejor"},
                                         {"Procurando el bien estar de los otros"},
                                         {"Resolviendo mis problemas por mi cuenta"},
                                         {"Trabajando solo"}};

        string[,] preg8 = new string[,] {{"Cuando piensas en el trabajo:"},
                                         {"Creo que trabajare en algo que me de libertad"},
                                         {"Me gustaría estar en una gran empresa"},
                                         {"Intentare emprender"},
                                         {"No visualizo nada muy especifico"}};

        string[,] preg9 = new string[,] {{"¿Cuál de las siguientes frases te representa más?"},
                                         {"Analizo por que los ostros actúan como actúan"},
                                         {"Pregunto sobre cosas que otros dan por obvias"},
                                         {"Invento soluciones que a otros no se les ocurren"},
                                         {"Siento que veo detalles que otros no ven"}};

        #endregion

    }
}
