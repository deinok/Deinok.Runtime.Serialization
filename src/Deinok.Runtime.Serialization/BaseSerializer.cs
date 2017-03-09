namespace Deinok.Runtime.Serialization {

	/// <summary>
	/// Base Serializer for Everything
	/// </summary>
	/// <typeparam name="TInput">The Input Type</typeparam>
	/// <typeparam name="TOutput">The Output Type</typeparam>
	public abstract class BaseSerializer<TInput, TOutput> : ISerializer<TInput, TOutput>,IDeserializer<TOutput,TInput> {

		/// <summary>
		/// Serialize a TInput to a TOutput
		/// </summary>
		/// <param name="input">The Input Type</param>
		/// <returns>The Output Type</returns>
		public abstract TOutput Serialize(TInput input);

		/// <summary>
		/// Deerialize a TInput to a TOutput
		/// </summary>
		/// <param name="input">The Input Type</param>
		/// <returns>The Output Type</returns>
		public abstract TInput Deserialize(TOutput input);

	}

}
