using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    class Shop
    {
        public void details(int bill, int paid)
        {
            int Balance, Fifty, Twenty,ten, five, two,one;

            Balance = paid - bill; //50-2 = 48
            //Fifty = Balance % 50; // 48
            //Twenty = Fifty % 20; //2
            //ten = Twenty % 10;
            //five = ten % 5;
            //two = five % 2;
            //one = two % 1;


            Console.WriteLine(Balance);
            int N50, N20, N10,N5, N2, N1 = 0;
            if (Balance >= 50)
            {
               N50 = Balance/50 ;
               Balance = Balance - (N50 * 50);
                Console.WriteLine("Fifties : " + N50);
            }
            if (Balance >=20)
            {
               N20 = Balance/20 ;
                Balance = Balance - (N20 * 20);
                Console.WriteLine("Twenties : " + N20);
            }
            if (Balance >= 10)
            {
                N10 = Balance / 10;
                Balance = Balance - (N10 * 10);
                Console.WriteLine("Ten : " + N10);
            }
            if (Balance >= 5)
            {
                N5 = Balance / 5;
                Balance = Balance - (N5 * 5);
                Console.WriteLine("Five : " + N5);
            }
            if (Balance >= 2)
            {
                N2 = Balance / 2;
                Balance = Balance - (N2 * 2);
                Console.WriteLine("Two : " + N2);
            }
            if (Balance >= 1)
            {
                N1 = Balance / 1;
                Balance = Balance - (N1 * 1);
                Console.WriteLine("One : " + N1);
            }




            //Console.WriteLine("Give: ");
            //if (Fifty != Balance)
            //{
            //    Console.WriteLine("Fifties = " + Fifty);
            //}
            //if (Twenty != Fifty)
            //{
            //    Console.WriteLine("Twenties " + Twenty);
            //}
            //if (ten != Twenty)
            //{
            //    Console.WriteLine("Tens = " + Fifty);
            //}
            //if (five != ten)
            //{
            //    Console.WriteLine("Fives = " + five);
            //}
            //if (two != five)
            //{
            //    Console.WriteLine("Twos  = " + two);
            //}
            //if (one != two)
            //{
            //    Console.WriteLine("Oon = " + one);
            //}
            


        }
    }
}
