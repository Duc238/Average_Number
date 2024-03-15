using System.Diagnostics;
using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            int NumberTotal, NumberStart=0, NumberSum=0;
            Console.WriteLine("Nhập số các số muốn tính trung bình: ");
            NumberTotal=Convert.ToInt32(Console.ReadLine());
            while(NumberStart<=NumberTotal) 
            {
                Console.WriteLine("Nhập vào số thứ {0}: ",NumberStart);
                NumberSum += Convert.ToInt32(Console.ReadLine());
                NumberStart++;
            }
            Console.WriteLine("Giá trị trung bình= {0}", (double)NumberSum/NumberTotal);
        }
    }
}
