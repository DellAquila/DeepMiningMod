using Mafi.Base;
using Mafi.Core.Research;
using ResNodeID = Mafi.Core.Research.ResearchNodeProto.ID;

namespace DeepMining;

public partial class DeepMiningIds {

	public partial class Research {

		[ResearchCosts(difficulty: 1)]
		public static readonly ResNodeID UnlockDeepMiningStuff = Ids.Research.CreateId("UnlockDeepMiningStuff");

	}

}