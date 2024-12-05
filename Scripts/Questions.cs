using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Questions : MonoBehaviour
{
    public TextMeshProUGUI question;




   
    //2 razred easy
    //saberi 3 broja
    public string SumThreeNumbers(int a,int b,int c)
    {
        int result = a + b + c;

        return $"Saberi sledeće brojeve {a}, {b} i {c}.";
    }



    ////Medium od 2 do 4 razreda
    //ax+b=c
    //moras x da dobijes
    public string SolveEquation(int a,int b,int x)
    {


        //generisi random
        
        int c = a * x + b;


        //string sa resenjem i problemom
        return $"Pronadji x u sledećoj jednačini: {a}x + {b} = {c}";

    }

    //konvertuj iz sata u minut
    //Easy od 2 do 4 razreda
    public string ConvertHoursToMinutes(int hours)
    {



        return $"Konvertuj sate u minute: {hours}";
    }

    //Veci broj 
    //Easy od 2 do 4 razreda
    public string WhichNumberIsBigger(int a,int b)
    {

        return $"Koji broj je veći {a} ili {b}?";

       
    }


    //Ko ima vise klikera
    //Medium od 2 do 4 razreda Medium
    public string HowMuchTheyGot(int a,int b)
    {

        //100 imena
        List<string> names = new List<string>
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

        string name1 = names[Random.Range(0,names.Count)];

        string name2 = names[Random.Range(0,names.Count)];

       

        return $"{name1} ima {a} klikera, a {name2} {b} klikera. " + "\n" +
            $"Koliko ukupno klikera imaju?";
        }


    //isto kao prethodni ali mu je dao klikere samo je oduzimanje u pitanju
    //Medium od 2 do 4 razreda Medium
    public string GivingStuffToEachOther(int a,int c)
    {


        //100 imena
        List<string> names = new List<string>
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

        string name1 = names[Random.Range(0,names.Count)];

        string name2 = names[Random.Range(0,names.Count)];

       

        return $"{name1} ima {a} klikera, {name2} poklonio je {c} klikera."+ "\n" +" Koliko je ostalo?";
    }


    //Izracunaj izraz
    //Medium od 2 do 4 razreda
    public string CalculateTheExpression(int a,int b,int c)
    {

        int result;
        string expression;


        if (Random.Range(0, 2) == 0)
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

        return $"Izraz: {expression}";
    }

    //racunanje samo za 3 razred skole 
    //hard od 3 do 4
    public string CalculateTheExpressionForThirdGrade()
    {

        int a = Random.Range(1, 200);
        int b = Random.Range(1, 200);
        int c = Random.Range(1, 200);

        int result;
        string expression;


        int operation = Random.Range(0, 3);

        if (operation == 0)
        {

            if (Random.Range(0, 2) == 0)
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
                result = Mathf.Abs(result);
            }
        }

        return $"Izraz: {expression}";
    }

    //glavna metoda za konvertovanje metara u druge jedinice
    //easy od 2 do 4 razreda
    public string ConvertUnits(int meters,string unit)
    {

        //int result = meters * factor;

        return $"Koliko {unit} je {meters} metara?";
    }

    /*//wrapper metode za konvertovanje jedinica
    //centimetre
    public string ConvertMeterToCentimetre()
    {
        return ConvertUnits("centimetara", 100);
    }
    //milimetre
    public string ConvertMeterToMilimetre()
    {
        return ConvertUnits("milimetara", 1000);
    }
    //decimetre
    public string ConvertMeterToDecimetre()
    {
        return ConvertUnits("decimetara", 10);
    }*/




    public string CircleArea(int r)
    {
        return $"Izracunaj površinu kruga ako je poluprečnik {r}.";
    }

    //easy od 5 do 8
    //obim kruga
    public string CirclePerimeter(int r)
    {
        return $"Izracunaj obim kruga ako je poluprečnik {r}.";
    }


    //easy 4 razred ovo je od 4 pa do 8
    //povrsina kocke 
    public string CubeSurfaceArea(int a)
    {
        return $"Izračunaj površinu kocke ako je stranica {a}.";
    }

    //easy 4 razred ovo je od 4 pa do 8
    //zapremina kocke 
    public string CubeVolume(int a)
    {
        return $"Izračunaj zapreminu kocke ako je stranica {a}.";
    }

    //Površina kvadrata
    //easy 4 razred ovo je od 4 pa do 8
    public string SquareArea(int a)
    {
        return $"Izračunaj površinu kvadrata ako je stranica {a}.";
    }

    //obim kvadrata
    public string SquarePerimiter(int a)
    {
        return $"Izračunaj obim kvadrata ako je stranica {a}.";
    }


    //Površina pravougaonika
    //easy 4 razred ovo je od 3 pa do 4
    public string RectangleArea(int a,int b)
    {
        return $"Izračunaj površinu pravougaonika sa stranicama {a} i {b}.";
    }

    //obim pravougaonika
    public string RectanglePerimiter(int a,int b)
    {
        return $"Izračunaj obim pravougaonika ako je stranica {a} i {b}.";
    }

    //zapremina kvadra
    //easy 4 razred ovo je od 4 pa do 8
    public string CuboidVolume(int a,int b,int c)
    {
        return $"Izračunaj zapreminu kvadra sa stranicama {a}, {b} i {c}.";
    }

    //Površina kvadra
    //easy 4 razred ovo je od 4 pa do 8
    public string CuboidSurfaceArea(int a,int b,int c)
    {
        return $"Izračunaj površinu kvadra sa stranicama {a}, {b} i {c}.";
    }

    //easy od 6 do 8
    //povrsina paralelograma

    public string ParallelogramArea(int a,int h)
    {

        return $"Izračunaj površinu paralelograma sa osnovom {a} i visinom {h}.";
    }


    //easy od 6 do 8
    //povrsina romba
    public string RhombusArea(int d1,int d2)
    {
        return $"Izračunaj površinu romba sa dijagonalama {d1} i {d2}.";
    }

    //easy od 7 do 8 razreda
    //pitagorina teorema
    public string PythagoreanTheorem(int a,int b)
    {
        return $"Izračunaj hipotenuzu pravouglog trougla sa katetama {a} i {b}.";
    }

    //medium 8 razreda
    //zapremina prizme
    public string PrismVolume(int a,int h)
    {

        return $"Izračunaj zapreminu prizme ako je stranica a {a} i visina {h}.";
    }


    


}






















