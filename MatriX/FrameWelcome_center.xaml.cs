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
    /// Логика взаимодействия для FrameWelcome_center.xaml
    /// </summary>
    public partial class FrameWelcome_center : Page
    {
        public FrameWelcome_center()
        {
            InitializeComponent();
        }
        public FrameWelcome_center(ApplicationСolor col)
        {
            InitializeComponent();
            GridWelcome.Background = col.BorderFields;
            TextBoxName.Foreground = col.Foreground;
        }
    }
}
