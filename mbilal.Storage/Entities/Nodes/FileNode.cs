using System.IO;

namespace mbilal.Storage.Entities.Nodes
{
	public class FileNode : StorageNode
	{
		public override StorageNodeType StorageNodeType => StorageNodeType.FileNode;
		public Stream Content { get; private set; }
	}
}