using System;
using System.Collections.Generic;
using System.Text;

namespace TorreDeHanoi {
    class Hanoi {
        static void Main(string[] args) {

            Hanoi h = new Hanoi();

            char inicial='1';
            char auxiliar='2';
            char final='3';

            int n;

            String a;

            Console.WriteLine("Número de discos: ");
            a = Console.ReadLine();

            n = int.Parse(a);

            Console.WriteLine("Los movimientos a realizar son: ");
            h.hanoi(n,inicial,auxiliar,final);
            
        }

        void hanoi(int n, char c, char a, char f) {

            if(n==1){

            Console.WriteLine(c + " -> " + f);

            }else{

            hanoi(n-1,c,f,a);

            Console.WriteLine(c + " -> " + f);

            hanoi(n-1,a,c,f);
            
            }
            
        }

    }

}