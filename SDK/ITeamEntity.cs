namespace Nox.Entities {
	/// <summary>
	/// Entity that belongs to a <see cref="ITeam"/>.
	/// <para>
	/// Only the team identifier is stored (authoritative data, kept out of the avatar pipeline); the
	/// team itself is resolved through the session registry. An avatar cannot change it.
	/// </para>
	/// </summary>
	public interface ITeamEntity : IEntity {
		/// <summary>
		/// Team the entity belongs to, resolved from the stored identifier through the session registry.
		/// Returns <c>null</c> when the entity has no team.
		/// </summary>
		ITeam Team { get; set; }
	}
}
