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

namespace Scada.Controls
{
    /// <summary>
    /// Interaction logic for RedEllipse.xaml
    /// </summary>
    public partial class Tank : UserControl
    {
        public Tank()
        {
            InitializeComponent();
            Height = 300;
            Width = 250;
            Canvas.SetTop(this, 100);
            Canvas.SetLeft(this, 100);
        }
    }
}
