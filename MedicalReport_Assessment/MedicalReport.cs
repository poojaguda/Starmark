
using System;

namespace SampleFrameworksApp.Assignment
{
    class details
    {
        public string name { get; set; }
        public string severity { get; set; }
        public string cause { get; set; }
        public string description { get; set; }
        public string symptoms { get; set; }
    }


    class AddingDisease
    {
        private details[] det = null;
        private int size = 0;
        public AddingDisease(int size)
        {
            this.size = size;
            //Console.WriteLine("hi");
            det = new details[size];
            // Console.WriteLine(size);
            //Console.WriteLine("bye");

        }
        public void AddDisease(details dts)
        {
            //Console.WriteLine(size);
            for (int i = 0; i < size; i++)
            {

                //Console.WriteLine(  i);
                if (det[i] == null)
                {
                    det[i] = new details { name = dts.name, severity = dts.severity, cause = dts.cause, description = dts.description };
                    Console.WriteLine("Added succesfully");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Symptoms(dts);
                    return;

                }
                else
                {
                    //Console.WriteLine("hi");
                    throw new Exception("Adding failed");
                }

            }

        }
        public static void Symptoms(details dts)
        {
            Console.WriteLine("Enter the symptoms for " + dts.name);
            Console.WriteLine("Enter the disease name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the symptom name");
            string symp = Console.ReadLine();
            Console.WriteLine("Enter the description");
            string desc = Console.ReadLine();
        }
        public static void operation()
        {
            Console.WriteLine("Enter the name of the disease");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Severity of the disease");
            string severity = Console.ReadLine();
            Console.WriteLine("Enter the cause of the disease");
            string cause = Console.ReadLine();
            Console.WriteLine("Enter the Description of the disease");
            string description = Console.ReadLine();
            details dts = new details { name = name, severity = severity, cause = cause, description = description };
            bl.AddDisease(dts);




        }
        public static AddingDisease bl = null;
        public static void useful()
        {
            Console.WriteLine("enter the size");
            int size = Convert.ToInt32(Console.ReadLine());
            bl = new AddingDisease(size);

        }
    }

    class Diesease
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The details of the Diseases");
            AddingDisease.useful();
            AddingDisease.operation();
        }

    }
}


