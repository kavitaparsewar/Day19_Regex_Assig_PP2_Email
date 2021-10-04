using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex_Assig_PP2_Email
{
    class UC1_sample_email_to_test
    {
      public static string validationgmailCUC1 = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?[,]$";

      
        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, validationgmailCUC1);
        }
    }
}
