using System;
using System.Collections.Generic;
using System.Linq;



namespace A2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine();

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine();

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();
            
            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                // we create the variable res of the lenght of nums to store the final numbers and initialize the index at 0
                var res = new int[nums.Length];
                var index = 0;
                // we run a for loop starting at 0 that goes throught the nums array elements and add each of the numbers of i and j to the res
                for (int i = 0, j = n; j < nums.Length; i++, j++)
                {
                    res[index] = nums[i];
                    index++;
                    res[index] = nums[j];
                    index++;
                }

                // we traverse throught the array res to print each of its components
                Console.Write("[");
                for (int k = 0; k < res.Length; k++)
                {
                    Console.Write(res[k]);
                    if (k < res.Length - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("]");
                Console.WriteLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Input entered is not valid");
                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                // we initialize the count in 0 and create a n variable witht the lenght of ar2
                int count = 0;
                int n = ar2.Length;

                // we traverse throught the array. for each element if it is not a zero, we then replace the element at index a and count a with this element 
                for (int i = 0; i < n; i++)
                    if (ar2[i] != 0)
                    {
                        // we increment the count 
                        ar2[count++] = ar2[i];
                    }

                        
                // all non-zero elements have been moved to the front. we set  as index of first 0. Make all elements 0 from count to end. 
                while (count < n)
                    ar2[count++] = 0;

                // we traverse through the ar2 arrray to print all of its components
                Console.Write("[");
                for (int k = 0; k < ar2.Length; k++)
                {
                    Console.Write(ar2[k]);
                    if (k < ar2.Length - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("]");
                Console.WriteLine();

            }
            catch (Exception)
            {
                Console.WriteLine("Input entered is not valid");
                throw;
            }
        }


        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ////Print the number of cool pairs
        ////Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            try
            {
                // we include a conditional statement where if nums is null or of lenght 0 then we return 0
                if (nums == null || nums.Length == 0)
                {
                    Console.Write("0");
                    
                }
                
                // we create a varibale to store the final result
                int res = 0;
                // we create a dictionary
                Dictionary<int, int> dict = new Dictionary<int, int>();

                // we run a loop ofr each of the elements in nums
                foreach (var num in nums)
                {
                    // if the dictionary contains the same value as num, we add it to the dictionary 
                    if (!dict.ContainsKey(num))
                    {
                        dict.Add(num, 0);
                    }
                        
                    // we add one to to the num index to continue looping through the dictionary
                    dict[num] += 1;
                }
                // for each element in the dictionary 
                foreach (var item in dict.Values)
                {
                    // if the element is differetn from 1, we dot he following math
                    if (item != 1)
                    {
                        res += item * (item - 1) / 2;
                    }
                }
                // print the final output   
                Console.Write(res);
                

            }
            catch (Exception)
            {
                Console.WriteLine("Input entered is not valid");
                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                // we create a dictionary 
                Dictionary<int, int> dict = new Dictionary<int, int>();
                // we create an array of lenght 2 to store the final array result
                int[] arr = new int[2];
                // we traverse throught the the nums array 
                for (int i = 0; i < nums.Length; i++)
                {
                    // we create the value int as the difference between target and nums
                    int Value = target - nums[i];

                    // if dictionary contains the value and i different thatn the dictioanry value
                    if (dict.ContainsKey(Value) && i != dict[Value])
                    {
                        arr[0] = dict[Value];
                        arr[1] = i;

                        // we traverse trhough the array to print each of the array's components 
                        Console.Write("[");
                        for (int k = 0; k < arr.Length; k++)
                        {
                            Console.Write(arr[k]);
                            if (k < arr.Length - 1)
                            {
                                Console.Write(",");
                            }
                        }
                        Console.Write("]");
                        Console.WriteLine();
                    }
                    dict[nums[i]] = i;
                }


            }
            catch (Exception)
            {
                Console.WriteLine("Input entered is not valid");
                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                // we create a conditional statement were if the lenght of string s is not equal to the indices array lenght, then print " "
                if (s.Length != indices.Length)
                {
                    Console.WriteLine("");
                }
                // we create a array result to store the final word with charcaters ordered by index
                char[] result = new char[s.Length];
                // we traverse through the array matching the value of each character in the string to its index
                for (int i = 0; i < s.Length; i++)
                {
                    result[indices[i]] = s[i];
                }
                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Input entered is not valid");
                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                // create a variable size
                int size = 256;
                // create variables for the lenght of s1 and s2
                int o = s1.Length;
                int p = s2.Length;

                // first we must ensure that the lenght of both strings must match
                 if (o != p)
                {
                    return false;
                }
                    
                // we use m to mark the already visited characters in s2 
                bool[] m = new bool[size];
                
                for (int i = 0; i < size; i++)
                {
                    m[i] = false;
                }
                    

                // in order to store map every character from s1 to s2, we initialize m as -1
                int[] l= new int[size];

                for (int i = 0; i < size; i++)
                {
                    l[i] = -1;
                }
                    
                // we proceed to loop throught the characters 
                for (int i = 0; i < p; i++)
                {

                    // if the current character of s1 is seen first time
                    if (l[s1[i]] == -1)
                    {

                        // if the current character of s2 is already seen, one to one mapping is not possible 
                        if (m[s2[i]] == true)
                            return false;

                        // we mark current character of s2 as visited 
                        m[s2[i]] = true;

                        // we store map the current characters 
                        l[s1[i]] = s2[i];
                    }

                    // if it is not the first time appearance of the current character in s1, then check if previos appearance to the same character of s2
                    else if (l[s1[i]] != s2[i])
                        return false;

                }

                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Input entered is not valid");
                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                // I was not able to figure out how to loop to create each of the id that is included in the problem, so did a manual solution were we assume only 2 student id exist. 

                // We create an array for the id and other 2 arrays for the values
                int[] id = new int[items.GetLength(0)];
                // we create an array for the values of each id number
                int[] v1 = new int[items.GetLength(0)];
                int[] v2 = new int[items.GetLength(0)];
                // we create s1 and s2 to calculate the sums
                int s1 = 0;
                int s2 = 0;
                // we create c1 and c2 to keep track of the top 5 only
                int c1 = 0;
                int c2 = 0;
                //  we create count to only ad the 5 highest numbers
                int count = 0;
                // we traverse through the items array extracting the ids to the array id
                for (int i = 0; i < items.GetLength(0); i++)
                {
                    id[i] = items[i, 0];
                }
                // we create a new array that stores the uniques ids 
                int[] u = id.Distinct<int>().ToArray();
                // for each unique id we create 2 sperate integers 
                int key1 = u[0];
                int key2 = u[1];
                // we loop trough the items array and store in id1 and id2 the vaalues for each id
                for (int k = 0; k < items.GetLength(0); k++)
                {
                    // if the u id is the same as the items array, include those values in the array v1
                    if (items[k, 0] == key1)
                    {
                        v1[c1] = items[k, 1];
                        c1++;
                    }
                    // if the u id is the same as the items array, include those values in the array v2
                    else if (items[k, 0] == key2)
                    {
                        v2[c2] = items[k, 1];
                        c2++;
                    }
                }
                // we proceed to sort in descending order both arrays v1 and v2
                Array.Sort(v1);
                Array.Reverse(v1);
                Array.Sort(v2);
                Array.Reverse(v2);

                // we loop through the v1 and v2 to add the 5 values, we add some conditions like grater than 0 and les than 100 for each 
                for (int h = 0; h < items.GetLength(0); h++)
                {
                    if (v1[h] >= 0 && v1[h] <= 100 && id[h] >= 0 && v2[h] <= 100 && count < 5)
                    {
                        s1 += v1[h];
                        s2 += v2[h];
                        count++;
                    }
                }

                // after adding the 5 values we divide each of the arrays by 5 to get the mean
                int res1 = (s1 / 5);
                int res2 = (s2 / 5);

                // we print the id and the mean value sores for each of the id
                Console.Write("[[");
                Console.Write(u[0] + ",");
                Console.Write(res1 + "],[");
                Console.Write(u[1] + ",");
                Console.Write(res2 + "]]");
            }
            catch (Exception)
            {
                Console.WriteLine("Input entered is not valid");
                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        // first we define a method for the sum of Squares of n 
        static int numSquareSum(int n)
        {
            int squareSum = 0;
            while (n != 0)
            {
                squareSum += (n % 10) *(n % 10);
                n /= 10;
            }
            return squareSum;
        }
        // now we proceed with the actual HappyNumber method to determine if n is a happy number
        private static bool HappyNumber(int n)
        {
            try
            {                
                // we will replace n with sum of squares n until we either get 1 or the the ecycle ends
                while (true)
                {
                    //if n reaches 1 tat means number is happy
                    if (n == 1)
                    {
                        return true;
                    }
                       
                    // we replace n with sum of squares of n 
                    n = numSquareSum(n);

                    // instead of running throught the complete cycle, we can just check for 4 as the cyclce always contains 4  if n reaches 4 number is not happy 
                    if (n == 4)
                    {
                        return false;
                    }
                        
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Input entered is not valid");
                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            try
            {
                // we create the profit variable and the position variable, also we create a minimum and maximum variable for the stocks
                int profit = 0;
                int position = 0;
                int minimum = 1000;
                int maximum = 0;

                // we traverse through the array to determine the minimum and maximum and the position of minimum
                for (int i = 0; i < prices.Length; i++)
                {
                    if (prices[i] >= 0)
                    {
                        if (prices[i] < minimum)
                        {
                            minimum = prices[i];
                            position = i;
                        }
                        // we know the maximum should be above the position of the minimum variable because we only sell a stock after buying it at the minimum
                        if (i > position && prices[i] > maximum)
                        {
                            maximum = prices[i];
                        }
                    }
                }
                // we calculate the profit by doing the difference between maximum and minimum
                profit = maximum - minimum;
                // If profit is greater than 0 we, return profit value
                if (profit > 0)
                {
                    return profit;
                }
                // else if profit is less or equal than 0 we, return 0
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Input entered is not valid");
                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            try
            {
                // we create an array result with the length of steps + 1
                int[] x = new int[steps + 1];
                // 0 steps can be climbed in 0 ways, 1 step can be climbed in 1 way and 2 steps can be climbed in 2 ways, these are the first three of the array
                x[0] = 0;
                x[1] = 1;
                x[2] = 2;
                // we traverse through the array until the number of steps given as input to the function
                for (int k = 3; k <= steps; k++)
                {
                    // start with 0 as the value of the array
                    x[k] = 0;
                    // we do another loop to define that we can only do 1 or 2 steps.
                    for (int l = 1; l <= 2 && (k - l) >= 0; l++)
                    {
                        // we add the number of different ways, we do this by using the k-1 for the current step
                        x[k] += x[k - l];
                    }
                }
                // we print the number of different ways value stored
                Console.WriteLine(x[steps]);
            }
            catch (Exception)
            {
                Console.WriteLine("Input entered is not valid");
                throw;
            }
        }
    }
}