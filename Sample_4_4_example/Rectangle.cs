using System;
namespace Sample_4_4_example
{
	public class Rectangle
	{
		private double width;
		private double height;

		public double Width
		{
			set { width = value; }
			get { return width; }
		}

		public double Height
		{
			set { height = value; }
			get { return height; }
		}

    public double GetArea()
    {
      return width * height;
    }

    public double GetPerimeter()
    {
      return width * 2 + height * 2;
    }

  }
}
