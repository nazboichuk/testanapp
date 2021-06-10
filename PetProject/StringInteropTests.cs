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

		/// <summary>
		///  Verify that String Equals / not equals to the test data
		/// </summary>
		[DataTestMethod]
		[DataRow("Test", "Test", true)]
		[DataRow("Test", "Testa", false)]
		public void VerifyStringEquals(string value, string value1, bool expectedResult)
		{
			var stringsInterop = new StringsInteroperation();
			var actualResult = stringsInterop.DoesStringEqualsToOtherString(value, value1);
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// Replace method
		/// </summary>
		[DataTestMethod]
		[DataRow("Test", "Data", "Data")]
		public void ReplaceTheWholeString(string valuenew, string valueold, string expectedResult)
		{
			//Arrange
			var stringsInterop = new StringsInteroperation();
			var actualResult = stringsInterop.ReplaceTheString(valuenew, valueold);
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// Remove method
		/// </summary>
		[DataTestMethod]
		[DataRow("Test", 2, "Te")]
		public void RemoveTheEndOfTheString(string value, int index, string expectedResult)
		{
			var stringsInterop = new StringsInteroperation();
			var actualResult = stringsInterop.RemoveTheString(value, index);
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// Remove spaces from the string
		/// </summary>
		[DataTestMethod]
		[DataRow(" Test should be automated ", "Test should be automated")]
		public void RemoveTheSpacesFromWholeString(string value, string expectedResult)
		{
			var stringsInterop = new StringsInteroperation();
			var actualResult = stringsInterop.RemoveSpacesFromString(value);
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// Returns a copy of line, in uppercase style
		/// </summary>
		[DataTestMethod]
		[DataRow("test", "TEST")]
		public void ConvertStringToUpperCase(string value, string expectedResult)
		{
			var stringsInterop = new StringsInteroperation();
			var actualResult = stringsInterop.ConvertStringToUpperCase(value);
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// Returns a copy of line, in uppercase style
		/// </summary>
		[DataTestMethod]
		[DataRow("AuToMaTeD", "automated")]
		public void ConvertStringToTheLowerCase(string value, string expectedResult)
		{
			var stringsInterop = new StringsInteroperation();
			var actualResult = stringsInterop.ConvertStringToLowerCase(value);
			Assert.AreEqual(expectedResult, actualResult);
		}

	}
}
