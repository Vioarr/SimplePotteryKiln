using SimplePotteryKiln.Blocks;
using Vintagestory.API.Common;

namespace SimplePotteryKiln;

public class SimplePotteryKilnModSystem : ModSystem
{
    public override void Start(ICoreAPI api)
    {
        base.Start(api);
        api.RegisterBlockClass(Mod.Info.ModID + ".simple-kiln-door", typeof(BlockSimpleKilnDoor));
        api.RegisterBlockEntityClass(Mod.Info.ModID + ".simple-kiln", typeof(BESimplePotteryKiln));
    }
}