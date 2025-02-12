using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace menu_para_areas
{
     class Program
     {
        static void Main(string[] args)
        {
            //declaracion de variables
            int op;
            //Menu
            System.Console.WriteLine("---------------------------------------------------------- M E N U ----------------------------------------------------------");
            System.Console.WriteLine("Elige la opcion a realizar");
            System.Console.WriteLine(" 1.Circulo\n 2.Triangulo\n 3.Trapecio\n 4.Exagono\n 5.Rombo");
            op=int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    //----------------------------------------------------------Circulo----------------------------------------------------------
                    System.Console.WriteLine("---------------------------------------------------Area de circulo------------------------------------------------------");
                    System.Console.WriteLine("Elige las opciones\n 1.Con el radio\n 2.Con el diametro");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            //---------------------------------Con el radio---------------------------------------------
                            System.Console.WriteLine("---------------------------------Con el radio---------------------------------------------");
                            System.Console.WriteLine("Ingresa el radio");
                            double radio = double.Parse(Console.ReadLine());
                            double area = Math.PI * Math.Pow(radio, 2);
                            System.Console.WriteLine("El area del circulo es: " + area);
                            break;
                        case 2:
                            //---------------------------------Con el diametro---------------------------------------------
                            System.Console.WriteLine("---------------------------------Con el diametro---------------------------------------------");
                            System.Console.WriteLine("Ingresa el diametro");
                            double diametro = double.Parse(Console.ReadLine());
                            double radio2 = diametro / 2;
                            double area2 = Math.PI * Math.Pow(radio2, 2);
                            System.Console.WriteLine("El area del circulo es: " + area2);
                            break;
                        default:
                            System.Console.WriteLine("La opcion no es valida");
                            break;
                    }
                    break;
                case 2:
                    //----------------------------------------------------------Triangulo----------------------------------------------------------
                    System.Console.WriteLine("--------------------------------------------------Area de triangulo-----------------------------------------------------");
                    System.Console.WriteLine("Ingresa la base");
                    double base1 = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingrese la altura");
                    double atura = double.Parse(Console.ReadLine());
                    double are3 = (base1 * atura) / 2;
                    System.Console.WriteLine("El area del triangulo es: " + are3);
                    break;
                case 3:
                    //----------------------------------------------------------Trapecio----------------------------------------------------------
                    System.Console.WriteLine("--------------------------------------------------Area de trapecio-----------------------------------------------------");
                    System.Console.WriteLine("Ingresa la base mayor");
                    double ba = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingresa la base menor");
                    double bm = double.Parse(Console.ReadLine());
                    System.Console.WriteLine("Ingresa la altura");
                    double al = double.Parse(Console.ReadLine());
                    double are4 = ((ba + bm) * al) / 2;
                    System.Console.WriteLine("El area del trapecio es: " + are4);
                    break;
                case 4:
                    //----------------------------------------------------------Exagono----------------------------------------------------------
                    System.Console.WriteLine("--------------------------------------------------Area de exagono-----------------------------------------------------");
                    System.Console.WriteLine("Ingresa el lado");
                    double lado = double.Parse(Console.ReadLine());
                    double are5 = (3 * Math.Sqrt(3) * Math.Pow(lado, 2)) / 2;
                    System.Console.WriteLine("el area del exagono es: " + are5);
                    break;
                case 5:
                    //----------------------------------------------------------Rombo---------------------------------------------------------- 
                     System.Console.WriteLine("--------------------------------------------------Area de rombo-----------------------------------------------------");
                    System.Console.WriteLine("elija la operacion que mas le fuincione\n 1.con diagonal mayor y menor\n 2.con el lado y altura");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            //---------------------------------Con la diagonal mayor y la diagonal menor---------------------------------------------
                            System.Console.WriteLine("---------------------------------Con la diagonal mayor y la diagonal menor---------------------------------------------");
                            System.Console.WriteLine("Ingresa la diagonal mayor");
                            double dm = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingresa la diagonal menor");
                            double dme = double.Parse(Console.ReadLine());
                            double are6 = (dm * dme) / 2;
                            System.Console.WriteLine("El area del rombo es: " + are6);
                            break;
                        case 2:
                            //---------------------------------Con el lado y la altura---------------------------------------------
                            System.Console.WriteLine("---------------------------------Con el lado y la altura---------------------------------------------");
                            System.Console.WriteLine("Ingresa el lado");
                            double lado2 = double.Parse(Console.ReadLine());
                            System.Console.WriteLine("Ingresa la altura");
                            double altura = double.Parse(Console.ReadLine());
                            double are7 = lado2 * altura;
                            System.Console.WriteLine("El area del rombo es: " + are7);
                            break;
                        default:
                            System.Console.WriteLine("La opcion no es valida");
                            break;
                    }
                    break;
                default:
                    System.Console.WriteLine("La opcion no es valida");
                    break;
            }

           Console.ReadKey();
        }

     }
}
