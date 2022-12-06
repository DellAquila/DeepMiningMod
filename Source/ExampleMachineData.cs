using Mafi;
using Mafi.Base;
using Mafi.Core.Entities.Animations;
using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Mods;

namespace DeepMining;

internal class ExampleMachineData : IModData {

	public void RegisterData(ProtoRegistrator registrator) {
		registrator.MachineProtoBuilder
			.Start("Deep Mining", DeepMiningIds.Machines.DeepMinerMachine)
			.Description("Deep Miner will give you all resources you need.")
			.SetCost(Costs.Build.CP(100).Workers(5))
			// For examples of layouts see `Mafi.Base.BaseMod` and `EntityLayoutParser`.
			.SetLayout(new EntityLayoutParams(useNewLayoutSyntax: true),
				"   [2][2][2][3][3][3][3][3][2]>@W",
				"   [2][2][3][5][5][7][7][4][3]   ",
				"   [2][2][3][5][5][7][7][4][3]>~K",
				"X#<[2][2][3][5][5][7][7][4][3]>~L",
				"   [2][2][2][3][3][7][7][4][3]   ",
				"   [2][2][2][2][2][2][2][2][3]>@E")
			.SetCategories(Ids.ToolbarCategories.MachinesMetallurgy)
			.SetPrefabPath(Assets.Base.Machines.MetalWorks.BlastFurnaceT1_prefab)
			.SetCustomIconPath(Assets.Base.Icons.Technologies.Recycling_svg)
			.SetAnimationParams(
				animParams: AnimationParams.RepeatTimes(Duration.FromKeyframes(360),
				times: 2,
				changeSpeedToFit: true))
			.BuildAndAdd();

		// Example of a new furnace recipe.
		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(12, Ids.Products.IronScrap, "L")
			.AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E", outputAtStart: true)
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 2",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting2,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(12, Ids.Products.CopperScrap, "L")
			.AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();



		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 3",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting3,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(18, Ids.Products.BrokenGlass, "L")
			.AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 4",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting4,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.Limestone, "L")
			.AddOutput(3, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 5",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting5,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(3, Ids.Products.GoldScrap, "L")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 6",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting6,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.Slag, "L")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();


		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 7",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting7,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.Rock, "L")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 8",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting8,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.Coal, "L")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 9",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting9,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.CopperOre, "L")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 10",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting10,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.IronOre, "L")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 11",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting11,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.GoldOre, "L")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 12",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting12,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.Quartz, "L")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 13",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting13,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.Wood, "X")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 14",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting14,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.UraniumOre, "L")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 15",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting15,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.Sulfur, "L")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 16",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting16,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.Dirt, "L")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 17",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting17,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.Sand, "L")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 18",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting18,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.Water, "W")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 19",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting19,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.CrudeOil, "W")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();

		registrator.RecipeProtoBuilder
			.Start(name: "Deep Miner 20",
				recipeId: DeepMiningIds.Recipes.ExampleSmelting20,
				machineId: DeepMiningIds.Machines.DeepMinerMachine)
			// .AddInput(8, DeepMiningIds.Products.ExampleLooseProduct)
			// .AddInput(2, Ids.Products.Coal)
			.SetDuration(30.Seconds())
			.AddOutput(15, Ids.Products.Seawater, "W")
			// .AddOutput(5, Ids.Products.Coal, "K")
			// .AddOutput(8, Ids.Products.Water, "W")
			.AddOutput(20, Ids.Products.CarbonDioxide, "E")
			.BuildAndAdd();







	}
}