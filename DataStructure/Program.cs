using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

using System.Threading.Tasks;

namespace MasteringC_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Collections.Generic.List<String> list = new List<String>();
            list.Add("Test 1");
            list.Add("Test 2");

            for (var i=0; i <list.Count; i++){
                    Console.WriteLine("List are: {0}", list[i]);
            }


            


        }
    }
}
