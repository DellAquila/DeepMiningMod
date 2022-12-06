using Mafi;
using Mafi.Base;
using Mafi.Core;
using Mafi.Core.Mods;

namespace DeepMining;

public sealed class DeepMining : DataOnlyMod {

	// Name of this mod. It will be eventually shown to the player.
	public override string Name => "Deep Mining";

	// Version, currently unused.
	public override int Version => 1;


	// Mod constructor that lists mod dependencies as parameters.
	// This guarantee that all listed mods will be loaded before this mod.
	// It is a good idea to depend on both `Mafi.Core.CoreMod` and `Mafi.Base.BaseMod`.
	public DeepMining(CoreMod coreMod, BaseMod baseMod) {
		// You can use Log class for logging. These will be written to the log file
		// and can be also displayed in the in-game console with command `also_log_to_console`.
		Log.Info("DeepMining: constructed");
	}


	public override void RegisterPrototypes(ProtoRegistrator registrator) {
		Log.Info("DeepMining: registering prototypes");
		// Register all prototypes here.

		// Registers all products from this assembly. See DeepMiningIds.Products.cs for examples.
		registrator.RegisterAllProducts();

		// Use data class registration to register other protos such as machines, recipes, etc.
		registrator.RegisterData<ExampleMachineData>();

		// Registers all research from this assembly. See ExampleResearchData.cs for examples.
		registrator.RegisterDataWithInterface<IResearchNodesData>();
	}

}