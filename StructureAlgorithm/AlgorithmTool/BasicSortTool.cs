using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureAlgorithm.AlgorithmTool
{
    public static class BasicSortTool
    {
        public static void Show()
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random(i + DateTime.Now.Millisecond).Next(100, 999);
            }

            Console.WriteLine("before BubbleSort");
            array.Show();
            Console.WriteLine("start BubbleSort");
            //array.BubbleSort();
            //array.SelectionSort();
            array.InsertionSort();

            Console.WriteLine("  end BubbleSort");
            array.Show();
        }


        /// <summary>
        /// 冒泡排序
        /// 先挑最大值 摆在最后面
        /// 先挑最小值 摆在最前面？
        /// </summary>
        /// <param name="arr"></param>
        public static void BubbleSort(this int[] arr)
        {
            int temp;
            for (int outer = arr.Length; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if (arr[inner] > arr[inner + 1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }
                arr.Show();
            }
        }
        /// <summary>
        /// 选择排序
        /// 依次选择最小的数字放到最左边
        /// </summary>
        /// <param name="arr"></param>
        public static void SelectionSort(this int[] arr)
        {
            int min, temp;
            for (int outer = 0; outer < arr.Length; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner < arr.Length; inner++)
                {
                    if (arr[inner] < arr[min])
                    {
                        min = inner;
                    }
                }
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
                arr.Show();
            }
        }

        /// <summary>
        /// 插入排序
        /// 从第2个数开始，跟第一个数对比，放在左边还是右边
        /// 循环下去比较，都放在合适的位置
        /// </summary>
        /// <param name="arr"></param>
        public static void InsertionSort(this int[] arr)
        {
            int inner, temp;
            for (int outer = 1; outer < arr.Length; outer++)
            {
                temp = arr[outer];
                inner = outer;
                while (inner > 0 && arr[inner - 1] >= temp)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }
                arr[inner] = temp;
                arr.Show();
            }
        }

        private static void Show(this int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
