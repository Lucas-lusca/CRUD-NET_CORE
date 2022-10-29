using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Realizacao_Enquetes.Models;

// Presta atenção nisso aqui!!!
// Durante o desenvolvimento, troquei o .Models por .Controller, isso me gerou alguns problemas.
namespace Realizacao_Enquetes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Quando uma variavel é passada para a view e não é apenas cosmetica, isso deve ser feito pelo controller.
            ViewBag.QtdeUsuarios = Usuario.Listagem.Count();
            return View();
        }

        // Se o parametro id passado no navegador for nulo, é exibido um formulario em branco.
        // Caso contrario é exibido os dados do id passado.
        [HttpGet]
        public IActionResult Cadastrar(int? id)
        {
            // Aqui passamos os valores do Id desejado para os Inputs dessa View.
            // var usuario = Usuario.Listagem.Single(u => u.Id == 2);
            // var usuario = new Usuario();
            
            // Esse id é o passado no navegador.
            // Esse u.Id é oque temos salvo em nosso código.
            // Isso verica o ID passado pelo usuario e oque temos no nosso "banco de dados".
            if (id.HasValue && Usuario.Listagem.Any(u => u.IdUsuario == id))
            {    
                var usuario = Usuario.Listagem.Single(u => u.IdUsuario == id);
                return View(usuario);
            }
            return View();
        }


        /*
            Primeiramente é chamado o método Cadastrar com a tag [HttpGet], nossa aplicação envia a view
        processada no método. Após o usuário enviar seus dados, ele passa novamente por esse controller e pelo método
        Cadastrar, só que dessa vez é pelo [HttpPost]. Lembre disso! sempre que o usuário enviar algo para o servidor,
        isso é feito por esse caminho e pelo atributo [HttpPost].
        
        Caminho: Usuário acessa a aplicação (É executado a view Index). Usuário preciona o botão
        na view da Index (É executado o método Cadastrar com o atributo[HttpGet]). Usuário preenche
        os Iputs e envia (Ao enviar, os dados passa por esse controller novamente e pelo método Cadastrar[HttpPost]).
        */
        
        [HttpPost]
        // É precisso passa para esse método o tipo do parametro que ele ira receber quando o usuário enviar os dados.
        public IActionResult Cadastrar(Usuario usuario)
        {
            // Passando para a função salvar, os dados do usuario.
            Usuario.Salvar(usuario);

            // Redirecionado o usuario para outra View.
            return RedirectToAction("Usuarios");
        }
    
        public IActionResult Usuarios()
        {
            // É preciso passar a coleção de usuário como modelo para essa view.
            return View(Usuario.Listagem);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id.HasValue && Usuario.Listagem.Any(u => u.IdUsuario == id))
            {    
                var usuario = Usuario.Listagem.Single(u => u.IdUsuario == id);
                return View(usuario);
            }
            return View("Usuario");
        }
        
        [HttpPost]
        public IActionResult Excluir(Usuario usuario)
        {
            Usuario.Excluir(usuario.IdUsuario);
            return RedirectToAction("Usuarios");
        }

    }
}
