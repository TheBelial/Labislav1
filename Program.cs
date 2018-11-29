using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.InteropServices;


namespace SimpleCApp
{
    class Program
    {
        
        static int Main(string[] args)
        {
           //foreach (string arg in args)
           //{
           //Console.WriteLine($"Arg:{arg}");
           //}
           //GetUserData();
           //FormatNumericalData();
           //LocalVarDeclarations();
           //NewDataTypes();
           //ObjectFunctionality();
           //DataTypeFunctionality();
           //CharFunctionality();
           //ParseFromStrings();
            //UseOfDatesAndTime();
            //UseOfBigInteger();
           //BasicString();
            //StringConcatenation();
            //EscapeChars();
            //StringEquality();
            //StringsAreImmuteable();
            FunWithStringBuilder();
            Console.ReadLine();
                return -1; 
            
        }

        static void FunWithStringBuilder()
        {
            StringBuilder sb=new StringBuilder("you're such a fucking whore",256);
            sb.Append("\n");
            sb.Append("i love it");
            sb.Append("\n");
            sb.Append("I'm a sick fuq");
            sb.Append(" i like a quick " + "2");
            sb.Append("\n");
            sb.Append("scoop");
            sb.Append("\n");
            sb.Append("i'm a sick fuck i like a quick fuck");
            Console.WriteLine(sb.ToString());
            sb.Replace("2", "fuck");
             Console.WriteLine(sb.ToString());
            Console.WriteLine($"sb has {sb.Length} characters.");
            Console.WriteLine();
        }

        static void StringsAreImmuteable()
        {
            string s1 = "YOU FACE JARAXUS,THE FIRE LORD OF THE BURNING LEGION!";
            Console.WriteLine($"s1={s1}");

            string lowString = s1.ToLower();
            Console.WriteLine($"lowString-{lowString}");
            Console.WriteLine(s1);

            string s2 = "drugoi string";
            s2 = "hui";
            Console.WriteLine(s2);
        }
        static void StringEquality()
        {
            Console.WriteLine("String Equality:");
            string s1 = "Hello!";
            string s2 = "UWU";
            Console.WriteLine($"s1={s1},s2={s2}");
            Console.WriteLine();

            Console.WriteLine($"s1 == s2 {s1==s2}");
            Console.WriteLine($"s1==HELLO!{s1.Equals("HELLO!")}.");
            Console.WriteLine($"s1==Hello!{s1.Equals("Hello!")}.");
            Console.WriteLine($"s1==hello!{s1==("hello!")}.");
            Console.WriteLine($"s1.Equals(s2) {s1.Equals(s2)}.");
            Console.WriteLine($"Yo.Equals(s2),{("UWU")==(s2)}.");
            Console.WriteLine();
        }


        static void EscapeChars()
        {
            Console.WriteLine("Escape characters:");
            string strWithTabs = "DE\tSPA\tCI\tTO\a";
            Console.WriteLine(strWithTabs);
            Console.WriteLine("Everyone loves \"kulini\"\a");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a");
            Console.WriteLine("Lupa\rza");
            //@-выводит в том виде в каком записано;
            Console.WriteLine(@"C:\MyApp\bin\Debug");
            string myLongString = @"My dick
                                        is big
                                                my dick
                                                        is very very big";
            Console.WriteLine(myLongString);
            Console.WriteLine(@"Gorobez skazal ""Ah ti suka eto moya pivolda""");
            Console.WriteLine();
        }
        static void StringConcatenation()
        {
            Console.WriteLine("Concatenation.");
            string s1 = "za";
            string s2 = "lupa";
            string s3 = s1 + s2;
            Console.WriteLine(s3);
            Console.WriteLine();
        }

        static void BasicString()
        {
            Console.WriteLine("Basic string functionality.");
            string firstName = "Tolik";
            Console.WriteLine($"Value of first name-{firstName}.");
            Console.WriteLine($"Length of the first name-{firstName.Length}.");
            Console.WriteLine($"first name in uppercase-{firstName.ToUpper()}.");
            Console.WriteLine($"first name in lowecase-{firstName.ToLower()}.");
            Console.WriteLine($"Does it contain 'y'?-{firstName.Contains("y")}.");
            Console.WriteLine($"First name after replacement-{firstName.Replace("k","chenko")}.");
           
        }
        static void UseOfBigInteger()
        {
            Console.WriteLine("Use of bigint");
            BigInteger biggy=BigInteger.Parse("999999999999999999999999999999999");
            Console.WriteLine($"Value of biggy {biggy}.");
            Console.WriteLine($"Is biggy an even value {biggy.IsEven}.");
            Console.WriteLine($"is biggy a power of two {biggy.IsPowerOfTwo}.");
            BigInteger reallyBig =
                BigInteger.Multiply(biggy, BigInteger.Parse("888888888888888888888888888888888888888888"));
            Console.WriteLine($"Value of reallyBig is {reallyBig}.");
        }

