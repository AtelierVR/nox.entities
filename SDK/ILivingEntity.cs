namespace Nox.Entities {
	/// <summary>
	/// Entity that is alive: it has health points and can be hidden from view.
	/// </summary>
	public interface ILivingEntity {
		/// <summary>Current health points.</summary>
		public float Health { get; set; }

		/// <summary>Maximum health points.</summary>
		public float MaxHealth { get; set; }

		/// <summary>Whether the entity is invisible (hidden, but still alive).</summary>
		public bool IsInvisible { get; set; }
	}
}