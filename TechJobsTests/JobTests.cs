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

            Assert.IsFalse(jobOne.Id.Equals(jobTwo.Id));
            // a previous version had Assert.IsFalse(jobOne.Equals(jobTwo)), which is also false but not what we're trying to get at
        }

        [TestMethod]
        public void FirstJobToStringTest()
        {
            Job looneyTunes = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string jobString = looneyTunes.ToString();

            Assert.IsTrue(jobString.StartsWith('\n'));
            Assert.IsTrue(jobString.EndsWith('\n'));

        }

        [TestMethod]
        public void SecondJobToStringTest()
        {
            Job looneyTunes = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string jobString = looneyTunes.ToString();

            string looneyTunesTestObj = $"\nID: {looneyTunes.Id}\n" +
                $"Name: {looneyTunes.Name}\n" +
                $"Employer: {looneyTunes.EmployerName.Value}\n" +
                $"Location: {looneyTunes.EmployerLocation.Value}\n" +
                $"Position Type: {looneyTunes.JobType.Value}\n" +
                $"Core Competency: {looneyTunes.JobCoreCompetency.Value}\n";

            Assert.AreEqual(jobString, looneyTunesTestObj);
        }

        [TestMethod]
        public void ThirdJobToStringTest()
        {
            Job oopsieTunes = new Job("Product tester", new Employer("ACME"), new Location(""), new PositionType(""), new CoreCompetency("Persistence"));

            string jobString = oopsieTunes.ToString();

            string oopsieTunesTestObj = $"\nID: {oopsieTunes.Id}\n" +
                $"Name: {oopsieTunes.Name}\n" +
                $"Employer: {oopsieTunes.EmployerName.Value}\n" +
                $"Location: {oopsieTunes.EmployerLocation.Value}\n" +
                $"Position Type: {oopsieTunes.JobType.Value}\n" +
                $"Core Competency: {oopsieTunes.JobCoreCompetency.Value}\n";

            Assert.AreEqual(jobString, oopsieTunesTestObj);
        }

    }
}
