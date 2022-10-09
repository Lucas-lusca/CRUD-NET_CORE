using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// Presta atenção nisso aqui!!!
// Durante o desenvolvimento, troquei o .Models por .Controller, isso me gerou alguns problemas.
namespace Realizacao_Enquetes.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // 
        [HttpGet]
        public IActionResult Responder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Responder(Resposta resposta)
        {
            if(ModelState.IsValid)
            {
                // Aqui enviamos o form recebido da view e mandamos para o model.
                Repositorio.AdicionarResposta(resposta);

                // O atributo passado para a "View" é o nome o qual ira ser procurado
                // uma view dentro da pasta 'View'
                return View("Obrigado");
            }
            else
            {
                return View(resposta);
            }
        }

        public IActionResult Resultado()
        {
            // A view recebe como parametro o modelo das respostas armazenadas no repositori.
            return View(Repositorio.Respostas);
        }

    }
}
