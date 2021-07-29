using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'checkMagazine' function below.
     *
     * The function accepts following parameters:
     *  1. STRING_ARRAY magazine
     *  2. STRING_ARRAY note
     */

    public static void checkMagazine(List<string> magazine, List<string> note)
    {
        string result = "No";

        if (magazine.Count <= 30000 && note.Count <= 30000)
        {

            List<string> answer = new List<string>();
            
            foreach (var b in note)
            {
                if (magazine.Contains(b))
                {
                    result = "Yes";
                    magazine.Remove(b);
                }
                else
                {
                    result = "No";
                    break;
                }
            }
        }

        Console.WriteLine(result);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        //int m = Convert.ToInt32(firstMultipleInput[0]);

        //int n = Convert.ToInt32(firstMultipleInput[1]);

        //List<string> magazine = Console.ReadLine().TrimEnd().Split(' ').ToList();

        //List<string> note = Console.ReadLine().TrimEnd().Split(' ').ToList();

        List<string> magazine = new List<string>(6);
        magazine.Add("give");
        magazine.Add("me");
        magazine.Add("one");
        magazine.Add("grand");
        magazine.Add("today");
        magazine.Add("please");
        List<string> note = new List<string>(4);
        note.Add("give");
        note.Add("me");
        note.Add("today");
        note.Add("please");
        Result.checkMagazine(magazine, note);
    }
}
