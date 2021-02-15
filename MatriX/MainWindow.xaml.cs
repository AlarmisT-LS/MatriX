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

namespace MatriX
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Colortopic = new ApplicationСolor();
            //Colortopic.ButtonColor = new SolidColorBrush(Color.FromArgb(255, 0x6c, 0x00, 0xb5)); //Цвет кнопки
            Colortopic.Shadow = Color.FromArgb(255, 0x6c, 0x00, 0xb5); //Цвет теней
            Colortopic.BorderFields = new SolidColorBrush(Color.FromArgb(255, 0x47, 0x47, 0x47)); //Цвет Border
            Colortopic.Foreground = new SolidColorBrush(Color.FromArgb(255, 0xff, 0xff, 0xff)); // Цвет текста
            FillingFlowers();
        }
        public ApplicationСolor Colortopic { get; set; }

        private void Button_Welcome_Click(object sender, RoutedEventArgs e)
        {
            MainFrameTop.Content = new FrameWelcome(Colortopic);
            MainFrameCenter.Content = new FrameWelcome_center(Colortopic);
        }
        private void Button_Adding_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Products_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Admission_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Shipment_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Graph_Click(object sender, RoutedEventArgs e)
        {

        }

        //Заполнение цветов
        private void FillingFlowers()
        {
            //Цвет кнопок
            //TODO Если захочу изменить цвет кнопок
            //buttonWelcome.Background = Colortopic.ButtonColor;
            //buttonAdding.Background = Colortopic.ButtonColor;
            //buttonAdmission.Background = Colortopic.ButtonColor;
            //buttonShipment.Background = Colortopic.ButtonColor;
            //buttonGraph.Background = Colortopic.ButtonColor;

            //Цвет теней
            DropShadowLeftMenu.Color = Colortopic.Shadow;
            DropShadowTopMenu.Color = Colortopic.Shadow;
            DropShadowCenterMenu.Color = Colortopic.Shadow;

            //Цвет окна Window------------
            GridMainWindow.Background = new SolidColorBrush(Color.FromArgb(255, 0x2e, 0x2e, 0x2e));

            //Цвета Border от кнопок
            BorderLeft.Background = Colortopic.BorderFields;

            //BorderTop & Frame
            BorderTop.Background = Colortopic.BorderFields;
            MainFrameTop.Background = Colortopic.BorderFields;

            //BorderCenter & Frame
            BorderCenter.Background = Colortopic.BorderFields;
            MainFrameCenter.Background = Colortopic.BorderFields;
        }

    }
}
