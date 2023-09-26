public interface IInputProvider<T> where T : IInputState
{
	/// <summary>
	/// Returns the updated input state.
	/// </summary>
	/// <returns>The input state.</returns>
	T GetState();
}
