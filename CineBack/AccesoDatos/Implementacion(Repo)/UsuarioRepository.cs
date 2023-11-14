using CineBack.AccesoDatos.Interfaz;
using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.AccesoDatos.Implementacion_Repo_
{
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// Obtiene un usuario de la bbdd por nombre.
        /// </summary>
        /// <param name="Nombre"></param>
        /// <returns>devuelve un usuario</returns>
        public async Task<Usuarios> GetUserByName(string Nombre)
        {
            // Buscar al usuario
            //DataTable dt = HelperDao.ObtenerInstancia().ConsultarUsuarioPorNombre("INGRESAR SP", Nombre);

            // Devolver el usuario
            Usuarios usuario = new Usuarios();
            usuario.Usuario = Nombre;
            usuario.Contraseña = "123";

            return usuario;
        }
    }
}
