using System.ComponentModel.DataAnnotations;

namespace MedrandaGarciaGabrielApi.Model
{
    public class User
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }

        public string clave { get; set; }

        public Boolean estado { get; set; }

        public int GeneroId { get; set; }

        public Genero Genero{ get; set;}
        
    }
}
