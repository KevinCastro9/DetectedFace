using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidadorDeFaces.Equipamentos;

namespace ValidadorDeFaces.Gerenciador
{
    public class GerenciadorDoValidadorDeFaces
    {
        public Bitmap Gerenciador(Bitmap bmp, Image image, Equipamento equipamento)
        {
            try
            {
                ValidadorDeFaces validadorDeFaces = new ValidadorDeFaces();

                bool verificaFace = validadorDeFaces.VerificaRosto(bmp);

                if (verificaFace == true)
                {
                    Bitmap imagemFaceAjustada = validadorDeFaces.RetornaImagemFOTO(bmp, image, equipamento.Width, equipamento.X, equipamento.Height, equipamento.Y);

                    return imagemFaceAjustada;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
