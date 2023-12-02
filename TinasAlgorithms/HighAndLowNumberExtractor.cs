using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TinasAlgorithms
{
    internal class HighAndLowNumberExtractor
    {
        public static string HighAndLow(string numbers)
        {
            List<int> numsList = new List<int>();
            string[] nums = numbers.Split(' ');
            foreach (string s in nums)
            {
                numsList.Add(int.Parse(s));
            }

            numsList.Sort();

            return $"{numsList[numsList.Count - 1]} {numsList[0]}";
        }
    }
}
