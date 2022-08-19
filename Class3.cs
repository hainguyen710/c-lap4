using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Class3
    {
        static void main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int low = 0, hight = 9, mid;
            int giaTri, timThay = 0;
            System.Console.WriteLine("\nNhap vao 1 gia tri nguyen");
            giaTri = int.Parse(Console.ReadLine());
            while (low <= hight)
            {
                mid = (low + hight) / 2;
                if (arr[mid] == giaTri) { 
                    System.Console.WriteLine("\nGia tri duoc tim thay o vi tri %d cua mang !", giaTri, mid);
                timThay = 1;
                break; }
            else if(arr[mid]> giaTri)
            {
                hight = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
            if (timThay == 0)
                System.Console.WriteLine("\nGia tri" + giaTri + "khong dc tim thay trong mang");

            }
            
            

            
            
        }
    }
}
