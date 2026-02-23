using SimplePotteryKiln.Blocks;
using Vintagestory.API.Common;

namespace SimplePotteryKiln;

public class SimplePotteryKilnModSystem : ModSystem
{
    public override void Start(ICoreAPI api)
    {
        base.Start(api);
        api.RegisterBlockClass(Mod.Info.ModID + ".fireclay-grating", typeof(BlockFireClayGrating));
    }
}