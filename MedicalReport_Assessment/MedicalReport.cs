using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearchApplication
{
    enum Severity
    {
        low,high,medium
    }
    enum Cause
    {
        InternalFactor, ExternalFactor
    }

    class Disease
    {
        public string DiseaseName { get; set; }
        public Severity DiseaseSeverity { get; set; }
        public Cause DiseaseCause { get; set; }
        public string DiseaseDescription { get; set; }
    }

    class Symptom
    {
        public string SymptomName { get; set; }
        public Disease DiseaseName { get; set; }
        public string SymptomDescriptiom { get; set; }
    }

    class Patient
    {
        public string PatientName { get; set; }
    }

    class DiseaseManager
    {
        static Disease dis = new Disease();
        public static void AddDisease()
        {
            ////////////////////Disease Name////////////////////
            Console.WriteLine("-------------------------------------------------");
           
            Console.WriteLine("Enter the Disease Name");
            string name = Console.ReadLine();
            dis.DiseaseName = name;

            ////////////////////Severity////////////////////
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Enter the Severity");
            Console.WriteLine("1.Low" +"\n2.Medium" + "\n3.High");
            string severity = Console.ReadLine();
            Severity convertedsev = (Severity)Enum.Parse(typeof(Severity), severity);
            dis.DiseaseSeverity = convertedsev;

            ////////////////////Cause////////////////////
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Enter the cause");
            Console.WriteLine("1.Internal Factor"+"\n2.External Factor");
            string cause = Console.ReadLine();
            Cause convertedcause = (Cause)Enum.Parse(typeof(Cause), cause);
            dis.DiseaseCause = convertedcause;

            ////////////////////Description///////////////
            Exception:
            Console.WriteLine("Enter the Description ");
            string desc = Console.ReadLine();
            //Console.WriteLine(desc.Length);
            if (desc.Length < 30)
            {
                Console.WriteLine("Description is less than 30 letter");
                goto Exception;
            }
             
            Console.WriteLine("Disease added successfully");
            Console.WriteLine("-------------------------------------------------");
        }

        public static void AddSymptom()
        {
            //Disease dis = new Disease();
            //dis.DiseaseName = Console.ReadLine();
            //Console.WriteLine(dis.DiseaseName);

            Console.WriteLine("Enter the Disease Name");
            string name = Console.ReadLine();
            if (dis.DiseaseName == name)
            {
                Symptom sym = new Symptom();
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Enter the Symptom");
                string symptom = Console.ReadLine();
                sym.SymptomName = symptom;
                Console.WriteLine("Symptom added successfully");
            }
            else
                Console.WriteLine("Disease not found");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("Enter the Description ");
            string desc = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------");
        }

        public static void CheckPatient()
        {
            Patient pat = new Patient();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Enter the Patient Name");
            string name = Console.ReadLine();
            pat.PatientName = name;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Enter the Symptom");

        }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Press 1 to Add Disease");
                Console.WriteLine("Press 2 to Add Sympton to the Disease:");
                Console.WriteLine("Press 3 to Check Patient");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DiseaseManager.AddDisease();
                        break;
                    case 2:
                        DiseaseManager.AddSymptom();
                        break;
                    case 3:
                        DiseaseManager.CheckPatient();
                        break;
                }
            } 
        }
    }
} 
