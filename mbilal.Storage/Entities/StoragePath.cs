using System.Collections.Generic;

namespace mbilal.Storage.Entities
{
	public class StoragePath
	{
		public int StorageDriveId { get; set; }
		public StorageDrive StorageDrive { get; set; }
		
		public IList<string> PathSegments { get; set; }
	}
}