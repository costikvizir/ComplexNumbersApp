using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Numerics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace ComplexNumbers
{
    /// <summary>
    /// Interaction logic for UnaryOperations.xaml
    /// </summary>
    public partial class UnaryOperations : Window
    {
        public UnaryOperations()
        {
            InitializeComponent();
        }      

        private void ClearTextbox()
        {
            this.realPart.Clear();
            this.imaginaryPart.Clear();
        }

        private void ShowError()
        {
            Error er = new Error();
            er.Show();      
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClearTextbox();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.-]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        
        //Magnitude Button

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool exceptionThrown = false;
            try
            {
                double real = Double.Parse(realPart.Text);
                double imaginary = Double.Parse(imaginaryPart.Text);
                Complex z = new Complex(real, imaginary);
                answerBox.Text = z.Magnitude.ToString();
            }
            catch (Exception)
            {
                ShowError();
                exceptionThrown = true;
            }
            finally
            {
                if(exceptionThrown)
                   ClearTextbox();
            }           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bool exceptionThrown = false;
            try
            {
                double real = Double.Parse(realPart.Text);
                double imaginary = Double.Parse(imaginaryPart.Text);
                Complex z = new Complex(real, imaginary);
                answerBox.Text = Complex.Conjugate(z).ToString();
            }
            catch (Exception)
            {
                ShowError();
                exceptionThrown = true;
            }
            finally
            {
                if (exceptionThrown)
                    ClearTextbox();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            bool exceptionThrown = false;
            try
            {
                double real = Double.Parse(realPart.Text);
                double imaginary = Double.Parse(imaginaryPart.Text);
                Complex z = new Complex(real, imaginary);
                answerBox.Text = (z.Phase * 180/ Math.PI).ToString();
            }
            catch (Exception)
            {
                ShowError();
                exceptionThrown = true;
            }
            finally
            {
                if (exceptionThrown)
                    ClearTextbox();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            bool exceptionThrown = false;
            try
            {
                double real = Double.Parse(realPart.Text);
                double imaginary = Double.Parse(imaginaryPart.Text);
                Complex z = new Complex(real, imaginary);
                answerBox.Text = Complex.Log(z).ToString();
            }
            catch (Exception)
            {
                ShowError();
                exceptionThrown = true;
            }
            finally
            {
                if (exceptionThrown)
                    ClearTextbox();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            bool exceptionThrown = false;
            try
            {
                double real = Double.Parse(realPart.Text);
                double imaginary = Double.Parse(imaginaryPart.Text);
                double pow = Double.Parse(power.Text);
                Complex z = new Complex(real, imaginary);
                answerBox.Text = Complex.Pow(z, pow).ToString();
            }
            catch (Exception)
            {
                ShowError();
                exceptionThrown = true;
            }
            finally
            {
                if (exceptionThrown)
                    ClearTextbox();
            }
        }
    }
}
