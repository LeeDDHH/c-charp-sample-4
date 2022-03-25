using System;
namespace Sample_4_1_example
{
	public class Rectangle
	{
		double width = 0.0;
		double height = 0.0;

		public void SetWidth(double width) {
			this.width = width;
		}

		public void SetHeight(double height)
		{
			this.height = height;
		}

		public double GetArea() {
			if (width <= 0 || height <= 0) { return 0; };
			return width * height;
		}

		public double GetPerimeter()
		{
			if (width <= 0 || height <= 0) { return 0; };
			return width * 2 + height * 2;
		}
	}
}

