// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataContainerType.cs" company="Julien Blin">
//   Copyright (c) 2014 Julien Blin
// </copyright>
// <summary>
//   A data container type represents the definition of a data container,
//   either a <see cref="FieldType"/> or a <see cref="DocumentType"/>.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Demeter.DataModel
{
    using System;

    /// <summary>
    ///     A data container type represents the definition of a data container,
    ///     either a <see cref="FieldType"/> or a <see cref="DocumentType"/>.
    /// </summary>
    public abstract class DataContainerType
    {
        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
    }
}
