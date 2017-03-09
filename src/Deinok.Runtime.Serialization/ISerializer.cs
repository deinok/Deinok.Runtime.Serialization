namespace Deinok.Runtime.Serialization {

	/// <summary>
	/// Interface to Serialize a TInput to TOutput
	/// </summary>
	/// <typeparam name="TInput">The Input Type</typeparam>
	/// <typeparam name="TOutput">The Output Type</typeparam>
    public interface ISerializer<TInput,TOutput> {

		/// <summary>
		/// Serialize a TInput to a TOutput
		/// </summary>
		/// <param name="input">The Input Type</param>
		/// <returns>The Output Type</returns>
		TOutput Serialize(TInput input);

    }

}
