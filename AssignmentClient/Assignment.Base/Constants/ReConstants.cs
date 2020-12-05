using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment.Base.Constants
{
    /// <summary>
    /// Regular Express constants for reuse
    /// </summary>
    public class ReConstants
    {
        // Regex for Alphanumeric value
        public static readonly Regex SpecialCharacterReg = new Regex("^[a-zA-Z0-9 ]*$");
       
        //Regex for Password
        /** Pattern satisfy, these below criteria
         Password Length 8 and Maximum 15 character
         Require Unique Chars
         Require Digit
         Require Lower Case
         Require Upper Case  */
        public static readonly Regex PasswordReg = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$");
      
        //Regex for email
        public static readonly Regex EmailReg =
            new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        //Regex for simple Name 
        public static readonly Regex NameBaseReg = new Regex(@"^[a-zA-Z0-9]{3,10}$");

        //Regex from integer only
        public static readonly Regex YearReg = new Regex(@"^[0-9]{4,4}$");
    }
}
