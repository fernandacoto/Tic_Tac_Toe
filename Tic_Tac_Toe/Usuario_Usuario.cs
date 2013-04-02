using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tic_Tac_Toe
{
    class Usuario_Usuario
    {
        int[] numeros = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        bool ganador = false;
        string entrada;
        int casilla;
        int jugador = 1;
        string[] gato = new string[9] {"1","2","3","4","5","6","7","8","9"};
        static private int[,] arreglosoluciones = new int[,]
           {
            {1,2,3},
            {4,5,6},
            {7,8,9},
            {1,4,7},
            {2,5,8},
            {3,6,9},
            {1,5,9},
            {3,5,7}
           };
         int[] usuario = new int[6]{0,0,0,0,0,0};
         int[] compu = new int[5] {0,0,0,0,0};
       
        public void pintargato()
        {
            Console.WriteLine(gato[0] + "|" + gato[1] + "|" + gato[2]);
            Console.WriteLine("------");
            Console.WriteLine(gato[3] + "|" + gato[4] + "|" + gato[5]);
            Console.WriteLine("------");
            Console.WriteLine(gato[6] + "|" + gato[7] + "|" + gato[8]);
        }
        public int largoreal(int[] arreglo)
        {
            int largoreal = 0;
            while (arreglo[largoreal] != 0)
                largoreal++;
            return largoreal;
        }
        public void partida_usuario()
        {
            int cantidad_movimientos = 0;
            pintargato();
            while (cantidad_movimientos < 9 && ganador == false)
            {
                do
                {
                    Console.WriteLine("Jugador " + jugador + " digite el número de la casilla:");
                    entrada = Console.ReadLine();
                }
                while (!Int32.TryParse(entrada, out casilla));
                if (casilla > 0 && casilla < 10)
                {
                    int i = 0;
                    if (numeros[casilla - 1] != 0)
                    {
                        while (casilla != numeros[i])
                        {
                            i++;
                        }
                        numeros[i] = 0;
                        if (jugador == 1)
                        {
                            gato[i] = "X";
                            usuario[largoreal(usuario)] = casilla;
                            pintargato();
                            jugador = 2;
                            ganador = verificar_ganador(usuario);
                            if (ganador == true)
                            {
                                Console.WriteLine("Felicidades jugador 1 eres el ganador");
                            }
                        }
                        else
                        {
                            gato[i] = "O";
                            compu[largoreal(compu)] = casilla;
                            pintargato();
                            jugador = 1;
                            ganador = verificar_ganador(compu);
                            if (ganador == true)
                            {
                                Console.WriteLine("Felicidades jugador 2 eres el ganador");
                            }

                        }
                    }
                    else
                        Console.WriteLine("Esa posicion ya fue utilizada elija otra");
                    }
                    else
                        Console.WriteLine("Posicion fuera de rango");
               cantidad_movimientos++; 
            }
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-FIN-*-*-*-*-*-*-*-*-*-*\n");            
        }

        public bool verificar_ganador(int[] arreglousuario)
        {
            int posarreglousuario = 0;
            bool solucion = false;
            if (largoreal(arreglousuario) >= 3)// si el largo del arreglo del usuario es 3 continua pues puede haber solucion
            {
                while (posarreglousuario < largoreal(arreglousuario) && solucion == false)
                {
                    int ensolnum = 0;
                    while (ensolnum < 8 && solucion == false)
                    {
                        if (arreglosoluciones[ensolnum, 0] == arreglousuario[posarreglousuario])
                        {
                            int nuevocont = posarreglousuario + 1;
                            while (nuevocont < largoreal(arreglousuario) && solucion == false)
                            {
                                if (arreglosoluciones[ensolnum, 1] == arreglousuario[nuevocont])
                                {
                                    int otrocont = nuevocont + 1;
                                    while (otrocont < largoreal(arreglousuario) && solucion == false)
                                    {
                                        if (arreglosoluciones[ensolnum, 2] == arreglousuario[otrocont])
                                        {
                                            solucion = true;
                                        }
                                        else
                                        {
                                            otrocont = otrocont + 1;
                                        }
                                    }
                                }
                                if (arreglosoluciones[ensolnum, 2] == arreglousuario[nuevocont])
                                {
                                    int otrocont = nuevocont + 1;
                                    while (otrocont < largoreal(arreglousuario) && solucion == false)
                                    {
                                        if (arreglosoluciones[ensolnum, 1] == arreglousuario[otrocont])
                                        {
                                            solucion = true;
                                        }
                                        else
                                        {
                                            otrocont = otrocont + 1;
                                        }
                                    }
                                }
                                nuevocont = nuevocont + 1;
                            }
                        }
                        if (arreglosoluciones[ensolnum, 1] == arreglousuario[posarreglousuario])
                        {
                            int nuevocont = posarreglousuario + 1;
                            while (nuevocont < largoreal(arreglousuario) && solucion == false)
                            {
                                if (arreglosoluciones[ensolnum, 0] == arreglousuario[nuevocont])
                                {
                                    int otrocont = nuevocont + 1;
                                    while (otrocont < largoreal(arreglousuario) && solucion == false)
                                    {
                                        if (arreglosoluciones[ensolnum, 2] == arreglousuario[otrocont])
                                        {
                                            solucion = true;
                                        }
                                        else
                                        {
                                            otrocont = otrocont + 1;
                                        }
                                    }
                                }
                                if (arreglosoluciones[ensolnum, 2] == arreglousuario[nuevocont])
                                {
                                    int otrocont = nuevocont + 1;
                                    while (otrocont < largoreal(arreglousuario) && solucion == false)
                                    {
                                        if (arreglosoluciones[ensolnum, 0] == arreglousuario[otrocont])
                                        {
                                            solucion = true;
                                        }
                                        else
                                        {
                                            otrocont = otrocont + 1;
                                        }
                                    }
                                }
                                nuevocont = nuevocont + 1;
                            }
                        }
                        if (arreglosoluciones[ensolnum, 2] == arreglousuario[posarreglousuario])
                        {
                            int nuevocont = posarreglousuario + 1;
                            while (nuevocont < largoreal(arreglousuario) && solucion == false)
                            {
                                if (arreglosoluciones[ensolnum, 0] == arreglousuario[nuevocont])
                                {
                                    int otrocont = nuevocont + 1;
                                    while (otrocont < largoreal(arreglousuario) && solucion == false)
                                    {
                                        if (arreglosoluciones[ensolnum, 1] == arreglousuario[otrocont])
                                        {
                                            solucion = true;
                                        }
                                        else
                                        {
                                            otrocont = otrocont + 1;
                                        }
                                    }
                                }
                                if (arreglosoluciones[ensolnum, 1] == arreglousuario[nuevocont])
                                {
                                    int otrocont = nuevocont + 1;
                                    while (otrocont < largoreal(arreglousuario) && solucion == false)
                                    {
                                        if (arreglosoluciones[ensolnum, 0] == arreglousuario[otrocont])
                                        {
                                            solucion = true;
                                        }
                                        else
                                        {
                                            otrocont = otrocont + 1;
                                        }
                                    }
                                }
                                nuevocont = nuevocont + 1;
                            }
                        }

                        ensolnum = ensolnum + 1;
                    }
                    posarreglousuario = posarreglousuario + 1;
                }
                return solucion;
            }
            else // sino devuelve falso diciendo que aun no gano
                return false;
        }
    
        public void  partida_computadora()
        {
            pintargato();
            int cantidad_mov = 0;
            ganador = false;
            while (cantidad_mov < 9 && ganador == false)
            {
                if (jugador == 1)
                {
                    do
                    {
                        Console.WriteLine("Jugador digite el número de la casilla:");
                        entrada = Console.ReadLine();
                    }
                    while (!Int32.TryParse(entrada, out casilla));
                    if (casilla > 0 && casilla < 10)
                    {
                        int i = 0;
                        if (numeros[casilla - 1] != 0)
                        {
                            while (casilla != numeros[i])
                            {
                                i++;
                            }
                            numeros[i] = 0;
                            gato[i] = "X";
                            usuario[largoreal(usuario)] = casilla;
                            pintargato();
                            jugador = 2;
                            ganador = verificar_ganador(usuario);
                            if (ganador == true)
                            {
                                Console.WriteLine("Felicidades jugador 1 es el ganador");
                            }
                        }
                        else
                            Console.WriteLine("Esa casilla ya esta ocupada elija otra");
                    }
                    else
                        Console.WriteLine("Casilla fuera de rango");

                }
                else
                {
                    Console.WriteLine("Turno de la computadora \n");
                    turnocomputadora(usuario,compu);
                    pintargato();
                    jugador = 1;
                    ganador = verificar_ganador(compu);
                    if (ganador == true)
                    {
                        Console.WriteLine("Fin del juego la computadora gano");
                    }
                }
                cantidad_mov++;
            }
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-FIN-*-*-*-*-*-*-*-*-*-*\n");
        }
        public void turnocomputadora(int[] arreglousuario, int[] arreglocompu)
        {
            if (arreglousuario.Length > 1)
            {
                turno_computadora(arreglousuario, arreglocompu);
            }
            else
            {
                int contarreglomarcados = 0;
                bool marcado = false;
                while (numeros[contarreglomarcados] != 0 && marcado == false)
                {
                    if (numeros[4] == 5)
                    {
                        gato[4] = "O";
                        compu[largoreal(compu)] = 5;
                        numeros[4] = 0;
                    }
                    else
                    {
                        gato[contarreglomarcados] = "O";
                        compu[largoreal(compu)] = numeros[contarreglomarcados];
                        numeros[contarreglomarcados] = 0;
                    }
                    marcado = true;
                    contarreglomarcados++;
                }
            }
        }
        public void turno_computadora(int[] usuario, int[] compu)
        {
            if ((largoreal(compu)) >= 2)
            {
                compugana(compu, usuario);
            }
            else
            {
                usuariogana(usuario, compu);
            }
        }

        public void compugana(int[] compu, int[] usuario)
        {
            int contcompu = 0;
            bool encontrado = false;
            while (contcompu < (largoreal(compu)) && encontrado == false)
            {
                int soluciones = 0;
                while (soluciones < 8 && encontrado == false)
                {
                    if (compu[contcompu] == arreglosoluciones[soluciones, 0])
                    {
                        int i = contcompu + 1;
                        while (i < largoreal(compu) && encontrado == false)
                        {
                            if (compu[i] == arreglosoluciones[soluciones, 1])
                            {
                                if (arreglosoluciones[soluciones, 2] == numeros[(arreglosoluciones[soluciones, 2] - 1)])
                                {
                                    numeros[(arreglosoluciones[soluciones,2] - 1)] = 0;
                                    compu[largoreal(compu)] = arreglosoluciones[soluciones,2];
                                    gato[(arreglosoluciones[soluciones,2] - 1)] = "O";
                                    encontrado = true;
                                }
                            }
                            if (compu[i] == arreglosoluciones[soluciones, 2])
                            {
                                if (arreglosoluciones[soluciones, 1] == numeros[(arreglosoluciones[soluciones, 1] - 1)])
                                {
                                    numeros[(arreglosoluciones[soluciones,1] - 1)] = 0;
                                    compu[largoreal(compu)] = arreglosoluciones[soluciones,1];
                                    gato[(arreglosoluciones[soluciones,1] - 1)] = "O";
                                    encontrado = true;
                                }
                            }
                            i++;
                        }
                    }
                    if (compu[contcompu] == arreglosoluciones[soluciones, 1])
                    {
                        int i = contcompu + 1;
                        while (i < largoreal(compu) && encontrado == false)
                        {
                            if (compu[i] == arreglosoluciones[soluciones, 0])
                            {
                                if (arreglosoluciones[soluciones, 2] == numeros[(arreglosoluciones[soluciones, 2] - 1)])
                                {
                                    numeros[(arreglosoluciones[soluciones,2] - 1)] = 0;
                                    compu[largoreal(compu)] = arreglosoluciones[soluciones,2];
                                    gato[(arreglosoluciones[soluciones,2] - 1)] = "O";
                                    encontrado = true;
                                }
                            }
                            if (compu[i] == arreglosoluciones[soluciones, 2])
                            {
                                if (arreglosoluciones[soluciones, 0] == numeros[(arreglosoluciones[soluciones, 0] - 1)])
                                {
                                    numeros[(arreglosoluciones[soluciones,0] - 1)] = 0;
                                    compu[largoreal(compu)] = arreglosoluciones[soluciones,0];
                                    gato[(arreglosoluciones[soluciones,0] - 1)] = "O";
                                    encontrado = true;
                                }
                            }
                            i++;
                        }
                    }
                    if (compu[contcompu] == arreglosoluciones[soluciones, 2])
                    {
                        int i = contcompu + 1;
                        while (i < largoreal(compu) && encontrado == false)
                        {
                            if (compu[i] == arreglosoluciones[soluciones, 1])
                            {
                                if (arreglosoluciones[soluciones, 0] == numeros[(arreglosoluciones[soluciones, 0] - 1)])
                                {
                                    numeros[(arreglosoluciones[soluciones,0] - 1)] = 0;
                                    compu[largoreal(compu)] = arreglosoluciones[soluciones,0];
                                    gato[(arreglosoluciones[soluciones,0] - 1)] = "O";
                                    encontrado = true;
                                }
                            }
                            if (compu[i] == arreglosoluciones[soluciones, 0])
                            {
                                if (arreglosoluciones[soluciones, 1] == numeros[(arreglosoluciones[soluciones, 1] - 1)])
                                {
                                    numeros[(arreglosoluciones[soluciones,1] - 1)] = 0;
                                    compu[largoreal(compu)] = arreglosoluciones[soluciones,1];
                                    gato[(arreglosoluciones[soluciones,1] - 1)] = "O";
                                    encontrado = true;
                                }
                            }
                            i++;
                        }
                    }
                    soluciones++;
                }
                contcompu++;
            }
            if (encontrado == false)
            {
                usuariogana(usuario, compu);
            }
        }

        public void usuariogana(int[] usuario, int[] compu)
        {
            int contusuario = 0;
            bool ganador = false;
            while (contusuario < (largoreal(usuario)) && ganador == false)
            {
                int contsol = 0;
                while (contsol < 8 && ganador == false)
                {
                    if (usuario[contusuario] == arreglosoluciones[contsol, 0])
                    {
                        int i = contusuario + 1;
                        while (i < (largoreal(usuario)) && ganador == false)
                        {
                            if (usuario[i] == arreglosoluciones[contsol, 1])
                            {
                                if (arreglosoluciones[contsol, 2] == numeros[(arreglosoluciones[contsol, 2] - 1)])
                                {
                                    ganador = true;
                                    numeros[(arreglosoluciones[contsol, 2] - 1)] = 0;
                                    compu[largoreal(compu)] = arreglosoluciones[contsol, 2];
                                    gato[(arreglosoluciones[contsol, 2] - 1)] = "O";  
                                }
                            }
                            if (usuario[i] == arreglosoluciones[contsol, 2])
                            {
                                if (arreglosoluciones[contsol, 1] == numeros[(arreglosoluciones[contsol, 1] - 1)])
                                {
                                    ganador = true;
                                    numeros[(arreglosoluciones[contsol, 1] - 1)] = 0;
                                    compu[largoreal(compu)] = arreglosoluciones[contsol, 1];
                                    gato[(arreglosoluciones[contsol, 1] - 1)] = "O";
                                }
                            }
                            i++;
                        }
                    }
                    if (usuario[contusuario] == arreglosoluciones[contsol, 1])
                    {
                        int i = contusuario + 1;
                        while (i < (largoreal(usuario)) && ganador == false)
                        {
                            if (usuario[i] == arreglosoluciones[contsol, 0])
                            {
                                if (arreglosoluciones[contsol, 2] == numeros[(arreglosoluciones[contsol, 2] - 1)])
                                {
                                    ganador = true;
                                    numeros[(arreglosoluciones[contsol, 2] - 1)] = 0;
                                    compu[largoreal(compu)] = arreglosoluciones[contsol, 2];
                                    gato[(arreglosoluciones[contsol, 2] - 1)] = "O";
                                }
                            }
                            if (usuario[i] == arreglosoluciones[contsol, 2])
                            {
                                if (arreglosoluciones[contsol, 0] == numeros[(arreglosoluciones[contsol, 0] - 1)])
                                {
                                    ganador = true;
                                    numeros[(arreglosoluciones[contsol, 0] - 1)] = 0;
                                    compu[largoreal(compu)] = arreglosoluciones[contsol, 0];
                                    gato[(arreglosoluciones[contsol, 0] - 1)] = "O";
                                }
                            }
                            i++;
                        }
                    }
                    if (usuario[contusuario] == arreglosoluciones[contsol, 2])
                    {
                        int i = contusuario + 1;
                        while (i < (largoreal(usuario)) && ganador == false)
                        {
                            if (usuario[i] == arreglosoluciones[contsol, 1])
                            {
                                if (arreglosoluciones[contsol, 0] == numeros[(arreglosoluciones[contsol, 0] - 1)])
                                {
                                    ganador = true;
                                    numeros[(arreglosoluciones[contsol, 0] - 1)] = 0;
                                    compu[largoreal(compu)] = arreglosoluciones[contsol, 0];
                                    gato[(arreglosoluciones[contsol, 0] - 1)] = "O";
                                }
                            }
                            if (usuario[i] == arreglosoluciones[contsol, 0])
                            {
                                if (arreglosoluciones[contsol, 1] == numeros[(arreglosoluciones[contsol, 1] - 1)])
                                {
                                    ganador = true;
                                    numeros[(arreglosoluciones[contsol, 1] - 1)] = 0;
                                    compu[largoreal(compu)] = arreglosoluciones[contsol, 1];
                                    gato[(arreglosoluciones[contsol, 1] - 1)] = "O";
                                }
                            }
                            i++;
                        }
                    }
                    contsol++;
                }
                contusuario++;
            }
            if (ganador == false)
            {
                usuarionoganadirectamente(compu);
            }
        }

        public void usuarionoganadirectamente(int[] arrcompu)
        {
            int c_compu = 0;
            bool solucion = false;
            while (c_compu < (largoreal(arrcompu)) && solucion == false)
            {
                int sol = 0;
                while (sol < 8 && solucion == false)
                {
                    if (arrcompu[c_compu] == arreglosoluciones[sol, 0])
                    {
                        if (arreglosoluciones[sol, 1] == numeros[(arreglosoluciones[sol, 1] - 1)] && arreglosoluciones[sol, 2] == numeros[(arreglosoluciones[sol, 2] - 1)])
                        {
                            solucion = true;
                            numeros[(arreglosoluciones[sol, 1] - 1)] = 0;
                            compu[largoreal(compu)] = arreglosoluciones[sol, 1];
                            gato[(arreglosoluciones[sol, 1] - 1)] = "O";
                        }
                    }
                    if (arrcompu[c_compu] == arreglosoluciones[sol, 1])
                    {
                        if (arreglosoluciones[sol, 0] == numeros[(arreglosoluciones[sol, 0] - 1)] && arreglosoluciones[sol, 2] == numeros[(arreglosoluciones[sol, 2] - 1)])
                        {
                            solucion = true;
                            numeros[(arreglosoluciones[sol, 0] - 1)] = 0;
                            compu[largoreal(compu)] = arreglosoluciones[sol, 0];
                            gato[(arreglosoluciones[sol, 0] - 1)] = "O";
                        }
                    }
                    if (arrcompu[c_compu] == arreglosoluciones[sol, 2])
                    {
                        if (arreglosoluciones[sol, 1] == numeros[(arreglosoluciones[sol, 1] - 1)] && arreglosoluciones[sol, 0] == numeros[(arreglosoluciones[sol, 0] - 1)])
                        {
                            solucion = true;
                            numeros[(arreglosoluciones[sol, 1] - 1)] = 0;
                            compu[largoreal(compu)] = arreglosoluciones[sol, 1];
                            gato[(arreglosoluciones[sol, 1] - 1)] = "O";
                        }
                    }
                    sol++;
                }
                c_compu++;
            }
            if (solucion == false)
            {
                int a = 0;
                while (numeros[a] == 0)
                {
                    a++;
                }
                if (numeros[4] == 5)
                {
                    numeros[4] = 0;
                    compu[largoreal(compu)] = 5;
                    gato[4] = "O";
                }
                else
                {
                    numeros[a] = 0;
                    compu[largoreal(compu)] = numeros[a];
                    gato[a] = "O";
                }
            }
        }

    }

}
