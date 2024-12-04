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

        return "Saberi sledeće brojeve {a}, {b} i {c}.";
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
    public string ConvertHoursToMinutes()
    {


        int hours = Random.Range(1, 24);
        int result = hours * 60;

        return $"Konvertuj sate u minute: {hours}";
    }

    //Veci broj 
    //Easy od 2 do 4 razreda
    public string WhichNumberIsBigger()
    {


        int a = Random.Range(1, 200);
        int b = Random.Range(1, 200);
        if (a == b)
        {
            while (a == b)
            {
                b = Random.Range(1, 200);
                a = Random.Range(1, 200);
            }
        }

        if (b > a)
        {
            return $"Koji broj je veći {a} ili {b}?";
        }
        else
        {
            return $"Koji broj je veći {a} ili {b}?";
        }


        return null;

    }


    //Ko ima vise klikera
    //Medium od 2 do 4 razreda Medium
    public string HowMuchTheyGot()
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

        int a = Random.Range(1, 200);
        int b = Random.Range(1, 200);

        int resenje = a + b;

        return $"{name1} ima {a} klikera, a {name2} {b} klikera. Koliko ukupno klikera imaju njih dvojica?";
        }


    //isto kao prethodni ali mu je dao klikere samo je oduzimanje u pitanju
    //Medium od 2 do 4 razreda Medium
    public string GivingStuffToEachOther()
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

        int a = Random.Range(1, 100);
        int c = Random.Range(0, a);

        int resenje = a - c;

        return $"{name1} ima {a} klikera, poklonio je {c} klikera. Koliko mu je ostalo?";
    }


    //Izracunaj izraz
    //Medium od 2 do 4 razreda
    public string CalculateTheExpression()
    {

        int a = Random.Range(1, 200);
        int b = Random.Range(1, 200);
        int c = Random.Range(1, 200);


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
    public string ConvertUnits(string unit, int factor)
    {

        int meters = Random.Range(1, 1000);

        int result = meters * factor;
        return $"Koliko {unit} je {meters} metara?";
    }

    //wrapper metode za konvertovanje jedinica
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
    }




}
