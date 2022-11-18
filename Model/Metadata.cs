﻿// <auto-generated>This code was generated by Instagile.</auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The;
using The.Entities;
using The.Attributes;
using The.Model;
using The.Relationships;
using The.Utility;

namespace Repro.Model
{
	public static partial class Entities
	{
		private static readonly Lazy<EntityMetadataDictionary> _Metadata = new Lazy<EntityMetadataDictionary>(CreateMetadataDictionary);
		public static EntityMetadataDictionary Metadata => _Metadata.Value;

		private static readonly Lazy<List<object[]>> _ConcreteTypeNames = new Lazy<List<object[]>>(() => _Metadata.Value.Where(kvp => !kvp.Value.IsAbstract).Select(kvp => new object[]{ kvp.Key }).ToList());
		public static IEnumerable<object[]> ConcreteTypeNames => _ConcreteTypeNames.Value;

		private static EntityMetadataDictionary CreateMetadataDictionary()
		{
			return new EntityMetadataDictionary("", false,
null,null,null,null,null,null,null,null,null,null,null,null) {
				{"Entity", EntityInfo.Instance}
			};
		}

		public sealed partial class EntityInfo : EntityInfo<Entity>
		{
			public static EntityInfo Instance = new EntityInfo();
			
			public EntityInfo()
				: base("Entity",
					   "Entities",
					   "Entity",
					   "Entities",
					   false,
					   false,
					   false,
					   false,
					   true,
                       CreateSections,
					   CreateAttributes,
					   CreateRelationships,
					   Construct)
			{ }

			public override PropertyInfo SortProperty => modifiedOn;
			public override bool SortAscending => false;
			
			private static Entity Construct(IEntityInfo metadata, IEntityContext context, IEntityInitialiser initialiser)
			{
	    		return new Entity(metadata, context, initialiser);
			}

            private static IEnumerable<SectionInfo> CreateSections()
            {
                yield return new SectionInfo(
                    parent: Repro.Model.Entity.Metadata,
                    name: "Main",
                    properties: () => new PropertyInfo[]
                    {
                        Repro.Model.Entity.Metadata.Attribute,
                    }
                );
            }

			private static IEnumerable<AttributeInfo> CreateAttributes()
			{
				yield return new AttributeInfo(
					memoryIndex: 0,
					storageIndex: 0,
					name: "active", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.Boolean, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: true,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Active",
                    section: () => Repro.Model.Entity.Metadata.MainSection,
					parent: Repro.Model.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: BooleanProperty.DefaultValue,
					typeParser: s => BooleanProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 1,
					storageIndex: 1,
					name: "createdBy", 
					maxLength: 50,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.String, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: false,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Created By",
                    section: () => Repro.Model.Entity.Metadata.MainSection,
					parent: Repro.Model.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: StringProperty.DefaultValue,
					typeParser: s => StringProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 2,
					storageIndex: 2,
					name: "createdOn", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.Instant, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: false,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Created On",
                    section: () => Repro.Model.Entity.Metadata.MainSection,
					parent: Repro.Model.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: InstantProperty.DefaultValue,
					typeParser: s => InstantProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 3,
					storageIndex: 3,
					name: "ID", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.GUID, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: false,
					isLegacy: false,
					displayOrder: -1, 
					caption: "ID",
                    section: () => Repro.Model.Entity.Metadata.MainSection,
					parent: Repro.Model.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: GUIDProperty.DefaultValue,
					typeParser: s => GUIDProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 4,
					storageIndex: 4,
					name: "modifiedBy", 
					maxLength: 50,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.String, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: false,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Modified By",
                    section: () => Repro.Model.Entity.Metadata.MainSection,
					parent: Repro.Model.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: StringProperty.DefaultValue,
					typeParser: s => StringProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 5,
					storageIndex: 5,
					name: "modifiedOn", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.Instant, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: false,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Modified On",
                    section: () => Repro.Model.Entity.Metadata.MainSection,
					parent: Repro.Model.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: InstantProperty.DefaultValue,
					typeParser: s => InstantProperty.Parse(s));
				var depsText = AttributeInfo.GetCalcDeps<Entity>(nameof(Text));
				yield return new AttributeInfo(
					memoryIndex: 6,
					storageIndex: 6,
					name: "Text", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.String, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: true,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Text",
                    section: () => Repro.Model.Entity.Metadata.MainSection,
					parent: Repro.Model.Entity.Metadata,
					isCalculated: true, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: StringProperty.DefaultValue,
					typeParser: s => StringProperty.Parse(s),
					calculateSyncValue: new Func<IEntity,string>(e => ((Entity)e).GetText()),
					calculateAsyncValue: null,
					calculateOnDemand: true,
					calculateOnSave: true,
					calculationDependencyPaths: new Lazy<IReadOnlyList<PropertyPath>>(() => depsText.Select(a => PropertyPath.DeserialisePath(Repro.Model.Entity.Metadata, a.DependencyPath)).ToList()));
				yield return new AttributeInfo(
					memoryIndex: 7,
					storageIndex: 7,
					name: "version", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.Version, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: true,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Version",
                    section: () => Repro.Model.Entity.Metadata.MainSection,
					parent: Repro.Model.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: VersionProperty.DefaultValue,
					typeParser: s => VersionProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 8,
					storageIndex: 8,
					name: "Attribute", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.Integer, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: false,
					isLegacy: false,
					displayOrder: 0, 
					caption: "Attribute",
                    section: () => Repro.Model.Entity.Metadata.MainSection,
					parent: Repro.Model.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: IntegerProperty.DefaultValue,
					typeParser: s => IntegerProperty.Parse(s));
	    	}
	    
