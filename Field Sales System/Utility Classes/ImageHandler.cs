using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_Sales_System.Utility_Classes
{
    public class ImageHandler
    {
        public Image resizeImage(Image image) {
            try
            {
                Rectangle destRectangle = new Rectangle(0, 0, 400, 400);
                Bitmap destImage = new Bitmap(400, 400);
                destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
                Graphics graphics = Graphics.FromImage(destImage);
                var wrapMode = new ImageAttributes();
                
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighSpeed;
                graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
                wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                graphics.DrawImage(image, destRectangle, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                graphics.Dispose();
                wrapMode.Dispose();
                return destImage;
            }
            catch (Exception e) {
                return null;
            }
           
        }

        public Image openImage(string filePath) {
            try
            {
                Image newImg =  Image.FromFile(filePath);
                return newImg;
            }
            catch (Exception e) {
                return null;
            }
            
        }

        public bool saveImage(int empId,string filePath, Image image)
        {
            try
            {
                image.Save(filePath+"/"+empId+".jpg");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }

    
}
