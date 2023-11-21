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
        public async Task<Usuarios> GetUserByName(string Usuario)
        {
            // Buscar al usuario
            Usuarios usuario = HelperDao.ObtenerInstancia().ConsultarUsuarioPorNombre("ObtenerDatosUsuario", Usuario);



            // Devolver el usuario
            //Usuarios usuario = new Usuarios();
            //usuario.Usuario = Nombre;
            //usuario.Contraseña = "123";

            return usuario;
        }
        public async Task<Usuarios> PutUser(string Usuario, string Contraseña, string Mail)
        {
            // Buscar al usuario
            Usuarios usuario = HelperDao.ObtenerInstancia().CrearUsuario("InsertarUsuario", Usuario, Contraseña, Mail);

            return usuario;
        }
    }
}
