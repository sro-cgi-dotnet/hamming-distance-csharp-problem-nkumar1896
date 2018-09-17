using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
    //original string should not be null otherwise will not be able to calculate hamming distance
       if(original==null)
        {
          throw(new ArgumentNullException("original"));
        }
        //current string should not be null otherwise will not be able to calculate hamming distance
        if(current==null)
        {
         throw(new ArgumentNullException("current"));
        }
        //both string length should be same otherwise will not be able to calculate hamming distance
        if(original.Length!=current.Length)
        {
            throw(new ArgumentException("Hamming Distance can only be calculated over strings of equal length"));
        }
        int hammingDistance = 0;
        int s=original.Length;
        int i=0;
         //loop will calculate the hamming distance and return it   
        while(i<s)
            {
                if(original[i]!=current[i])
                {
                    hammingDistance=hammingDistance+1;
                }
                i++;
            }
         return hammingDistance;
        }
    }
}
 
