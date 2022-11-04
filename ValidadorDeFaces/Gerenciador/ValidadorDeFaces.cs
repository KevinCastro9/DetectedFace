using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;

namespace ValidadorDeFaces.Gerenciador
{
    public class ValidadorDeFaces
    {
        //Criando a variavel do arquivo de treinamento para validar as fotos
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier(@"C:\Users\kevin\Desktop\PROJETOS\C#\Projeto Exemplo - Detectar e validar faces\ValidadorDeFaces\ValidadorDeFaces\Treinamento\haarcascade_frontalface_alt.xml");


        //metodo para verificar se existe um rosto na imagem, só retorna true caso tenha apenas 1 rosto na imagem
        public bool VerificaRosto(Bitmap btm)
        {
            Bitmap bitmap = (Bitmap)btm.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, Byte>(bitmap);

            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 10);

            if (rectangles.Count() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Metodo para retornar a imagem cortada com apenas o rosto da pessoa, o tamanho da imagem cortada esta em 100x100 caso queira alterar
        //o tamanho apenas trocar no momento de chamar o metodo resizeImage
        public Bitmap RetornaImagemFOTO(Bitmap btm, Image caminhoSalvaImagem, int w, int x, int t1, int t2)
        {

            Bitmap bitmap = (Bitmap)btm.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, Byte>(bitmap);
            Image retornoImagem = null;
            Bitmap imgbitmap = null;

            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 10, new Size(2, 2));

            Image[] bit = new Image[rectangles.Count()];
            foreach (var rectangle in rectangles)
            {
                if (rectangles.Count() == 1)
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using (Pen pen = new Pen(Color.Red, 1))
                        {
                            graphics.DrawRectangle(pen, rectangle);

                            if (rectangles[0].Y - t2 <= 0)
                            {
                                t2 = rectangles[0].Y;
                            }
                            if (rectangles[0].Height + t1 > bitmap.Height)
                            {
                                t1 = bitmap.Height - rectangles[0].Height;
                            }

                            retornoImagem = Crop(caminhoSalvaImagem, rectangles[0].Width + w, rectangles[0].Height + t1, rectangles[0].X - x, rectangles[0].Y - t2); //height = tamanho pra baixo // y = tamanho pra cima

                            imgbitmap = new Bitmap(retornoImagem);
                        }
                    }
                }
            }
            return imgbitmap;
        }

        //metodo para fazer o retangulo em volta do rosto na imagem
        public Bitmap DesenhaRostoFOTO(Bitmap btm)
        {

            Bitmap bitmap = (Bitmap)btm.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, Byte>(bitmap);

            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 10);

            Image[] bit = new Image[rectangles.Count()];
            foreach (var rectangle in rectangles)
            {
                if (rectangles.Count() == 1)
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using (Pen pen = new Pen(Color.Red, 1))
                        {
                            graphics.DrawRectangle(pen, rectangle);
                        }
                    }
                }
            }
            return bitmap;
        }

        //metodo para reajustar o tamanho da imagem
        public Image ResizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        //metodo para cortar a imagem
        public Image Crop(Image image, int width, int height, int x, int y)
        {
            try
            {
                Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                bmp.SetResolution(80, 60);
                Graphics gfx = Graphics.FromImage(bmp);
                gfx.SmoothingMode = SmoothingMode.AntiAlias;
                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gfx.DrawImage(image, new Rectangle(0, 0, width, height), x, y, width, height, GraphicsUnit.Pixel);

                return bmp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
