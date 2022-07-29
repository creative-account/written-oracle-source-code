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

namespace written_oracle
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var rand = new Random();
            int value = rand.Next(minValue: 0, maxValue: 7);
            Console.WriteLine($"{value}");
            switch (value)
            {
                case 0:
                    大吉 dai_kichi = new 大吉();
                    dai_kichi.Show();
                    break;
                case 1:
                    中吉 chuu_kichi = new 中吉();
                    chuu_kichi.Show();
                    break;
                case 2:
                    吉 kichi = new 吉();
                    kichi.Show();
                    break;
                case 3:
                    末吉 sue_kichi = new 末吉();
                    sue_kichi.Show();
                    break;
                case 4:
                    小吉 shou_kichi = new 小吉();
                    shou_kichi.Show();
                    break;
                case 5:
                    大凶 dai_kyou = new 大凶();
                    dai_kyou.Show();
                    break;
                case 6:
                    凶 kyou = new 凶();
                    kyou.Show();
                    break;

            }
        }
    }
}
