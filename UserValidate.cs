using System;
using System.Text.RegularExpressions;

namespace UserRegistrationLamda
{
    public class UserValidate
    {

        public static bool ValidateName()
        {

            Console.WriteLine("Enter First Name : start with capital and min 3 characters");
            string name = Console.ReadLine();
            String pattern = "^[A-Z][a-zA-Z0-9]{2}";
            Regex regex = new Regex(pattern);

            Func<string, bool> ValidateName = (name) => regex.IsMatch(name);
            {
    
                Console.WriteLine("Valid name entered");
                return true;
            }
        }

   
        public static bool ValidateEmail()
        {
          
            Console.WriteLine("Enter mail id");
            string email = Console.ReadLine();
            String emailPattern = "[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
            Regex regex = new Regex(emailPattern);
           
            Func<string, bool> ValidateName = (email) => regex.IsMatch(email);
            {
              
                Console.WriteLine("Valid email entered");
                return true;
            }
        }


        public static bool ValidatePhoneNumber()
        {
    
            Console.WriteLine("Enter Phone Number");
            string phnNo = Console.ReadLine();
            String phnPattern = "^[9][1][ ][6-9]([0-9]{9})$";
            Regex regex = new Regex(phnPattern);
   
            Func<string, bool> ValidateName = (phnNo) => regex.IsMatch(phnNo);
            {
       
                Console.WriteLine("Valid Phone Number entered");
                return true;
            }
        }

        public static bool ValidatePassword()
        {

            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            String passwordPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            Regex regex = new Regex(passwordPattern);
  
            Func<string, bool> ValidateName = (password) => regex.IsMatch(password);
            {
    
                Console.WriteLine("Valid Password entered");
                return true;
            }
        }
    }
}
