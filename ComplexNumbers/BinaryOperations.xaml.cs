using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Numerics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ComplexNumbers
{
    /// <summary>
    /// Interaction logic for BinaryOperations.xaml
    /// </summary>
    public partial class BinaryOperations : Window
    {
        public BinaryOperations()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.-]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ClearTextbox()
        {
            this.real_1.Clear();
            this.real_2.Clear();
            this.imaginary_1.Clear();
            this.imaginary_2.Clear();
        }

        private void ShowError()
        {
            Error er = new Error();
            er.Show();
        }
        private void real_1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClearTextbox();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                double r1 = Double.Parse(real_1.Text);
                double r2 = Double.Parse(real_2.Text);
                double i1 = Double.Parse(imaginary_1.Text);
                double i2 = Double.Parse(imaginary_2.Text);
                Complex z1 = new Complex(r1, i1);
                Complex z2 = new Complex(r2, i2);
                answer.Text = Complex.Add(z1, z2).ToString();
            }
            catch (Exception)
            {
                ShowError();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                double r1 = Double.Parse(real_1.Text);
                double r2 = Double.Parse(real_2.Text);
                double i1 = Double.Parse(imaginary_1.Text);
                double i2 = Double.Parse(imaginary_2.Text);
                Complex z1 = new Complex(r1, i1);
                Complex z2 = new Complex(r2, i2);
                answer.Text = Complex.Subtract(z1, z2).ToString();
            }
            catch (Exception)
            {
                ShowError();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                double r1 = Double.Parse(real_1.Text);
                double r2 = Double.Parse(real_2.Text);
                double i1 = Double.Parse(imaginary_1.Text);
                double i2 = Double.Parse(imaginary_2.Text);
                Complex z1 = new Complex(r1, i1);
                Complex z2 = new Complex(r2, i2);
                answer.Text = Complex.Multiply(z1, z2).ToString();
            }
            catch (Exception)
            {
                ShowError();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                double r1 = Double.Parse(real_1.Text);
                double r2 = Double.Parse(real_2.Text);
                double i1 = Double.Parse(imaginary_1.Text);
                double i2 = Double.Parse(imaginary_2.Text);
                Complex z1 = new Complex(r1, i1);
                Complex z2 = new Complex(r2, i2);
                answer.Text = Complex.Divide(z1, z2).ToString();
            }
            catch (Exception)
            {
                ShowError();
            }
        }
    }
}
