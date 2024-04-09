using System;

namespace NewFirst
{
    class ArrayDemo
    {
        public void setArray()
        {
            //1d array
            //direct method
            int[] arr1 = { 1, 2, 3, 4, 5 };
            //size
            int[] arr2 = new int[5] { 12, 45, 14, 12, 3 };
            Console.WriteLine("-------1 using for loop------");
            for(int i=0; i<arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.WriteLine("------2 using for each loop----------");
            foreach(int a in arr2)//foreach (data type variable name 'in' 'arrayname')
            {
                Console.WriteLine(a);
            }
            //2d array
            int[,] arr3 ={
                            {20,30,40},//oth row 3 column (0-2)
                            {12,412,42},
                            {34,53,12 }
                                     };
            Console.WriteLine("--------3 using for loop----------");
            for(int i = 0; i < arr3.GetLength(0); i++)
            {
                for(int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i,j]+" ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("-------------4 using for each loop------------");
            foreach (int b in arr3)
            {
                Console.Write(b+" ");
            }
            //jagged array: varaition in column
            int[][] jarr = new int[3][];
            jarr[0] =new int []{ 2,3,4};//oth row 3 column
            jarr[1] = new int[] { 3, 5, 3, 2 };
            jarr[2] = new int[] { 2, 4 };
            Console.WriteLine("\n--------5 using for loop of jagged array----------");
            for(int i = 0;i < jarr.Length; i++)
            {
                for (int j = 0;j < jarr[i].Length; j++)
                {
                    Console.Write(jarr[i][j]+" ");  
                }
                Console.WriteLine("");
            }
            Console.WriteLine("------------6 using for each loop-------------------");
            foreach(int[]i in jarr)
            {
                foreach(int j in i)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine("");
            }
        }
    }
}
