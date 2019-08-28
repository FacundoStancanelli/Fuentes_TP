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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Class1> lista_p_r = Form3.lista_p_r;
            int num = Form3.num_aux;
            label1.Text = lista_p_r[num].rta_larga;
        }
    }
}
