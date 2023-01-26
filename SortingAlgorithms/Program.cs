using System;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome! This is a program to test sorting algorithms.");
            while (true) {
                //To generate random number
                Random random = new Random();

                
                Console.WriteLine("Start by choosing an algorithm:\n" +
                                  "[1]: Bubble Sort\n" +
                                  "[2]: Quick Sort\n" +
                                  "[3]: Insertion Sort");
                int[] arrTest = { 3, 5, 3, 2, 7, 4, 2, 1, 4, 5, 6, };
                string algInput = Console.ReadLine();
                int algPick = int.Parse(algInput);

                Console.Write("Pick array size: ");
                string sizInput = Console.ReadLine();
                int sizePick = int.Parse(sizInput);
                int[] arr = new int[sizePick];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = random.Next(0, 99);
                }


                if (algPick == 1)
                {
                    //PrintArr(arr);
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    BubbleSort(arr);
                    watch.Stop();
                    Console.WriteLine("It took {0} milliseconds!", watch.ElapsedMilliseconds);
                    //PrintArr(arr);
                } else if (algPick == 2)
                {
                    //PrintArr(arr);
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    QuickSort(arr, 0, arr.Length - 1);
                    watch.Stop();
                    Console.WriteLine("Quick Sorting!");
                    Console.WriteLine("It took {0} milliseconds!", watch.ElapsedMilliseconds);
                    
                    //PrintArr(arr);
                } else if (algPick == 3)
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    InsertionSort(arr);
                    watch.Stop();
                    Console.WriteLine("Insertion Sorting!");
                    Console.WriteLine("It took {0} milliseconds!", watch.ElapsedMilliseconds);
                }
                
                Console.WriteLine("Run another algorithm? [Y/N]");
                string response = Console.ReadLine().ToUpper();

                if (response == "Y")
                {
                    continue;
                }
                else if (response == "N")
                {
                    return;
                }
                else
                {
                    return;
                }



            }
        }

        static void PrintArr(int[] arr)
            {
                foreach (int item in arr)
                {
                    Console.Write(item.ToString());
                    Console.Write(",");
                }
                Console.Write("\n");

            }
        static void BubbleSort(int[] array)
            {
                Console.WriteLine("Bubble-Sorting!");
                int temp;
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    for (int j = 0; j <= array.Length - 2; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }

        static void InsertionSort(int[] arr)
            {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            }

        static void QuickSort(int[] array, int start, int end)
            {
                if (start < end)
                {
                    int i = Partition(array, start, end);

                    QuickSort(array, start, i - 1);
                    QuickSort(array, i + 1, end);
                }
            }

            static int Partition(int[] array, int left, int right)
            {
                int temp;
                int pivot = array[right];
                int i = left - 1;

                for (int j = left; j <= right - 1; j++)
                {
                    if (array[j] <= pivot)
                    {
                        i++;
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                temp = array[i + 1];
                array[i + 1] = array[right];
                array[right] = temp;
                return i + 1;
            }



        
        
    }

    
}
