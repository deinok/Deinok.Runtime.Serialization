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
        /// <param name="input">The TComplex Input</param>
        /// <returns>The Output</returns>
        TSerialized Serialize(TComplex input);

        /// <summary>
        /// Deserialize a TSerialized to a TComplex
        /// </summary>
        /// <param name="input">The TSerialized Input</param>
        /// <returns>The TComplex Output</returns>
        TComplex Deserialize(TSerialized input);

    }

    /// <summary>
    /// Extension Methods for ISerializer
    /// </summary>
    public static class ISerializerExtension {

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

        /// <summary>
        /// Deserialize a TSerialized to a TComplex async
        /// </summary>
        /// <typeparam name="TComplex">The Serialized Type</typeparam>
        /// <typeparam name="TSerialized">The Deserialized Type</typeparam>
        /// <param name="serializer">The Serializer instance</param>
        /// <param name="input">The TSerialized Input</param>
        /// <returns>The TComplex Task</returns>
        public static async Task<TComplex> DeserializeAsync<TComplex, TSerialized>(this ISerializer<TComplex, TSerialized> serializer, TSerialized input) {
            return await Task.Run(() => {
                return serializer.Deserialize(input);
            }).ConfigureAwait(false);
        }

    }

}
