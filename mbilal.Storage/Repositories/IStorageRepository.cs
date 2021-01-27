using mbilal.Storage.Entities;
using mbilal.Storage.Entities.Nodes;

namespace mbilal.Storage.Repositories
{
	public interface IStorageRepository
	{
		void Add(StorageDrive drive);
		void Add(StoragePath path, StorageNode node);
		
		void Copy(StoragePath path, StoragePath destinationPath);
		void Copy(StorageNode node, StoragePath desetinationPath);
		
		void Move(StoragePath path, StoragePath destinationPath);
		
		StorageDrive GetStorageDrive(string driveId);
		StorageNode GetStorageNode(StoragePath path);
		StorageNode GetParent(StorageNode node);

		void Remove(string driveId);
		void Remove(StorageDrive drive);
		void Remove(StoragePath path);
	}
}