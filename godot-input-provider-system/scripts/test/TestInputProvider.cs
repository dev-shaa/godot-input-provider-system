using System.Collections.Generic;
using InputProvider;

public partial class TestInputProvider : ChainInputProvider<TestInputState>
{

    private readonly List<IInputHandler<TestInputState>> inputHandlers = new();

    public TestInputProvider()
    {
        inputHandlers.Add(new TestInputHandler());
    }

    protected override TestInputState CreateNewState()
    {
        return new TestInputState();
    }

    protected override IEnumerable<IInputHandler<TestInputState>> GetInputHandlers()
    {
        return inputHandlers;
    }

}