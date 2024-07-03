﻿namespace ProblemsSolving.Level_One
{
    /*
    * #2
    * DESCRIPTION:
    * 
    * Introduction 
    * 
    * The first century spans from the year 1 up to and including 
    * the year 100, the second century - from the year 101 up to and including the year 200, etc.
    * 
    * Task 
    * 
    * Given a year, return the century it is in.
    * 
    * Examples
    * 
    * 1705 --> 18
    * 1900 --> 19
    * 1601 --> 17
    * 2000 --> 20
    * 2742 --> 28
    * 
    * link : https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097
    * 
    */
    public class СenturyFromYear
    {
        public int centuryFromYear(int year)
        {
            int a = (year - 1) / 100 + 1;

            return a;
        }
        // public static int СenturyFromYear(int year) => (year - 1) / 100 + 1;
    }
}
