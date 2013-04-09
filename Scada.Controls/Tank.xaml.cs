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

        #region Properties
        /// <summary>
        /// Gets or sets the Background Brush for the tank.
        /// </summary>
        public Brush TankBackgroundColor
        {
            get { return TankDrawing.Fill; }
            set { TankDrawing.Fill = value; }
        }

        /// <summary>
        /// Gets or sets the Stroke Brush for the tank.
        /// </summary>
        public Brush TankStrokeColor
        {
            get { return TankDrawing.Stroke; }
            set { TankDrawing.Stroke = value; }
        }

        /// <summary>
        /// Gets or sets the StrokeThickness for the tank
        /// </summary>
        public double TankStrokeThickness
        {
            get { return TankDrawing.StrokeThickness; }
            set { TankDrawing.StrokeThickness = value; }
        }

        /// <summary>
        /// Indicates whether or not the TankGradient is visible;
        /// </summary>
        public bool IsTankGradientVisible
        {
            get { return TankGradient.IsVisible; }
            set { TankGradient.Visibility = value ? Visibility.Visible : Visibility.Collapsed;}
        }
        #endregion

        public Tank()
        {
            InitializeComponent();
            Height = 300;
            Width = 250;
            Canvas.SetTop(this, 100);
            Canvas.SetLeft(this, 100);

            // Default Colors
            TankBackgroundColor = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF797979"));
            TankStrokeColor = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FF1F1F1F"));
            TankStrokeThickness = 2.0;
            IsTankGradientVisible = true;

            TankFill.Minimum = 0;
            TankFill.Maximum = 100;
            TankFill.Value = 1;

            // Water - #FFE6E6E6
            // Oil - #FF1F1F1F
        }

        private void UserControl_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            if (TankFill.Value != 100) { TankFill.Value += TankFill.Maximum / 10; } else { TankFill.Value = 0; }
            System.Diagnostics.Debug.WriteLine(TankFill.Value);

        }

    }
}
