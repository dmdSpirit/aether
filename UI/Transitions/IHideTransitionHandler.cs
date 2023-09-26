#nullable enable

namespace aether.Aether.UI.Transitions
{
    public interface IHideTransitionHandler
    {
        void OnHide();
        void Stop();
    }
}