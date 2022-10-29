using System.Collections.Generic;
using System.Linq;

namespace Template_Minimo_Views_Models.Models
{
    public class Usuario
    {
        // Faça a alteração de nome utilizando F2, isso altera o nome em tosos os lugares!!!
        // Objetos da classe Usuario ira ter um Id, Nome e Email.
        public int IdUsuario {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}

        private static List<Usuario> listagem = new List<Usuario>();
        public static IQueryable<Usuario> Listagem
        {
            get
            {
                return listagem.AsQueryable();
            }
    
        }

        // Isso serve para popular nosso "banco de dados".
        static Usuario()
        {
            Usuario.listagem.Add(
                new Usuario {IdUsuario=1, Nome="Fabio", Email="fabio@email.com"});
            Usuario.listagem.Add(
                new Usuario {IdUsuario=2, Nome="Renata", Email="renata@email.com"});
            Usuario.listagem.Add(
                new Usuario {IdUsuario=3, Nome="Carlos", Email="carlos@email.com"});
            Usuario.listagem.Add(
                new Usuario {IdUsuario=4, Nome="Mariana", Email="mariana@email.com"});
            Usuario.listagem.Add(
                new Usuario {IdUsuario=5, Nome="Jorge", Email="jorge@email.com"});
        }
    
        public static void Salvar(Usuario usuario)
        {
            var usuarioExistente = Usuario.listagem.Find(u => u.IdUsuario == usuario.IdUsuario);
            if (usuarioExistente != null)
            {
                usuarioExistente.Nome = usuario.Nome;
                usuarioExistente.Email = usuario.Email;
            }
            else
            {
                int maiorId = Usuario.Listagem.Max(u => u.IdUsuario);
                usuario.IdUsuario = maiorId + 1;
                Usuario.listagem.Add(usuario);
            }
        }

        public static void Excluir(int idUsuario)
        {
            var usuarioExistente = Usuario.listagem.Find(u => u.IdUsuario == idUsuario);
            if (usuarioExistente != null)
            {
                Usuario.listagem.Remove(usuarioExistente);
            }
        }
    }
}