namespace ShapesLibrary.Abstraction
{
	/// <summary>
	/// Интерфейс описания фигуры
	/// </summary>
	public interface IShape
	{
		/// <summary>
		/// Метод подсчета площади
		/// </summary>
		/// <returns>
		/// Возвращает площадь фигуры
		/// </returns>
		public double GetArea();
	}
}
