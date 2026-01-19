namespace KebabGGbab.Primitives.Extensions.Tests.TestClasses
{
    [TestClass]
    public class PathExtensionsTest
    {
        [TestMethod]
        public void CorrectFileName_SendNotCorrect_ReturCorrect()
        {
            string fileName = "H\\e/l:l*o?W\"o<r>l|d_-=+";

            fileName = Path.CorrectFileName(fileName);

            Assert.AreEqual("H_e_l_l_o_W_o_r_l_d_-=+", fileName);
        }
    }
}
