using System;
using Nox.CCK;

namespace Nox.Entities {
	/// <summary>
	/// Base of every entity: an identity on the network and the data container holding the values that
	/// are not replicated through the properties (<see cref="IPropertiesEntity"/>).
	/// What else the entity is able to do is described by the capability interfaces it implements
	/// (<see cref="IPropertiesEntity"/>, <see cref="IPhysicalEntity"/>, <see cref="IMultiPartEntity{TPart}"/>,
	/// <see cref="IMovingEntity"/>, <see cref="ILivingEntity"/>, <see cref="ITeamEntity"/>, ...).
	/// </summary>
	public interface IEntity : IDisposable {
		/// <summary>
		/// Unique identifier of the entity. It is granted by the session when it registers the entity
		/// (<c>0</c> until then).
		/// </summary>
		public uint Id { get; set; }

		/// <summary>
		/// Get the data container of the entity.
		/// Holds complex values (team, identifier, walk speed, jump power, ...) that are not driven by
		/// the avatar parameter pipeline, so an avatar cannot read or write them (anti-cheat).
		/// </summary>
		public IDataContainer Data { get; }

		/// <summary>Release the resources of the entity (default: nothing to release).</summary>
		void IDisposable.Dispose() { }
	}
}