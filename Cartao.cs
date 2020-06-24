namespace Aula23
{
    public class Cartao
    {
        public string titular { get; set; }
        public int numero { get; set; } 
        public string bandeira { get; set; }
        public string vencimento { get; set; }  
        public string cvv { get; set; } 
                    
                        // Tudo dentro desses parenteses abaixos sao argumentos;
        public Cartao(string _titular,int _numero,string _bandeira,string _vencimento,string _cvv){
                                // ^^^^^^ aqui passamos que o parametro numero
                                // é do tipo int e assim vai...
                
            //aaah tendeu
            // Isso aqui se chama metodo construtor
            // Ele é uma coisa em Programaçao Orientada a objeto que nos ajuda a escrever menos codigos
            // Ele recebe os parametros/argumento
            // Depois manipula esses argumentos dando valor as variaveis dessa classe
            // Isso nos ajuda a construir um sistema facil de se manusear e de mudar algumas coisas
            
            
            titular=_titular;
            numero=_numero;
            bandeira=_bandeira;
            vencimento=_vencimento;
            cvv=_cvv;

        }
    }
}