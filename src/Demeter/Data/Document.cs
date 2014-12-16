// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Document.cs" company="Julien Blin">
//   Copyright (c) 2014 Julien Blin
// </copyright>
// <summary>
//   A document is a a single unit of data storage that combines information
//   from other <see cref="DataContainer"/>.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Demeter.Data
{
    using System;

    /// <summary>
    ///     A document is a a single unit of data storage that combines information
    ///     from other <see cref="DataContainer"/>.
    /// </summary>
    public class Document : DataContainer
    {
        /// <summary>
        ///     Gets or sets the document unique identifier.
        /// </summary>
        public Guid DocumentId { get; set; }
    }
}
