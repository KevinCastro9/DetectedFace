using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidadorDeFaces.Equipamentos;

namespace ValidadorDeFaces.Pessoas
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        private Bitmap _face;

        public Bitmap Face { get { return _face; } set { this._face = value; } }

        private List<Equipamento> _equipamentos;
        public List<Equipamento> Equipamentos { get { return _equipamentos; } set { this._equipamentos = value; } }

        public Pessoa(int id, string nome, Bitmap face, List<Equipamento> equipamentos)
        {
            Id = id;
            Nome = nome;
            Face = face;
            Equipamentos = equipamentos;
        }
    }
}
