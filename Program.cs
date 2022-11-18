using The.Persistence;
using The.Security;
using Repro.Model;

var services = new The.Composition.Builder()
    .RegisterMetadata(Entities.Metadata)
    .RegisterEntityStore(new TransientEntityStore(Entities.Metadata, MemoryPersistence.CreatePersisters()))
    .RegisterAuthentication(new PresetAuthentication("test"))
    .Build();

Console.WriteLine($"Hello, {services.AppName}!");