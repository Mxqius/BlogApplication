using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlogUtility
{
    public class ConvertImage
    {
        public Image ConvertArrayToImage(byte[] picture)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(picture))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                return null;
            }
        }

        public byte[] ConvertImageToArray(Image picture)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picture.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