			private static IEnumerable<RelationshipInfo> CreateRelationships()
			{
				yield break;
	    	}

			public AttributeInfo active => Attributes["active"];

			public AttributeInfo createdBy => Attributes["createdBy"];

			public AttributeInfo createdOn => Attributes["createdOn"];

			public AttributeInfo ID => Attributes["ID"];

			public AttributeInfo modifiedBy => Attributes["modifiedBy"];

			public AttributeInfo modifiedOn => Attributes["modifiedOn"];

			public AttributeInfo Text => Attributes["Text"];

			public AttributeInfo version => Attributes["version"];

			public AttributeInfo Attribute => Attributes["Attribute"];
			
			public SectionInfo MainSection => Sections[0];
		}
	}
}

namespace Repro.Model.Legacy
{
	public static partial class Entities
	{
		private static readonly Lazy<EntityMetadataDictionary> _Metadata = new Lazy<EntityMetadataDictionary>(CreateMetadataDictionary);
		public static EntityMetadataDictionary Metadata => _Metadata.Value;

		private static readonly Lazy<List<object[]>> _ConcreteTypeNames = new Lazy<List<object[]>>(() => _Metadata.Value.Where(kvp => !kvp.Value.IsAbstract).Select(kvp => new object[]{ kvp.Key }).ToList());
		public static IEnumerable<object[]> ConcreteTypeNames => _ConcreteTypeNames.Value;

		private static EntityMetadataDictionary CreateMetadataDictionary()
		{
			return new EntityMetadataDictionary("", true,
null,null,null,null,null,null,null,null,null,null,null,null) {
				{"Entity", EntityInfo.Instance}
			};
		}

		public sealed partial class EntityInfo : EntityInfo<Entity>
		{
			public static EntityInfo Instance = new EntityInfo();
			
			public EntityInfo()
				: base("Entity",
					   "Entities",
					   "Entity",
					   "Entities",
					   false,
					   false,
					   false,
					   false,
					   true,
                       CreateSections,
					   CreateAttributes,
					   CreateRelationships,
					   Construct)
			{ }

			public override PropertyInfo SortProperty => modifiedOn;
			public override bool SortAscending => false;
			
			private static Entity Construct(IEntityInfo metadata, IEntityContext context, IEntityInitialiser initialiser)
			{
	    		return new Entity(metadata, context, initialiser);
			}

            private static IEnumerable<SectionInfo> CreateSections()
            {
                yield return new SectionInfo(
                    parent: Repro.Model.Legacy.Entity.Metadata,
                    name: "Main",
                    properties: () => new PropertyInfo[]
                    {
                        Repro.Model.Legacy.Entity.Metadata.Attribute,
                    }
                );
            }

