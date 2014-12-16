// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDataModelRepository.cs" company="Julien Blin">
//   Copyright (c) 2014 Julien Blin
// </copyright>
// <summary>
//   Represents the repository for retrieving and saving data models (data containers).
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Demeter.DataModel
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     Represents the repository for retrieving and saving data models (data containers).
    /// </summary>
    public interface IDataModelRepository
    {
        /// <summary>
        ///     Gets a <see cref="IStorageType"/> by name.
        /// </summary>
        /// <param name="name">The name of the <see cref="IStorageType"/>.</param>
        /// <returns>The <see cref="IStorageType"/>, or null if not found.</returns>
        IStorageType GetStorageType(string name);

        /// <summary>
        ///     Gets all the <see cref="IStorageType"/>.
        /// </summary>
        /// <returns>The available <see cref="IStorageType"/>.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "A method is better here - it might imply processing.")]
        IEnumerable<IStorageType> GetStorageTypes();

        /// <summary>
        ///     Gets a <see cref="FieldType"/> by name.
        /// </summary>
        /// <param name="name">The name of the <see cref="FieldType"/>.</param>
        /// <returns>The <see cref="FieldType"/>, or null if not found.</returns>
        FieldType GetFieldType(string name);

        /// <summary>
        ///     Gets all the <see cref="FieldType"/>.
        /// </summary>
        /// <returns>The available <see cref="FieldType"/>.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "A method is better here - it might imply processing.")]
        IEnumerable<FieldType> GetFieldTypes();

        /// <summary>
        ///     Gets a <see cref="DocumentType"/> by name.
        /// </summary>
        /// <param name="name">The name of the <see cref="DocumentType"/>.</param>
        /// <returns>The <see cref="DocumentType"/>, or null if not found.</returns>
        DocumentType GetDocumentType(string name);

        /// <summary>
        ///     Gets all the <see cref="DocumentType"/>.
        /// </summary>
        /// <returns>The available <see cref="DocumentType"/>.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "A method is better here - it might imply processing.")]
        IEnumerable<DocumentType> GetDocumentTypes();
    }
}
