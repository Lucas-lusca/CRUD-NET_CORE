using System.Collections.Generic;
namespace Realizacao_Enquetes.Models
{
    public static class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas { get {return respostas;}}
        public static void AdicionarResposta(Resposta resposta)
        {
            respostas.Add(resposta);
        }

        // Aqui, adicionamos alguns dados de teste.
        static Repositorio(){
            respostas.Add(new Resposta(){
                Nome = "11111", Email = "emaill111@.com", Sim = true});
            respostas.Add(new Resposta(){
                Nome = "22222", Email = "email2222@.com", Sim = true});
            respostas.Add(new Resposta(){
                Nome = "33333", Email = "email3333@.com", Sim = false});
            respostas.Add(new Resposta(){
                Nome = "44444", Email = "email4444@.com", Sim = true});
            respostas.Add(new Resposta(){
                Nome = "55555", Email = "email5555@.com", Sim = false});
        }

    }
}

//  Models seria uma parte do código que ainda não foi definida, tipo os 
// dados do usuário, se ninguém preencheu os dados, como iremos trabalhar
// com eles? ai que entra o model (Explicação TOP).

//  Aqui temos uma classe que cria uma lista para salvar os resultados.
// Listas IEnumerable não contem os métodos de manipulação presente eu uma lista comum,
// elas são bastante usadas para criar coleções pois não possuem métodos de add e remover,
// elas somente podem ser visualizadas, por isso utilizamos a função AdicionarResposta, 
// que adiciona a coleção privada de resposta(não entendi  
// como ela adiciona hehe mas sei que adiciona hehe).