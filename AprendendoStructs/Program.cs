using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;                               //Super Tipo: Struct

namespace AprendendoStructs  //Struct é uma forma de criar novos tipo de dados dentro do C#, Personalizar novos tipos;
{                            //Basicamente Structs criam várias váriaveis dentro de um só local, além de variáveis podem criar funções também ! 
    class Program
    {
        struct Produto  //Criando primeira struct. // Dentro de uma Struct possui Campos e Atributos;
        {
           public string nome;            //Public serve para que todas áreas do seu código possam acessar as variáveis do seu struct;
           public float preco;
           public float peso;
           public string marca;
                                        //Struct Criada abaixo:
            public Produto(string nome, float preco, float peso, string marca) //Este é o Construtor de uma Struct;
            {
                this.nome = nome; // Variável do Atributo = (recebe) variável do Parametro; // This = acessando Atributo;
                this.preco = preco;
                this.peso = peso;
                this.marca = marca;

                Teste();
            }
           
            public void ExibirInfo()
            {
                Console.WriteLine("Struct!");
                Console.WriteLine($"Nome : { this.nome }");
                Console.WriteLine($"Preço: R${ this.preco }");
                Console.WriteLine($"Peso: { this.peso }g");
                Console.WriteLine($"Marca: { this.marca }");
            }

            public float AdicionarCupom(float porc)  //Função dentro do Struct para calcular desconto de algum Produto;
            {
                float desconto = this.preco * porc / 100f;
                return this.preco - desconto;
            }
            public void Teste()
            {
                Console.WriteLine("Novos Produtos");
            }
        }    

        static void Main(string[] args) //Exemplo para armazenar um produto sem Structs;
        {
            Produto bola = new Produto("Bola Azul",100f,450f,"Nike"); //Struct sendo utilizado; / Passando valores para uma nova variável de tipo Struct; / Cria um Objeto do tipo produto e salva dentro da variável; 

            Produto chinelo = new Produto("Comforty1.0",30f,180f,"Havainas");   //Struct funcionando;

            bola.ExibirInfo(); //Pegue os campos da variável bola e exiba no console;
            Console.WriteLine("================");
            chinelo.ExibirInfo();

            float valorFinal = bola.AdicionarCupom(50f);

            //chinelo.AdicionarCupom(15f); Outra forma com a função Desconto;

            Console.WriteLine("=================");

            Console.WriteLine($"Desconto final da bola é de: { valorFinal}$" );

            Console.ReadLine();
        }
    }
}
