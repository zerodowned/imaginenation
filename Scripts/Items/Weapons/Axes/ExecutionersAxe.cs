namespace Server.Items
{
	[Flipable( 0xf45, 0xf46 )]
	public class ExecutionersAxe : BaseAxe
	{
		////public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.BleedAttack; } }
		//public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.MortalStrike; } }

		public override int AosStrengthReq{ get{ return 40; } }
		public override int AosMinDamage{ get{ return 15; } }
		public override int AosMaxDamage{ get{ return 17; } }
		public override int AosSpeed{ get{ return 33; } }

		public override int OldStrengthReq{ get{ return 35; } }
		public override int OldMinDamage{ get{ return 24; } }
		public override int OldMaxDamage{ get{ return 33; } } //Loki edit: was 20 - 30
		public override int OldSpeed{ get{ return 408; } }

		public override int InitMinHits{ get{ return 31; } }
		public override int InitMaxHits{ get{ return 70; } }

		[Constructable]
		public ExecutionersAxe() : base( 0xF45 )
		{
			Weight = 8.0;
			HitSound = 566;
			MissSound = 568;
			//Name = "executioner's axe";
		}

		public ExecutionersAxe( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( 2 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

            if (version < 2)
            {
                MinDamage = 24;
                MaxDamage = 33;
            }
		}
	}
}