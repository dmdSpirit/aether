#nullable enable

using System.Threading.Tasks;
using UnityEngine.AddressableAssets;

namespace Aether.AssetManagement
{
    public interface IAssetProvider
    {
        Task<T> Load<T>(AssetReference assetReference) where T : class;
        Task<T> Load<T>(string key) where T : class;
        void CleanUp();
    }
}