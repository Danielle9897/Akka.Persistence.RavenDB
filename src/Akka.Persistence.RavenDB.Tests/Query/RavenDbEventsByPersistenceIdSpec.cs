﻿using Akka.Persistence.Query;
using Akka.Persistence.RavenDB.Query;
using Akka.Persistence.TCK.Query;
using Raven.Client.Documents;
using Xunit.Abstractions;

namespace Akka.Persistence.RavenDB.Tests.Query;

public class RavenDbEventsByPersistenceIdSpec : EventsByPersistenceIdSpec, IClassFixture<RavenDbFixture>
{
    private IDocumentStore _store;

    public RavenDbEventsByPersistenceIdSpec(ITestOutputHelper output, RavenDbFixture databaseFixture) 
        : base(databaseFixture.CreateSpecConfigAndStore(out var store), "RavenDbEventsByPersistenceIdSpec", output)
    {
        _store = store;
        ReadJournal = Sys.ReadJournalFor<RavenDbReadJournal>(RavenDbReadJournal.Identifier);
    }

    protected override void Dispose(bool disposing)
    {
        _store.Dispose();
        base.Dispose(disposing);
    }
}