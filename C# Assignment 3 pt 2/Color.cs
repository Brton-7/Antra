using System;

namespace OOP_Classes
{
	public class Color
	{
		public int red { get; set; }
		public int green { get; set; }
		public int blue { get; set; }
		public int alpha { get; set; }

		public Color(int red, int green, int blue, int alpha)
		{

		}
		public Color(int red, int green, int blue, int alpha = 255)
		{
			Console.WriteLine("Opaque");
		}
		public void grayscale()
        {
			int temp = (red + green + blue)/3;
			Console.WriteLine("Grayscale: " + temp);
        }
	}
}
