using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Nox.Entities {
	/// <summary>
	/// Physical representation exposing the colliders that make its body, and announcing when that set
	/// changes (an avatar is attached, swapped or removed, a hand collider appears, ...).
	/// <para>
	/// Lets a consumer follow the body without re-scanning the hierarchy every frame: it reads
	/// <see cref="Colliders"/> once and re-reads it when <see cref="OnCollidersChanged"/> is invoked.
	/// </para>
	/// </summary>
	public interface IPhysicalColliders {
		/// <summary>Colliders making the body of the physical.</summary>
		public IReadOnlyList<Collider> Colliders { get; }

		/// <summary>
		/// Invoked when the body changed, with the colliders it carries from now on: the previous list is
		/// stale.
		/// </summary>
		public UnityEvent<IReadOnlyList<Collider>> OnCollidersChanged { get; }
	}
}
