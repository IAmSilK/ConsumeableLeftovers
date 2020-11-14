using System.Xml.Serialization;

namespace SilK.ConsumeableLeftovers.Configuration
{
    public class LeftoverConfig
    {
        [XmlAttribute]
        public ushort Id { get; set; }

        [XmlAttribute]
        public ushort LeftoverId { get; set; }

        public LeftoverConfig(ushort id, ushort leftoverId)
        {
            Id = id;
            LeftoverId = leftoverId;
        }
    }
}
