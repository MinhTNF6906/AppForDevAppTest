using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        [DllImport("user32")]
        public static extern void LockWorkStation();
        static void Main(string[] args) {
            Console.Write("Hello, may i have you name? : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.Write("Please pick a number from 1 to 3 : ");
            string num = Console.ReadLine();
            if(num == "1")
            {   
                // chọn 1 thì ăn rickroll
                Process myProcess = new Process();
                try
                {
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
                    myProcess.Start();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            if (num == "2")
            {
                // sập luôn máy     
                Process.Start("shutdown", "/s /t 0");
            }
            if (num == "3")
            {
                //em k bt treo hệ thống nên làm cái khác :"))
                // là gì thi a cứ chọn số 3 r enter :>>
                while (true)
                {
                    LockWorkStation();
                }
            }           
        }
    }
}