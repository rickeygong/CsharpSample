using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSample.Chapter2_BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 54, 26, 93, 17, 77, 31, 44, 55, 20 };
            int[] insertSortList = InsertSort(list,"Des");
            string sList = string.Join(",", insertSortList);
            Console.WriteLine(sList);
            Console.ReadKey();
        }


        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="array"></param>
        /// <param name="type">输入参数，升序：Asc,降序：Des</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int[] BubbleSort(int[] array, string type)
        {
            if (!type.Equals("Asc", StringComparison.OrdinalIgnoreCase) && !type.Equals("Des", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Invalid value for 'type' parameter. Valid values are 'Asc' or 'Des'.", nameof(type));
            }
            int num = array.Length - 1;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (type.Equals("Asc"))
                    {
                        if (array[j] > array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                    else if (type.Equals("Des"))
                    {
                        if (array[j] < array[j + 1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// 插入排序
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] InsertSort(int[] array,string type)
        {
            if (!type.Equals("Asc", StringComparison.OrdinalIgnoreCase) && !type.Equals("Des", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Invalid value for 'type' parameter. Valid values are 'Asc' or 'Des'.", nameof(type));
            }
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (type.Equals("Asc"))
                    {
                        if (temp < array[j])
                        {
                            array[j + 1] = array[j];
                            array[j] = temp;
                        }
                    }
                    else if (type.Equals("Des"))
                    {
                        if (temp > array[j])
                        {
                            array[j + 1] = array[j];
                            array[j] = temp;
                        }
                    }
                    
                }
            }
            return array;
        }
    }
}
