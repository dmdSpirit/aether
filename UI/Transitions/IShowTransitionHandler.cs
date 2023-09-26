#nullable enable
namespace Aether.UI.Transitions
{
    public interface IShowTransitionHandler
    {
        void OnShow();
        void Stop();
    }
}