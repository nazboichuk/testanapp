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
			var stringsInterop = new StringsInteroperation();
			var actualResult = stringsInterop.DoesStringContainsOtherString(value, value1);
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
		/// Replace the whole text on the new one
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
		/// Remove the part of the string
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
		[DataRow("    test    ", "test")]
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
		[DataRow("Data 123", "DATA 123")]
		public void ConvertStringToUpperCase(string value, string expectedResult)
		{
			var stringsInterop = new StringsInteroperation();
			var actualResult = stringsInterop.ConvertStringToUpperCase(value);
			Assert.AreEqual(expectedResult, actualResult);
		}

		/// <summary>
		/// Returns a copy of line, in lower case style
		/// </summary>
		[DataTestMethod]
		[DataRow("AuToMaTeD", "automated")]
		[DataRow("S1S2S3S4", "s1s2s3s4")]
		[DataRow("VERIFY stringS", "verify strings")]
		public void ConvertStringToTheLowerCase(string value, string expectedResult)
		{
			var stringsInterop = new StringsInteroperation();
			var actualResult = stringsInterop.ConvertStringToLowerCase(value);
			Assert.AreEqual(expectedResult, actualResult);
		}
	}
}
