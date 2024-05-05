using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisãoOrientacaoObjetos
{
    internal class Pessoa
    {
        string nome;  
        int idade;

        public Pessoa()
        {
            nome = "John Doe";
            idade = 0;
            Console.WriteLine("Classe criou a pessoa:");
        }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
         
        public void setNome(string nome)//metodo de atribuiçao para o nome
        {
            this.nome = nome;
        } 

        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        
        public string getNome()
        {
            return nome;
        }
        public int getIdade()
        {
            return idade;
        }
    }
}
