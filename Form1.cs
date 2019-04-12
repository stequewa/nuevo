using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehiculos
{
    public partial class Form1 : Form
    {
        List<Datos_Vehiculos> lista;
        List<Taxi> lista1;

        public Form1()
        {
            lista = new List<Datos_Vehiculos>();
            lista1 = new List<Taxi>();
            InitializeComponent();
        }


        public void insertar()
        {
            Datos_Vehiculos p = new Datos_Vehiculos(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            lista.Add(p);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            insertar();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" El coche esta acelerando");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int fila = dataGridView1.CurrentRow.Index;
            lista[fila].apagar();
            lista1[fila].apagar();
            MessageBox.Show(" El coche se apago");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int fila = dataGridView1.CurrentRow.Index;
            lista[fila].encender();
            lista1[fila].encender();
            MessageBox.Show(" El coche se encendio");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MessageBox.Show(" El coche freno");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {


        }

        private void button9_Click(object sender, EventArgs e)
        {
            Taxi b = new Taxi(txtBox1.Text, txtBox2.Text, txtBox3.Text, textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            lista1.Add(b);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lista1;
            txtBox1.Clear();
            txtBox2.Clear();
            txtBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            Datos_Vehiculos l = new Datos_Vehiculos();

        }

        public void eliminar(string placa, string placataxi)
        {
            foreach (var Datos_Vehiculos in lista)
            {
                if ( Datos_Vehiculos.Placa == placa)
                {
                    lista.Remove(Datos_Vehiculos);
                    break;
                }
            }
            foreach (var Taxi in lista1)
            {
                if (Taxi.Placataxi == placataxi)
                {
                    lista.Remove(Taxi);
                    break;
                }
            }
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            eliminar(txtBox6.Text, txtBox7.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lista1;
        }

        public void modificar(string placa, string placataxi)
        {
            foreach (var Datos_Vehiculos in lista)
            {
                if (Datos_Vehiculos.Placa == placa)
                {
                    Datos_Vehiculos.Marca = textBox2.Text;
                    Datos_Vehiculos.Modelo = textBox3.Text;
                    Datos_Vehiculos.Año = int.Parse(textBox4.Text);

                }
            }
            foreach (var Taxi in lista1)
            {
                if (Taxi.Placataxi == placataxi)
                {
                    Taxi.Empresa = txtBox1.Text;
                    Taxi.Chofer = txtBox2.Text;
                    
                }


            }
        }
        

        private void button8_Click(object sender, EventArgs e)
        {
            modificar(txtBox6.Text,txtBox7.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = lista1;

        }
    }
        

}
