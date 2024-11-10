using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace hw
{

public class Player{
public string Name { get; set; }
public string Surname { get; set; }
public string Description { get; set; }
public int Salary { get; set; }
public int Number { get; set; }


public Player(){
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

          WriteLine("Enter a number of the player: ");
     string n= ReadLine();
     int number = int.Parse(n);
     Number = number;
     

}

}

}