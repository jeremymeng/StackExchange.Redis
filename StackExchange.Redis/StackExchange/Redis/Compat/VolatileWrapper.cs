namespace StackExchange.Redis
{
    internal static class VolatileWrapper
    {
        public static int Read(ref int location)
        {
#if !NETSTANDARD1
            return System.Threading.Thread.VolatileRead(ref location);
#else
            return System.Threading.Volatile.Read(ref location);
#endif
        }

        public static void Write(ref int address, int value)
        {
#if !NETSTANDARD1
            System.Threading.Thread.VolatileWrite(ref address, value);
#else
            System.Threading.Volatile.Write(ref address, value);
#endif
        }
    }
}
