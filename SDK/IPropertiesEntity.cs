namespace Nox.Entities {
	/// <summary>
	/// Entity carrying payload properties: the values replicated by the session (the same pipeline as
	/// the avatar parameters when the entity is a player).
	/// </summary>
	public interface IPropertiesEntity : IEntity {
		/// <summary>All properties of the entity.</summary>
		public IProperty[] Properties { get; }

		/// <summary>Get a property of the entity by key.</summary>
		public bool TryGetProperty(int key, out IProperty property);

		/// <summary>
		/// Add or replace a property of the entity. Returns <c>false</c> when the entity cannot host
		/// it (it only reads properties, or it holds a fixed set), so the caller can tell the value
		/// was dropped instead of silently losing it.
		/// </summary>
		public bool SetProperty(IProperty property)
			=> false;
	}
}
