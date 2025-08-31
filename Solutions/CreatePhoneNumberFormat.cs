using System.Text;

namespace TinasAlgorithms
{
    internal class CreatePhoneNumberFormat
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int number in numbers)
            {
                sb.Append(number);
            }
            sb.Insert(0, '(');
            sb.Insert(4, ") ");
            sb.Insert(9, '-');

            return sb.ToString();
        }
    }
}
