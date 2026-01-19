namespace KebabGGbab.Primitives.Extensions.Tests.TestClasses
{
	[TestClass]
	public sealed class StringExtensionsTest
	{
		[TestMethod]
		public void ToStream_ReadStream_String()
		{
			string str = "Привет мир!";

			Stream stream = str.ToStream();
			using StreamReader sr = new(stream);
			string valueStream = sr.ReadToEnd();

			Assert.AreEqual(str, valueStream);
		}

		[TestMethod]
		public void Replace_ReplaceArrayCharWithNewChar_StringWithoutOldChar()
		{
			string str = "Hellow world!";
			char[] oldChars = ['l', ' ', '!'];
			char newChar = '1';

			str = str.Replace(oldChars, newChar);

			Assert.AreEqual("He11ow1wor1d1", str);
		}
	}
}
