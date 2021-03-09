using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {
            string[] s = Console.ReadLine().Split(' ');

            int M = int.Parse(s[0]);
            int N = int.Parse(s[1]);

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int X = int.Parse(Console.ReadLine());



            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] == X) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if ((j - 1) >= 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if ((j + 1) <= (N - 1)) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if ((i - 1) >= 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if ((i + 1) <= (M - 1)) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }

                }
            }

        }
    }
}
