using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace FrameworkExample
{
    internal class Ex06FileIO
    {
        //const string fileName = "TestCode.txt";
        static void WriteToFile(string content)
        {
            if(Configuration != null)
            {
                string? fileName = Configuration["FileOptions:FilePath"];
                Console.WriteLine(fileName);
                if(fileName != null)
                {
                    File.WriteAllText(fileName, content);
                }
                else
                {
                    Console.WriteLine("Path is not sent, Cammot sent the file");
                }
            }
        }

        public static IConfigurationRoot? Configuration { get; private set; }

        static void Initialize()
        {
            var config = new ConfigurationBuilder()
            .SetBasePath("C:\\Users\\6147955\\source\\repos\\WritetoFile\\WritetoFile")
            .AddJsonFile("appsettings.json",optional:false, reloadOnChange: true)
            .Build();
            if(Configuration == null)
            {
                Configuration = config;
            }
        }
        static void Main(string[] args)
        {
            Initialize();
            WriteToFile("Sample Content for file");
        }
    }
}
