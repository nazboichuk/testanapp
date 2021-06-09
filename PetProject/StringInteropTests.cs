using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperationWithStrings;

namespace PetProject
{
	[TestClass]
	public class StringInteropTests
	{
		[DataTestMethod]
		[DataRow("Test", 4)]
		[DataRow("A", 1)]
		public void VerifyStringLength(string value, int expectedResult)
		{
			//Arrange
			var stringsInterop = new StringsInteroperation();

			//Act
			var actualResult = stringsInterop.GetStringLength(value);

			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		[DataTestMethod]
		[DataRow("Test", "est", true)]
		[DataRow("Test", "rwa", false)]
		public void VerifyStringContains(string value, string value1, bool expectedResult)
		{
			//Arrange
			var stringsInterop = new StringsInteroperation();

			//Act
			var actualResult = stringsInterop.DoesStringContainsOtherString(value, value1);

			//Assert
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}
