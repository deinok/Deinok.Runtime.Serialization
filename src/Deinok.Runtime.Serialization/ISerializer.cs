using System.Threading.Tasks;

namespace Deinok.Runtime.Serialization {

    /// <summary>
    /// Interface to Serialize a TComplex to TSerialized
    /// </summary>
    /// <typeparam name="TComplex">The Deserialized Type</typeparam>
    /// <typeparam name="TSerialized">The Serialized Type</typeparam>
    public interface ISerializer<TComplex,TSerialized> {

        /// <summary>
        /// Serialize a TComplex to a TSerialized
        /// </summary>
        /// <param name="inputType">The Input</param>
        /// <returns>The Output</returns>
        TSerialized Serialize(TComplex inputType);

        /// <summary>
        /// Deserialize a TSerialized to a TComplex
        /// </summary>
        /// <param name="outputType">The Input</param>
        /// <returns>The Input</returns>
        TComplex Deserialize(TSerialized outputType);

    }

    /// <summary>
    /// Extension Methods for ISerializer
    /// </summary>
    public static class ISerializerExtension {

        /// <summary>
        /// Serialize a TComplex to a TOutput in a new thread
        /// </summary>
        /// <typeparam name="TComplex">The Deserialized Type</typeparam>
        /// <typeparam name="TSerialized">The Serialized Type</typeparam>
        /// <param name="serializer">The Serializer instance</param>
        /// <param name="inputType">The Input</param>
        /// <returns>The Output Task</returns>
        public static async Task<TSerialized> SerializeAsync<TComplex, TSerialized>(this ISerializer<TComplex, TSerialized> serializer, TComplex inputType) {
			return await Task.Run(() => {
				return serializer.Serialize(inputType);
			}).ConfigureAwait(false);
		}

        /// <summary>
        /// Deserialize a TOutput to a TInput in a new thread
        /// </summary>
        /// <typeparam name="TComplex">The Serialized Type</typeparam>
        /// <typeparam name="TSerialized">The Deserialized Type</typeparam>
        /// <param name="serializer">The Serializer instance</param>
        /// <param name="outputType">The Input</param>
        /// <returns>The Input Task</returns>
        public static async Task<TComplex> DeserializeAsync<TComplex, TSerialized>(this ISerializer<TComplex, TSerialized> serializer, TSerialized outputType) {
            return await Task.Run(() => {
                return serializer.Deserialize(outputType);
            }).ConfigureAwait(false);
        }

    }

}
