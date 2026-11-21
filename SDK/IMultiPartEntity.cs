using Nox.CCK.Utils;

namespace Nox.Entities {
	/// <summary>
	/// An entity composed of multiple parts.
	/// </summary>
	public interface IMultiPartEntity<TPart> : IEntity
		where TPart : IPart {
		/// <summary>
		/// Get all parts of the entity.
		/// </summary>
		/// <returns></returns>
		public TPart[] GetParts();

		/// <summary>
		/// Try to get a part by name.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="part"></param>
		/// <returns></returns>
		public bool TryGetPart(ushort name, out TPart part);

		/// <summary>
		/// Apply a pose received from the session to one of the parts. The default implementation only
		/// forwards to an existing part, an entity creating its parts lazily overrides it.
		/// </summary>
		public void ApplyPart(ushort id, TransformObject transform, uint time = 0) {
			if (TryGetPart(id, out var part) && part != null)
				part.Apply(transform, time);
		}
	}
}
