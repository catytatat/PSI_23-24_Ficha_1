using System;

namespace BolasColoridas
{
    class Program 
    {
        static void Main(StringComparer[] args)
        {
            Cor aa = new Cor(25, 37, 41);
            Cor bb = new Cor(27, 41, 53);
            Cor cc = new Cor(8, 24, 35);
            Cor dd = new Cor(12, 55, 43);
            Cor vv = new Cor(2, 5, 34);

            Bola a = new Bola(2, aa);
            Bola b = new Bola(35, bb);
            Bola c = new Bola(12, cc);
            Bola d = new Bola(6, dd);
            Bola v = new Bola(9, vv);

            Console.WriteLine("A bola A foi atirada. ");
            a.Atirar();
            Console.WriteLine("A bola B foi atirada. ");
            b.Atirar();
            Console.WriteLine("A bola C foi atirada. ");
            c.Atirar();
            Console.WriteLine("A bola D foi atirada. ");
            d.Atirar();
            Console.WriteLine("A bola V foi atirada. ");
            v.Atirar();

            Console.WriteLine("A bola A foi rebentada. ");
            a.Pop();
            Console.WriteLine("A bola B foi rebentada. ");
            b.Pop();
            Console.WriteLine("A bola C foi rebentada. ");
            c.Pop();
            Console.WriteLine("A bola D foi rebentada. ");
            d.Pop();
            Console.WriteLine("");

            Console.WriteLine("A bola A tem: ");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {aa.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {aa.GetGreen()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {aa.GetBlue()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {a.GetRaio()}");
            Console.WriteLine("");
            Console.WriteLine($"Número de vezes que bola A foi atirada: {a.NVezes()}");
            Console.WriteLine("");
            Console.WriteLine("A bola B tem: ");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {bb.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {bb.GetGreen()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {bb.GetBlue()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {b.GetRaio()}");
            Console.WriteLine("");
            Console.WriteLine($"Número de vezes que bola B foi atirada: {b.NVezes()}");
            Console.WriteLine("");
            Console.WriteLine("A bola C tem: ");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {cc.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {cc.GetGreen()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {cc.GetBlue()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {c.GetRaio()}");
            Console.WriteLine("");
            Console.WriteLine($"Número de vezes que bola C foi atirada: {c.NVezes()}");
            Console.WriteLine("");
            Console.WriteLine("A bola D tem: ");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {dd.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {dd.GetGreen()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {dd.GetBlue()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {d.GetRaio()}");
            Console.WriteLine("");
            Console.WriteLine($"Número de vezes que bola D foi atirada: {d.NVezes()}");
            Console.WriteLine("");
            Console.WriteLine("A bola V tem: ");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de vermelho: {vv.GetRed()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de verde: {vv.GetGreen()}");
            Console.WriteLine("");
            Console.WriteLine($"Quantidade de azul: {vv.GetBlue()}");
            Console.WriteLine("");
            Console.WriteLine($"Raio: {v.GetRaio()}");
            Console.WriteLine("");
            Console.WriteLine($"Número de vezes que bola V foi atirada: {v.NVezes()}");
            Console.WriteLine("");

        }
     }
       
       
}

         

        
    

    

        



    
    

