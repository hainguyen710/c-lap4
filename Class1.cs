using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class1
    {
        static void main(string[] args) 
        {
            int[] arr = { 10, 3, 21, 6, 1 };
            int i, j, tmp;
            //vong lap cho moi phan tu cua mang chua sap xep
            for(i = 0; i <5; i++)
            {
                tmp = arr[i];
                j = i - 1;
                //vong lap cho moi phan tu cua mang da sap xep
                while(j >= 0 && tmp < arr[i])
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j+ 1] = tmp;
            }
            //hien thi mang duoc sap xep

            System.Console.WriteLine("\nHien thi mang da duoc sap xep: \n");
            for(i = 0; i <5; i++)
                System.Console.WriteLine(arr[i]);   
        }
    }
}
