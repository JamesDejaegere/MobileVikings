using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MV.WebApi;

namespace Test.MV.WebApi
{
    class Program
    {
        static void Main(string[] args)
        {

            GetSims();
            Console.ReadLine();
        }

        private async static void GetSims()
        {
            var client = new WebClient();
            var sims = await client.GetSimsAsync();

            foreach (var sim in sims)
            {
                Console.WriteLine(sim.alias + " :: " + sim.msisdn);
            }
        }
    }
}
