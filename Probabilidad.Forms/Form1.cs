using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            Random ran = new Random();

            if (NumerotextBox.Text == string.Empty || NumerotextBox.Text != null)
            {
                NumerotextBox.Text = ran.Next(1, 6).ToString();
                Mensajelabel3.Text = "Número del dado";
            }

        }

        private void Buscar(int numero, double probabilidad)
        {
            double aux = 0;
            int[] num = { 1, 2, 3, 4, 5, 6 };
            double restar = 0;
            const double resultado2 = 0.16;
            const int dividendo = 5;


            for (int i = 0; i < (num.Count()); i++)
            {              
                if (numero == num[i])
                {
                    aux = (0.16 + probabilidad) * 100;

                    dataGridView1.Rows.Add(i + 1, resultado2.ToString("N2"), aux + "%");
                }
                else if (numero != num[i])
                {
                    restar = (((1 - (probabilidad + resultado2)))/dividendo)*100;
                    dataGridView1.Rows.Add(i + 1, resultado2.ToString("N2"), restar.ToString("N2")+ "%");
                }
            }

            aux = 0;
            restar = 0;
        }
    
        private void Limpiarbutton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            NumerotextBox.Text = string.Empty;
            ProbabilidadtextBox.Text = string.Empty;
            dataGridView1.Rows.Clear();
            Mensajelabel3.Text = null;
            
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (NumerotextBox.Text != null || ProbabilidadtextBox.Text != null)
            {

                if (Convert.ToInt32(NumerotextBox.Text) < 0)
                {
                    dataGridView1.Rows.Clear();
                    errorProvider1.SetError(NumerotextBox, "Debe de ser un número entero entre el 1 y 6");
                    NumerotextBox.Focus();
                }
                else  if (Regex.IsMatch(NumerotextBox.Text, "[1-6]") || Regex.IsMatch(ProbabilidadtextBox.Text, "[0-9] + (,[0-9]{ 1,3})?"))
                { 
                    int numereo = Convert.ToInt32(NumerotextBox.Text);
                    double probabilidad = Convert.ToDouble(ProbabilidadtextBox.Text);
               
                    if(probabilidad > 0.84 || probabilidad < 0)
                    {
                      
                        errorProvider1.SetError(ProbabilidadtextBox, "La probilidad no puede ser mayor que 0.84 o menor que 0");
                        ProbabilidadtextBox.Focus();

                        NumerotextBox.Text = string.Empty;
                        ProbabilidadtextBox.Text = string.Empty;
                        dataGridView1.Rows.Clear();
                        Mensajelabel3.Text = null;

                    }
                    else
                    {
                        Buscar(numereo, probabilidad);
                    }  
                }
                else
                {
                    errorProvider1.SetError(ProbabilidadtextBox, "Debe de ser un número decimal");
                    ProbabilidadtextBox.Focus();
                    errorProvider1.SetError(NumerotextBox, "Debe de ser un número entero entre el 1 y 6");
                    NumerotextBox.Focus();
                }
            }
        }
    }
}