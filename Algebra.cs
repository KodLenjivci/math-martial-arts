//TODO: algebra od 2 do 4 razreda je gotova treba sve proveriti i mozda dodati po nesto, ostala je algebra od 5 do 8 
//TODO: geometrija ide u drugi fajl Geometry.cs

using System;
using System.Collections;
using System.Collections.Generic;

namespace DefaultNamespace
{

    
    class Algebra
    {
        ////Medium od 2 do 4 razreda
        //ax+b=c
        //moras x da dobijes
        static string SolveEquation()
        {
            Random rand = new Random();

            //generisi random
            int a = rand.Next(1, 1000);
            int b = rand.Next(1, 1000);
            int x = rand.Next(1, 100);

            int c = a * x + b;
            

            //string sa resenjem i problemom
            return $"Pronadji x u sledećoj jednačini: {a}x + {b} = {c}\n Rešenje je {x}";

        }

        //konvertuj iz sata u minut
        //Easy od 2 do 4 razreda
        static string ConvertHoursToMinutes()
        {
            Random rand = new Random();

            int hours = rand.Next(1,24);

            return $"Konvertuj sate u minute: {hours}\n Rešenje je: {hours * 60}";
        }

        //Veci broj 
        //Easy od 2 do 4 razreda
        static string WhichNumberIsBigger(){
            Random rand = new Random();

            int a = rand.Next(1,200);
            int b = rand.Next(1,200);
            if(a == b){
                while(a == b){
                    b = rand.Next(1,200);
                    a = rand.Next(1,200);
                }
            }

            if(b > a){
                return $"Koji broj je veći{a} ili {b}\n Rešenje je: {b}";
            } else {
                return $"Koji broj je veći{a} ili {b}\n Rešenje je: {a}";
            }


            return null;
            
        }


        //Ko ima vise klikera
        //Medium od 2 do 4 razreda Medium
        static string HowMuchTheyGot(){
            Random rand = new Random();

            //100 imena
            List<string> names = new List<string>;
            {
                "Aleksandar", "Nikola", "Jovan", "Marko", "Luka", "Stefan", "Mihailo", "Vuk", "Nemanja", "Bogdan",
                "Andrej", "Petar", "Matej", "Vasilije", "Teodor", "David", "Filip", "Ivan", "Bojan", "Lazar",
                "Marko", "Dušan", "Toma", "Damjan", "Maksim", "Đorđe", "Saša", "Milan", "Radoslav", "Goran",
                "Sava", "Radovan", "Nemanja", "Jovan", "Mitar", "Stefan", "Marija", "Ana", "Jelena", "Ivana",
                "Teodora", "Tijana", "Nikolina", "Dragana", "Tamara", "Milena", "Sara", "Katarina", "Ivana", "Snežana",
                "Maja", "Nataša", "Vesna", "Jovana", "Danijela", "Ivana", "Svetlana", "Tatjana", "Dragica", "Jovana",
                "Sanja", "Maja", "Vera", "Milica", "Tatjana", "Marina", "Dijana", "Nina", "Aleksandra", "Jelena",
                "Jovana", "Marija", "Stefana", "Ivana", "Ksenija", "Simona", "Sanja", "Svetlana", "Dragana", "Mirjana",
                "Nikolina", "Ivana", "Maja", "Snežana", "Teodora", "Milica", "Maja", "Svetlana", "Radmila", "Mina",
                "Sara", "Ivana", "Tatjana", "Marina", "Ivana", "Tijana", "Jovana", "Dragana", "Simona", "Ana",
                "Danica", "Milica", "Tanja", "Lena", "Lana", "Sonja", "Ema", "Lejla", "Vera", "Ana", "Dragana", "Maja",
                "Tijana", "Teodora", "Sara", "Jovana", "Milica", "Maja", "Marija", "Anita", "Jelena", "Maja", "Katarina"
            };

            string name1 = names[rand.Next(names.Count)];

            string name2 = names[rand.Next(names.Count)];

            int a = rand.Next(1,200);
            int b = rand.Next(1,200);
            

            return $"{name1} ima {a} klikera, a {name2} {b} klikera. Koliko ukupno klikera imaju njih dvojica?, Rešenje je {a+b}"
        }


