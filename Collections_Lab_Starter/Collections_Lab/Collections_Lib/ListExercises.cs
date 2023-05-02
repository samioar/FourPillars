﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> numList = new List<int>();
            
            {
                for (int i = 1; i <= max; i++) // changed < to <= PASSES
                {
                    if (i % 5 == 0)
                    {
                        numList.Add(i);
                    }
                }
            }
            
            return numList;

        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> stringList = new List<string>();

            foreach (string checkedstring in sourceList)
            {
                if (checkedstring.StartsWith("A")|| checkedstring.StartsWith("a"))
                {
                    stringList.Add(checkedstring);
                }
            }

            return stringList;

        }
    }
}
