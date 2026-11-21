namespace Nox.Entities {
	/// <summary>
	/// An entity a session drives on its clock. Both steps carry a default implementation, so an entity
	/// only overrides the one it needs.
	/// </summary>
	public interface IUpdateEntity : IEntity {
		/// <summary>
		/// Called once per frame: what is not paced by the tick rate (visibility, a physical
		/// representation, an interpolation).
		/// </summary>
		public void Update() { }

		/// <summary>
		/// Called once per session tick: what must follow the tick rate (sending, sampling, a state
		/// machine of the entity).
		/// </summary>
		public void Tick() { }
	}
}
