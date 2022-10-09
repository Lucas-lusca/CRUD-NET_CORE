// Necessário pois ele é que contem os atributos de propriedade.(Quero ver eu lembra disso kk) 
using System.ComponentModel.DataAnnotations;

namespace Realizacao_Enquetes.Models
{
    public class Resposta
    {
        // Required serve para obrigar o usuario a preencher o campo.
        [Required(ErrorMessage = "Preencha o campo Nome.")]
        public string Nome { get; set; }

        // [Required(ErrorMessage = "Preencha o campo Email.")]
        [EmailAddress(ErrorMessage = "E-mail invalido.")]
        public string Email { get; set; }
        // EmailAddress valida se o email é válido.
        
        // ErrorMassage, mostra uma mensagem de erro personalizada.
        [Required(ErrorMessage = "Responda a pergunta.")]
        public bool? Sim { get; set; }
    }
}

// Models são literalmete como modelos para nossa aplicação, utilizados para pegar.