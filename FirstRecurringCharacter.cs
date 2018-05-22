using System;
using System.Collections.Generic;
// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
    // find the recuring character
    // ABC = Return null;
    //ABCA = Return A'
    //ABCBA = Retunr B
        string Inputstring = "ABCEFGG";
        List<char> FoundCharacter = new List<char>();
        int Count =0;
        char Found = FoundRepeatedCharacter(Count,Inputstring,FoundCharacter);
        if (string.IsNullOrWhiteSpace(Found.ToString()) )
        {
            Console.Write(string.Format("No repeated character found."));
        }
        else
        {
            Console.Write(string.Format("Found Repeated Character---{0}--", Found));
        }
    }
static char FoundRepeatedCharacter(int Index, string Inputstring,List<char> Memory)
    {
        if(Inputstring.Length==0) return ' ';
    
        if ((Index >= Inputstring.Length-1) && (! Memory.Contains((char)Inputstring[Index])))  return ' ';
            
        if (Memory.Contains((char)Inputstring[Index]))
            return Inputstring[Index];
        else
            Memory.Add((char)Inputstring[Index]);
        Index++;
        return FoundRepeatedCharacter(Index, Inputstring,Memory);
        
    }
}



/* 
Your previous Plain Text content is preserved below:


 */
