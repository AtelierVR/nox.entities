using System;
using Nox.CCK.Network;
using Nox.CCK.Utils;
using UnityEngine;

namespace Nox.Entities {
	/// <summary>
	/// Represents a part of a multi-part entity.
	/// </summary>
	public interface IPart : IDirty {
		/// <summary>
		/// Gets the unique ID of this part within its parent entity.
		/// </summary>
		/// <returns></returns>
		public ushort Id { get; }

		/// <summary>
		/// Gets or sets the position of this part relative to its parent entity.
		/// </summary>
		public Vector3 Position { get; set; }

		/// <summary>
		/// Gets or sets the rotation of this part relative to its parent entity.
		/// </summary>
		public Quaternion Rotation { get; set; }

		/// <summary>
		/// Gets or sets the scale of this part.
		/// </summary>
		public Vector3 Scale { get; set; }

		/// <summary>
		/// Gets or sets the velocity of this part.
		/// </summary>
		public Vector3 Velocity { get; set; }

		/// <summary>
		/// Gets or sets the angular velocity of this part.
		/// </summary>
		public Vector3 Angular { get; set; }

		/// <summary>
		/// Gets the timestamp of the last update to this part.
		/// </summary>
		public DateTime Updated { get; }

		/// <summary>
		/// Apply a pose received from the session: the fields named by its flags are the only ones that were
		/// sent. A part that needs more than a copy (interpolation of a remote entity, a sound, a script
		/// event, ...) overrides it.
		/// </summary>
		public void Apply(TransformObject transform, uint time = 0) {
			if (transform == null)
				return;

			if (transform.Flags.HasFlag(TransformFlags.Position))
				Position = transform.GetPosition();
			if (transform.Flags.HasFlag(TransformFlags.Rotation))
				Rotation = transform.GetRotation();
			if (transform.Flags.HasFlag(TransformFlags.Scale))
				Scale = transform.GetScale();
			if (transform.Flags.HasFlag(TransformFlags.Velocity))
				Velocity = transform.GetVelocity();
			if (transform.Flags.HasFlag(TransformFlags.Angular))
				Angular = transform.GetAngular();
		}

		/// <summary>
		/// Export the pose of this part into <paramref name="target"/>: only the fields the part carries
		/// (see <see cref="Kind"/>) are written, so an empty pose never claims a value the part does not
		/// have (a zero position, a unit scale).
		/// </summary>
		public void Export(TransformObject target) {
			if (target == null)
				return;

			target.Clear();

			var kind = Kind;

			if (kind.HasFlag(TransformFlags.Position))
				target.SetPosition(Position);
			if (kind.HasFlag(TransformFlags.Rotation))
				target.SetRotation(Rotation);
			if (kind.HasFlag(TransformFlags.Scale))
				target.SetScale(Scale);
			if (kind.HasFlag(TransformFlags.Velocity))
				target.SetVelocity(Velocity);
			if (kind.HasFlag(TransformFlags.Angular))
				target.SetAngular(Angular);
		}

		/// <summary>
		/// The fields this part really carries. A sender only publishes those: reading a field the part
		/// does not carry gives the default of an empty pose (a zero position, a unit scale), which would
		/// teleport the part on the other clients. A desktop head, for instance, only turns: it carries a
		/// rotation and no position.
		/// </summary>
		public TransformFlags Kind
			=> TransformFlags.All;
	}
}
