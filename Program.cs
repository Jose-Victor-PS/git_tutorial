using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        //Enum Deve ser declarado no escopo da classe, e fora dos metodos
        enum Estado { Running, Stopped, Migrating, Error }
        static void Main(string[] args)
        {
            const String greetings = "CONTAGEM DE LEGAL NO FOR LOOP... ";
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(greetings + i);
            }

            Console.WriteLine("Digite um numero Maneiro de Entrada: ");
            int entrada = Convert.ToInt32(Console.ReadLine());

            if (entrada > 10)
            {
                Console.WriteLine("Seu numero " + entrada + " eh maior do que 10");
            }
            else if (entrada <= 10 || entrada >= 0)
            {
                Console.WriteLine("Seu numero " + entrada + " esta entre 0 e 10");
            }
            else
            {
                Console.WriteLine("Seu numero " + entrada + " eh negativo");
            }

            int j = 1;
            A:
                Console.WriteLine("Increasing count... " + j);
                j++;
            const int compr = 10;
            if (j - compr <= 0)
            {
                goto A;
            }

            Produto[] produtos = new Produto[] {
                new Produto(19.99f, "Mouse Maneiro"),
                new Produto(69.99f, "Teclado Maneiro"),
                new Produto(119.99f, "Monitor Maneiro")
            };
            foreach (Produto prod in produtos) {
                prod.exibeAttrs();
            }

            List<Produto> lista_produtos = new List<Produto>();
            lista_produtos.Add(new Produto(99.99f, "Gabinete Maneiro"));
            lista_produtos.Add(new Produto(39.99f, "Livro Maneiro"));
            lista_produtos.Add(new Produto(159.99f, "Jogo Maneiro"));
            lista_produtos.RemoveAt(1);
            int k = 0;
            while (k < 2)
            {
                lista_produtos.ElementAt(k).exibeAttrs();
                k++;
            } 

            
            Estado estate = Estado.Running;

            switch(estate)
            {
                case Estado.Running:
                    Console.WriteLine("O Container esta executando");
                    break;
                case Estado.Stopped:
                    Console.WriteLine("O Container esta parado");
                    break;
                case Estado.Migrating:
                    Console.WriteLine("O Container esta migrando");
                    break;
                case Estado.Error:
                    Console.WriteLine("O Container deu erro");
                    break;
            }

            Debugger.Break(); //Mantem o terminal aberto para depuracao
            /*
             * Comentario Multi-Linha
             */
        }
    }

    class Produto
    {
        float preco;
        String nome;

        public Produto(float p, String n)
        {
            this.preco = p;
            this.nome = n;
        }

        public void  exibeAttrs()
        {
            Console.WriteLine("Este produto se chama: " + this.nome + "\nCujo preco eh: " + this.preco);
        }
    }
}
