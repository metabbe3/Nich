using System;
using System.Collections.Generic;  
using System. Linq;  
using System. Text;  
using System.Threading.Tasks;  

namespace rifactory
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // 
            // 
            
           // NumberOne.hello();
           // NumberTwo.date(new DateTime(2020,01,22),new DateTime(2020,10,13));
           // NumberThree.three("Hai Aku Nicholas!");
           // NumberFour.censored();
           //  Console.WriteLine(NumberFive.isEven(3));
           //  Console.WriteLine(NumberFive.isOdd(5));
           //  Console.WriteLine(NumberSix.Grade(90));
           // Console.WriteLine(NumberSeven.CelciusToFahrenheit(0));
           // Console.WriteLine(NumberSeven.FahrenheitToCelcius(50));
           // Console.WriteLine(NumberSeven.CelciusToKelvin(100));
           // Console.WriteLine(NumberSeven.KelvinToCelcius(375));
           // Console.WriteLine(NumberSeven.KelvinToFahrenheit(375));
           // Console.WriteLine(NumberSeven.FahrenheitToKelvin(12));
           // Console.WriteLine(NumberEight.isLeapYear(2020));
        //      var jakarta = Tuple.Create("Jakarta", 7);
        //     var bali = Tuple.Create("Bali", 8);
        //     var london = Tuple.Create("London", 0);
        //     var cairo = Tuple.Create("Cairo", 2);
        //     var denver = Tuple.Create("Denver", -6);
        //     var chicago = Tuple.Create("Chicago", -5);
        //    Console.WriteLine(NumberNine.TimezoneDiff(jakarta,london));
           //  Console.WriteLine(NumberTen.Sum(1,2));
           // Console.WriteLine(NumberEleven.sumAll());
           // Console.WriteLine(NumberTwelve.uppercase("haiii"));
           // Console.WriteLine(NumberThirteen.CountWords("AKU ADALAH ANAK GEMBALA"));
           // Console.WriteLine(NumberFourteen.IsPalindrome("malam"));
           // Console.WriteLine(NumberFifteen.Mirror("--VV"));
        //    string[] fruits = {
        //         "Jeruk",
        //         "Apel",
        //         "Anggur",
        //         "Pepaya",
        //         "Pisang",
        //         "Kiwi",
        //         "Markisa",
        //     };
        //     Console.WriteLine(NumberSixteen.IndexFinder(fruits,"Jeruk"));
        //    NumberSeventeen.Loop();
        // int[] numbers = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};
        // Console.WriteLine(NumberEightteen.FindMax(numbers));
        // Console.WriteLine(NumberEightteen.FindMin(numbers));
        // Console.WriteLine(NumberEightteen.FindAverage(numbers));
        //NumberNineteen.Sort();
            Item item = new Item();
            item.name = "Indomie Goreng";
            item.price = 3500;
            item.onSale = true; // If true the price will drop 20%
            item.print(); // Output: "Indomie Goreng (Rp2800)"
        
        
    }
    
 // Example
   class NumberOne 
    {
        public static void hello()
        {
            Console.WriteLine("Enter Your Name : ");
            string a = Console.ReadLine();
            Console.WriteLine($"Hello, my name is {a}");
        }
    }

     class NumberTwo 
    {
        public static void date(DateTime startDate,DateTime endDate)
        {
            int remaining = (endDate.Date - startDate.Date).Days; 
            Console.WriteLine($"{remaining} days remaining to my next birthday.");
        }
    }

     class NumberThree 
    {
        public static void three(string text)
        {
             Console.WriteLine($"'{text}' have {CountString(text)} characters");
        }
        public static int CountString(string args)
        {
           int stringLength = args.Length;
           return stringLength;
        }
    }

    class NumberFour 
    {
        public static void censored()
        {
            // We have some word collection ...
            var censoredWords = new List<string>(){"imperdiet","dolor","duo"};
            
            // and a paragraph.
            var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";
            foreach(string cens in censoredWords){
                int censLength = cens.Length;
                int indexCens = paragraph.IndexOf(cens);
                string censW = "";
                for(int i=0;i<censLength;i++){
                   censW = censW + "*";
                }
               paragraph =  paragraph.Replace(cens,censW);
            }
            Console.WriteLine(paragraph);
        }
    }

    class NumberFive 
    {
        public static bool isEven(int num) => num % 2 == 0;
        public static bool isOdd(int num) => num % 2 != 0;
    }

    class NumberSix 
    {
        public static string Grade(int score){
            string grade = "";
           if(score >= 90){
               grade = "A";
           }else if(score >= 80){
               grade = "B";
           }else if(score >= 70){
               grade = "C";
           }else if(score >=60){
               grade = "D";
           }else{
               grade = "E";
           }
            
            return grade;
        }
    }

    class NumberSeven 
    {
        public static int CelciusToFahrenheit(int input){
            return (input * 9/5)+32 ;
        }
        public static int FahrenheitToCelcius(int input){
            return (input - 32) * 5/9 ;
        }
        public static double CelciusToKelvin(int input){
            return (input + 273.15);
        }
        public static double KelvinToCelcius(int input){
             return (input - 273.15);
        }
        public static double KelvinToFahrenheit(int input){
            return (input - 273.15) * 9/5 + 32;
        }
        public static double FahrenheitToKelvin(int input){
            return (input - 32) * 5/9 + 273.15;
        }
    }
    class NumberEight{
        public static bool isLeapYear(int year){
           if (DateTime.IsLeapYear(year))
            {
               return true;
            }else{
                return false;
            }
        }
    }

    class NumberNine 
    {
        public static string TimezoneDiff(dynamic a,dynamic b){
          
          
         return $"{a.Item1} {a.Item2 - b.Item2} Hours ahead {b.Item1}";
        }
    }

    class NumberTen 
    {
        public static int Sum(int a,int b){
           return a+b;
        }
        public static int Substract(int a,int b){
           return a-b;
        }
        public static int Multiply(int a,int b){
           return a*b;
        }
        public static int Divide(int a,int b){
           return a/b;
        }
    }

    class NumberEleven
    {
        public static int sumAll(){
            string[] arguments = Environment.GetCommandLineArgs();
            int i=0;
           
            foreach(string a in arguments){
                Int32.TryParse(a, out int j);
                i = i+j;
            }
            return i;
        }
    }
    class NumberTwelve
    {
        public static string uppercase(string a){
            return a.ToUpper();
        }
    }

    class NumberThirteen
    {
        public static int CountWords(string a){
            string[] count = a.Split(" ");
            return count.Length;
        }
    }
    class NumberFourteen
    {
        public static bool IsPalindrome(string a){
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);
            string aRev = new string(arr);
            if(a == aRev){
                return true;
            } else{
                return false;
            }
        }
    }

    class NumberFifteen
    {
        public static string Mirror (string a){
            char[] arr = a.ToCharArray();
            Array.Reverse(arr);
            string aRev = new string(arr);
           return $"{a}{aRev}";
        }
    }
    class NumberSixteen
    {
        public static int IndexFinder (Array b, string a){
            
           return Array.IndexOf(b,a);
        }
    }

    class NumberSeventeen
    {
        public static void Loop(){
            for(int i=0;i<1000;i++){
                if(i%5 == 0){
                    Console.WriteLine($"{i}. Foo");
                }
                if(i%20 == 0){
                    Console.WriteLine($"{i}. Bar");
                }
                if(i%100 == 0){
                    Console.WriteLine($"{i}. Baz");
                }
            }
        }
    }

    class NumberEightteen
    {
        public static int FindMax(Array a){
            int maxInt = int.MinValue;
            foreach(int num in a){
                    if(num > maxInt){
                        maxInt = num;
                    }
            }
            return maxInt;
        }

        public static int FindMin(Array a){
            int minInt = int.MaxValue;
            foreach(int num in a){
                    if(num < minInt){
                        minInt = num;
                    }
            }
            return minInt;
        }

        public static double FindAverage(Array a){
            int tempNumb = 0;
            foreach(int num in a){
                    tempNumb += num;
            }
            return tempNumb / a.Length;
        }
    }

    class NumberNineteen
    {
        public static void Sort(){
            int[] points = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 45};

           Array.Sort(points);
           Console.WriteLine("[{0}]", string.Join(", ", points));
        }
    }
     class Item
    {   
        public string name;
        public double price;
        public bool onSale;
       
        public void print(){

            if(onSale){
                Console.WriteLine($"{name} (Rp{price*80/100})");
            }else{
                 Console.WriteLine($"{name} (Rp{price})");
            }
        }
        
    }
    

 }
}
