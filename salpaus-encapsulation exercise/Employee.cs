using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace salpaus_encapsulation_exercise
{
    public class Employee
    {
        private string socialSecurityNumber;// private field to store the social security number
        public string SSNumber// public property to get and set the social security number
        {
            get
            {
                return socialSecurityNumber.Substring(0,5)+ "******"; // when getting the value,return the first 5 characters followed by ******
                
             
            }
            set 
            {
                bool Control = false;// controll flag to track if there is any invalid character
                if(value.Length==11)// check if the input length is exactly 11 characters
                {
                     for(int i =0; i <value.Length; i++)// loop through each character in the input string 
                     {
                        bool isitNumber = char.IsNumber(value[i]);// check if the character is a number
                        if (isitNumber)
                        {
                            //nothing to do
                            
                        }
                        else
                        {
                            Control = true;// 
                            break;
                        }
                     }
                     if(Control)
                     {
                        Console.WriteLine("There is invalid character.");
                     }
                     else
                     {
                            socialSecurityNumber = value;
                     }

                        

                }
                else
                {
                    Console.WriteLine("your social security number is not 11 character");
                }


            }
        }
    
       
    }
}
