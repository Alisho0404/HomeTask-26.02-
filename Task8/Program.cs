using System.Runtime.InteropServices;

var cars=new List<string>(){"Toyota","Lexsus","BMW","Mercedes","Volvo"};  

 var right=cars.Contains("Toyota"); // resut will be true cause toyota exist in this list 
 System.Console.WriteLine(right);

 System.Console.WriteLine(cars.Exists(car=>car=="Opel"));  // result false, Opel does not exist in list cars