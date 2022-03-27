using System;
namespace Sample_4_6_example
{
	public class Bingo
	{
		private int[,] data;
        private int size;
        private int bingoSheetSize;

        private void InitFiled(int size)
        {
            this.size = size;
            data = new int[size, size];
            bingoSheetSize = size * size;
            return;
        }

        private void InitBingoSheet()
		{
			for (int i = 0; i < data.GetLength(0); i++)
			{
				for (int j = 0; j < data.GetLength(1); j++)
				{
					data[i, j] = 0;
				}
			}

			return;
		}

		private void GenerateBingo()
		{
			Random rnd = new Random();

			int num = 1;

			while (num <= bingoSheetSize)
			{

				while (true)
				{
					int m = rnd.Next(size);
					int n = rnd.Next(size);

					if (data[m, n] == 0)
					{
						data[m, n] = num;
						num++;
						break;
					}
				}
			}

			return;
		}

		public void Init(int size)
		{
            InitFiled(size);
            InitBingoSheet();
			GenerateBingo();
		}

		public void Show()
		{
			for (int i = 0; i < data.GetLength(0); i++)
			{
				for (int j = 0; j < data.GetLength(1); j++)
				{
					Console.Write("{0,2:d}|", data[i, j]);
				}
				Console.WriteLine();
				for (int j = 0; j < data.GetLength(1); j++)
				{
					Console.Write("---");
				}
				Console.WriteLine();
			}
		}
	}
}
