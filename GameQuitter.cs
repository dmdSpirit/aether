#nullable enable

using JetBrains.Annotations;

namespace Aether
{
    [UsedImplicitly]
    public sealed class GameQuitter : IGameQuitter
    {
        public void QuitGame()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            UnityEngine.Application.Quit();
#endif
        }
    }
}