using System;


namespace DamageCounter
{ 
	public class bestsave
	{
        int a;
		int b;
		int c;
        int d;

		public int save (int a, int b, int c)
		{
            int d = a + c;

            if(b > d)

            {
                return d;
            }
            else
            {
                return b;
            }
        }

	}
}