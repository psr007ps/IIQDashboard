using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Media;

namespace IIQ_Dashboard.CustomButton
{
    public class ButtonTile : Button
    {
        public static readonly DependencyProperty TileImageSourceProperty = DependencyProperty.Register("TileImageSource", typeof(ImageSource), typeof(ButtonTile));
        public ImageSource TileImageSource
        {
            get
            {
                return this.GetValue(TileImageSourceProperty) as ImageSource;
            }
            set
            {
                this.SetValue(TileImageSourceProperty, value);
            }
        }
    }
}
