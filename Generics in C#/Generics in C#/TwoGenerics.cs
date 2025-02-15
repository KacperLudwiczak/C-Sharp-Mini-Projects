namespace Generics_in_C_
{
	internal class TwoGenerics<TFirst, TSecond>
	{
		public TFirst First { get; set; }
		public TSecond Second { get; set; }

		public TwoGenerics(TFirst first, TSecond second)
		{
			First = first;
			Second = second;
		}

		public void Display()
		{
			Console.WriteLine($"First: {First}. Second: {Second}.");
		}
	}
}