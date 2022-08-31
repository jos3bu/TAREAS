/*
Autor: Jose Buchan
Github: jos3bu
Descripcion:  Descuento en compra de helados
*/

using System;
internal class Program
    {
        static void Main(string[] args)
        {
            double compra, descuento,tipo, resta;
            Console.WriteLine("Buen dia! ingrese el total de su compra: ");
            compra=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Porfavor! ingresa una de las opciones: ");
            Console.WriteLine("1 = tipo A");
            Console.WriteLine("2 = tipo B");
            Console.WriteLine("3 = tipo C");
            tipo=Convert.ToInt32(Console.ReadLine());
            switch(tipo)
        {
            case 1:
                descuento = compra*.10;
                break;
            case 2:
                descuento = compra*.15;
                break;
            case 3:
                descuento = compra*.20;
                break;
            default:
                descuento = 0;
                break;
        }
        compra = Convert.ToDouble(compra);
        descuento = Convert.ToDouble(descuento);
        resta = compra - descuento;
        Console.WriteLine("El total de la compra es: Q" + resta);
        Console.WriteLine("El descuento aplicado es: Q" + descuento);       
        }
    }