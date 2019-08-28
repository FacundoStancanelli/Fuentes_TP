using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace snake_game
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static List<Class1> lista_p_r = new List<Class1>();
        char opcion_correcta;
        public static int num_aux;
        List<string> rtas_bien = new List<string> { "Muy bien, acertaste la pregunta, puedes seguir jugando!", "Bieeeen, respondiste perfecto, podes seguir jugando" };
        List<string> rtas_mal = new List<string> { "Respondiste mal, ahora te explicaremos mas sobre el tema", "Lastimosamente, debemos comunicarte que tu respuesta es incorrecta, ahora en breve te enseñaremos un poco mas" };

        private void Form3_Load(object sender, EventArgs e)
        {
        Class1 obj = new Class1("¿QUE ES VANIDAD?", "Algo que te va a servir para tu vida", "Algo malo, tenes que dejarlo atras", "Obediencia", "Algo vacio, sin nada de transfondo", 'D', "La vanidad es algo que carece de significado");

            opcion_correcta = obj.opcion_correcta;
            lista_p_r.Add(obj);

        Class1 obj_1 = new Class1("¿QUE COMPARACION HACE EL AUTOR EN CUANTO A LA SABIDURIA Y LA NECEDAD?", "Necesitamos mas sabiduria para nuestra vida, que necedad", "Necesitamos mas necedad para nuestra vida, que sabiduria", "La sabiduria aventaja a la necesidad", "Ninguna de las anteriores", 'C', "A pesar de sus diferencias, el texto resalta la equivalencia del destino de los dos caminos: LA MUERTE");

            opcion_correcta = obj_1.opcion_correcta;
            lista_p_r.Add(obj_1);

        Class1 obj_2 = new Class1("¿QUE SIGNIFICA ATRAPAR VIENTOS?", "Algo que no te lleva a nada", "Hacer algo para resolver problemas urgentemente", "Tener tiempo libre", "Relajarse un poco mas, para resolver problemas con mas claridad", 'A', "Esto quiere decir que seguis algo que no te lleva a ningun punto. Es algo imposible atrapar el viento");

            opcion_correcta = obj_2.opcion_correcta;
            lista_p_r.Add(obj);

        Class1 obj_3 = new Class1("¿POR QUE EL AUTOR DICE CON TANTA FIRMEZA QUE TODO ES VANIDAD?", "Porque piensa que no hay nada para hacer", "Porque la vida, al fin no es nada", "Porque piensa que todo es malo", "Porque piensa que se nos acabara el tiempo para nuestras metas", 'B', "Porque el autor ya es un hombre con mucha experiencia, y entiende que al fin y al cabo, la vida no es nada");
            opcion_correcta = obj_3.opcion_correcta;
            lista_p_r.Add(obj_3);

        Class1 obj_4 = new Class1("¿QUIEN ES EL AUTOR DE KOHELET?", "Shlomo", "Moshe", "David", "Kohelet", 'A', "No se sabe pero se sospecha que pudo haber sido Shlomo");
            opcion_correcta = obj_4.opcion_correcta;
            lista_p_r.Add(obj_4);




            /*
            if (A.Text.Contains(obj.opcion_correcta))
            {
                MessageBox.Show("hola");
            }
            */
            Random rnd = new Random();
            int numero = rnd.Next(0, 4);
            num_aux = numero;
            label1.Text = lista_p_r[numero].pregunta;
            A.Text += lista_p_r[numero].opcion_a;
            B.Text += lista_p_r[numero].opcion_b;
            C.Text += lista_p_r[numero].opcion_c;
            D.Text += lista_p_r[numero].opcion_d;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int numero = rnd.Next(0, 5);
            num_aux = numero;
            label1.Text = lista_p_r[numero].pregunta;
            A.Text += lista_p_r[numero].opcion_a;
            B.Text += lista_p_r[numero].opcion_b;
            C.Text += lista_p_r[numero].opcion_c;
            D.Text += lista_p_r[numero].opcion_d;
        }

        private void A_Click(object sender, EventArgs e)
        {
            if (A.Text.Contains(lista_p_r[num_aux].opcion_correcta))
            {
                Random rnd = new Random();
                int numero = rnd.Next(0, 1);
                MessageBox.Show(rtas_bien[numero].ToString());
            }
            else
            {
                Random rnd = new Random();
                int numero = rnd.Next(0, 1);
                MessageBox.Show(rtas_mal[numero].ToString());
                Form2 newForm = new Form2();
                newForm.Show();
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (B.Text.Contains(lista_p_r[num_aux].opcion_correcta))
            {
                Random rnd = new Random();
                int numero = rnd.Next(0, 1);
                MessageBox.Show(rtas_bien[numero].ToString());
            }
            else
            {
                Random rnd = new Random();
                int numero = rnd.Next(0, 1);
                MessageBox.Show(rtas_mal[numero].ToString());
                Form2 newForm = new Form2();
                newForm.Show();
            }
        }

        private void C_Click(object sender, EventArgs e)
        {
            if (C.Text.Contains(lista_p_r[num_aux].opcion_correcta))
            {
                Random rnd = new Random();
                int numero = rnd.Next(0, 1);
                MessageBox.Show(rtas_bien[numero].ToString());
            }
            else
            {
                Random rnd = new Random();
                int numero = rnd.Next(0, 1);
                MessageBox.Show(rtas_mal[numero].ToString());
                Form2 newForm = new Form2();
                newForm.Show();
            }
        }

        private void D_Click(object sender, EventArgs e)
        {
            if (D.Text.Contains(lista_p_r[num_aux].opcion_correcta))
            {
                Random rnd = new Random();
                int numero = rnd.Next(0, 1);
                MessageBox.Show(rtas_bien[numero].ToString());
            }
            else
            {
                Random rnd = new Random();
                int numero = rnd.Next(0, 1);
                MessageBox.Show(rtas_mal[numero].ToString());
                Form2 newForm = new Form2();
                newForm.Show();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

    private void Button5_Click(object sender, EventArgs e)
    {
        
    }
    }
}

