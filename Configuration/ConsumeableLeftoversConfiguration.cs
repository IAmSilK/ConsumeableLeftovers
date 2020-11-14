using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SilK.ConsumeableLeftovers.Configuration
{
    public class ConsumeableLeftoversConfiguration : IRocketPluginConfiguration
    {
        [XmlArrayItem("Leftover")]
        public List<LeftoverConfig> Leftovers { get; set; }

        public void LoadDefaults()
        {
            Leftovers = new List<LeftoverConfig>
            {
                new LeftoverConfig(13, 72)
            };
        }
    }
}
