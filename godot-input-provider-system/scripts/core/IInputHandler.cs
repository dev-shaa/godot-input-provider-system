namespace InputProvider
{

    /// <summary>
    /// The interface which all custom input handler have to implement.
    /// An input handler is an object which processes an input state.
    /// </summary>
    /// <typeparam name="T">The type of input state to handle.</typeparam>
    public interface IInputHandler<T> where T : IInputState
    {
        /// <summary>
        /// Handles the input state and updates it.
        /// </summary>
        /// <param name="state">Input state to update.</param>
        void Handle(T state);
    }

}