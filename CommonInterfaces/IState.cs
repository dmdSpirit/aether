#nullable enable
namespace aether.Aether.CommonInterfaces
{
    public interface IState
    {
        void Enter(StateMachine stateMachine, object? arg);
        void Exit();
    }
}