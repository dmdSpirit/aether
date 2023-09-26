#nullable enable
namespace aether.Aether.UI.Transitions
{
    public interface IShowTransitionHandler
    {
        void OnShow();
        void Stop();
    }
}