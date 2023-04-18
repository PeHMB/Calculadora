using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Calculadora.Janelas
{
    /// <summary>
    /// Lógica interna para Calculo.xaml
    /// </summary>
    public partial class Calculo : Window
    {
        public Calculo()
        {
            InitializeComponent();
        }

        private void btSoma_Click(object sender, RoutedEventArgs e)
        {
            double v1, v2, result;

            try
            {

                v1 = Convert.ToDouble(txtValor1.Text);
                v2 = Convert.ToDouble(txtValor2.Text);

                result = v1 + v2;

                txtResult.Text = result.ToString();

            }
            catch
            {
                    MessageBox.Show("Digite os valores antes ♥");         
            }
        }

        private void btSubtracao_Click(object sender, RoutedEventArgs e)
        {
            double v1, v2, result;
            try
            {
                v1 = Convert.ToDouble(txtValor1.Text);
                v2 = Convert.ToDouble(txtValor2.Text);

                result = v1 - v2;

                txtResult.Text = result.ToString();

            }catch
            {
                MessageBox.Show("Digite os valores antes ♥");
            }
        }

        private void btMultiplicacao_Click(object sender, RoutedEventArgs e)
        {
            double v1, v2, result;
            try
            {

                v1 = Convert.ToDouble(txtValor1.Text);
                v2 = Convert.ToDouble(txtValor2.Text);

                result = v1 * v2;

                txtResult.Text = result.ToString();

            }
            catch
            {
                MessageBox.Show("Digite os valores antes ♥");
            }
        }

        private void btDivisao_Click(object sender, RoutedEventArgs e)
        {
            double v1, v2, result;
            try
            {

                v1 = Convert.ToDouble(txtValor1.Text);
                v2 = Convert.ToDouble(txtValor2.Text);

                result = v1 / v2;

                txtResult.Text = result.ToString();

            }
            catch
            {
                MessageBox.Show("Digite os valores antes ♥");
            }
        }

        private void btPotencia_Click(object sender, RoutedEventArgs e)
        {
            double v1, v2, result;
            try
            {
                v1 = Convert.ToDouble(txtValor1.Text);
                v2 = Convert.ToDouble(txtValor2.Text);

                result = Math.Pow(v1, v2);

                txtResult.Text = result.ToString();

            }
            catch
            {
                MessageBox.Show("Digite os valores antes ♥");
            }

        }

        private void btRaiz_Click(object sender, RoutedEventArgs e)
        {
            double v1, v2, result;
            try
            {
                v1 = Convert.ToDouble(txtValor1.Text);
                v2 = Convert.ToDouble(txtValor1.Text);

                result = Math.Sqrt(v1);

                txtResult.Text = result.ToString();
                MessageBox.Show("Atenção! será mostrado a raiz do primeiro valor digitado");
            }
            catch
            {
                MessageBox.Show("Digite um único valor antes ♥");
            }
        }

        private void txtResult_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
