namespace Nox.Entities {
	/// <summary>
	/// Entity declaring the stable identity it is replicated under: the session master announces the entity
	/// with that type and the server assigns the id, so every client can map the spawn back onto its own copy.
	/// <para>
	/// The type has to be the same on every client whatever produced the object (the editor, an asset bundle,
	/// a prefab instantiated at runtime): it cannot derive from anything local to a client.
	/// </para>
	/// </summary>
	public interface IEntityType {
		/// <summary>Type the entity is announced with, or 0 when it has none.</summary>
		public uint Type { get; }
	}
}
