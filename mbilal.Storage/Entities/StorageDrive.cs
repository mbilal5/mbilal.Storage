using mbilal.Storage.Entities.Nodes;


namespace mbilal.Storage.Entities
{
	public class StorageDrive
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public FolderNode Root { get; set; }
	}
}