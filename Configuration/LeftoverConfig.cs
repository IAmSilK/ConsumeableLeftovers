using System.Xml.Serialization;

namespace SilK.ConsumeableLeftovers.Configuration
{
    public class LeftoverConfig
    {
        [XmlAttribute]
        public ushort Id { get; set; }

        [XmlAttribute]
        public ushort LeftoverId { get; set; }

        public LeftoverConfig() : this(0, 0)
        {
        }

        public LeftoverConfig(ushort id, ushort leftoverId)
        {
            Id = id;
            LeftoverId = leftoverId;
        }
    }
}
