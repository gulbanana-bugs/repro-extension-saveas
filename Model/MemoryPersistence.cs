// <auto-generated>This code was generated by Instagile.</auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using The;
using The.Components;
using The.Entities;
using The.Persistence;
using The.Persistence.Transient;

namespace Repro.Model
{
	public static class MemoryPersistence
	{
		public static Dictionary<string, IRowPersistence> CreatePersisters()
		{
			var persisters = new Dictionary<string, IRowPersistence>();

			persisters["Entity"] = new EntityPersistence();

			return persisters;
		}

		private class EntityPersistence : IRowPersistence
		{
			public Type Type => typeof(Proxies.Entity);

			public IEntityRow Insert(ColumnsByIndex d) => Proxies.Entity.Create(d.AsList());

			public IEntityRow InsertLegacy(ColumnsByIndex d) => Proxies.Entity.CreateLegacy(d.AsList());

			public IEnumerable<IRelationshipRow> OriginatingRelationships
			{
				get
				{
					yield break;
				}
			}
		}
	}
}

namespace Repro.Model.Proxies
{
    public class Entity : EntityRowBase
	{
        public int Attribute { get; set; }

		public static Entity Create(IReadOnlyList<object?> d)
		{
			var result = new Entity();
            result.active = (bool)d[0]!;
            result.createdBy = (string)d[1]!;
            result.createdOn = (DateTimeOffset)d[2]!;
            result.ID = (Guid)d[3]!;
            result.modifiedBy = (string)d[4]!;
            result.modifiedOn = (DateTimeOffset)d[5]!;
            result.Text = (string)d[6]!;
            result.version = (byte[])d[7]!;
			result.Attribute = (int)d[8]!;
			result.InitLists();
			return result;
		}

		public static Entity CreateNull()
		{
			var result = new Entity();
			result.isNull = true;
			result.InitLists();
			return result;
		}

		public static Entity CreateLegacy(IReadOnlyList<object?> d) => Create(d);

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Entity(Guid id)
		{
            ID = id;
			InitLists();
		}

		protected Entity() { }
#pragma warning restore CS8618 // these types are not created in anything like a normal way


		protected virtual void InitLists()
		{
		}

        public override string TypeName => "Entity";

        public override void Update(ColumnsByName d)
		{
            if (d.ContainsKey("active")) this.active = (bool)d["active"]; 
            if (d.ContainsKey("createdBy")) this.createdBy = (string)d["createdBy"]; 
            if (d.ContainsKey("createdOn")) this.createdOn = (DateTimeOffset)d["createdOn"]; 
            if (d.ContainsKey("ID")) this.ID = (Guid)d["ID"]; 
            if (d.ContainsKey("modifiedBy")) this.modifiedBy = (string)d["modifiedBy"]; 
            if (d.ContainsKey("modifiedOn")) this.modifiedOn = (DateTimeOffset)d["modifiedOn"]; 
            if (d.ContainsKey("Text")) this.Text = (string)d["Text"]; 
            if (d.ContainsKey("version")) this.version = (byte[])d["version"]; 

            if (d.ContainsKey("Attribute")) this.Attribute = (int)d["Attribute"];
		}

        public override ColumnsByIndex Select()
		{
			var result = new object?[9];

			result[0] = this.active;
			result[1] = this.createdBy;
			result[2] = this.createdOn;
			result[3] = this.ID;
			result[4] = this.modifiedBy;
			result[5] = this.modifiedOn;
			result[6] = this.Text;
			result[7] = this.version;
			result[8] = this.Attribute;

			return new ColumnsByIndex(result);
		}

		public override ColumnsByIndex SelectLegacy() => Select();

		public override int CompareTo(object o) => ID.CompareTo((o as Entity)?.ID);

		public static bool operator ==(Entity left, Entity right)
		{
			if ((left is null || left.isNull) && (right is null || right.isNull)) return true;
			return object.ReferenceEquals(left, right);
		}

		public static bool operator !=(Entity left, Entity right)
		{
			if ((left is null || left.isNull) && (right is null || right.isNull)) return false;
			return !object.ReferenceEquals(left, right);
		}

		public override bool Equals(object? obj)
		{
			if (obj is null) return (this is null || this.isNull);
			if (!(obj is Entity that)) return false;
			if ((this.isNull) && (that is null || that.isNull)) return true;
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
    }
}

// <auto-generated />
