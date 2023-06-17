using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;
using Negocio;

namespace CRUD.Controllers
{
    public class UsuariosController : Controller
    {

        private readonly GestorUsuarios _gestorUsuarios;

        public UsuariosController(GestorUsuarios gestorUsuarios)
        {
            _gestorUsuarios = gestorUsuarios;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
              return _gestorUsuarios != null ? 
                          Ok(await _gestorUsuarios.GetUsuarios()) :
                          Problem("Error al obtener los usuarios");
        }
    }
}
