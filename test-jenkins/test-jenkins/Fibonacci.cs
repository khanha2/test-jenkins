namespace test_jenkins
{
    public static class Fibonacci
    {
        public static int Generate(int n)
        {
            if(n < 3)
            {
                return 1;
            }
            int a = 1;
            int b = 1;
            for (var i = 3; i <= n; ++i)
            {
                var t = a + b;
                a = b;
                b = t;
            }
            return b;
        }
    }
}
