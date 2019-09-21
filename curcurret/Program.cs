using System;

namespace curcurret
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
                Console.WriteLine(p.solution(42));
        }
        public int solution(int N)
        {
            string bits = Convert.ToString(N, 2);
            //Console.WriteLine($"Bit String: {bits}");
            int longest = 0;
            int curCount = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[i] == '0')
                {
                    if (curCount > 0) curCount++;
                    else curCount = 1;
                }
                else if (curCount > longest && bits[bits.Length - 1] =='1')
                {
                    longest = curCount;
                    curCount = 0;
                }
                else
                {
                    if(curCount > longest && bits[i]=='1')
                        longest = curCount;
                    curCount = 0;
                }
            }

            return longest;

        
    }

}
}
