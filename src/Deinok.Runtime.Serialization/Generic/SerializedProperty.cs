using System;

namespace Deinok.Runtime.Serialization.Generic {

	public abstract class SerializedProperty<T>{

		public string Name { get; set; }
		public abstract SerializedType Type { get; }
		public T Value { get; set; }

	}

	public class SerializedStringProperty : SerializedProperty<string> {
		public override SerializedType Type { get; }= SerializedType.String;
	}

	public class SerializedIntegerProperty : SerializedProperty<int> {
		public override SerializedType Type { get; } = SerializedType.Integer;
	}

	public class SerializedFloatProperty : SerializedProperty<float> {
		public override SerializedType Type { get; } = SerializedType.Float;
	}

	public class SerializedBoolProperty : SerializedProperty<bool> {
		public override SerializedType Type { get; } = SerializedType.Bool;
	}

	public class SerializedEnumProperty : SerializedProperty<Enum> {
		public override SerializedType Type { get; } = SerializedType.Enum;
	}

	public class SerializedObjectProperty : SerializedProperty<object> {
		public override SerializedType Type { get; } = SerializedType.Object;
	}

	public class SerializedArrayProperty : SerializedProperty<Array> {
		public override SerializedType Type { get; } = SerializedType.Array;
	}

}
