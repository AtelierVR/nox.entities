namespace Nox.Entities {
	/// <summary>
	/// A property whose value comes from a live source (an avatar parameter, the state of a media
	/// player, ...): the session pulls the value before reading it, and tells the source once the value
	/// was delivered, so the same value is not sent again.
	/// </summary>
	public interface IObservableProperty : IProperty {
		/// <summary>
		/// Whether the source announces its own writes: when it does, the session does not need to pull
		/// the value on every tick.
		/// </summary>
		public bool IsObservable { get; }

		/// <summary>Capture the current value of the source, marking the property dirty when it changed.</summary>
		public void Refresh();

		/// <summary>The value was delivered: align the cache of the source with what was sent.</summary>
		public void UpdateCache();
	}
}
