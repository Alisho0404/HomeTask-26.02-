 var car=new List<string>(){"Toyota","Lexsus","BMW","Mercedes","Volvo"};  
 foreach (var cars in car)
 {
    System.Console.WriteLine(cars);
 } 
 System.Console.WriteLine("-----------------");
 car.Remove("Volvo"); 
 foreach (var cars in car)
 {
    System.Console.WriteLine(cars);
 }