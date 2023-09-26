using Godot;

/// <summary>
/// An handler which retrieves the inputs from the player, such as keyboard or mouse presses.
/// </summary>
public partial class PlayerInputHandler : TestInputHandler
{
    public override void Handle(TestInputState state)
    {
        state.movementInput = Input.GetVector("left", "right", "forward", "back");
        state.fire = Input.IsActionPressed("fire");
    }
}