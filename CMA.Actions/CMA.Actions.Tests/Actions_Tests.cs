namespace CMA.Actions.Tests
{
    public class Actions_Tests
    {
        [Fact]
        public void FabricService_IsValid()
        {
            Assert.True(new FabricService().IsValid());
        }
    }
}