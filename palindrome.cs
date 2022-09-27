// See https://aka.ms/new-console-template for more information
using System;
namespace app
{
    class palindrome
    {
        static void Main(string[] args){

         Console.WriteLine("Enter your input");
         string palindromeInput=Console.ReadLine();
         String result = palindromeCheck(palindromeInput);
         Console.WriteLine(result);
         }

        static string palindromeCheck(string palindromeInput){
            string input=palindromeInput.ToUpper();// convert to uppercase
            
            int length=input.Length;
            for (int i=0;i<length/2;i++){
                if (input[i]!=input[length-i-1])
                   return "Is not palindrome"
            
            
            }
            return "Is palindrome";
        }
    }

         


}