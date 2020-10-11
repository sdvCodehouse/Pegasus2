using NUnit.Framework;

namespace PegasusTests
{
    public class MiscTests
    {
        [Test]
        public void PoorInputStringToTryParse_IntIsZero()
        {
            int projectId;
            string testStr = "1,2";

            int.TryParse(testStr, out projectId);

            Assert.AreEqual(0, projectId);
        }

        [Test]
        public void NullInputStringToTryParse_IntIsZero()
        {
            int projectId;
            string testStr = null;

            int.TryParse(testStr, out projectId);

            Assert.AreEqual(0, projectId);
        }
    }
}
