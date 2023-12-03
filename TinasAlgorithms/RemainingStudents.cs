namespace TinasAlgorithms
{
    internal class RemainingStudents
    {
        public static int CountStudents(List<int> students, List<int> sandwiches)
        {
            int count = 0;
            int count2 = students.Count * 2;
            while (count != count2)
            {
                if (students[0] == sandwiches[0])
                {
                    sandwiches.RemoveAt(0);
                    students.RemoveAt(0);
                }
                else
                {
                    students.Add(students[0]);
                    students.RemoveAt(0);
                }

                count++;
            }

            return students.Count;
        }
    }
}
