﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsSolving.Level_One
{
    /* DESCRIPTION:
     * 
     * Note: This kata is inspired by Convert a Number to a String!. Try that one too.
     * Description
     * We need a function that can transform a string into a number. 
     * What ways of achieving this do you know?
     * Note: Don't worry, all inputs will be strings, 
     * and every string is a perfectly valid representation of an integral number.
     * 
     * Examples
     * "1234" --> 1234
     * "605"  --> 605
     * "1405" --> 1405
     * "-7" --> -7
     * 
     */
    public class ConvertStringToNumber
    {
        public  int StringToNumber(String str)
        {
            return Convert.ToInt32(str);
        }
    }
}
