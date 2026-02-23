using Vintagestory.API.Common;
using Vintagestory.API.MathTools;

namespace SimplePotteryKiln.Blocks;

public class BlockSimpleKilnDoor : Block
{
    public override void OnBlockPlaced(IWorldAccessor world, BlockPos blockPos, ItemStack byItemStack = null)
    {
        api.Logger.Event("Block Simple Kiln Door Placed");
        base.OnBlockPlaced(world, blockPos, byItemStack);
    }

    public override void OnBlockBroken(IWorldAccessor world, BlockPos pos, IPlayer byPlayer, float dropQuantityMultiplier = 1)
    {
        api.Logger.Event("Block Simple Kiln Door Broken");
        base.OnBlockBroken(world, pos, byPlayer, dropQuantityMultiplier);
    }
}