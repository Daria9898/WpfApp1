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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int balls = 0;
            if(radioBin4.IsChecked == true)
            {
                balls++;
            }
            if (radioBin7.IsChecked == true)
            {
                balls++;
            }
            if (radioBin12.IsChecked == true)
            {
                balls++;
            }
            if (radioBin17.IsChecked == true)
            {
                balls++;
            }
            if (balls == 0)
            {
                MessageBox.Show("0 баллов. Ты не шаришь за покемонов :(");
            }
            if (balls == 1)
            {
                MessageBox.Show("Видел, но не шаришь за покемонов. 1 балл. ");
            }
            if (balls == 2)
            {
                MessageBox.Show("Ты ответил правильно на половину вопросов. 2 балла.");
            }
            if (balls == 3)
            {
                MessageBox.Show("Почти, 3 балла");
            }
            if (balls == 4)
            {
                MessageBox.Show("Ура, 4 балла");
            }
        }
    }
}
