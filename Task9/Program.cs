 var cars=new List<string>(){"Toyota","Lexsus","BMW","Mercedes","Volvo"};  
cars.Add("Opel"); //adding an element 
foreach (var car in cars)
{
    System.Console.WriteLine(car);
}  
System.Console.WriteLine("---------------------------");
cars.AddRange(new [] {"Mitsubishi","Range Rover"}); 
cars.Reverse();
foreach (var car in cars)
{
   System.Console.WriteLine(car); 
}