        static void UseOfDatesAndTime()
        {
            Console.WriteLine("Dates and Times");
            DateTime dt = new DateTime(2011,10,17);
            Console.WriteLine($"The day of {dt.Date} is {dt.DayOfWeek}.");
            dt = dt.AddMonths(2);
            Console.WriteLine($"Daylight savings {dt.IsDaylightSavingTime()}");
            TimeSpan ts=new TimeSpan(4,30,0);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Subtract(new TimeSpan(0,15,0)));
        }
        static void ParseFromStrings()
        {
            Console.WriteLine("Data type parsing:" );
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b:{0}",b);
            double d = double.Parse("99,884");
            Console.WriteLine("Value of d: {0}",d);
            int i = int.Parse("8");
            Console.WriteLine("Value of i:{0}",i);
            char c = Char.Parse("w");
            Console.WriteLine($"Value of c:{c}");
            Console.WriteLine();
        }
        static void CharFunctionality()
        {
            Console.WriteLine("=> char type Functionality");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit ('a ' ) : {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter ('a'):{0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello there', 5):{0}",
                char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
                char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation ('?'): {0}",
                char.IsPunctuation('?'));
        }



        static void DataTypeFunctionality()
        {
            Console.WriteLine("Max of int:{0}", int.MaxValue);
            Console.WriteLine("Min of int:{0}", int.MinValue);
            Console.WriteLine("double.Epsilon:{0}", double.Epsilon);
            Console.WriteLine("double.PositivInfinity:{0}",double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity:{0}", double.NegativeInfinity);
            Console.WriteLine("bool.Falsestring: {0 } ", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine();
        }
        static void ObjectFunctionality()
        {
            Console.WriteLine("System.Object Functionality:");
            Console.WriteLine("12.GetHashCode () = {0}" , 12.GetHashCode());
            Console.WriteLine("12.Equals (23) = {0}", 12.Equals (12));
            Console.WriteLine("12.ToString () = {0}", 12.ToString());
            Console.WriteLine("12.GetType () = {0}", (-3).GetType());
            Console.WriteLine();
        }

        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            int myInt=0;
            string myString="ok,so basicly i'm monkey";
            bool b1 = false, b2 = true, b3 = b1;
            System.Boolean b4 = false;
            Console.WriteLine($"My data:{myInt},{myString},{b1},{b2},{b3},{b4}");
            Console.WriteLine();
        }

        static void NewDataTypes()
        {
            Console.WriteLine("New variables:");
            bool b= false;
            int i = 154;
            i=new int();
            double d=new double();
            DateTime dt=new DateTime();
            Console.WriteLine($"{b},{i},{d},{dt}");
            Console.WriteLine();
        }



        static void FormatNumericalData()
        {
            int num = 99999;
            Console.WriteLine("The value 99999 in various formats:");
            Console.WriteLine($"c format:{num:c}");
            Console.WriteLine($"d9 format:{num:d9}");
            Console.WriteLine($"f3 format:{num:f3}");
            Console.WriteLine($"Е format: {num:E2}");
            Console.WriteLine($"е format: {num:e2}");
            Console.WriteLine($"X format: {num:X}");
            Console.WriteLine($"х format: {num:x}");
        }
        static void GetUserData()
        {
            Console.WriteLine("imya");
            string userName = Console.ReadLine();
            Console.WriteLine("age");
            string userAge = Console.ReadLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine($"Hello {userName},you are {userAge} years old");
            Console.ForegroundColor = prevColor;
        }
        static void ShowEnvoirmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine(drive);

            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine("Num of Processors: {0}",
                Environment.ProcessorCount);
            Console.WriteLine(".Net ver: {0}" , Environment.Version);
            Console.WriteLine(Environment.UserName);

        }
    }
}
