using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_7_23__Assign__9_
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name, email, password;
                Console.WriteLine("Enter your name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter your email address:");
                email = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();
                if (name.Length < 6)
                {
                    throw new ValidationException("Enter the name should be minimum 6");
                }
                else if (password.Length < 8)
                {
                    throw new ValidationException("Enter the password should be minimum 8");
                }
                else if (!email.Contains("@"))
                {
                    Console.WriteLine("Email must contain \"@\" ");
                }
                else
                {
                    Console.WriteLine("User registration is  successfull!!!");
                    Console.WriteLine($"Name:  {name} \nEmail: {email} \nPassword: {password}");
                }

            }
            catch (ValidationException ce)
            {
                Console.WriteLine("Error !! in validation  " + ce.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!! " + ex.Message);
            }

            finally
            {
                Console.WriteLine("****End of Registration process**");

                Console.ReadKey();
            }
        }

    }
}


    

