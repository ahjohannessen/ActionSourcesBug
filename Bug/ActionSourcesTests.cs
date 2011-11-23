using System;
using System.Collections.Generic;
using System.Linq;
using FubuMVC.Core.Registration.Nodes;
using FubuTestingSupport;
using NUnit.Framework;

namespace Bug
{
    [TestFixture]
    public class ActionSourcesTests
    {
        [Test]
        public void oh_noes()
        {
            build(false).Each(a => Console.WriteLine(a)).ShouldHaveCount(2);
        }

        [Test]
        public void yay()
        {
            build(true).Each(a => Console.WriteLine(a)).ShouldHaveCount(2);
        }


        private static IEnumerable<ActionCall> build(bool enableDiagnostics)
        {
            return new CustomFubuRegistry(enableDiagnostics).BuildGraph().Actions()
                .Where(a => a.HandlerType.Assembly == typeof (CustomFubuRegistry).Assembly);
        }
    }
}
