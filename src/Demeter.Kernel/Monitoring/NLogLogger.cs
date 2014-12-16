// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NLogLogger.cs" company="Julien Blin">
//   Copyright (c) 2014 Julien Blin
// </copyright>
// <summary>
//   <see cref="ILogger"/> implementation for the NLog component.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Demeter.Kernel.Monitoring
{
    using System;

    using Demeter.Monitoring;
    using NLog;

    /// <summary>
    ///     <see cref="ILogger"/> implementation for the NLog component.
    /// </summary>
    public class NLogLogger : ILogger
    {
        /// <summary>
        ///     The internal NLog <see cref="Logger"/>.
        /// </summary>
        private readonly Logger internalLogger;

        /// <summary>
        ///     Initializes a new instance of the <see cref="NLogLogger"/> class.
        /// </summary>
        /// <param name="name">The logger name.</param>
        public NLogLogger(string name)
        {
            this.internalLogger = LogManager.GetLogger(name);
        }

        /// <inheritdoc />
        public bool IsDebugEnabled
        {
            get { return this.internalLogger.IsDebugEnabled; }
        }

        /// <inheritdoc />
        public bool IsInfoEnabled
        {
            get { return this.internalLogger.IsInfoEnabled; }
        }

        /// <inheritdoc />
        public bool IsWarnEnabled
        {
            get { return this.internalLogger.IsWarnEnabled; }
        }

        /// <inheritdoc />
        public void Debug(object message)
        {
            this.internalLogger.Debug(message);
        }

        /// <inheritdoc />
        public void Info(object message)
        {
            this.internalLogger.Info(message);
        }

        /// <inheritdoc />
        public void Warn(object message)
        {
            this.internalLogger.Warn(message);
        }

        /// <inheritdoc />
        public void Warn(Exception ex, object message)
        {
            this.internalLogger.Warn(message != null ? message.ToString() : null, ex);
        }

        /// <inheritdoc />
        public void Error(object message)
        {
            this.internalLogger.Error(message);
        }

        /// <inheritdoc />
        public void Error(Exception ex, object message)
        {
            this.internalLogger.Error(message != null ? message.ToString() : null, ex);
        }

        /// <inheritdoc />
        public void Fatal(object message)
        {
            this.internalLogger.Fatal(message);
        }

        /// <inheritdoc />
        public void Fatal(Exception ex, object message)
        {
            this.internalLogger.Fatal(message != null ? message.ToString() : null, ex);
        }
    }
}
