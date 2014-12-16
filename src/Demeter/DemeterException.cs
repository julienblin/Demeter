// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DemeterException.cs" company="Julien Blin">
//   Copyright (c) 2014 Julien Blin
// </copyright>
// <summary>
//   Represents a clock, which can give the instant.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Demeter
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    ///     Represents errors that occur during the execution.
    /// </summary>
    [Serializable]
    public class DemeterException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DemeterException"/> class.
        /// </summary>
        public DemeterException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DemeterException"/> class
        ///     with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public DemeterException(string message) : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DemeterException"/> class with a specified
        ///     error message and a reference to the inner exception that is the cause of
        ///     this exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public DemeterException(string message, Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DemeterException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected DemeterException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
