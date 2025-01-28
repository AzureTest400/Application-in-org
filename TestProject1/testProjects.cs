namespace TestProject1
{
    public class testProjects
    {
        [Fact]
        public void Test1()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.True(result, "value ");

        }
    }
}