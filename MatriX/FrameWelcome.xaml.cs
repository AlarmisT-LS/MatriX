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
    /// Логика взаимодействия для FrameWelcome.xaml
    /// </summary>
    public partial class FrameWelcome : Page
    {
        public FrameWelcome()
        {
            InitializeComponent();
        }
        public FrameWelcome(ApplicationСolor col)
        {
            InitializeComponent();
            FrameWelcome_s.Background = col.BorderFields;
            TextBox1.Foreground = col.Foreground;
        }


        
    }
}
