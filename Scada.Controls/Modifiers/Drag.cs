using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Scada.Controls.Modifiers
{
    public class Drag : Thumb
    {

        /// <summary>
        /// Initializer for DragThumb
        /// </summary>
        public Drag()
        {
            IsEnabled = true;
            base.DragDelta += DragThumb_DragDelta;
        }

        void DragThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (IsEnabled)
            {
                // Drag object here.
                Control item = this.DataContext as Control;

                if (item != null)
                {
                    double left = Canvas.GetLeft(item);
                    double top = Canvas.GetTop(item);

                    Canvas.SetLeft(item, left + e.HorizontalChange);
                    Canvas.SetTop(item, top + e.VerticalChange);
                }
                e.Handled = true;
            }
        }
    }
}