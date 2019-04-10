using System;
using NUnit.Framework;

namespace TryNUnit
{
    [TestFixture]
    public class MainTest
    {
        // FriendlyMainClaim() must be public in this case
        // MainClass has `internal` accessibility by default
        [Test]
        public void FriendlyMainClaimReturnsString()
        {
            string text = MainClass.FriendlyMainClaim();
            Assert.That(text, Is.TypeOf(typeof(string)));
        }

        // InternalFriendlyMainClaim() is `internal` by default
        [Test]
        [Ignore("This test is not supposed to pass")]
        public void InternalFriendlyMainClaimReturnsString()
        {
            string text = MainClass.InternalFriendlyMainClaim();
            Assert.That(text, Is.TypeOf(typeof(string)));
        }
    }

    [TestFixture]
    public class StomachTest
    {
        [Test]
        public void GrowlReturnsString()
        {
            Stomach organ = new Stomach();
            string noise = organ.Growl();
            Assert.That(noise, Is.InstanceOf(typeof(string)), "Expected Growl method to return a string");
        }

        [Test]
        public void GrowlReturnsSpecificString()
        {
            Stomach organ = new Stomach();
            string noise = organ.Growl();
            Assert.That(noise, Is.EqualTo("grrr"), "Expected Growl method to return 'grrr'");
        }
    }
}
