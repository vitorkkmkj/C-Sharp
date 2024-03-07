using System;
using System.Diagnostics.SymbolStore;

class PP
{
    static void Main()
    {
        string nome;

        Console.Write("Insira seu nome: ");
        nome = Console.ReadLine();



        if (nome == "pedro")
        {
            while (nome == "pedro")
            {
                string pedro;

                Console.Write("Ola pedro!");
                break;
            }
        }
        while (nome != "pedro")
        {
            string dif;
            Console.Write("Digite Novamente: ");
            dif = Console.ReadLine();
            if (dif == "pedro")
            {
                Console.Write("Ola pedro!");
                break;
            }



        }
    }

}

