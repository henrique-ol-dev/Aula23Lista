using System;
using System.Collections.Generic;
//Nesta atividade faça o mesmo exemplo dado em aula, incrementando com uma classe Cartao, com seus devidos métodos construtores e atributos: titular, numero, bandeira, vencimento e cvv;
// Crie uma lista de cartões no Program.cs, utilize foreach para mostrar para o usuário os cartões instanciados 
namespace Aula23
{
    class Program
    {
        // cria um Cartao.cs
        static void Main(string[] args)
        {
            // Isso aqui serve pra instanciar listas , ou seja , fala pro
            // programa que nos vamos fazer listas de coisas
            // a sintaxe é essa = List<Nome da classe> nomequalquer = new List<Nome da classe > ();
            // 
            List<Cartao> cartao = new List<Cartao>();

            // Dentro do nosso Cartao.cs temos o metodo Cartao(); 
            // Ele recebe os parametros que nos colocarmos por exemplo;
            // Ele modifica os dados pelo construtor la porem nao vamos conseguir ver nada por enquanto
            // Como estamos trabalhando com listas eu vou adicionar nosso primeiro cartao

            
            
            cartao.Add(new Cartao("Henrique",6595,"VISA","30/05/2020","553"));

                                // Titular,numero,band,dataVencimento,cvv
            cartao.Add(new Cartao("Barbosa",2525,"ELO","25/05/2020","552"));

            // Criamos uma lista com dois cartoes
            // O meu e o seu
            // Agora para nos vermos ele vamos usar o metodo foreach
            // foreach significa "Para (cadaItem in algumaCoisa){
            //     executar oq tiver aqui
            
            foreach (var item in cartao)
            {
                
                Console.WriteLine("Nome:.........{0,15}",item.titular);
                Console.WriteLine("Numero:.......{0,15}",item.numero);
                Console.WriteLine("Bandeira:.....{0,15}",item.bandeira);
                Console.WriteLine("Vencimento:...{0,15}",item.vencimento);
                Console.WriteLine("cvv:..........{0,15}\n",item.cvv);
            }

           //dotnet e deu ceerto
            
        }
    }
}
