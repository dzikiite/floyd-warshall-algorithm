using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace list9
{
    class Program
        {
            private static void Print(int[,] distance, int verticesCount)
            {
                Console.WriteLine("Shortest distances between each pair of vertices:");

                for (int i = 0; i < verticesCount; ++i)
                {
                    for (int j = 0; j < verticesCount; ++j)
                    {

                        Console.Write(distance[i, j].ToString().PadLeft(9));
                    }

                    Console.WriteLine();
                }
            }

            public static void Algorithm(int[,] graph, int verticesCount)
            {

                int[,] distance = new int[verticesCount, verticesCount];

                for (int i = 0; i < verticesCount; ++i)
                    for (int j = 0; j < verticesCount; ++j)
                        distance[i, j] = graph[i, j];

                for (int k = 0; k < verticesCount; ++k)
                {
                    for (int i = 0; i < verticesCount; ++i)
                    {
                        for (int j = 0; j < verticesCount; ++j)
                        {
                            if ((distance[i, k] * distance[k, j] == 0) && (distance[i, j] == 0))
                                distance[i, j] = 0;
                            else
                                distance[i, j] = 1;
                        }
                    }
                }

                Print(distance, verticesCount);
            }
            static void Main(string[] args)
            {
                int[,] graph = new int[5, 5];
                Random rand = new Random();
                for (int i = 0; i < 5; ++i)
                    for (int j = 0; j < 5; ++j)
                    {
                    graph[i, j] = rand.Next(0, 2);
                    }

                Print(graph, 5);
                Algorithm(graph, 5);

                Console.ReadLine();
            }
        }
    }
