using UnityEngine;

namespace Nox.Entities {
	/// <summary>
	/// Interface for moving entities.
	/// </summary>
	public interface IMovingEntity : IEntity {
		/// <summary>
		/// Indicates whether the entity has been modified since the last sync.
		/// </summary>
		public Vector3 Position { get; set; }
		
		/// <summary>
		/// Gets or sets the rotation of the entity.
		/// </summary>
		public Quaternion Rotation { get; set; }
		
		/// <summary>
		/// Gets or sets the scale of the entity.
		/// </summary>
		public Vector3 Scale { get; set; }
		
		/// <summary>
		/// Gets or sets the velocity of the entity.
		/// </summary>
		public Vector3 Velocity { get; set; }
		
		/// <summary>
		/// Gets or sets the angular velocity of the entity.
		/// </summary>
		public Vector3 Angular { get; set; }

		/// <summary>
		/// Gets or sets the walk speed of the entity, in metres per second
		/// (controller ability <c>max_move_speed</c>).
		/// Authoritative data: it is not editable through the avatar parameters.
		/// </summary>
		public float WalkSpeed { get; set; }

		/// <summary>
		/// Gets or sets the acceleration used to reach <see cref="WalkSpeed"/>
		/// (controller ability <c>move_acceleration</c>).
		/// </summary>
		public float MoveAcceleration { get; set; }

		/// <summary>
		/// Gets or sets the force applied when jumping (controller ability <c>jump_force</c>).
		/// </summary>
		public float JumpForce { get; set; }

		/// <summary>
		/// Gets or sets the multiplier applied to <see cref="WalkSpeed"/> while sprinting
		/// (controller ability <c>sprint_multiplier</c>).
		/// </summary>
		public float SprintMultiplier { get; set; }

		/// <summary>
		/// Gets or sets the part of the movement kept while airborne, from 0 to 1
		/// (controller ability <c>air_control</c>).
		/// </summary>
		public float AirControl { get; set; }

		/// <summary>
		/// Gets or sets the flying speed of the entity, in metres per second
		/// (controller ability <c>fly_speed</c>).
		/// </summary>
		public float FlySpeed { get; set; }

		/// <summary>
		/// Gets or sets whether the entity is allowed to fly (controller ability <c>may_fly</c>).
		/// </summary>
		public bool MayFly { get; set; }

		/// <summary>
		/// Gets or sets whether the entity cannot move (controller ability <c>immobilized</c>).
		/// </summary>
		public bool IsImmobilized { get; set; }

		/// <summary>
		/// Gets or sets whether the entity is flying (controller ability <c>flying</c>).
		/// </summary>
		public bool IsFlying { get; set; }

		/// <summary>
		/// Gets or sets whether the entity is crouching (controller ability <c>crouching</c>).
		/// </summary>
		public bool IsCrouching { get; set; }

		/// <summary>
		/// Gets or sets whether the entity is sprinting (controller ability <c>sprinting</c>).
		/// </summary>
		public bool IsSprinting { get; set; }

	}
}