namespace ProjectEuler100.Problems
{
    // How many Sundays fell on the first of the month during the 
    // twentieth century (1 Jan 1901 to 31 Dec 2000)?
    // Solution time = 00:00:00.0008298
    public class Problem019
    {
        public int Solve()
        {
            return CountSundays();
        }

        private int CountSundays()
        {
            int[] normal = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] leap = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int sundays = 0;
            int day = 2; // Tuesday

            for (int year = 1; year <= 100; year++)
            {
                for (int month = 0; month < 12; month++)
                {
                    day = (year % 4 == 0) ? (day + leap[month]) % 7 : (day + normal[month]) % 7;
                    if (day == 0) sundays++;
                }
            }

            return sundays;
        }
    }
}
