namespace Deinok.Runtime.Serialization {

	/// <summary>
	/// Interface to Deserialize a TInput to TOutput
	/// </summary>
	/// <typeparam name="TInput">The Input Type</typeparam>
	/// <typeparam name="TOutput">The Output Type</typeparam>
	public interface IDeserializer<TInput, TOutput> {

		/// <summary>
		/// Deserialize a TInput to a TOutput
		/// </summary>
		/// <param name="input">The Input Type</param>
		/// <returns>The Output Type</returns>
		TOutput Deserialize(TInput input);

	}

}