        //isto kao prethodni ali mu je dao klikere samo je oduzimanje u pitanju
        //Medium od 2 do 4 razreda Medium
        static string GivingStuffToEachOther(){
            Random rand = new Random();

            //100 imena
            List<string> names = new List<string>;
            {
                "Aleksandar", "Nikola", "Jovan", "Marko", "Luka", "Stefan", "Mihailo", "Vuk", "Nemanja", "Bogdan",
                "Andrej", "Petar", "Matej", "Vasilije", "Teodor", "David", "Filip", "Ivan", "Bojan", "Lazar",
                "Marko", "Dušan", "Toma", "Damjan", "Maksim", "Đorđe", "Saša", "Milan", "Radoslav", "Goran",
                "Sava", "Radovan", "Nemanja", "Jovan", "Mitar", "Stefan", "Marija", "Ana", "Jelena", "Ivana",
                "Teodora", "Tijana", "Nikolina", "Dragana", "Tamara", "Milena", "Sara", "Katarina", "Ivana", "Snežana",
                "Maja", "Nataša", "Vesna", "Jovana", "Danijela", "Ivana", "Svetlana", "Tatjana", "Dragica", "Jovana",
                "Sanja", "Maja", "Vera", "Milica", "Tatjana", "Marina", "Dijana", "Nina", "Aleksandra", "Jelena",
                "Jovana", "Marija", "Stefana", "Ivana", "Ksenija", "Simona", "Sanja", "Svetlana", "Dragana", "Mirjana",
                "Nikolina", "Ivana", "Maja", "Snežana", "Teodora", "Milica", "Maja", "Svetlana", "Radmila", "Mina",
                "Sara", "Ivana", "Tatjana", "Marina", "Ivana", "Tijana", "Jovana", "Dragana", "Simona", "Ana",
                "Danica", "Milica", "Tanja", "Lena", "Lana", "Sonja", "Ema", "Lejla", "Vera", "Ana", "Dragana", "Maja",
                "Tijana", "Teodora", "Sara", "Jovana", "Milica", "Maja", "Marija", "Anita", "Jelena", "Maja", "Katarina"
            };

            string name1 = names[rand.Next(names.Count)];

            string name2 = names[rand.Next(names.Count)];

            int a = rand.Next(1,100);
            int b = rand.Next(a,200);
            int c = rand.Next(0,a)
            

            return $"{name1} ima {a} klikera, a {name2} {b} klikera. {name1} je poklonio {c} klikera. Koliko mu je ostalo {name1} klikera?, Rešenje je: {b-c}"
        }


        //Izracunaj izraz
        //Medium od 2 do 4 razreda
        static string CalculateTheExpression(){
            Random rand = new Random();
            int a = rand.Next(1, 200);
            int b = rand.Next(1, 200);
            int c = rand.Next(1, 200);

    
            int result;
            string expression;

    
            if (rand.Next(0, 2) == 0) 
            {
                result = a + b - c;  
                expression = $"{a} + {b} - {c}";
            }
            else
            {
            
            if (a - b < 0)
            {
                result = a + b - c;
                expression = $"{a} + {b} - {c}";
            }
            else
            {
                result = a - b + c;
                expression = $"{a} - {b} + {c}";
            }
            }

        return $"Izraz: {expression}, Rešenje je: {result}";
    }

        //racunanje samo za 3 razred skole 
        //medium
        static string CalculateTheExpressionForThirdGrade()
        {
            Random rand = new Random();
            int a = rand.Next(1, 200);
            int b = rand.Next(1, 200);
            int c = rand.Next(1, 200);

            int result;
            string expression;

    
            int operation = rand.Next(0, 3);  

            if (operation == 0) 
            {
        
                if (rand.Next(0, 2) == 0) 
                {
                    result = a + b - c;  
                    expression = $"{a} + {b} - {c}";
                }
                else
                {
                    if (a - b < 0)
                    {
                        result = a + b - c;
                        expression = $"{a} + {b} - {c}";
                    }
                    else
                    {
                        result = a - b + c;
                        expression = $"{a} - {b} + {c}";
                    }
                }
            }
            else
            {
        
                result = a * b;
                expression = $"{a} * {b}";

        
                if (result < 0)
                {
                    result = Math.Abs(result);  
                }
            }

            return $"Izraz: {expression}, Rešenje je: {result}";
        }



        //easy od 2 do 4 razreda
        //koji broj nedostaje
        static string MissingNumber(){
            int a = rand.Next(1, 200);
            int b = b-1;
            int c = a+1;

            return $"Koji broj nedostaje {b} _ {c}, Rešenje je: {a}"
        }

        //easy od 2 do 4 razreda
        //konvertuj metre u centimetre
        static string ConvertMeterToCentimetre(){
            int a = rand.Next(1,1000);

            return $"Koliko centimetara je {a} metara? Rešenje je: {a*100}"
        }

        //easy od 2 do 4 razreda
        //konvertuj metre u milimetre
        static string ConvertMeterToMilimetre(){
            int a = rand.Next(1,1000);

            return $"Koliko milimetara je {a} metara? Rešenje je: {a*1000}"
        }

        //easy od 2 do 4 razreda
        //konvertuj metre u decimetar
        static string ConvertMeterToDecimetre(){
            int a = rand.Next(1,1000);

            return $"Koliko decimetara je {a} metara? Rešenje je: {a*10}"
        }




    
    }

    /*class Program
    {
        static void Main(string[] args)
        {
            string rez = WhoGotMore();
            Console.WriteLine(rezultat);


        }
    }*/
}
