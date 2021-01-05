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

namespace WpfApp3

{

    /// <summary>

    /// Логика взаимодействия для MainWindow.xaml

    /// </summary>

    public partial class MainWindow : Window

    {

        public MainWindow()

        {

            InitializeComponent();

        }

        private void btncount_Click(object sender, RoutedEventArgs e)

        {

            string s = tb1.Text;

            int count = 0;

            for (int i = 0; i < s.Length - 2; i++)

            {
//Проверяется знак препинания и то , чтобы после каждого предложения был пробел
                if (((s[i] == '.') || (s[i] == '?') || (s[i] == '!')) && (s[i + 1] == ' '))

                {

                    count++;

                }

            }
            // Пробел не проверяется , так как это последнее предложение
            if ((s[s.Length - 1] == '.') || (s[s.Length - 1] == '?') || (s[s.Length - 1] == '!'))

            {

                count++;

            }

            tb2.Text = $"{count}";

        }

      
    }

}