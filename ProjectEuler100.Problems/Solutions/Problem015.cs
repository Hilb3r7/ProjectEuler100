namespace ProjectEuler100.Problems
{
    // How many such routes are there through a 20×20 grid?
    // Solution time = 00:00:00.0061857
    public class Problem015
    {
        /* In a x * y grid where you can only move right or down, there
        * are x + y moves you must make and you can only move right 
        * x number of times. So for example, of the 40 moves in a 20x20 grid
        * you must move right 20 times. So 40choose20 is the answer
        */
        public long Solve(int x, int y)
        {
            return new Utils.EulerTools().NChooseK(x + y, y);
        }
    }
}