			private static IEnumerable<AttributeInfo> CreateAttributes()
			{
				yield return new AttributeInfo(
					memoryIndex: 0,
					storageIndex: 0,
					name: "active", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.Boolean, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: true,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Active",
                    section: () => Repro.Model.Legacy.Entity.Metadata.MainSection,
					parent: Repro.Model.Legacy.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: BooleanProperty.DefaultValue,
					typeParser: s => BooleanProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 1,
					storageIndex: 1,
					name: "createdBy", 
					maxLength: 50,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.String, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: false,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Created By",
                    section: () => Repro.Model.Legacy.Entity.Metadata.MainSection,
					parent: Repro.Model.Legacy.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: StringProperty.DefaultValue,
					typeParser: s => StringProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 2,
					storageIndex: 2,
					name: "createdOn", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.Instant, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: false,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Created On",
                    section: () => Repro.Model.Legacy.Entity.Metadata.MainSection,
					parent: Repro.Model.Legacy.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: InstantProperty.DefaultValue,
					typeParser: s => InstantProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 3,
					storageIndex: 3,
					name: "ID", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.GUID, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: false,
					isLegacy: false,
					displayOrder: -1, 
					caption: "ID",
                    section: () => Repro.Model.Legacy.Entity.Metadata.MainSection,
					parent: Repro.Model.Legacy.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: GUIDProperty.DefaultValue,
					typeParser: s => GUIDProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 4,
					storageIndex: 4,
					name: "modifiedBy", 
					maxLength: 50,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.String, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: false,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Modified By",
                    section: () => Repro.Model.Legacy.Entity.Metadata.MainSection,
					parent: Repro.Model.Legacy.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: StringProperty.DefaultValue,
					typeParser: s => StringProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 5,
					storageIndex: 5,
					name: "modifiedOn", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.Instant, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: false,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Modified On",
                    section: () => Repro.Model.Legacy.Entity.Metadata.MainSection,
					parent: Repro.Model.Legacy.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: InstantProperty.DefaultValue,
					typeParser: s => InstantProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 6,
					storageIndex: 6,
					name: "Text", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.String, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: true,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Text",
                    section: () => Repro.Model.Legacy.Entity.Metadata.MainSection,
					parent: Repro.Model.Legacy.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: StringProperty.DefaultValue,
					typeParser: s => StringProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 7,
					storageIndex: 7,
					name: "version", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.Version, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: true,
					isLegacy: false,
					displayOrder: -1, 
					caption: "Version",
                    section: () => Repro.Model.Legacy.Entity.Metadata.MainSection,
					parent: Repro.Model.Legacy.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: VersionProperty.DefaultValue,
					typeParser: s => VersionProperty.Parse(s));
				yield return new AttributeInfo(
					memoryIndex: 8,
					storageIndex: 8,
					name: "Attribute", 
					maxLength: 0,
					precision: 0,
					isRequired: false, 
					isNullable: false, 
					dataType: AttributeType.Integer, 
					shouldShowInSearch: false, 
					shouldShowInList: false, 
					shouldShowOnForm: false, 
					isAdminOnly: false,
					isLegacy: false,
					displayOrder: 0, 
					caption: "Attribute",
                    section: () => Repro.Model.Legacy.Entity.Metadata.MainSection,
					parent: Repro.Model.Legacy.Entity.Metadata,
					isCalculated: false, 
					isTransient: false, 
					defaultValue: "",
					isSQLIdentity: false,
					typeDefault: IntegerProperty.DefaultValue,
					typeParser: s => IntegerProperty.Parse(s));
	    	}
	    
			private static IEnumerable<RelationshipInfo> CreateRelationships()
			{
				yield break;
	    	}

			public AttributeInfo active => Attributes["active"];

			public AttributeInfo createdBy => Attributes["createdBy"];

			public AttributeInfo createdOn => Attributes["createdOn"];

			public AttributeInfo ID => Attributes["ID"];

			public AttributeInfo modifiedBy => Attributes["modifiedBy"];

			public AttributeInfo modifiedOn => Attributes["modifiedOn"];

			public AttributeInfo Text => Attributes["Text"];

			public AttributeInfo version => Attributes["version"];

			public AttributeInfo Attribute => Attributes["Attribute"];
			
			public SectionInfo MainSection => Sections[0];
		}
	}
}