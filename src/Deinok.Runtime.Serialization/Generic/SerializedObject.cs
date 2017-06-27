using System.Collections.Generic;

namespace Deinok.Runtime.Serialization.Generic {

	public class SerializedObject{

		public IEnumerable<SerializedStringProperty> SerializedStringProperties { get; set; }
		public IEnumerable<SerializedIntegerProperty> SerializedIntegerProperties { get; set; }
		public IEnumerable<SerializedFloatProperty> SerializedFloatProperties { get; set; }
		public IEnumerable<SerializedBoolProperty> SerializedBoolProperties { get; set; }
		public IEnumerable<SerializedEnumProperty> SerializedEnumProperties { get; set; }
		public IEnumerable<SerializedObjectProperty> SerializedObjectProperties { get; set; }
		public IEnumerable<SerializedArrayProperty> SerializedArrayProperties { get; set; }

	}

}
