namespace TinasAlgorithms
{
    internal class UniqueTrueChecker
    {
        public static bool OnlyOne(params bool[] flags)
        {
            bool b = false;
            for (int i = 0; i < flags.Length; i++)
            {
                if (flags[i] == true)
                {
                    for (int j = 0; j < flags.Length; j++)
                    {
                        if (flags[j] == true && i != j)
                        {
                            b = false;
                            break;
                        }
                        else
                        {
                            b = true;
                        }
                    }
                }
            }
            return b;
        }
    }
}
