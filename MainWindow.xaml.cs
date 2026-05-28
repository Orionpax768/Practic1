using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            MessageBox.Show("Впереди планеты всей!", "Полностью готов!", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            string txt1 = txtBox1.Text.Trim();
            string txt2 = txtBox2.Text.Trim();
            if (String.IsNullOrEmpty(txt1.ToString()) && String.IsNullOrEmpty(txt2.ToString()))
            {
                MessageBox.Show("Оба поля не заполнены", "Сообщение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
            if (!String.IsNullOrEmpty(txt1.ToString()))
            {
                MessageBox.Show($"Вызов №1:{txt1}", "Вызов принят!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            if (!String.IsNullOrEmpty(txt2.ToString()))
            {
                MessageBox.Show($"Вызов №2:{txt2}", "Вызов принят!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            Random random = new Random();
            int change = random.Next(4);
            switch (change)
            {
                case 0:
                    MessageBox.Show("Но гордость наша, но потребность риска, но вызов судьбе, вызов в беспредельность!", "Цитата№1", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 1:
                    MessageBox.Show("Тут бы мне и отойти, но во мне родилось какое-то странное ощущение, какой-то вызов судьбе, какое-то желание дать ей щелчок, выставить ей язык.", "Цитата №2", 
                        MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 2:
                    MessageBox.Show("Судьба не выбирает случайных. Она выбирает тех, чей внутренний свет ярче, чем её вызовы. Будь этой силой!", "Цитата №3", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case 3:
                    MessageBox.Show("Наша способность адаптироваться к новым обстоятельствам и принимать вызовы судьбы формирует нашу жизнь", "Цитата №4", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
            }
        }
    }
}