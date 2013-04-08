using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Scada.Controls.Modifiers
{
    public class ResizeThumb : Thumb
    {

        /// <summary>
        /// Initializer for ResizeThumb
        /// </summary>
        public ResizeThumb()
        {
            IsEnabled = true;
            DragDelta += ResizeThumb_DragDelta;
        }

        void ResizeThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if (IsEnabled)
            {
                Control item = this.DataContext as Control;

                if (item != null)
                {
                    double deltaVertical, deltaHorizontal;

                    switch (VerticalAlignment)
                    {
                        case VerticalAlignment.Bottom:
                            deltaVertical = Math.Min(-e.VerticalChange, item.ActualHeight - item.MinHeight);
                            item.Height -= deltaVertical;
                            break;

                        case VerticalAlignment.Top:
                            deltaVertical = Math.Min(e.VerticalChange, item.ActualHeight - item.MinHeight);
                            Canvas.SetTop(item, Canvas.GetTop(item) + deltaVertical);
                            item.Height -= deltaVertical;
                            break;

                        default:
                            break;
                    }

                    switch (HorizontalAlignment)
                    {
                        case HorizontalAlignment.Left:
                            deltaHorizontal = Math.Min(e.HorizontalChange, item.ActualWidth - item.MinWidth);
                            Canvas.SetLeft(item, Canvas.GetLeft(item) + deltaHorizontal);
                            item.Width -= deltaHorizontal;
                            break;
                        case HorizontalAlignment.Right:
                            deltaHorizontal = Math.Min(-e.HorizontalChange, item.ActualWidth - item.MinWidth);
                            item.Width -= deltaHorizontal;
                            break;
                        default:
                            break;
                    }

                }
                e.Handled = true;
            }
        }
    }
}
