using mbilal.Storage.Entities;
using mbilal.Storage.Entities.Nodes;

namespace mbilal.Storage.Repositories
{
	public class OneDriveRepository : IStorageRepository
	{
		public void Add(StorageDrive drive)
		{
			throw new System.NotImplementedException();
		}

		public void Add(StoragePath path, StorageNode node)
		{
			throw new System.NotImplementedException();
		}

		public void Copy(StoragePath path, StoragePath destinationPath)
		{
			throw new System.NotImplementedException();
		}

		public void Copy(StorageNode node, StoragePath desetinationPath)
		{
			throw new System.NotImplementedException();
		}

		public StorageNode GetParent(StorageNode node)
		{
			throw new System.NotImplementedException();
		}

		public StorageDrive GetStorageDrive(string driveId)
		{
			throw new System.NotImplementedException();
		}

		public StorageNode GetStorageNode(StoragePath path)
		{
			throw new System.NotImplementedException();
		}

		public void Move(StoragePath path, StoragePath destinationPath)
		{
			throw new System.NotImplementedException();
		}

		public void Remove(string driveId)
		{
			throw new System.NotImplementedException();
		}

		public void Remove(StorageDrive drive)
		{
			throw new System.NotImplementedException();
		}

		public void Remove(StoragePath path)
		{
			throw new System.NotImplementedException();
		}
	}
}