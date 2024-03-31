using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Example2.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public int? Balance { get; set; }

        public void DisplayUser()
        {
            Console.WriteLine($"Id: {Id} Firstname : {FirstName} Lastname : {LastName} balance : {Balance} ");
        }
    }
}
