using System.Collections.Generic;
using Godot;
using InputProvider;

public partial class TestInputProvider : ChainInputProvider<TestInputState>
{
    [Export] private Godot.Collections.Array<TestInputHandler> inputHandlers;

    protected override TestInputState CreateNewState()
    {
        return new TestInputState();
    }

    protected override IEnumerable<IInputHandler<TestInputState>> GetInputHandlers()
    {
        return inputHandlers;
    }

}