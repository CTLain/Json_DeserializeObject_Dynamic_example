using System;
using Newtonsoft.Json.Linq;

namespace Json_DeserializeObject_Dynamic_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            JObject jo = JObject.Parse(jsonSrc);
            dynamic dyna = jo as dynamic;
            //var ary = ((JArray)jo["a"]).Cast<dynamic>().ToArray();
            //Console.WriteLine("d:{0},n:{1},s:{2},a:{3}", dyna.d, dyna.n, dyna.s,
            //    string.Join("/", ary));
            JArray array = (JArray)jo["Items"];
            Console.WriteLine("d:{0},n:{1},s:{2}", dyna.a[0], dyna.Items[0].Price, dyna.s);
            //Console.WriteLine("count = {0}", dyna.Items.Length);
        }

        static string jsonSrc =
@"{ 
    ""d"": ""2015-01-01T00:00:00Z"", 
    ""n"": 32767, 
    ""s"": ""darkthread"",
    ""a"": [ 99,2,3,4,5 ],
    ""Items"":[
    { ""Name"":""Apple"", ""Price"":12.3 },
    { ""Name"":""Grape"", ""Price"":3.21 }
  ]
}";

    }
}
