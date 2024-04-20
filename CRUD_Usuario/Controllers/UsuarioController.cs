using CRUD_Usuario.Models;
using CRUD_Usuario.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Usuario.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            List<ListUsuarioViewModel> lst;
            using (DBUsuarioEntities db = new DBUsuarioEntities())
            {
                lst = (from d in db.Usuarios
                       select new ListUsuarioViewModel
                       {
                           ID = d.ID,
                           Nombre = d.Nombre,
                           Correo = d.Correo,
                           Fecha_nacimiento = (DateTime)d.Fecha_nacimiento
                       }).ToList();
            }

            return View(lst);

        }
    }
}