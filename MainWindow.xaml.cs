/* Jordan Ross
May 24, 2019
Math Tutor
*/
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U5_MathTutor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        double x;
        int symbol;
        double y;
        double answer;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnQuestion_Click(object sender, RoutedEventArgs e)
        {
            x = rnd.Next(1, 11);
            symbol = rnd.Next(1, 5);
            y = rnd.Next(1, 11);
            

            if (symbol == 1)
            {
                lblQuestion.Content = x + "+" + y;
            }
            
            else if (symbol == 2)
            {
                lblQuestion.Content = x + "-" + y;
            }
            else if (symbol == 3)
            {
                lblQuestion.Content = x + "/" + y;
            }
            else
            {
                lblQuestion.Content = x + "*" + y;
            }

        }

        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        {
            double temp;
            if (symbol == 1)
            {
                answer = x + y;
            }
            else if (symbol == 2)
            {
                answer = x - y;
            }
            else if (symbol == 3)
            {
                temp = x / y;
                answer = Math.Round(temp,1);
            }
            else
            {
                answer = x * y;
            }
           
            if (txtAnswer.Text == answer.ToString())
            {
                lblOutput.Content = Environment.NewLine + "Your answer is correct";
            }
            else
            {
                lblOutput.Content = Environment.NewLine + "Your answer is wrong, the answer is " + answer;
            } 


        }
    }
}
