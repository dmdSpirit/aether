#nullable enable

using aether.Aether.AssetManagement;
using aether.Aether.UI;
using Zenject;

namespace aether.Aether
{
    public sealed class CoreGameInstallers : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<UIManager>().AsSingle().NonLazy();
            Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle().NonLazy();
            Container.Bind<IGameQuitter>().To<GameQuitter>().AsSingle();
        }
    }
}