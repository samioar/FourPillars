using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collections_Lib
{
    public class CollectionsExercises
    {
 //-------------------------------------------------------------------------------------------------------------------//

         /* removes and returns the next num entries in the queue, as a comma separated string */

//-------------------------------------------------------------------------------------------------------------------//
        public static string NextInQueue(int num, Queue<string> queue)
        {
            // Check if num is less than or equal to 0
            if (num <= 0)
            {
                // If so, return an empty string
                return "";
            }

            // Create a StringBuilder to build the result string
            StringBuilder resultBuilder = new StringBuilder();

            // Get the minimum value between num and the number of items in the queue
            int count = Math.Min(num, queue.Count);

            // Loop through the first "count" items in the queue
            for (int i = 0; i < count; i++)
            {
                // Dequeue the next item from the queue
                string name = queue.Dequeue();

                // Append the name to the result string
                resultBuilder.Append(name);

                // If this is not the last item, append a comma and a space
                if (i < count - 1)
                {
                    resultBuilder.Append(", ");
                }
            }
            // Return the result string
            return resultBuilder.ToString();
            }
 //-------------------------------------------------------------------------------------------------------------------//

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */

 //-------------------------------------------------------------------------------------------------------------------//


        // This method takes an integer array as input and returns a new array with the elements in reverse order.
        public static int[] Reverse(int[] original)
        {
            // Create a new stack to hold the elements of the original array in reverse order.
            Stack<int> myStack = new Stack<int>(); //LIFO GANG

            // Loop through each element of the original array and push it onto the stack.
            foreach (int number in original)
            {
                myStack.Push(number);
            }

            // Create a new array to hold the reversed elements and set its length to that of the original array.
            int[] reversedArray = new int[original.Length];

            // Loop through the stack and pop each element onto the new array.
            int i = 0;
            while (myStack.Count > 0)
            {
                reversedArray[i] = myStack.Pop();
                i++;
            }

            // Return the new array with the reversed elements.
            return reversedArray;
        }
//-------------------------------------------------------------------------------------------------------------------//

        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        // This method takes a string as input and returns a string containing the count of each digit in the input string.
//----------------------------------------------------------------------------------------------------------------------------//
        public static string CountDigits(string input)
        {
            // Create a new dictionary to store the count of each digit in the input string.
            Dictionary<char, int> numCount = new Dictionary<char, int>();

            // Loop through each character in the input string.
            foreach (char num in input)
            {
                // If the character is a digit, increment its count in the dictionary.
                if (char.IsDigit(num))
                {
                    if (numCount.ContainsKey(num))
                    {
                        numCount[num]++;
                    }
                    else
                    {
                        numCount.Add(num, 1);
                    }
                }
            }

            // Create a new string to store the count of each digit in a formatted way.
            string result = "";

            // Loop through the dictionary and format each entry as [digit, count].
            foreach (KeyValuePair<char, int> number in numCount)
            {
                result += $"[{number.Key}, {number.Value}]";
            }

            // Return the formatted string with the count of each digit.
            return result;
        }

    }
}


       
        
    

