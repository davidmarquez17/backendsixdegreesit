using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal interface IGestorUsuarios
    {
        Task<List<Usuario>> GetUsuarios();
    }
}
