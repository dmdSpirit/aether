#nullable enable

namespace Aether.UI.Transitions
{
    public interface IHideTransitionHandler
    {
        void OnHide();
        void Stop();
    }
}