using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw
{

public class Worker{
public string Name { get; set; }
public string Surname { get; set; }
public string Description { get; set; }
public int Salary { get; set; }



public Worker(){
    WriteLine("Enter a name: ");
   Name = ReadLine();

    WriteLine("Enter a surname: ");
   Surname = ReadLine();

       WriteLine("Enter a description: ");
   Description = ReadLine();

       WriteLine("Enter a salary: ");
     string s = ReadLine();
     int salary = int.Parse(s);
     Salary = salary;

 
     

}

}

}