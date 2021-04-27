using System;


namespace DamageCounter
{

	public class hitfinder
	{
		int bsws;
		int numshots;
		double v;
		int V;
        double x;
		int X;

        public hitfinder(int bsws, int numshots)
		{
			if (bsws == 2)
			{
				v = numshots * .8;
				V = (int)v;
				return V;
			}
            else if(bsws == 3)
			{
				x = numshots * .6;
                int X = (int)x;
                return X;
			}
		}

		
	}
}