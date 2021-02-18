using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job jobOne = new Job();
            Job jobTwo = new Job();

            Assert.AreEqual(jobOne.Id, jobTwo.Id, 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job looneyTunes = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual(looneyTunes.Name, "Product tester");
            Assert.AreEqual(looneyTunes.EmployerName.Value, "ACME");
            Assert.AreEqual(looneyTunes.EmployerLocation.Value, "Desert");
            Assert.AreEqual(looneyTunes.JobType.Value, "Quality control");
            Assert.AreEqual(looneyTunes.JobCoreCompetency.Value, "Persistence");

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job jobOne = new Job();
            Job jobTwo = new Job();

            Assert.IsFalse(jobOne.Equals(jobTwo));
        }



    }
}
