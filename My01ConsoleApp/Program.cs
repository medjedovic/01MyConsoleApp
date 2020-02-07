using System;
namespace My01ConsoleApp
{
    class Program//ista boja kao i console tj. označava klasu
    {
        static void Main(string[] args)//main je iste boje kao i writeline, označava klasu
        {
            Console.WriteLine("Esselamu alejkum!");

            //Promenljive - jako tipiziran jezik

            /*
             * INTEGER CELOBROJNE VRIJEDNOSTI
             */
            //int intNum;
            //intNum = 10;

            int intNum = 10;
            intNum = 12;

            int x = 5;

            Console.WriteLine("Prvi ceo broj, je =", intNum);
            Console.WriteLine("Drugi ceo broj, je =", x);
            Console.WriteLine("Prvi ceo broj" + intNum + "Drugi ceo broj, je =", x);

            byte Bajt = 255; //ne može biti negativan, zauzima 8bita
            sbyte sBajt = -128; //može biti negativan ali je duplo manji od byte i zauzima 8bita

            Console.WriteLine("Max i min za int:");
            Console.WriteLine("Max za int:"+ int.MaxValue);//2.147.483.647
            Console.WriteLine("Min za int:" + int.MinValue);//-2.147.483.647

            Console.WriteLine("Max za uint:" + uint.MaxValue);//4.294.967.295
            Console.WriteLine("Min za uint:" + uint.MinValue);//0

            Console.WriteLine("Max za long:" + long.MaxValue);// 9.223.372.036.854.775.807
            Console.WriteLine("Min za long:" + long.MinValue);//-9.223.372.036.854.775.808

            /*
             * DOUBLE BROJEVI SA OSTATKOM
             */

            float Prvi = 4.56f;//float Prvi = (float)4.56;
            double Drugi = 3.45;
            decimal Treci = 1.54m;//decimal Treci = (decimal)1.54;
            Console.WriteLine("float veličina:" + sizeof(float)); //4 bajta 
            Console.WriteLine("double veličina:" + sizeof(double));// 8
            Console.WriteLine("decimal veličina:" + sizeof(decimal));// 16
            Console.WriteLine("long veličina:" + sizeof(long));// 8

            /*
             * BOOL LOGIČKI TIP PODATKA
             */

            bool Logicki = true;

            /*
             * STRING TIP PODATKA, NIZ KARAKTERA
             */
            string NizKaraktera = "Esselamu alejkum";

            /*
             * CHAR TIP PODATKA, JEDAN KARAKTER
             */
            char JedanKaraktera = 'A';


            //Ovo je jednolinijski komentar

            /*
			 *	Ovo je višelinijski komentar
			 * 
			 * 
			 */


            Console.ReadKey();
        }
    }
}