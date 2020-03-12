
namespace ProjectEuler100.Problems
{
    // If the product of these four fractions is given in its lowest common terms, find the value of the denominator.
    // Solution time = 00:00:00.0002734
    public class Problem033
    {
        public int Solve()
        {
            return Dafuq();
        }

        // Should split to two methods since it's doing two things, but problem is so trivial I don't care
        private int Dafuq()
        {
            int numer, denom = numer = 1;

            for (double i = 1; i < 10; i++)
            {
                for (double j = i + i; j < 10; j++)
                {
                    for (double k = i + 1; k < 10; k++)
                    {
                        double ij = i * 10 + j;
                        double jk = j * 10 + k;

                        if (ij / jk == i / k)
                        {
                            numer *= (int) ij;
                            denom *= (int) jk;
                        }
                    }
                }
            }

            return (denom % numer == 0)? denom / numer : denom;
        }
    }
}
