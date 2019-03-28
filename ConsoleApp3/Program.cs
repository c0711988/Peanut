using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("peter rules IT department!");
            Download();
            Console.ReadLine();

        }
        static async void Download();

        HttpClient client = new HttpClient();
        var data = await client.GetStringAsync("http://ibm.com");
        Console.Writeline(data);
            // ToDo: Store eac line of the website into an entry
            // in a list 
            
            List myList = new List();

    }
    class Network
{
 static public Task Download()
        {
            return Task.Run(() => Thread.Sleep(3000));        }

    }
}
