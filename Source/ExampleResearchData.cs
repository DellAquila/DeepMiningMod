using Mafi;
using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Research;

namespace DeepMining;

internal class ExampleResearchData : IResearchNodesData {

	public void RegisterData(ProtoRegistrator registrator) {

		ResearchNodeProto nodeProto = registrator.ResearchNodeProtoBuilder
			.Start("Deep Miner Research", DeepMiningIds.Research.UnlockDeepMiningStuff)
			.Description("Unlocks a miner that generates basic resources.")
	//		.AddProductToUnlock(DeepMiningIds.Products.ExampleLooseProduct)
	//		.AddProductToUnlock(DeepMiningIds.Products.ExampleFluidProduct)
	//		.AddProductToUnlock(DeepMiningIds.Products.ExampleUnitProduct)
			.AddMachineToUnlock(DeepMiningIds.Machines.DeepMinerMachine)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting2)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting3)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting4)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting5)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting6)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting7)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting8)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting9)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting10)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting11)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting12)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting13)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting14)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting15)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting16)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting17)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting18)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting19)
			.AddRecipeToUnlock(DeepMiningIds.Recipes.ExampleSmelting20)
			.BuildAndAdd();

		nodeProto.GridPosition = new Vector2i(0, 40);
		// nodeProto.AddParent(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.BasicFarming));

	}

}