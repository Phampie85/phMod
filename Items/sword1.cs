using Terraria.ID;
using Terraria.ModLoader;

namespace phMod.Items
{
	public class sword1 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("phampie85 sword");
			Tooltip.SetDefault("a sword");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 1);
			recipe.AddIngredient(ItemID.DemoniteBar, 13);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
