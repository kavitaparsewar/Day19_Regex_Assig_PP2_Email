using System;

namespace Day19_Regex_Assig_PP2_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1_sample_email_to_test valid = new UC1_sample_email_to_test();

            //#region valid emails
            //Console.WriteLine(valid.validatePinCode("abc@yahoo.com,"));
            //Console.WriteLine(valid.validatePinCode("abc-100@yahoo.com,"));
            //Console.WriteLine(valid.validatePinCode("abc.100@yahoo.com"));
            //Console.WriteLine(valid.validatePinCode("abc111@abc.com,"));
            //Console.WriteLine(valid.validatePinCode("abc-100@abc.net,"));
            //Console.WriteLine(valid.validatePinCode("abc.100@abc.com.au"));
            //Console.WriteLine(valid.validatePinCode("abc@1.com,"));


             Console.WriteLine(valid.validatePinCode("abc@gmail.com.com"));


            //Console.WriteLine(valid.validatePinCode("abc+100@gmail.com"));
            //#endregion valid emails


            #region invalid emails
            //Console.WriteLine(valid.validatePinCode("abc"));
            //Console.WriteLine(valid.validatePinCode("abc@.com.my"));
            //Console.WriteLine(valid.validatePinCode("abc123@gmail.a"));
            //Console.WriteLine(valid.validatePinCode("abc123@.com"));
            //Console.WriteLine(valid.validatePinCode("abc123@.com.com"));
            //Console.WriteLine(valid.validatePinCode(".abc@abc.com"));
            //Console.WriteLine(valid.validatePinCode("abc()*@gmail.com"));
            //Console.WriteLine(valid.validatePinCode("abc@%*.com"));
            //Console.WriteLine(valid.validatePinCode("abc@.com.my"));
            //Console.WriteLine(valid.validatePinCode("abc..2002@gmail.com"));
            //Console.WriteLine(valid.validatePinCode("abc.@gmail.com"));
            //Console.WriteLine(valid.validatePinCode("abc@abc@gmail.com"));
            //Console.WriteLine(valid.validatePinCode("abc@gmail.com.1a"));
            //Console.WriteLine(valid.validatePinCode("abc @gmail.com.aa.au"));
            #endregion invalid emails

        }
    }
}
