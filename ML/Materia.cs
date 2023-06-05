using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ML
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Creditos { get; set; }
        public decimal Costo { get; set; }
        public List<object> Materias { get; set; }
        public byte[] Imagen { get; set; }
        public ML.Semestre Semestre { get; set; }

    }
}