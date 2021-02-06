using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ColorManager
{
    public static class Extensions
    {
        public static string ToHex(this Color color)
        {
            return color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }

        public static Image FromBase64(this string value)
        {
            using var ms = new MemoryStream(Convert.FromBase64String(value));
            return Image.FromStream(ms);
        }

        public static Bitmap CropFromCenter(this Image image, int width, int height)
        {
            var x = image.Width / 2 - width / 2;
            var y = image.Height / 2 - height / 2;

            var cropArea = new Rectangle(x, y, width, height);

            var targetImage = ((Bitmap) image).Clone(cropArea, image.PixelFormat);

            return targetImage;
        }
        
        public static string ToRgbString(this Color color) => $"{color.R}, {color.G}, {color.B}";

        public static string ToSafeFileName(this string value)
        {
            var invalidChars = Path.GetInvalidFileNameChars();
            return new string(value.Where(c => !invalidChars.Contains(c)).ToArray());
        }
    }

    public static class ListViewExtensions
    {
        public static ColorItem FindColorItem(this ListView listView, string hex) => 
            listView.Items.Cast<ColorItem>().FirstOrDefault(i => i.Color.ToHex() == hex);

        public static void AddColorItem(this ListView listView, ColorItem item)
        {
            if (!listView.SmallImageList.Images.ContainsKey(item.Hex)) {
                var img = new Bitmap(16, 16, PixelFormat.Format32bppRgb);
                using var g = Graphics.FromImage(img);
                using var brush = new SolidBrush(item.Color);
                g.FillRectangle(brush, 0, 0, 16, 16);
                
                listView.SmallImageList.Images.Add(item.Hex, img);
            }
            listView.Items.Add(item);
        }

        public static void ClearColorItems(this ListView listView)
        {
            listView.Items.Clear();
            listView.SmallImageList.Images.Clear();
        }
    }
}
