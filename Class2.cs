using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class2
    {
        static void main(string[] args)
        {
            int[] arr = { 10, 3, 6, 24, 12 };
            int i, j, tmp;
            //vong lap dem so phan tu cua mang da dc sap xep
            for(i=0; i< 5; i++)
            {
                if (arr[j] > arr[j + 1])
                {
                    tmp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tmp;
                }
            }
            //hien thi mang da dc sap xep
            System.Console.WriteLine("\nHien thi mang da dc sap xep");
            System.Console.WriteLine(arr[i]);

        }
    }
}
