#nullable enable
namespace Aether.CommonInterfaces
{
    public interface IState
    {
        void Enter(StateMachine stateMachine, object? arg);
        void Exit();
    }
}