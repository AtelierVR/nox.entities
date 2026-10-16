using Nox.CCK.Utils;

namespace Nox.CCK.Entities {
	/// <summary>
	/// A part of an entity: the rig slot it fills and the transform it carries.
	/// <para>
	/// A player rig part and a prop sub-element are both an <see cref="EntityPart"/>: only the backend
	/// decides what a part is bound to (a controller, a mesh, ...).
	/// </para>
	/// </summary>
	public class EntityPart {
		/// <summary>Rig slot of the part (see <see cref="EntityRig"/>).</summary>
		public readonly EntityRig Rig;

		/// <summary>Transform carried by the part.</summary>
		public readonly TransformObject Transform;

		public EntityPart(EntityRig rig, TransformObject transform) {
			Rig       = rig;
			Transform = transform;
		}
	}
}