using System;
using System.Numerics;
using System.Xml.Linq;

namespace Lesson3Methods
{
    class Program
    {

        // (static) RETURN_TYPE(DATA TYPE)  METHOD_NAME (DATA_TYPE - PARAMETERS) { } 
        static void Main(string[] args)
        {
            #region Lesson Main method
            //int x = 3;
            //int y =  F(x);
            //Console.WriteLine($"Method Main - X = {x}");

            //Console.WriteLine("Input Your Name: ");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Input Your Surname: ");
            //string surname = Console.ReadLine();
            //Console.WriteLine("Input Your FatherName: ");
            //string fatherName = Console.ReadLine();


            //string age = "18";
            //string fullName = PrintUserInfo(userName,22);
            //Console.WriteLine(fullName);

            //string dbIP = "172.10.1.72";
            //string provider = "MongoDB";
            //string providerVer = "3.2.2";

            //DBConnection(provider,providerVer);
            #endregion
            //Console.WriteLine("Enter number 1: ");
            //string number1 = Console.ReadLine();
            //bool result  = int.TryParse(number1, out int num1);
            //Console.WriteLine("enter number 2: ");
            //string number2 = Console.ReadLine();
            //bool result2 = int.TryParse(number2, out int num2);
            //if (result && result2)
            //{
            //    int sum1 = Sum(num1, num2);
            //    Console.WriteLine(sum1);
            //}
            //else
            //{
            //    double.TryParse(number1, out double numb1);
            //    double.TryParse(number2, out double numb2);
            //    double sum2 = Sum(numb1, numb2);
            //    Console.WriteLine(sum2);
            //}


            


        }
        //static int Sum(int number1,int number2)
        //{
        //   return number1 + number2;
        //}

        //static double Sum(double number1,double number2)
        //{
        //    return number1 + number2;
        //}
        #region methods basic
        //static int F(int x)  // int x = x.Copy();
        //{
        //    //return Keyword

        //    int y = x * 2 - 1;

        //    x = 25;
        //    Console.WriteLine($"Method F - X = {x}");
        //    //Qaytardigi deyer
        //    return y;
        //}

        //static string Search(string surname)
        //{
        //    string name = default;
        //    //Databasede axtarish 
        //    return name;
        //}

        //static void PrintLine(string data)
        //{//begin

        //     if (data=="")
        //     {
        //         return;
        //     }

        //     Console.WriteLine(data);
        // } // end
        #endregion

        #region Method Overloading
        //static string PrintUserInfo(string TV)
        //{

        //    return $"User Full name is {TV}";
        //}

        //static string PrintUserInfo(string phone, int phoneNumber)
        //{
        //    return $"User name is {phone} and age is {phoneNumber}";

        //}
        //static string PrintUserInfo(string car, string motor) //name = userName.Copy()
        //{
        //    return $"User Full name is {car} {motor}";

        //}
        //static string PrintUserInfo(string car, string wheel,int wheelCount) //name = userName.Copy()
        //{
        //    return $"User Full name is {car} {wheel}";

        //}


        //static string PrintUserInfo(string userName,string surname,string fatherName)
        //{

        //    return $"User Full name is {userName} {surname} {fatherName}";
        //}

        //default parametr
        //static void DBConnection( string dbProvider,string providerVersion, string dbConnectionIP = "172.12.2.98")
        //{
        //    Console.WriteLine("Hello with default ");
        //}
        #endregion


        

    }
}
