using Interpreter.Lib.BackEnd;
using Interpreter.Lib.BackEnd.Instructions;
using Microsoft.Extensions.Options;
using Moq;

namespace Interpreter.Tests;

public static class MockExtensions
{
    public static Mock<Halt> Trackable(this Mock<Halt> halt)
    {
        halt.Setup(x => x.Execute(It.IsAny<VirtualMachine>()))
            .Returns(-3).Verifiable();
        halt.Setup(x => x.End()).Returns(true);
        return halt;
    }

    public static IOptions<CommandLineSettings> ToOptions
        (this Mock<CommandLineSettings> commandLineSettings) =>
        Options.Create(commandLineSettings.Object);
}