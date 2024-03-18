using System;
using System.Diagnostics;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = "29535123p48723487597645723645";
            double sum = 0;

            for (int i = 0; i < inputString.Length; i++)  //Gå igenom alla tecken 
            {                
                var currentLetter = inputString[i]; 

                if (int.TryParse(currentLetter.ToString(), out int number)) //Ta reda på om tecknet är en siffra och i så fall spara i number
                {                    
                    string newString = inputString.Substring(i+1); //Göra en ny sträng från siffran och framåt

                    for (int j = 0; j < newString.Length; j++) //Gå igenom nya strängen för att hitta matchande siffra
                    {
                        var currentLetter2 = newString[j]; //Kontrollera var i strängen vi står

                        if(int.TryParse(currentLetter2.ToString(), out int number2)) //Kontrollera så det bara är siffror
                        {
                            if(number == number2) //Jämföra med siffran vi började på
                            {
                                string newString2 = inputString.Substring(i, j+2); //Göra en ny strängsekvens mellan matchande siffror
                                //Console.WriteLine(newString2); //Kontrollgrej som användes vid programmeringen
                                for (int k = 0; k < inputString.Length; k++)//Gå igenom strängen tecken för tecken för att kunna sätta färg
                                {
                                    if (k >= i && k <= i+j+1) //Säga åt programmet från vilken position och när den ska sluta färgsätta med annan färg
                                    {
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.White; //Övriga teckens färg
                                    }
                                    Console.Write(inputString[k]); //Utskrift till konsolen                                 
                                }
                                Console.WriteLine();
                                double numbers = double.Parse(newString2); //Konvertering till siffror för att kunna räkna med tecknen
                                sum += numbers; //Summmering av alla nya siffersekvenser i newString2
                                break;
                            }   
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                }
            }
            Console.ForegroundColor = ConsoleColor.White; //Säga åt programmet att summan inte ska vara samma färg som de nya sekvenserna
            Console.WriteLine();
            Console.WriteLine(sum);//Utskrift av summan


        }
    }
}
