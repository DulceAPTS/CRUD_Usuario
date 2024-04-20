using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Usuario.Models.ViewModels
{
    public class ListUsuarioViewModel
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
    }
}