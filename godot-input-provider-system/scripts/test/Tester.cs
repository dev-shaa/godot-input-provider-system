using Godot;

public partial class Tester : Node
{

	[Export] private TestInputProvider inputProvider;

	public override void _Process(double delta)
	{
		base._Process(delta);
	}

	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);

		TestInputState inputState = inputProvider.GetState();

		if (inputState.fire)
			GD.Print("Fire");
	}

}
