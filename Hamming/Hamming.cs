using System;

namespace Hamming
{
    public class Hamming
    {
        public static int Distance(string original, string current)
        {
       if(original==null)
        {
          throw(new ArgumentNullException("original"));
        }
        if(current==null)
        {
         throw(new ArgumentNullException("current"));
        }
        if(original.Length!=current.Length)
        {
            throw(new ArgumentException("Hamming Distance can only be calculated over strings of equal length"));
        }
        int hammingDistance = 0;
        int s=original.Length;
        int i=0;
            
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
 
