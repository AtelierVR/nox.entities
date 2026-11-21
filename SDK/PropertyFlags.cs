namespace Nox.Entities {
	[System.Flags]
	public enum PropertyFlags {
		None = 0,

		/// <summary>The owner sends the value when it changes.</summary>
		LocalEmit = 1 << 0,

		/// <summary>The value received from the network is applied to the entity.</summary>
		RemoteEmit = 1 << 1,

		/// <summary>
		/// The value is repeated periodically, so a peer that joined later or missed an update still
		/// receives it. A value that must stay as it was declared (a playback position the clients
		/// extrapolate on their own, ...) leaves it out.
		/// </summary>
		Keyframe = 1 << 2,

		Synced = LocalEmit | RemoteEmit | Keyframe,
	}
}
