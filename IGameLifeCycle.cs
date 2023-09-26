#nullable enable

namespace Aether
{
    public interface IGameLifeCycle
    {
        void Start();
        void NewGame();
        void ExitGame();
        void MainMenu();
    }
}