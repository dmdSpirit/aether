#nullable enable

using System.Threading.Tasks;
using UnityEngine.AddressableAssets;

namespace aether.Aether.AssetManagement
{
    public interface IAssetProvider
    {
        Task<T> Load<T>(AssetReference assetReference) where T : class;
        void CleanUp();
    }
}