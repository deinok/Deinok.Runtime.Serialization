namespace Deinok.Runtime.Serialization {

    /// <summary>
    /// Interface to Serialize a TComplex to TSerialized
    /// </summary>
    /// <typeparam name="TComplex">The Deserialized Type</typeparam>
    /// <typeparam name="TSerialized">The Serialized Type</typeparam>
    public interface IOnlySerializer<TComplex,TSerialized> {

        /// <summary>
        /// Serialize a TComplex to a TSerialized
        /// </summary>
        /// <param name="input">The TComplex Input</param>
        /// <returns>The Output</returns>
        TSerialized Serialize(TComplex input);

    }

    /// <summary>
    /// Extension Methods for IOnlySerializer
    /// </summary>
    public static class IOnlySerializerExtension {

        /// <summary>
        /// Serialize a TComplex to a TOutput async
        /// </summary>
        /// <typeparam name="TComplex">The Deserialized Type</typeparam>
        /// <typeparam name="TSerialized">The Serialized Type</typeparam>
        /// <param name="serializer">The Serializer instance</param>
        /// <param name="input">The TComplex Input</param>
        /// <returns>The TSerialized Task</returns>
        public static async Task<TSerialized> SerializeAsync<TComplex, TSerialized>(this ISerializer<TComplex, TSerialized> serializer, TComplex input) {
          return await Task.Run(() => {
            return serializer.Serialize(input);
          }).ConfigureAwait(false);
        }

    }

}
