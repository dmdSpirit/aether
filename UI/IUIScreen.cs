#nullable enable
using System;

namespace Aether.UI
{
    public interface IUIScreen
    {
        public bool IsShown { get; }
        public bool IsInitialized { get; }
        public void Initialize();
        public void Show();
        public void Hide();
        public IObservable<IUIScreen> OnScreenShown { get; }
        public IObservable<IUIScreen> OnScreenHidden { get; }
    }
}