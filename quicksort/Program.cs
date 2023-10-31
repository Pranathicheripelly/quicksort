using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("========quick sort=======");
                int[] marks = { 89, 56, 32, 75, 90, 42, 88 };
                Console.WriteLine("Unsorted Marks: ");
                PrintArray(marks);

                // Call the quickSort method to sort the array
                QuickSort(marks, 0, marks.Length - 1);

                Console.WriteLine("Sorted Marks (ascending order): ");
                PrintArray(marks);
            }

            static void QuickSort(int[] arr, int low, int high)
            {
                if (low < high)
                {
                    int pivotIndex = Partition(arr, low, high);

                    QuickSort(arr, low, pivotIndex - 1);
                    QuickSort(arr, pivotIndex + 1, high);
                }
            }

            static int Partition(int[] arr, int low, int high)
            {
                int pivot = arr[high];
                int i = low - 1;

                for (int j = low; j < high; j++)
                {
                    if (arr[j] < pivot)
                    {
                        i++;
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

                int temp2 = arr[i + 1];
                arr[i + 1] = arr[high];
                arr[high] = temp2;

                return i + 1;
            }

            static void PrintArray(int[] arr)
            {
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            Console.ReadLine();
            }
        }

    }

