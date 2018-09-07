using System;
class Program{
static void Main(){
     Console.WriteLine("enter first string");
     string str1=Console.ReadLine();
     Console.WriteLine("enter second string");
     string str2=Console.ReadLine();  
       int k=0;
       int i=0;
       int j=str1.Length;
     while(i<j)
     {
        if(str1[i]!=str2[i])
         {
             k++;
         }
         
         i++;
     }
    Console.WriteLine(k);
 }
}
 
