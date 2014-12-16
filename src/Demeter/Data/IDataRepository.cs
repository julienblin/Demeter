// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataRepository.cs" company="Julien Blin">
//   Copyright (c) 2014 Julien Blin
// </copyright>
// <summary>
//   Represents the repository for retrieving and saving data (documents).
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Demeter.Data
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     Represents the repository for retrieving and saving data (documents).
    /// </summary>
    public interface IDataRepository
    {
        /// <summary>
        ///     Gets a <see cref="Document"/> by its id.
        /// </summary>
        /// <param name="id">The id of the document to find.</param>
        /// <returns>The <see cref="Document"/>, or null if not found.</returns>
        Document GetDocument(Guid id);

        /// <summary>
        ///     Gets several documents by their ids.
        /// </summary>
        /// <param name="ids">The list of document ids to find.</param>
        /// <returns>The list of found documents.</returns>
        IEnumerable<Document> GetDocuments(IEnumerable<Guid> ids);
    }
}
