namespace TheBankerPlan
{
    public class BankerPlan : IBankerPlan
    {
        public bool Fortune(int f0, double p, int c0, int n, double i)
        {
            int yearsPassed = 2;

            double pPercent = p / 100;

            double iPercent = i / 100;

            var result = FortuneLooper(f0, pPercent, c0, n, iPercent, yearsPassed);

            return result;
        }


        public bool FortuneLooper(double f0, double p, double c0, int n, double i, int yearsPassed)
        {
            var hit = false;

            if (f0 < c0 && hit == false)
            {
                hit = false;

                return hit;
            }

            if (yearsPassed == n)
            {
                hit = true;

                return hit;
            }

            f0 = f0 + (p * f0) - c0;

            c0 = c0 + (c0 * i);

            f0 = Math.Truncate(f0);

            c0 = Math.Truncate(c0);

            return FortuneLooper(f0, p, c0, n, i, yearsPassed + 1);
        }
    }
}