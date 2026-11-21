using Cysharp.Threading.Tasks;

namespace Nox.Entities {
	/// <summary>
	/// Entity owning a physical representation (<see cref="Physical"/>): the component the session and
	/// the world use for collisions, grabs and forces. Only one exists at a time per entity.
	/// </summary>
	public interface IPhysicalEntity : IEntity {
		/// <summary>
		/// Lifecycle of the physical representation: <see cref="PhysicalState.None"/> when there is none
		/// and nothing in progress, <see cref="PhysicalState.Creating"/> / <see cref="PhysicalState.Destroying"/>
		/// while an operation is running.
		/// </summary>
		public PhysicalState PhysicalState { get; }

		/// <summary>Try to get the physical component of the entity.</summary>
		public bool TryGetPhysical<T>(out T physical) where T : Physical;

		/// <summary>
		/// Create the physical component of the entity when it has none.
		/// (only one physical component can exist at a time for an entity)
		/// </summary>
		/// <returns>
		/// <c>true</c> when the entity has a physical at the end of the call; <c>false</c> when it could
		/// not be created or when a creation / destruction is already in progress (the call is a no-op,
		/// so it can be requested on every frame).
		/// </returns>
		public UniTask<bool> MakePhysical();

		/// <summary>Destroy the physical component of the entity.</summary>
		public UniTask DestroyPhysical();
	}
}
