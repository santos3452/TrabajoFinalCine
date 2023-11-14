using CineBack.AccesoDatos.Interfaz;
using CineBack.Entidades;
using CineBack.services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.services.implementaciones
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository usuarioRepository;

        public UsuarioService(IUsuarioRepository _usuarioRepository)
        {
            usuarioRepository = _usuarioRepository;
        }

        public async Task<bool> Login(Usuarios credenciales)
        {
            // Buscar al usuario por nombre de usuario en el repo.
            Usuarios usuarioEncontrado = await usuarioRepository.GetUserByName(credenciales.Usuario);

            // Comparar contra del usuario que trajo el repo con la del usuario ingresado por txt
            if(usuarioEncontrado.Contraseña == credenciales.Contraseña)
            {
                return true;
            }

            // Si no son iguales false.

            return false;
        }

    }
}
