using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.AccesoDatos.Interfaz
{
    public interface IUsuarioRepository
    {
        Task<Usuarios> GetUserByName(string Usuario);
        Task<Usuarios> PutUser(string Usuario, string Contraseña, string Mail);
    }
}
