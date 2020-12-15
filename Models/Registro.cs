using System.ComponentModel.DataAnnotations;

namespace registro.Models
{
    public class Registro
    {
        public int Id {get;set;}
        [Required]
        public string Producto{get;set;}
        public string Foto{get;set;}
        public string Descripcion{get;set;}
        public double Precio{get;set;}
        public string Celular{get;set;}
        public string Lugar{get;set;}
        public string Usuario{get;set;}

    }
}