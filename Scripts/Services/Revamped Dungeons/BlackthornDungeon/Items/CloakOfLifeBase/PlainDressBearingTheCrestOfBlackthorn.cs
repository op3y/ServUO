using Server;
using System;

namespace Server.Items
{
    public class PlainDressBearingTheCrestOfBlackthorn5 : PlainDress
    {
        public override bool IsArtifact { get { return true; } }
        
        [Constructable]
        public PlainDressBearingTheCrestOfBlackthorn5()
            : base()
        {
            ReforgedSuffix = ReforgedSuffix.Blackthorn;
            Attributes.BonusHits = 3;
            Attributes.RegenHits = 1;
            Hue = 132;
        }

        //public override int InitMinHits { get { return 255; } }
        //public override int InitMaxHits { get { return 255; } }

        public PlainDressBearingTheCrestOfBlackthorn5(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(1);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            if (version == 0)
            {
                MaxHitPoints = 0;
                HitPoints = 0;
            }
        }
    }
}