using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ev_Final_4toBi
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}


		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void Suma_Click(object sender, EventArgs e)
		{

			int Num1 = int.Parse(TextVar1.Text);
			int Num2 = int.Parse(TextVar2.Text);
			int suma = Num1 + Num2;
			MessageBox.Show("El Resultado de la suma es " + suma);
		}

		private void Producto_Click(object sender, EventArgs e)
		{
			int Num1 = int.Parse(TextVar1.Text);
			int Num2 = int.Parse(TextVar2.Text);
			int multiplicacion = Num1 * Num2;
			MessageBox.Show("El Resultado del producto es " + multiplicacion);
		}

		private void Potencia_Click(object sender, EventArgs e)
		{
			int Num1 = int.Parse(TextVar1.Text);
			int Num2 = int.Parse(TextVar2.Text);
			int Num3 = 0;
			int potencia = 1;
			while (Num3 != Num2)
			{
				potencia = potencia * Num1;
				Num3++;
			}
			MessageBox.Show("El Resultado es" + potencia);
		}

		private void Division_Click(object sender, EventArgs e)
		{

			float Num1 = float.Parse(TextVar1.Text);
			float Num2 = float.Parse(TextVar2.Text);

			if (Num2 > 0)
			{
				float division = Num1 / Num2;
				MessageBox.Show("El Resultado es " + division);
			}
			else
			{
				MessageBox.Show("La Division es indefinida ");
			}
		}

		private void Factorial_Click(object sender, EventArgs e)
		{
			int Num1 = int.Parse(TextVar1.Text);
			long j = 1;
			for (int i = 0; i == Num1;)
			{
				j = j * i;
			}
			MessageBox.Show("El Resultado es " + j);
		}
	}
}
	
	
