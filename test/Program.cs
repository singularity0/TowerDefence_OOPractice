using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] matrix = new bool[5, 10] {
                {true, false, false, false, false, false, false, false, false, false},
                {true, false, false, false, false, false, false, false, false, false},
                {true, true, false, false, false, false, false, true, true, true},
                {false, true, true, true, true, false, false, true, false, false},
                {false, false, false, false, true, true, true, true, false, false},
            };

            List<List<int>> EnemyPath = new List<List<int>>() {
                    new List<int>(){ 0,0},
                    new List<int>(){ 1,0},
                    new List<int>(){ 2,0},
                    new List<int>(){ 2,1},
                    new List<int>(){ 3,1},
                    new List<int>(){ 3,2},
                    new List<int>(){ 3,3},
                    new List<int>(){ 3,4},
                    new List<int>(){ 4,4},
                    new List<int>(){ 4,5},
                    new List<int>(){ 4,6},
                    new List<int>(){ 4,7},
                    new List<int>(){ 3,7},
                    new List<int>(){ 2,7},
                    new List<int>(){ 2,8},
                    new List<int>(){ 2,9}
            };

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        if (matrix[i, j] == true)
            //        {
            //            EnemyPath.Add(new List<int>(){i,j});
            //        };
            //    }
            //}

            for (int i = 0; i < EnemyPath.Count; i++)
            {
                for (int j = 0; j < EnemyPath[i].Count; j++)
                {
                    Console.Write(EnemyPath[i][j] + " ");
                }
                Console.WriteLine();
            }

            //for (int i = 0; i < EnemyPath.Count; i++)
            //{
                
            //    if (EnemyPath[i][0] == 2 && EnemyPath[i][0] == 9)
            //        {
            //            Console.WriteLine(EnemyPath[i+1][0]);
            //            Console.WriteLine(EnemyPath[i + 1][1]);

            //    };
                
            //}


            //for (int i = 0; i < EnemyPath.Count(); i++)
            //{
            //    foreach (var item in EnemyPath)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            

            LinkedList<int> Neighbors = new LinkedList<int>();
            
        }
    }
}
