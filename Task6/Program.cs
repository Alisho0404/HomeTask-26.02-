using System.Net.WebSockets;

List<bool> values = new List<bool>{ true, true, true }; 
bool allTrue=values.All(p=>p==true);
Console.WriteLine("Are all the values in the list true? " + allTrue);