namespace ToyRobot.Runner;

// Strong Inject Dependency Injection configuration

using StrongInject;
using System.ComponentModel;
using ToyRobot.Library;

public interface IToyRobotContainer
{
    IParser Parser { get; }
}

[Register(typeof(Board), Scope.SingleInstance, typeof(IBoard))]
[Register(typeof(ConsoleWriter), typeof(IConsoleWriter))]
[Register(typeof(Parser))]
public partial class ToyRobotContainer : IContainer<Parser>
{
    // StrongInject will automatically resolve the dependency for MySingletonService
}