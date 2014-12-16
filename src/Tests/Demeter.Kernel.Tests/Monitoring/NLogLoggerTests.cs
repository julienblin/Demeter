// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NLogLoggerTests.cs" company="Julien Blin">
//   Copyright (c) 2014 Julien Blin
// </copyright>
// <summary>
//   Unit tests for <see cref="NLogLogger"/>.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Demeter.Kernel.Tests.Monitoring
{
    using System;

    using Demeter.Kernel.Monitoring;
    using Demeter.Monitoring;
    using NFluent;
    using NLog;
    using NLog.Config;
    using NLog.Targets;
    using NUnit.Framework;

    /// <summary>
    ///     Unit tests for <see cref="NLogLogger"/>.
    /// </summary>
    [TestFixture]
    public class NLogLoggerTests : IDisposable
    {
        private const string LoggerName = "LoggerName";
        private LoggingConfiguration savedConfiguration;
        private MemoryTarget memoryTarget;
        private ILogger logger;

        ~NLogLoggerTests() 
        {
            this.Dispose(false);
        }

        [SetUp]
        public void Setup_system_under_test()
        {
            this.savedConfiguration = LogManager.Configuration;
            var config = new LoggingConfiguration();

            this.memoryTarget = new MemoryTarget();
            this.memoryTarget.Layout = @"${logger} ${level} ${message} ${exception}";
            config.AddTarget("memory", this.memoryTarget);

            var rule = new LoggingRule("*", LogLevel.Debug, this.memoryTarget);
            config.LoggingRules.Add(rule);

            LogManager.Configuration = config;

            this.logger = new NLogLogger(LoggerName);
        }

        [TearDown]
        public void Restore_log_configuration()
        {
            LogManager.Configuration = this.savedConfiguration;
            
            if (this.memoryTarget != null)
            {
                this.memoryTarget.Dispose();
                this.memoryTarget = null;
            }
        }

        [Test]
        public void It_should_log_debug_messages()
        {
            this.logger.Debug("Foo");

            Check.That(this.memoryTarget.Logs).ContainsExactly(LoggerName + " Debug Foo ");
        }

        [Test]
        public void It_should_log_info_messages()
        {
            this.logger.Info("Foo");

            Check.That(this.memoryTarget.Logs).ContainsExactly(LoggerName + " Info Foo ");
        }

        [Test]
        public void It_should_log_warn_messages()
        {
            this.logger.Warn("Foo");

            Check.That(this.memoryTarget.Logs).ContainsExactly(LoggerName + " Warn Foo ");
        }

        [Test]
        public void It_should_log_warn_messages_with_exception()
        {
            var exception = new DemeterException();
            this.logger.Warn(exception, "Foo");

            Check.That(this.memoryTarget.Logs).ContainsExactly(LoggerName + " Warn Foo " + exception.Message);
        }

        [Test]
        public void It_should_log_error_messages()
        {
            this.logger.Error("Foo");

            Check.That(this.memoryTarget.Logs).ContainsExactly(LoggerName + " Error Foo ");
        }

        [Test]
        public void It_should_log_error_messages_with_exception()
        {
            var exception = new DemeterException();
            this.logger.Error(exception, "Foo");

            Check.That(this.memoryTarget.Logs).ContainsExactly(LoggerName + " Error Foo " + exception.Message);
        }

        [Test]
        public void It_should_log_fatal_messages()
        {
            this.logger.Fatal("Foo");

            Check.That(this.memoryTarget.Logs).ContainsExactly(LoggerName + " Fatal Foo ");
        }

        [Test]
        public void It_should_log_fatal_messages_with_exception()
        {
            var exception = new DemeterException();
            this.logger.Fatal(exception, "Foo");

            Check.That(this.memoryTarget.Logs).ContainsExactly(LoggerName + " Fatal Foo " + exception.Message);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.memoryTarget != null)
                {
                    this.memoryTarget.Dispose();
                    this.memoryTarget = null;
                }
            }
        }
    }
}
