using System;
using System.Collections.Generic;
using System.IO;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()).ToString()).ToString();
            var sudokupath = Path.Combine(directory + "/data/Sudoku_Easy50.txt");
            //string text = File.ReadAllText(sudokupath);
            //Console.WriteLine(Sudoku.Parse(text)); //affiche un sudoku

            List<Sudoku.Sudoku> allSudokus = Sudoku.Sudoku.ParseFile(sudokupath);
            
            for (int i = 0; i < allSudokus.Count; i++)
            {
                Sudoku.Sudoku sudoku = (Sudoku.Sudoku)allSudokus[i];
                Console.WriteLine(sudoku.ToString());
            }
        }
    }
}