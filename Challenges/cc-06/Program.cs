using System;
using System.Collections.Generic;

namespace CommonElement
{
    public class CommonElementsFinder
    {
        public static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 0 };
            int[] array2 = { 2, 3, 4, 9 };
            int[] result = CommonElements(array1, array2);

            Console.WriteLine("Common Elements: ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }

        public static int[] CommonElements(int[] array1, int[] array2)
        {
            List<int> commonElements = new List<int>();

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        if (!IsInArray(commonElements, array1[i]))
                        {
                            commonElements.Add(array1[i]);
                        }
                        break;
                    }
                }
            }

            int[] result = new int[commonElements.Count];
            for (int k = 0; k < commonElements.Count; k++)
            {
                result[k] = commonElements[k];
            }

            return result;
        }

        private static bool IsInArray(List<int> list, int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
