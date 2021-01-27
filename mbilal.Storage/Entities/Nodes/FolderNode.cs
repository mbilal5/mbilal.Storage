using System.Collections.Generic;
using System.Linq;


namespace mbilal.Storage.Entities.Nodes
{
	public class FolderNode : StorageNode
	{
		public override StorageNodeType StorageNodeType => StorageNodeType.FolderNode;

		public IList<StorageNode> Children { get; set; }
		public int Count { get => Children.Count(); }
	}
}