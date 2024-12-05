//TODO: ostala je algebra od 5 do 8 


using System;
using System.Collections;
using System.Collections.Generic;

namespace DefaultNamespace
{

    
    class Algebra
    {

        static Random rand = new Random();
        
        //hard od 2 do 4 razreda
        static string FuelStationTask()
        {   
            int cars = rand.Next(800, 1000); 
            int pump12 = rand.Next(400, cars - 200); //prva i druga pumpa
            int pump23 = rand.Next(400, cars - 200); //druga i treca pumpa

            //koliko automobila ima na svakoj pumpi
            int pump2 = pump12 + pump23 - cars;
            int pump1 = pump12 - pump2;
            int pump3 = pump23 - pump2;

            return $"Na tri pumpe danas je gorivo tocilo ukupno {cars} automobila. Na prvoj i drugoj pumpi je bilo {pump12} automobila, a na drugoj i trećoj {pump23}. Broj automobila na svakoj pumpi je: prva pumpa - {pump1}, druga pumpa - {pump2}, treća pumpa - {pump3}.";
        }

        
        //2 razred easy
        //saberi 3 broja
        static string SumThreeNumbers()
        {
    

            int a = rand.Next(1, 100); 
            int b = rand.Next(1, 100); 
            int c = rand.Next(1, 100); 

            int result = a + b + c;

            return $"Saberi sledeće brojeve {a}, {b} i {c}. Rešenje je: {result}.";
        }
    


        ////Medium od 2 do 4 razreda
        //ax+b=c
        //moras x da dobijes
        static string SolveEquation()
        {
            

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
            

            int hours = rand.Next(1,24);

            return $"Konvertuj sate u minute: {hours}\n Rešenje je: {hours * 60}";
        }

        //Veci broj 
        //Easy od 2 do 4 razreda
        static string WhichNumberIsBigger(){
            

            int a = rand.Next(1,200);
            int b = rand.Next(1,200);
            if(a == b){
                while(a == b){
                    b = rand.Next(1,200);
                    a = rand.Next(1,200);
                }
            }

            if(b > a){
                return $"Koji broj je veći {a} ili {b}?  Rešenje je: {b}";
            } else {
                return $"Koji broj je veći {a} ili {b}?  Rešenje je: {a}";
            }


            return null;
            
        }


        //Ko ima vise klikera
        //Medium od 2 do 4 razreda Medium
        static string HowMuchTheyGot(){
            
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
            int c = rand.Next(0,a);
            
            
            return $"{name1} ima {a} klikera, poklonio je {c} klikera. Koliko mu je ostalo? Rešenje je: {a - c}";
        }


        //Izracunaj izraz
        //Medium od 2 do 4 razreda
        static string CalculateTheExpression(){
            
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
        //hard od 3 do 4
        static string CalculateTheExpressionForThirdGrade()
        {
            
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
            int b = a-1;
            int c = a+1;

            return $"Koji broj nedostaje {b} _ {c}, Rešenje je: {a}"
        }

        //glavna metoda za konvertovanje metara u druge jedinice
        //easy od 2 do 4 razreda
        static string ConvertUnits(string unit, int factor)
        {
            
            int meters = rand.Next(1, 1000); 

            int result = meters * factor; 
            return $"Koliko {unit} je {meters} metara? Rešenje je: {result}";
        }

        //wrapper metode za konvertovanje jedinica
        //centimetre
        static string ConvertMeterToCentimetre()
        {
            return ConvertUnits("centimetara", 100); 
        }
        //milimetre
        static string ConvertMeterToMilimetre()
        {
            return ConvertUnits("milimetara", 1000); 
        }
        //decimetre
        static string ConvertMeterToDecimetre()
        {
            return ConvertUnits("decimetara", 10); 
        }


        

    
    }
}