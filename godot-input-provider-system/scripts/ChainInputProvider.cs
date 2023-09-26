using System.Collections.Generic;

namespace InputProvider
{

    /// <summary>
    /// An input provider which follows the chain of responsability pattern to get the input state.
    /// </summary>
    /// <typeparam name="T">The type of the input state to handle.</typeparam>
    public abstract partial class ChainInputProvider<T> : NodeInputProvider<T> where T : IInputState
    {
        private readonly T state;

        /// <summary>
        /// Creates a new chain of responsability input provider.
        /// </summary>
        public ChainInputProvider()
        {
            state = CreateNewState();
        }

        public override T GetState()
        {
            foreach (var inputHandler in GetInputHandlers())
                inputHandler.Handle(state);

            return state;
        }

        /// <summary>
        /// Instantiates a new input state. This will be called from the constructor.
        /// </summary>
        /// <returns>A new input state.</returns>
        protected abstract T CreateNewState();

        /// <summary>
        /// Returns all input handlers that should be handled by this provider. Handlers will be called in the order specified by the enumerator.
        /// </summary>
        /// <returns>An iterator of input handlers.</returns>
        protected abstract IEnumerable<IInputHandler<T>> GetInputHandlers();
    }

}