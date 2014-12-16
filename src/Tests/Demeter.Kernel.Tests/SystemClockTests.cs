// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SystemClockTests.cs" company="Julien Blin">
//   Copyright (c) 2014 Julien Blin
// </copyright>
// <summary>
//   Unit tests for <see cref="SystemClock"/>.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Demeter.Kernel.Tests
{
    using System;

    using NFluent;
    using NUnit.Framework;

    /// <summary>
    ///     Unit tests for <see cref="SystemClock"/>.
    /// </summary>
    [TestFixture]
    public class SystemClockTests
    {
        private readonly IClock clock = SystemClock.Instance;

        [Test]
        public void It_should_return_system_time()
        {
            Check.That(this.clock.Now.DateTime).IsBeforeOrEqualTo(DateTimeOffset.Now.DateTime);
        }
    }
}
