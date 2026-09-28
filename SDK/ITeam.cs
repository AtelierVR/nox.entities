using UnityEngine;

namespace Nox.Entities {
	/// <summary>
	/// A team: an identified group entities belong to (see <see cref="ITeamEntity"/>).
	/// <para>
	/// Teams live in a session (see <c>ITeamSession</c>), which also owns the relations between them.
	/// </para>
	/// </summary>
	public interface ITeam {
		/// <summary>Identifier of the team, unique within its session.</summary>
		int Id { get; }

		/// <summary>Display name of the team.</summary>
		string Name { get; set; }

		/// <summary>Colour of the team (nameplate, map, scoreboard, ...).</summary>
		Color Color { get; set; }
	}
}
