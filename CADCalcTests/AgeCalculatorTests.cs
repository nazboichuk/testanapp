using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTasksWithLoopsAndConditions;

namespace CADCalcTests
{
	[TestClass]
	public class AgeCalculatorTests
	{
		[DataTestMethod]
		[DataRow(1, new int[] { 1, 15, 15 })]
		[DataRow(2, new int[] { 2, 24, 24 })]
		[DataRow(3, new int[] { 3, 28, 29 })]
		[DataRow(4, new int[] { 4, 32, 34 })]
		[DataRow(5, new int[] { 5, 36, 39 })]
		[DataRow(6, new int[] { 6, 40, 44 })]
		public void VerifyAgeCalculation(int humanYears, int[] expectedResult)
		{
			//Arrange
			var calc = new AgeCalculator();

			//Act
			var actualResult = calc.CalcYears(humanYears);

			//Assert
			CollectionAssert.AreEqual(expectedResult, actualResult);
		}
	}
}
