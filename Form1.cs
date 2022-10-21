using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PracticasAccenture
{
    public partial class Form1 : Form
    {
        int[] numeros;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnValidaciones_Click(object sender, EventArgs e)
        {
            double sueldo = Convert.ToDouble(txtSueldo.Text);
            string puesto = txtPuesto.Text;
            string nombre = txtNombre.Text;
            string apellido = txtapellido.Text;
            if (sueldo <= 0) {
                MessageBox.Show("Por favor, ingrese un numero " +
                "valido desde 1 en adelante ");
            }
            else if (puesto != "Soporte Tecnico" || puesto != "DBA" || puesto != "Desarrollador")
            { MessageBox.Show("Por favor, ingrese uno de los puestos existentes"); }
            else if (nombre.Length <2 && apellido.Length < 2 ||nombre.Length>50 && apellido.Length >50)
            { MessageBox.Show("Error, ingrese un nombre y apellido que se encuentre entre los 2 y los 50 caracteres"); }

        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtapellido.Text;
            string puesto= txtPuesto.Text;
            Imprimir(nombre,apellido,puesto);
        }
        public void Imprimir(String a, string b, string c){
            a = a.ToUpper();
            b = b.ToUpper();
            c = c.ToUpper();    
            MessageBox.Show(a + " " + b +"" + c);
        }

        private void BtnIngresarhoras_Click(object sender, EventArgs e)
        {
            int contador = 0;
            numeros = new int[5];
            for (int j = 0; j < numeros.Length; j++)
            {


                int numero = Convert.ToInt32(Interaction.InputBox("Ingrese horas"));
                contador += numero;
                numeros[j] = numero;
            }
            int promedio = contador / 5;
            int minimo = numeros.Min();
            if(minimo < 4){ MessageBox.Show( "el dia de la semana que menos horas de trabajo tuvo fue el de " + minimo ) ; }
            MessageBox.Show("sus horas de trabajo totales son " + contador + " de lunes a viernes");
            MessageBox.Show("El promedio de sus horas de trabajo son " + promedio + " horas");
            

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPuesto.Clear();
            txtapellido.Clear();
            txtSueldo.Clear();
        }
    }
}
