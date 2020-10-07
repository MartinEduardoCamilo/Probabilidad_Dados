using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probabilidad.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn();
            c1.HeaderText = "Serie";
            c1.Width = 50;
            c1.ReadOnly = true;

            DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn();
            c2.HeaderText = "Probabilidad";
            c2.Width = 90;
            c2.ReadOnly = true;

            DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn();
            c3.HeaderText = "Probabilidad alterada";
            c3.Width = 150;
            c3.ReadOnly = true;

            dataGridView1.Columns.Add(c1);
            dataGridView1.Columns.Add(c2);
            dataGridView1.Columns.Add(c3);

        }

        private void Tirarbutton_Click(object sender, EventArgs e)
        {
            int numereo = Convert.ToInt32(NumerotextBox.Text);
            double probabilidad = Convert.ToDouble(ProbabilidadtextBox.Text);

            switch (numereo)
            {
                case 1:
                    Image image = Image.FromFile("Fotos\01.png");
                    pictureBox1.Image = image;
                    break;
                default:
                    break;
            }

            Buscar(numereo, probabilidad);
        }

        private void Buscar(int numero, double probabilidad)
        {
            int[] num = {1, 2, 3, 4, 5, 6 };

            double resultado = 0;
            double resultado2 = 0;

            for (int i = 0; i < (num.Count()); i++)
            {

                resultado2 = (1%6);

                if (numero == num[i])
                {
                    resultado = ((numero/6) + probabilidad);
                }


                dataGridView1.Rows.Add(i, resultado2.ToString("N2"), resultado.ToString("N2"));
            }
        }
    }
}
