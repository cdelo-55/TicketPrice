using System;

namespace ticketPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int ticket;
            Boolean isStudent = false;

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Are you a student (Y or N)");
            var student = (Console.ReadLine());
            
            if (student == "Y" || student == "y") {
              isStudent = true;
            }

            ticket = 14;
            
            if (age >= 65) {
                ticket = 10;
            }
            if ((age >= 0 && age <=12 ) || isStudent == true) {
                ticket = 8;
            }; 
            
            try {
                if (age < 0) {
                    throw new ArgumentException("Age cannot be negative");  
                }
                else {
                    Console.WriteLine("Ticket price is: " + ticket);
                }
            }
            catch (ArgumentException) {
                Console.WriteLine("Age cannot be negative");
                }                
        }
    }
}
