namespace Nox.Entities {
	/// <summary>
	/// Lifecycle of the physical representation of an entity. It lets callers (the world update loop,
	/// a module, a script) know whether the physical is being built or torn down, so they do not ask
	/// for it again while the first request is still in flight.
	/// </summary>
	public enum PhysicalState : byte {
		/// <summary>No physical and no operation in progress.</summary>
		None = 0,

		/// <summary>The physical representation is being created.</summary>
		Creating = 1,

		/// <summary>The physical representation is being destroyed.</summary>
		Destroying = 2,
	}
}
