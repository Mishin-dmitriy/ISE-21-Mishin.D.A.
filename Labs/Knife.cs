using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
	class Knife
	{
		public void cutMeat(Meat meat)
		{
			meat.isCut = true;
		}

		public void brokeEgg(Egg egg)
		{
			egg.isBroken = true;
		}
	}
}
