using System;

namespace EscribeNumeros
{
    public class LongRandom
    {
        private Random rand;
        private Byte[] buf = new byte[8];

        public LongRandom()
        {
            rand = new Random();
        }

        public long LRandom()
        {
            rand.NextBytes(buf);
            return BitConverter.ToInt64(buf, 0);
        }
    }
}
