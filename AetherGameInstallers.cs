#nullable enable

using Aether.AssetManagement;
using Aether.Localization;
using Aether.UI;
using Zenject;

namespace Aether
{
    public sealed class AetherGameInstallers : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<UIManager>().AsSingle().NonLazy();
            Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle().NonLazy();
            Container.Bind<IGameQuitter>().To<GameQuitter>().AsSingle();
            Container.BindInterfacesTo<LocalizationController>().AsSingle();
        }
    }
}