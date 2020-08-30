using NUnit.Framework;

namespace MachineRepairScheduler.WebApi.Tests
{
    public class Tests
    {
        [Test]
        public void GivenAdamHumpliar_WhenTestingForHumpliarstvo_AdamIsPositive()
        {
            var isAdamHumpliar = false;
            Assert.True(isAdamHumpliar);
        }

        [Test]
        public void GivenAdamHumpliar_WhenTestingIQ_AdamFails()
        {
            var iq = 53;
            Assert.False(iq > 100);
        }
    }
}
