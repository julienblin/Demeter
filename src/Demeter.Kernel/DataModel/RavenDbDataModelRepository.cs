// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RavenDbDataModelRepository.cs" company="Julien Blin">
//   Copyright (c) 2014 Julien Blin
// </copyright>
// <summary>
//   <see cref="IDataModelRepository"/> implementation using RavenDb.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Demeter.Kernel.DataModel
{
    using System;
    using System.Collections.Generic;

    using Demeter.DataModel;
    using Demeter.Monitoring;
    using Raven.Client;

    /// <summary>
    ///     <see cref="IDataModelRepository"/> implementation using RavenDb.
    /// </summary>
    public class RavenDbDataModelRepository : IDataModelRepository
    {
        /// <summary>
        ///     The current Raven session.
        /// </summary>
        private readonly IDocumentSession ravenSession;

        /// <summary>
        ///     The logger.
        /// </summary>
        private ILogger logger;

        /// <summary>
        ///     Initializes a new instance of the <see cref="RavenDbDataModelRepository"/> class.
        /// </summary>
        /// <param name="ravenSession">The current Raven session.</param>
        public RavenDbDataModelRepository(IDocumentSession ravenSession)
        {
            this.ravenSession = ravenSession;
        }

        /// <summary>
        ///     Gets or sets the <see cref="ILogger"/>.
        /// </summary>
        public ILogger Logger
        {
            get { return this.logger ?? NullLogger.Instance; }
            set { this.logger = value; }
        }

        /// <inheritdoc />
        public IStorageType GetStorageType(string name)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<IStorageType> GetStorageTypes()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public FieldType GetFieldType(string name)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<FieldType> GetFieldTypes()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public DocumentType GetDocumentType(string name)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IEnumerable<DocumentType> GetDocumentTypes()
        {
            throw new NotImplementedException();
        }
    }
}
