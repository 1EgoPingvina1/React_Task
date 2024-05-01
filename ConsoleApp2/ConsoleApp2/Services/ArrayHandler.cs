using ConsoleApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    internal class ArrayHandler : IArrayHangler
    {
        public string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = chars.Length - 1; i > -1; i--)
                stringBuilder.Append(chars[i]);
            return stringBuilder.ToString();
        }

        public bool IsPalindrome(string input)
        {
            if (input == Reverse(input))
                return true;
            return false;
        }

        public IEnumerable<int> MissingElements(int[] arr)
        {
            for (int i = arr[0]; i < arr[arr.Length - 1]; i++)
            {
                if (!arr.Contains(i))
                {
                    yield return i;
                }
            }
        }
    }
}
