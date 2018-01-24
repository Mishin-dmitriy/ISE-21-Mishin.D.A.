using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
	class MeatGrinder
	{
		public bool state;

		public Meat meat { set; private get; }
		public Egg egg { set; private get; }
		public Spice spice { set; private get; }

		public ForceMeat getForceMeat()
		{
			if(meat!=null &&
				egg !=null &&
				spice != null &
				state)
			{
				meat = null;
				egg = null;
				spice = null;
				return new ForceMeat();
			} else
			{
				return null;
			}
		}

	}
}
