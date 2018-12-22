using System;

namespace solution
{
    class Program
    {
        public int Solution(int n)
        {
            string binary = Convert.ToString(n,2);
            binary = binary.Substring(binary.IndexOf('1'), 
                    binary.LastIndexOf('1') - binary.IndexOf('1') + 1);

            
            string[] zeroRanges = binary.Split('1');

            int max = 0;
            foreach(var range in zeroRanges)
            {
                if(range.Length > max)
                {
                    max = range.Length;
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
            
            var program = new Program();
            Console.WriteLine(program.Solution(32));
        }
    }
}
