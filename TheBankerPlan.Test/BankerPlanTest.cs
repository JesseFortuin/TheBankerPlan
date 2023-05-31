namespace TheBankerPlan.Test
{
    public class BankerPlanTest
    {
        [Theory]
        [InlineData(100000, 1, 2000, 15, 1, true)]
        [InlineData(100000, 1, 9185, 12, 1, false)]
        [InlineData(100000000, 1, 100000, 50, 1, true)]
        [InlineData(100000000, 1.5, 10000000, 50, 1, false)]
        [InlineData(100000000, 5, 1000000, 50, 1, true)]
        public void FortuneTests(int deposit, double interest, int withdraw, int numberOfYears, double inflation, bool expected)
        {
            //arrange
            IBankerPlan plan = new BankerPlan();

            //act
            var actual = plan.Fortune(deposit, interest, withdraw, numberOfYears, inflation);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}