using System;
namespace RevisãoOrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Jorge", 39); //aqui falo que p1 vai receber uma nova pessoa, e é aqui que instacio o objeto pessoa, o comando new é que manda criar o obejeto na memoria 
            Console.WriteLine("Os dados da pessoa p1 criada são:");
            Console.WriteLine(p1.getNome());
            Console.WriteLine(p1.getIdade());
            //p1 é o controlador do tipo da classse Pessoa com P maisculo 
            // Apenas para enteder: acima temos dois objetos o p1 e o pessoa 

            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Os dados da pessoa criada são:");
            Console.WriteLine(pessoa.getNome());
            Console.WriteLine(pessoa.getIdade());
            //com os metodos get e set pegamos o objeto pessoa, e conseguimos acessar o atributo nome dele e atribuir o nome dele 

            pessoa.setNome("Pestana");
            pessoa.setIdade(38);

            Console.WriteLine("Os dados da pessoa criada são:");
            Console.WriteLine("Nome:");
            Console.WriteLine(pessoa.getNome());
            Console.WriteLine("Idade:");
            Console.WriteLine(pessoa.getIdade());



        }

       
    }




}
 