using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
	class Pan
	{
		public Oil oil { set; private get; }
		public ForceMeat forceMeat { set; private get; }
		public Cutlets cutlets { private set; get; }
		public int temperature;

		public void cook(int temperature)
		{
			this.temperature += temperature;
			if (this.oil != null &&
				this.forceMeat != null &&
				this.temperature >= 100)
			{
				oil = null;
				forceMeat = null;
				cutlets = new Cutlets();
			}
            else
			{
				cutlets =  null;
			}
		}
		
	}
}
