using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Interfaces
{
    public interface IArrayHangler
    {
        string Reverse(string input);
        bool IsPalindrome(string input);
        IEnumerable<int> MissingElements(int[] arr);


    }
}
