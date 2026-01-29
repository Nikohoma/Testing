using System;
using System.Collections.Generic;
using System.Text;
using EmployeeServices.Repositories;

namespace EmployeeServices.Class
{
    public class EmployeeServiceClass : IEmployeeServiceRepository
    {
        public int GetId(int id)
        {
            Console.WriteLine("ID is :");
            return id;
        }

        public string GetName(string name)
        {
            return $"{name} is here.";
        }
    }
}
