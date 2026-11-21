using System;
using Nox.CCK.Network;
using UnityEngine.Events;

namespace Nox.Entities {
	/// <summary>
	/// Interface for a property of an entity.
	/// </summary>
	public interface IProperty : IDirty, ISerializable {
		/// <summary>
		/// Get the key of the property.
		/// Is normally CRC32 hash of the name.
		/// </summary>
		/// <returns></returns>
		public int Key { get; }

		/// <summary>
		/// Get the last updated time of the property.
		/// </summary>
		/// <returns></returns>
		public DateTime UpdatedAt { get; }

		/// <summary>
		/// Get the name of the property.
		/// (optional, may be null)
		/// </summary>
		/// <returns></returns>
		public string Name { get; }

		/// <summary>
		/// Get the category of the property (snake_case), or <c>null</c> when it declares none.
		/// The editors group the avatar parameters by category.
		/// </summary>
		/// <returns></returns>
		public string Category { get; }

		/// <summary>
		/// Get the value of the property.
		/// </summary>
		/// <returns></returns>
		public object Value { get; set; }

		/// <summary>
		/// Get the flags of the property.
		/// </summary>
		public PropertyFlags Flags { get; }

		/// <summary>
		/// Invoked once a value was applied to the property (received from the session), so the owner
		/// listens only to the properties it needs (a voice status, a video URL, ...).
		/// </summary>
		public UnityEvent<IProperty> OnUpdated { get; }

		/// <summary>
		/// Apply a value received from the session: deserialize it, clear the dirty flag so it is not
		/// sent back, then raise <see cref="OnUpdated"/>.
		/// </summary>
		public void Apply(byte[] value) {
			Deserialize(value);
			IsDirty = false;

			OnUpdated.Invoke(this);
		}
	}
}
