// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FieldType.cs" company="Julien Blin">
//   Copyright (c) 2014 Julien Blin
// </copyright>
// <summary>
//   A field type holds the definition of a Field.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Demeter.DataModel
{
    using System;

    /// <summary>
    ///     A field type holds the definition of a Field.
    /// </summary>
    public class FieldType : DataContainerType
    {
        /// <summary>
        ///     Gets or sets the storage type.
        /// </summary>
        public IStorageType StorageType { get; set; }
    }
}
