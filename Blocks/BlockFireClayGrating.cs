namespace SimplePotteryKiln.Blocks;
//TODO: Get rid of this & json entries, transfer block over to simple kiln door
using Vintagestory.API.Common;
using Vintagestory.API.MathTools;

internal class BlockFireClayGrating : Block
{
    public override void OnBlockPlaced(IWorldAccessor world, BlockPos blockPos, ItemStack byItemStack = null)
    {
        api.Logger.Event("Block Fire Clay Grating Placed");
        base.OnBlockPlaced(world, blockPos, byItemStack);
    }

    public override void OnBlockBroken(IWorldAccessor world, BlockPos pos, IPlayer byPlayer, float dropQuantityMultiplier = 1)
    {
        api.Logger.Event("Block Fire Clay Grating Broken");
        base.OnBlockBroken(world, pos, byPlayer, dropQuantityMultiplier);
    }
    
}