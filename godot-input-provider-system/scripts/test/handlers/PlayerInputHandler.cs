using Godot;

public partial class PlayerInputHandler : TestInputHandler
{
    public override void Handle(TestInputState state)
    {
        state.movementInput = Input.GetVector("left", "right", "forward", "back");
        state.fire = Input.IsActionPressed("fire");
    }
}