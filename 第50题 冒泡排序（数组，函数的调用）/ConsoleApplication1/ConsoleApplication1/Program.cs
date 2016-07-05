using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /*unsorted:未排序的*/
        static void bubble_sort(int[] unsorted)
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                for (int j = i; j < unsorted.Length; j++)
                {
                    if (unsorted[i] > unsorted[j])
                    {
                        int temp = unsorted[i];
                        unsorted[i] = unsorted[j];
                        unsorted[j] = temp;
                    }
                }
            }
        }
        /*args:存储的是命令，其后才是参数!*/
        static void Main(string[] args)
        {
            int[] x = { 1,9,3,7,4,2,5,0,6,8 };
            //bubble_sort为冒泡排序
            bubble_sort(x);
            /*var用来定义变量  item:一条*/
            //在x里定义这条数组
            foreach (var item in x)
            {
                Console.Write("{0}\t",item);
            }
            Console.ReadLine();
        }
    }
}