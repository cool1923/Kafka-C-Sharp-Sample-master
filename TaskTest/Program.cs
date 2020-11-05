using System;
using System.Threading.Tasks;

namespace TaskTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(MyMethod);
            t1.Start();
           // t1.Wait();
            Console.WriteLine("主线程代码运行结束");
            Console.ReadLine();
        }
        static void MyMethod()
        {

            Console.WriteLine("线程代码运行");
           // throw new Exception("Task异常测试");
        }
    }
}
