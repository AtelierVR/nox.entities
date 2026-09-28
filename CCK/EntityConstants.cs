namespace Nox.CCK.Entities {
	/// <summary>
	/// Default values shared by the entity implementations (<c>nox.relay</c>, <c>nox.offline</c>, ...).
	/// Kept here so every implementation applies the same defaults.
	/// </summary>
	public static class EntityConstants {
		/// <summary>Health points of a living entity when none has been set.</summary>
		public const float DefaultHealth = 100f;

		/// <summary>Maximum health points of a living entity when none has been set.</summary>
		public const float DefaultMaxHealth = 100f;

		/// <summary>Whether a living entity is invisible when it has not been told otherwise.</summary>
		public const bool DefaultInvisible = true;

		/// <summary>Walk speed (metres per second) of a moving entity when none has been set.</summary>
		public const float DefaultWalkSpeed = 2.3f;

		/// <summary>Movement acceleration of a moving entity when none has been set.</summary>
		public const float DefaultMoveAcceleration = 100_000f;

		/// <summary>Jump force of a moving entity when none has been set.</summary>
		public const float DefaultJumpForce = 5f;

		/// <summary>Sprint multiplier of a moving entity when none has been set.</summary>
		public const float DefaultSprintMultiplier = 1.5f;

		/// <summary>Air control (0-1) of a moving entity when none has been set.</summary>
		public const float DefaultAirControl = 0.3f;

		/// <summary>Flying speed (metres per second) of a moving entity when none has been set.</summary>
		public const float DefaultFlySpeed = 5f;

		/// <summary>Whether a moving entity may fly when it has not been told otherwise.</summary>
		public const bool DefaultMayFly = true;

		/// <summary>Whether a moving entity is immobilized when it has not been told otherwise.</summary>
		public const bool DefaultImmobilized = false;

		/// <summary>Whether a moving entity is flying when it has not been told otherwise.</summary>
		public const bool DefaultFlying = false;

		/// <summary>Whether a moving entity is crouching when it has not been told otherwise.</summary>
		public const bool DefaultCrouching = false;

		/// <summary>Whether a moving entity is sprinting when it has not been told otherwise.</summary>
		public const bool DefaultSprinting = false;

		/// <summary>Whether an entity's nameplate is visible when it has not been told otherwise.</summary>
		public const bool DefaultNameplateVisible = true;

		/// <summary>Whether an entity's nameplate health bar is shown when it has not been told otherwise.</summary>
		public const bool DefaultHealthbarVisible = true;

		/// <summary>Team identifier meaning "no team".</summary>
		public const int NoTeam = 0;
	}
}
