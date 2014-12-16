// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IStorageType.cs" company="Julien Blin">
//   Copyright (c) 2014 Julien Blin
// </copyright>
// <summary>
//    A storage type relates a <see cref="FieldType"/> to the
//    underlying storage in the data store.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Demeter.DataModel
{
    using System;

    /// <summary>
    ///     A storage type relates a <see cref="FieldType"/> to the
    ///     underlying storage in the data store.
    /// </summary>
    public interface IStorageType
    {
        /// <summary>
        ///     Gets the name.
        /// </summary>
        string Name { get; }
    }
}
