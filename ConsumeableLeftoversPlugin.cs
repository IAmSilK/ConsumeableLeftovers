using Rocket.Core.Plugins;
using SDG.Unturned;
using SilK.ConsumeableLeftovers.Configuration;
using System.Linq;

namespace SilK.ConsumeableLeftovers
{
    public class ConsumeableLeftoversPlugin : RocketPlugin<ConsumeableLeftoversConfiguration>
    {
        public static ConsumeableLeftoversPlugin Instance { get; private set; }

        protected override void Load()
        {
            Instance = this;

            UseableConsumeable.onConsumePerformed += OnConsumePerformed;
        }

        protected override void Unload()
        {
            Instance = null;

            UseableConsumeable.onConsumePerformed -= OnConsumePerformed;
        }

        private void OnConsumePerformed(Player instigatingPlayer, ItemConsumeableAsset consumeableAsset)
        {
            foreach (var leftover in Configuration.Instance.Leftovers.Where(x => x.Id == consumeableAsset.id))
            {
                ItemTool.tryForceGiveItem(instigatingPlayer, leftover.LeftoverId, 1);
            }
        }
    }
}
