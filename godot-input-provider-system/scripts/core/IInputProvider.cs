namespace InputProvider
{

	/// <summary>
	/// The interface which all custom input provider have to implement.
	/// An input provider is an object which returns a processed input state.
	/// </summary>
	/// <typeparam name="T">The type of input state to handle.</typeparam>
	public interface IInputProvider<T> where T : IInputState
	{
		/// <summary>
		/// Returns the updated input state.
		/// </summary>
		/// <returns>The input state.</returns>
		T GetState();
	}

}