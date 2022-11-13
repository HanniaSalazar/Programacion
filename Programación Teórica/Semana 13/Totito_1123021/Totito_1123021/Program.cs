using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Totito_1123021
{
    internal class Program
    {
        public static string[,] tablero = new string[3, 3];
        public static void Main(string[] args)
        {
            Console.WriteLine("PRUEBA EN CLASE");
            IniciarTablero();
            jugar(1, 0, 0);
            jugar(2, 1, 1);
            jugar(1, 0, 1);
            jugar(2, 1, 2);
            jugar(1, 0, 2);
            MostrarTablero();
            int res = evaluar();
            Console.WriteLine(res);

            //PRUEBA REACTIVA 1
            Console.WriteLine("Si no se ingresan un totito ganador para el primer jugador aun que el jugador No.2 no haya terminado es declarado como ganador");
            IniciarTablero();
            jugar(1, 0, 0);
            jugar(2, 1, 1);
            jugar(1, 0, 1);
            jugar(2, 1, 2);
            MostrarTablero();
            res = evaluar();
            Console.WriteLine(res);

            //PRUEBA REACTIVA 2
            Console.WriteLine("Debe ingresarse un try-catch para que se exija ingresar algo, de lo contrario aun sin jugadores declara un ganador");
            IniciarTablero();
            MostrarTablero();
            res = evaluar();
            Console.WriteLine(res);

            //PRUEBA PREVENTIVA 1
            Console.WriteLine("No se indica un ganador si nadie gana");
            IniciarTablero();
            jugar(1, 0, 0);
            jugar(2, 1, 1);
            jugar(1, 2, 1);
            jugar(2, 1, 2);
            jugar(1, 2, 2);
            MostrarTablero();
            res = evaluar();
            Console.WriteLine(res);


            //PRUEBA PREVENTIVA 2
            Console.WriteLine("El juego correctamente anuncia que está ocupada la posición");
            IniciarTablero();
            jugar(1, 0, 0);
            jugar(2, 1, 1);
            jugar(1, 1, 2);
            jugar(2, 1, 2);
            jugar(1, 2, 2);
            MostrarTablero();
            res = evaluar();
            Console.WriteLine(res);

            Console.ReadKey();
        }
        public static void jugar(int nJugador, int fila, int columna)
        {
            string pieza = "";
            if (nJugador == 1)
            {
                pieza = "x";
            }
            else
            {
                pieza = "o";
            }
            if (tablero[fila, columna] == "")
            {
                tablero[fila, columna] = pieza;
            }
            else
            {
                Console.WriteLine("Posición ocupada");
            }
        }

        //MOSTRANDO EL TABLERO

        public static void MostrarTablero()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(tablero[f, c] + " | ");
                }
                Console.WriteLine();
            }

        }
        //INICIALIZANDO LA MTATRIZ

        public static void IniciarTablero()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    tablero[f, c] = "";
                }
                Console.WriteLine();
            }

        }

        public static int evaluar()
        {
            //Evaluar horizontal
            for (int f = 0; f < 3; f++)
            {
                if (tablero[f, 0] == tablero[f, 1] && tablero[f, 1]== tablero[f, 2])
                {
                    //Evaluar ganador
                    if (tablero[f,0]=="x")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                    
                }
               
            }
            //Evaluar vertical
            for (int c = 0; c < 3; c++)
            {
                if (tablero[0, c] == tablero[1,c] && tablero[1,c] == tablero[2,c])
                {
                    //Evaluar ganador
                    if (tablero[0, c] == "x")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }

                }
            
            if (tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2])
                {
                    //Evaluar ganador
                    if (tablero[0, c] == "x")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
            return 0;
            
        }

    }

}

