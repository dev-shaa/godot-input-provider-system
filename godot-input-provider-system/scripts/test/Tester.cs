using Godot;

public partial class Tester : Node
{

	[Export] private TestInputProvider inputProvider;

	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		TestInputState inputState = inputProvider.GetState();

		if (inputState.fire)
		{
			GD.Print("Fire");
		}
	}

}
