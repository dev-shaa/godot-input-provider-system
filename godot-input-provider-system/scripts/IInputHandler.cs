public interface IInputHandler<T> where T : IInputState
{
    /// <summary>
    /// Handles the input state and updates it.
    /// </summary>
    /// <param name="state">Input state to update.</param>
    void Handle(T state);
}