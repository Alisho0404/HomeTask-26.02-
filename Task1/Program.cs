List<int>numbers=new List<int>(){1,2,3,4,5,6,7,12,15,22}; 
int sum=0; 
foreach (var element in numbers)
{
    sum+=element;
} 
System.Console.WriteLine("The sum of all the elements in the list is: " + sum);