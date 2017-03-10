namespace Deinok.Runtime.Serialization.Generic {

	/// <summary>
	/// A Generic Serializer
	/// </summary>
	/// <typeparam name="TOutput">The Output Type</typeparam>
	public interface IGenericSerializer<TOutput> {

		/// <summary>
		/// Serializes a TInput to TOutput
		/// </summary>
		/// <typeparam name="TInput">The Input Type</typeparam>
		/// <param name="input">The Input</param>
		/// <returns>The Output</returns>
		TOutput Serialize<TInput>(TInput input);

	}

}
