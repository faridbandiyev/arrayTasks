namespace arrayTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1

            int[] arr = { 2, 3, 4, 5 };

            int length = arr.Length;
            for (int i = 0; i < length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[length - i - 1];
                arr[length - i - 1] = temp;
            }

            for (int i = 0; i < length; i++)
                Console.WriteLine(arr[i]);

            #endregion

            #region task2

            int[] arr1 = { 0, 1, 2, 3 };
            int[] arr2 = { 0, 1, 2, 3, 4 };
            bool isDuplicate = true;

            if (arr1.Length > arr2.Length)
            {
                isDuplicate = false;
            }
            else
            {

                for (int i = 0; i < arr1.Length; i++)
                {
                    bool found = false;
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        isDuplicate = false;
                        break;
                    }
                }

            }


            if (!isDuplicate)
            {
                Console.WriteLine("Two different arrays.");
            }
            else
                Console.WriteLine("True");

            #endregion

            #region task3

            int[] arr3 = { 1, 2, 3, 4 };
            bool isDuplicateTask3 = false;

            for (int i = 0; i < arr3.Length - 1; i++)
            {
                if (arr3[i] == arr3[i + 1])
                {
                    Console.WriteLine("Duplicate numbers");
                    isDuplicateTask3 = true;
                }
            }

            if (!isDuplicateTask3)
                Console.WriteLine("No duplicate numbers.");


            #endregion
        }
    }
}
