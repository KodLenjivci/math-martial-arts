using System;
using System.Collections;
using System.Collections.Generic;


namespace DefaultNamespace
{
    class Geometry
    {
        static Random rand = new Random();


        //easy od 5 do 8
        //Racuna povrsinu kruga
        static string CircleArea()
        {
            int r = rand.Next(1,450); 

   
            return $"Izracunaj površinu kruga ako je poluprečnik {r}. Rešenje je: {Math.PI * r*r}";
        }

        //easy od 5 do 8
        //obim kruga
        static string CirclePerimeter()
        {
            int r = rand.Next(1,450);
            return $"Izracunaj obim kruga ako je poluprečnik {r}. Rešenje je: {Math.PI * 2*r}";
        }
        
        
        //easy 4 razred ovo je od 4 pa do 8
        //povrsina kocke 
        static string CubeSurfaceArea()
        {
            double result = 6 * Math.Pow(a, 2);
            int a  = rand.Next(1,450);
            return $"Izračunaj površinu kocke ako je stranica {a}. Rešenje je: {result}";
        }
        
        //easy 4 razred ovo je od 4 pa do 8
        //zapremina kocke 
        static string CubeVolume()
        {
            double result = Math.Pow(a, 3);
            int a  = rand.Next(1,450);
            return $"Izračunaj zapreminu kocke ako je stranica {a}. Rešenje je: {result}";
        }

        //Površina kvadrata
        //easy 4 razred ovo je od 4 pa do 8
        static string SquareArea()
        {
            int a  = rand.Next(1,450);
            double result = Math.Pow(a, 2);
            
            return $"Izračunaj površinu kvadrata ako je stranica {a}. Rešenje je: {result}";
        }

        //Površina pravougaonika
        //easy 4 razred ovo je od 3 pa do 4
        static string RectangleArea()
        {
            int a  = rand.Next(1,450);
            int b  = rand.Next(1,450);
            double result = a * b;
            return $"Izračunaj površinu pravougaonika sa širinom {a} i visinom {b}. Rešenje je: {result}";
        }

        //zapremina kvadra
        //easy 4 razred ovo je od 4 pa do 8
        static string CuboidVolume()
        {
            int a  = rand.Next(1,450);
            int b  = rand.Next(1,450);
            int c  = rand.Next(1,450);
            double result = a * b * c;
            return $"Izračunaj zapreminu kvadra sa širinom {a}, visinom {b} i dubinom {c}. Rešenje je: {result}";
        }

        //Površina kvadra
        //easy 4 razred ovo je od 4 pa do 8
        static string CuboidSurfaceArea()
        {
            int a  = rand.Next(1,450);
            int b  = rand.Next(1,450);
            int c  = rand.Next(1,450);
            
            
            double result = 2 * (a * b + a * c + b * c);
            return $"Izračunaj površinu kvadra sa širinom {a}, visinom {b} i dubinom {c}. Rešenje je: {result}";
        }

        //easy od 2 do 8 razreda
        //kakav je ugao(prav,ostar,tup)
        static string WhatAngle(){
            int a  = rand.Next(1,180);
            string a = "";

            if(a<90){
                a = "Oštar ugao";
                return $"Dali je ugao {a}, oštar,prav ili tup. Rešenje je: {a}";
            } else if(a==90){
                a = "Prav ugao";
                return $"Da li  je ugao {a}, oštar,prav ili tup. Rešenje je: {a}";
            } else (90<a){
                a = "Tup ugao";
                return $"Dali je ugao {a}, oštar,prav ili tup. Rešenje je: {a}";
            }
        }

        //easy od 6 do 8
        //povrsina paralelograma
        
        static string ParallelogramArea()
        {
            int a = rand.Next(1, 450);
            int h = rand.Next(1, 450);   
    
            double result = a * h;

            return $"Izračunaj površinu paralelograma sa osnovom {a} i visinom {h}. Rešenje je: {result}";
        }


        //easy od 6 do 8
        //povrsina romba
        static string RhombusArea()
        {
            int d1 = rand.Next(1, 450); //Prva dijagonala romba
            int d2 = rand.Next(1, 450); //druga dijagonala romba
    
            double result = (d1 * d2) / 2.0;
            return $"Izračunaj površinu romba sa dijagonalama {d1} i {d2}. Rešenje je: {result}";
        }

        //easy od 7 do 8 razreda
        //pitagorina teorema
        static string PythagoreanTheorem()
        {
    
            int a = rand.Next(1, 450); //Prva kateta
            int b = rand.Next(1, 450); //Druga kateta

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            
            return $"Izračunaj hipotenuzu pravouglog trougla sa katetama {a} i {b}. Rešenje je: {c:F2}";
        }



        //medium 8 razreda
        //zapremina prizme
        static string PrismVolume()
        {
    
            int a = rand.Next(1, 20); //stranica a
            int h = rand.Next(1, 20); //Visina prizme

            double v = a * h;
            
            return $"Izračunaj zapreminu prizme ako je stranica a {a} i visina {h}. Rešenje je: {v}";
        }


        //medium 8 razred
        //zapremina valjka
        static string CylinderVolume()
        {
    
            int r = rand.Next(1, 450); //Poluprečnik osnove
            int h = rand.Next(1, 450); //Visina valjka

            double v = Math.PI * (r*r) * h;
            
            return $"Izračunaj zapreminu valjka sa poluprečnikom {r} i visinom {h}. Rešenje je: {Math.Round(volume, 2)}";
        }

        //hard od 5 do 8
        //izracunaj dijagonale romba
        static string CalculateRhombusDiagonals()
        {
    

    
            int ratio1 = rand.Next(2, 10); 
            int ratio2 = rand.Next(2, 10); 

    
            while (ratio1 == ratio2)
                ratio2 = rand.Next(2, 10);

    
            
            int p = rand.Next(100, 1000); 

    
            int sumRatios = ratio1 + ratio2;
            
            double k = Math.Sqrt((2.0 * p) / (ratio1 * ratio2));

    
            double d1 = ratio1 * k;
            double d2 = ratio2 * k;

            
           return $"Dijagonale romba stoje u razmeri {ratio1}:{ratio2}, a njegova površina je {p} m². Izračunaj dužine dijagonala romba.\n\n" +
           $"Rešenje:\n" +
           $"d1 = {ratio1}k = {Math.Round(d1, 2)} m\n" +
           $"d2 = {ratio2}k = {Math.Round(d2, 2)} m";
        }

        

        
    }


    
}    