using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake_game
{
    public class Class1
    {
        public string pregunta;
        public string opcion_a;
        public string opcion_b;
        public string opcion_c;
        public string opcion_d;
        public string rta_larga;
        public char opcion_correcta;

        public Class1(string Pregunta, string Opcion_a, string Opcion_b, string Opcion_c, string Opcion_d, char Opcion_correcta, string Rta_larga)
        {
            pregunta = Pregunta;
            opcion_a = Opcion_a;
            opcion_b = Opcion_b;
            opcion_c = Opcion_c;
            opcion_d = Opcion_d;
            rta_larga = Rta_larga;
            opcion_correcta = Opcion_correcta;
        }
    }
}
