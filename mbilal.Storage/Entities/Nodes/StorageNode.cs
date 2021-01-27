using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mbilal.Storage.Entities.Nodes
{
	public abstract class StorageNode
	{
		public abstract StorageNodeType StorageNodeType { get; }
		
		[Key]
		public StoragePath Path { get; set; }
		
		public string Name { get; set; }
		
		// Parent should be retrievable via Path
		[NotMapped]
		public StorageNode Parent { get => throw new NotImplementedException(); }
		
		public DateTime LastModified { get; set; }
	}
}