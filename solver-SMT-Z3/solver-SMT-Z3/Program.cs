using System;
using System.Collections.Generic;
using System.IO;

namespace sudoku_SMT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string directory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()).ToString()).ToString()).ToString();
            var sudokupath = Path.Combine(directory + "/data/Sudoku_Easy50.txt");
            //string text = File.ReadAllText(sudokupath);
            //Console.WriteLine(Sudoku.Parse(text)); //affiche un sudoku

            List<Sudoku> allSudokus = Sudoku.ParseFile(sudokupath);
            for (int i = 0; i < allSudokus.Count; i++)
            {
                Sudoku sudoku = (Sudoku)allSudokus[i];
                Console.WriteLine(sudoku.ToString());
            }
        }
    }
}
