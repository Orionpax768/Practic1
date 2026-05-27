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

namespace Practic1
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

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Впереди планеты всей!");
            Random random = new Random();
            int change = random.Next(4);
            switch (change)
            {
                case 0:
                    MessageBox.Show("Но гордость наша, но потребность риска, но вызов судьбе, вызов в беспредельность!");
                    break;
                case 1:
                    MessageBox.Show("Тут бы мне и отойти, но во мне родилось какое-то странное ощущение, какой-то вызов судьбе, какое-то желание дать ей щелчок, выставить ей язык.");
                    break;
                case 2:
                    MessageBox.Show("Судьба не выбирает случайных. Она выбирает тех, чей внутренний свет ярче, чем её вызовы. Будь этой силой!");
                    break;
                case 3:
                    MessageBox.Show("Наша способность адаптироваться к новым обстоятельствам и принимать вызовы судьбы формирует нашу жизнь");
                    break;
            }
        }
    }
}