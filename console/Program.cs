// See https://aka.ms/new-console-template for more information


// read csv file

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using classlibrary.Data;
using classlibrary.Models;

namespace console
{
    class Program
    {
        
        static void KiIr(IEnumerable<Object> adatok)
        {
            foreach (var item in adatok)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            // read csv file

            EmployeeContext db = new EmployeeContext();

            if (!db.Employee.Any())
            {
                var lines = File.ReadAllLines("19.csv").Skip(1);
                var employees = new List<Employee>();
                foreach (var line in lines)
                {
                    db.Employee.Add(new Employee(line));
                    db.SaveChanges();
                }
            }
            
            KiIr(db.Employee.ToList());
            
        }
        
    }
}