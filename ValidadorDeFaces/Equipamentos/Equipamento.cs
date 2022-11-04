using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorDeFaces.Equipamentos
{
    public class Equipamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Equipamento(int id, string nome, string marca, int width, int height, int x, int y)
        {
            Id = id;
            Nome = nome;
            Marca = marca;
            Width = width;
            Height = height;
            X = x;
            Y = y;
        }
    }
}
