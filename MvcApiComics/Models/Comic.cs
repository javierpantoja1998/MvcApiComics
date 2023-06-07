using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApiComics.Models
{
    
    public class Comic
    {
        public int IdComic { get; set; }
        public string Nombre { get; set; }
        public string Imagen{ get; set; }
    }
}
