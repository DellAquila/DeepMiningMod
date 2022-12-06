﻿using Mafi.Base;
using ProductID = Mafi.Core.Products.ProductProto.ID;

namespace DeepMining;

// Tip: Keep all IDs as static members of a class like this. See `Mafi.Base.Ids`
public static partial class DeepMiningIds {

	// Products proto registrations can be done either by manually constructing and registering
	// `ProductProto` variants or by defining IDs and marking them with one of following attributes:
	// CountableProduct, FluidProduct, LooseProduct, MoltenProduct, or VirtualProduct.
	// These static IDs are then automatically registered via `registrator.RegisterAllProducts()`.
	public static partial class Products {

		//	[CountableProduct(icon: Assets.Base.Products.Icons.Wood_svg,
		// prefab: Assets.Base.Products.Countable.RawWood_prefab)]
		// public static readonly ProductID ExampleUnitProduct = Ids.Products.CreateId("ExampleUnitProduct");

		// [FluidProduct(color: 0xFF00FF, icon: Assets.Base.Products.Icons.Water_svg)]
		// public static readonly ProductID ExampleFluidProduct = Ids.Products.CreateId("ExampleFluidProduct");

		// [LooseProduct(material: Assets.Base.Products.Loose.Dirt_mat,
		// icon: Assets.Base.Products.Icons.Dirt_svg, dumpByDefault: true, isFarmable: true)]
		// public static readonly ProductID ExampleLooseProduct = Ids.Products.CreateId("ExampleLooseProduct");

		// [MoltenProduct(material: Assets.Base.Products.Molten.Copper_mat,
		// prefab: Assets.Base.Products.Molten.MoltenCopper_prefab,
		// icon: Assets.Base.Products.Icons.CopperMolten_svg)]
		// public static readonly ProductID ExampleMoltenProduct = Ids.Products.CreateId("ExampleMoltenProduct");

	}

}