namespace ShapesLibrary.Abstraction
{
	/// <summary>
	/// Описывает фигуру
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
