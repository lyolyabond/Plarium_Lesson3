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

namespace Plarium_Lesson3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listofnumbers.Items.Clear();
            int num;// = int.Parse(tb_input.Text);

            if(!int.TryParse(tb_input.Text, out num) || int.Parse(tb_input.Text)>27 || int.Parse(tb_input.Text)<=0)
            {
                // MessageBox.Show("Повторите ввод!");
                Window1 dialog_window = new Window1();
                dialog_window.ShowDialog();
                tb_input.Text = "";
            }
            
            // Console.WriteLine("--Все трехзначные числа, сумма цифр которых равна {0}:--", num);
            for (int i = 1; i < 10; i++)//подбор первой цифрры, которая может быть в диапазоне 1-9
            {
                for (int j = 0; j < 10; j++)//подбор второй цифрры, который может быть в диапазоне 0-9
                {
                    for (int n = 0; n < 10; n++)//подбор третьей цифрры, который может быть в диапазоне 0-9
                    {
                        if (i + j + n == num)//проверка: равна ли сумма 3 цифр введённому числу
                        {
                            listofnumbers.Items.Add(string.Format("{0}{1}{2}", i, j, n));
                            // Console.WriteLine("{0}{1}{2}", a, b, c);//вывод трёхзначного числа по цифрам
                        }
                    }
                }
            }

        }

    }
}
