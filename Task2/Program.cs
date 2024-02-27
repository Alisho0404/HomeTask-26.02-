 List<string> words = new List<string>{ "hello", "world", "!" }; 
 string concat=""; 
 foreach (var item in words)
 {
    concat+=item;
 } 
 System.Console.WriteLine("The concatenated string is:"+concat);