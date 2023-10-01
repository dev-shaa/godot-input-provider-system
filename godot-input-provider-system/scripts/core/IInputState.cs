namespace InputProvider
{

	/// <summary>
	/// The interface which all custom input states have to implement.
	/// </summary>
	public interface IInputState
	{
		/// <summary>
		/// Resets the input state.
		/// </summary>
		void Reset();
	}

}