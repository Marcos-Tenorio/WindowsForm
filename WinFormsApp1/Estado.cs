using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Estado
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Estado(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public static List<Estado> Lista()
        {
            var lista = new List<Estado>();
            var e1 = new Estado(1, "SP");
            var e2 = new Estado(2, "RJ");
            var e3 = new Estado(3, "PE");
            var e4 = new Estado(4, "BH");
            lista.AddRange(new List<Estado> { e1, e2, e3, e4 });
            return lista;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
