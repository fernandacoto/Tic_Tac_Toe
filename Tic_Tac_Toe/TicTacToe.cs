using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tic_Tac_Toe
{
    class TicTacToe
    {
        Usuario_Usuario us;
        string opcion_menu;
        int opcion;
        public void menu(){
            do{
                Console.Clear();
                Console.WriteLine("*-*-*Tic Tac Toe*-*-*");
                Console.WriteLine("Menú:");
                Console.WriteLine("1.Instrucciones");
                Console.WriteLine("2.Jugar modo Usuario-Usuario");
                Console.WriteLine("3.Jugar modo Usuario-Computadora");
                Console.WriteLine("4.Acerca de");
                Console.WriteLine("5.Salir");
                do
                {
                    Console.WriteLine("Digite un numero entre 1 y 5 segun el menu "); 
                    opcion_menu = Console.ReadLine();
                }
                while (!Int32.TryParse(opcion_menu, out opcion));
                switch (opcion) {
                    case 1:
                        {
                            Console.WriteLine("\nINSTRUCCIONES:\n");
                            Console.WriteLine("Para jugar tic tac toe lo que debe de hacer es digitar el numero");
                            Console.WriteLine("correspondiente a la posicion en la que desee jugar\n");
                            us = new Usuario_Usuario();
                            us.pintargato();
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("*-*-*Jugar Modo Usuario Usuario*-*-*");
                            us = new Usuario_Usuario();
                            us.partida_usuario();
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("*-*-*Jugar Modo Usuario Computadora*-*-*");
                            us = new Usuario_Usuario();
                            us.partida_computadora();
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        Console.WriteLine(" *********************************************");
                        Console.WriteLine("| Realizado por:                              |");
                        Console.WriteLine("| Maria Fernanda Coto Morales                 |");
                        Console.WriteLine("| Estudiante de Ingenieria en Computacion     |");
                        Console.WriteLine("| Del Tecnologico de Costa Rica               |");
                        Console.WriteLine(" *********************************************");
                        Console.ReadKey();
                        break;
                    default:
                        break;

                }
            }while(opcion != 5);
        }
        static void Main(string[] args)
        {
            TicTacToe gato = new TicTacToe();
            gato.menu();
        }
    }
}
