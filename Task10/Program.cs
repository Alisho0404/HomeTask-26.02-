 var ints=new List<int>(); 
 Random rand=new Random();  

 for (int i = 0; i < 10; i++)
 {
    int nums=rand.Next(2,25); 
    ints.Add(nums); 
    System.Console.Write(nums+" ");
 }
 
  