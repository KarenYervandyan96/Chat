using Chat;
using Chat.Dto;
using Chat.Service;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    //internal class Program
    //{
    //    public static IList<MessageITem> list;
    //    public static ChatService chat = new ChatService();
    //    static void Main(string[] args)
    //    {

    //        Console.WriteLine("Hello World!");
    //        Task.Run(() => { Print(); });

    //        while (true)
    //        {
    //            Task.Delay(10000);
    //            string n = Console.ReadLine();
    //            string m = Console.ReadLine();

    //            chat.CreatMessage(new CreatMessage(n, m)).GetAwaiter().GetResult();

    //        }
    //    }


    //    private static void Print()
    //    {
           
    //        while (true)
    //        {
    //            Task.Delay(10000);
    //            list = (chat.GetAllMessageAsync().Result).ToList();
    //            Thread.Sleep(5000);
    //            Console.Clear();
    //            foreach (MessageITem message in list)
    //            {
    //                Console.WriteLine(message.ToString());

    //            }

    //        }
    //    }


    //}
}