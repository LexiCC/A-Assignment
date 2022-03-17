using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignment
{
    public class Assignment2
    {
        //-------------------------------------------------------------------- 1. CopyingArray
        public void CopyingArray()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] copy = new int[array.Length];

            for(int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }

            foreach (var item in copy)
            {
                Console.WriteLine(item.ToString());
            }
        }

        //-------------------------------------------------------------------- 2.CustomizeTodoList
        public void todoList(){
            List<String> todolist = new List<String>();

            while (todolist.Count != 0 || todolist.Count == 0) {
                Console.WriteLine("(Enter command(+item, -item, or -- to clear)");
                String input = Console.ReadLine();

                if (input.Substring(0, 1).Equals("+"))
                {
                    todolist.Add(input);
                }
                else if (input.Equals("--"))
                {
                    todolist.Clear();
                }
                else if (input.Substring(0, 1).Equals("-") && todolist.Count != 0)
                {
                    todolist.RemoveAll(x => x.Contains(input.Substring(1)));
                }

                Console.WriteLine("Your plans: ");
                foreach (var el in todolist)
                    Console.WriteLine(el);
            }//end while loop
        }

        //-------------------------------------------------------------------- 3.Prime numbers
        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            int[] result = new int[endNum-startNum];
            int index = 0;
            

            while (startNum < endNum)
            {
                bool flag = false;
                for (int j = 2; j <= startNum/2; ++j)
                {
                    if(startNum % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }//end 2nd forloop

                if (!flag && startNum != 0 && startNum != 1)
                {
                    result[index++] = startNum;
                }
                ++startNum;
            }

            return result;
        }

        //-------------------------------------------------------------------- 4.RotateArray
        public void RotateArray(int[] nums, int k)
        {
            while (k > 0)
            {
                int tmp = nums[nums.Length - 1]; //get last ele
                for (int i = nums.Length - 2; i >= 0; i--)
                {
                    nums[i + 1] = nums[i];
                }//shuffle the array to the right
                nums[0] = tmp; //finish one rotation

                int[] rotate = nums;
                k--;
            }

        }

        //-------------------------------------------------------------------- 5.longest sequence 
        public static int[] longestSeq(int[] input)
        {
            int count = 1;
            int num = input[0];
            int longestCount = 1;

            for(int i = 1; i < input.Length; i++)
            {
                if(input[i] != input[i - 1])
                {
                    count = 0;
                }
                count++;

                if (count > longestCount)
                {
                    longestCount = count;
                    num = input[i];
                }
            }

            int[] result = new int[longestCount];
            Array.Fill(result, num);
            return result;
        }

        //-------------------------------------------------------------------- 7.Count frequency
        public static void frequency(int[] input)
        {
            Dictionary<int, int> hp = new Dictionary<int, int>();

            for(int i = 0; i < input.Length; i++)
            {
                if (!hp.ContainsKey(input[i]))
                {
                    hp.Add(input[i], 1);
                }
                else
                {
                    hp[input[i]] = hp[input[i]] + 1;
                }
            }// put all num and their freq in hp

            int count = 0, res = -1;
            foreach (KeyValuePair < int, int > pair in hp)
            {
                if (count < pair.Value)
                {
                    res = pair.Key;
                    count = pair.Value;
                }
            }

            Console.WriteLine($"The number {res} is the most frequent (occurs {count} times)");
        }

        //-------------------------------------------------------------------- 1. Reverse String
        public static void reverseString(String s)
        {
            char[] inputArray = s.ToCharArray();
            int i = 0;
            int j = inputArray.Length - 1;

            while(i < j)
            {
                char tmp = inputArray[i];
                inputArray[i] = inputArray[j];
                inputArray[j] = tmp;
                i++;
                j--;
            }

            String res = new String(inputArray);
            Console.WriteLine(res);
        }

        //-------------------------------------------------------------------- 2. Reverse Words
        public static string ReverseWords(string str)
        {
            return String.Join(" ", str.Split('.',' ',',','?','!',':','=','(',')','&','[',']').Reverse()).ToString();
        }

        //-------------------------------------------------------------------- 3. GetAllPalindromes
        public static void GetAllPalindromes(String str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (isPalindrome(str.Substring(i, j - i + 1)))
                    {
                        Console.WriteLine(str.Substring(i, j - i + 1));
                    }
                }
            }
        }

        public static bool isPalindrome(String input)
        {
            int i = 0, j = input.Length - 1;
            while (i < j)
            {
                if (input[i] != input[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        //-------------------------------------------------------------------- 4. Parses URL
        public static void url(String input)
        {
            String[] spearator = { "://", "/"};
            String[] words = input.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < words.Length; i++) {
                if(i == 0)
                {
                    Console.WriteLine("[protocol] = " + words[i]);
                }

                if (i == 1)
                {
                    Console.WriteLine("[server] = " + words[i]);
                }

                if (i == 2)
                {
                    Console.WriteLine("[resource] = " + words[i]);
                }
            }
        }
    }
}
