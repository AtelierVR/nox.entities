namespace Nox.Entities {
	/// <summary>
	/// Relation between two teams.
	/// </summary>
	public enum TeamRelation {
		/// <summary>No particular relation (default): the teams are neutral to each other.</summary>
		Neutral = 0,

		/// <summary>The teams are allied.</summary>
		Ally = 1,

		/// <summary>The teams are enemies.</summary>
		Enemy = 2,
	}
}
