namespace ToyRobot.Runner;

// Strong Inject Dependency Injection configuration

using StrongInject;
using ToyRobot.Library;

//public interface IToyRobotContainer
//{
//    IParser Parser { get; }
//}

[Register(typeof(Board), Scope.SingleInstance, typeof(IBoard))]
[Register(typeof(Parser), Scope.SingleInstance)]
[Register(typeof(ConsoleWriter), typeof(IConsoleWriter))]
public partial class ToyRobotContainer
{
    // StrongInject will automatically resolve the dependency for MySingletonService
}