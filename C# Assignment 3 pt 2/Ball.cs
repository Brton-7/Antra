using System;

namespace OOP_Classes
{
	public class Ball : Color
	{
		public double size { get; set; }
		public Color ballColor { get; set; } 
		public int numThrows { get; set; }
		public Ball(Color ball)
		{
			ballColor = ball; 
		}
		puplic void pop()
        {
			size = 0;
        }
		public void Throw()
        {
			if(size > 0)
            {
				numThrows++;
            }
        }
	}
}

