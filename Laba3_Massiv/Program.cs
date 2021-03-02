using System;

namespace Laba3_Massiv
{
    class Program
    {
        static void Main(string[] args)
        {
            // One();
            // Two();
            // Three();
            // Four();
            // Five();
            Six();
            
        }

       static void One()
        {
            Console.WriteLine("Введіть розмір масиву: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Введіть елемент масиву: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Mасив: ");
            
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("Введіть число: ");
            int lowerThan = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < size; i++)
            {
                if (array[i] < lowerThan)
                {
                    array[i] = lowerThan;
                }
            }
           
            Console.WriteLine("Відредагований масив: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

       static void Two()
       {
           int[] array = new int[20];
           Random random = new Random();
           for (int i = 0; i < 20; i++)
           {
               array[i] = random.Next(-3, 11);
           }
           Console.WriteLine("Mасив: ");
            
           for (int i = 0; i < 20; i++)
           {
               Console.Write(array[i] + " ");
           }
           
           
           for (int i = 0; i < 20; i++)
           {
               if (array[i] > 0)
               {
                   for (int j = 0; j < 20; j++)
                   {
                       if (array[i] == array[j] * (-1))
                       {
                           array[j] = array[j] * (-1);
                       }
                   }
               }
           }
           
           Console.WriteLine("\nВідредагований масив: ");
           for (int i = 0; i < 20; i++)
           {
               Console.Write(array[i] + " ");
           }
       }

       static void Three()
       {
           Random random = new Random();
           Console.WriteLine("Введіть розмір масиву: ");
           int size = Convert.ToInt32(Console.ReadLine());
           int[,] array = new int[size, size];
           
           for (int i = 0; i < size; i++)
           {
               for (int j = 0; j < size; j++)
               {
                   array[i, j] = random.Next(0, 101);
               }
           }
           Console.WriteLine("Mасив: ");
           for (int i = 0; i < size; i++)
           {
               for (int j = 0; j < size; j++)
               {
                  Console.Write($"{array[i,j]} \t"); 
               }
               Console.WriteLine();
           }

           int[] vector = new int[size];
           
           for (int i = 0; i < size; i++)
           {
               if (array[i, i] < 10)
               {
                   if (i == size - 1)
                   {
                       vector[i] = 0;
                   }
                   else
                   {
                       for (int j = i + 1; j < size; j++)
                       {
                           vector[i] += Math.Abs(array[j, i]);
                       }
                   }
               } 
               else if (array[i, i] > 10)
               {
                   if (i == 0)
                   {
                       vector[i] = 0;
                   }
                   else
                   {
                       for (int j = i-1; j >= 0; j--)
                       {
                           vector[i] += Math.Abs(array[j, i]);
                       }
                   }
               }
               else
               {
                   vector[i] = 0;
               }
           }

           Console.WriteLine("Вектор: ");
           for (int i = 0; i < size; i++)
           {
              Console.Write(vector[i] + " "); 
           }
       }

       static void Four()
       {
           Random random = new Random();
           int[,] array = new int[4, 5];
           for (int i = 0; i < 4; i++)
           {
               for (int j = 0; j < 5; j++)
               {
                   array[i, j] = random.Next(0, 101);
               }
           }
           
           Console.WriteLine("Mасив: ");
           for (int i = 0; i < 4; i++)
           {
               for (int j = 0; j < 5; j++)
               {
                   Console.Write($"{array[i,j]} \t"); 
               }
               Console.WriteLine();
           }

           int maxNumber = array[0, 0];
           int maxI = 0;
           int maxJ = 0;
           
           for (int i = 0; i < 4; i++)
           {
               for (int j = 0; j < 5; j++)
               {
                   if (Math.Abs(array[i, j]) > maxNumber)
                   {
                       maxNumber = array[i, j];
                       maxI = i;
                       maxJ = j;
                   }
               }
           }
           Console.WriteLine("Найбільше число по модулю: " + maxNumber + ", i = " + maxI + " j = " + maxJ);
       }
       
       static void Five()
       {
           Random random = new Random();
           Console.WriteLine("Введіть кількість місяців (не менше 4): ");
           int month = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Введіть кількість працівників (не менше 4): ");
           int employee = Convert.ToInt32(Console.ReadLine());
           
           int[,] array = new int[month, employee];
           
           for (int i = 0; i < month; i++)
           {
               for (int j = 0; j < employee; j++)
               {
                   array[i, j] = random.Next(4000, 30001);
               }
           }

           int yearBudget = 0;
           int kvitenBudget = 0;
           
           
           Console.WriteLine("Mасив: ");
           for (int i = 0; i < month; i++)
           {
               for (int j = 0; j < employee; j++)
               {
                   yearBudget += array[i, j];
                   Console.Write($"{array[i,j]} \t");
                   if (i == 3)
                   {
                       kvitenBudget += array[i, j];
                   }
               }
               Console.WriteLine();
           }

           double serKviten = kvitenBudget / employee;
           
           Console.WriteLine("Бюджет на рік: " + yearBudget + "\n" +
                             "Бюджет на квітень: " + kvitenBudget + "\n" +
                             "Середня зарплата за квітень: " + serKviten);
       }
       static void Six()
       {
           Random random = new Random();
           int size = Convert.ToInt32(Console.ReadLine());
           int[][] array = new int[size][];
           for (int i = 0; i < size; i++)
           {
               array[i] = new int[i+1];
           }

           for (int i = 0; i < size; i++)
           {
               for (int j = 0; j < array[i].Length; j++)
               {
                   array[i][j] = random.Next(0, 101);
               } 
           }
           Console.WriteLine("Mасив: ");
           for (int i = 0; i < size; i++)
           {
               for (int j = 0; j < array[i].Length; j++)
               {
                   Console.Write($"{array[i][j]} \t");
               } 
               Console.WriteLine();
           }

           int[] vector = new int[size];
           
           // for (int i = 0; i < size; i++)
           // {
           //     int min = array[i][0];
           //     for (int j = 0; j < array[i].Length; j++)
           //     {
           //         if (min > array[i][j])
           //         {
           //             min = array[i][j];
           //         }
           //     }
           //     vector[i] = min;
           // }
           
           // for (int i = 0; i < size; i++)
           //     {
           //         for (int j = 0; j < array[i].Length; j++)
           //         {
           //             int min = 1000;
           //             for (int k = 0; k < size; k++)
           //             {
           //                 if (min > array[k][j])
           //                 {
           //                     min = array[k][j];
           //                 }
           //             }
           //             vector[i] = min;
           //         }
           //     }

           int counter = 0;
           for (int i = 0; i < size; i++)
           { 
               int min = 1000;
               for (int j = size-1; j >= counter; j--)
               {
                   if (min > array[j][i])
                   {
                       min = array[j][i];
                   }
               }
               counter++;
               vector[i] = min;
           }

           Console.WriteLine("Вектор: ");
           for (int i = 0; i < size; i++)
           {
               Console.Write(vector[i] + " ");
           }
       }
    }
}