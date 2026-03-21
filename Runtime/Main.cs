using Nox.CCK.Mods.Initializers;
using Nox.CCK.Utils;
using Nox.Entities;

namespace Nox.Entities.Runtime {
	public class Main : IEntityAPI, IMainModInitializer {
		
		[NoxPublic(NoxAccess.Method)]
		public IEntities New()
			=> new Entities();
	}
}