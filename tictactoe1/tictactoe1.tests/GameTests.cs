using Xunit;

namespace tictactoe1.tests
{
    public class GameTests
    {
        [Fact]
        public void Test1GetFirstLineTekst_WhenHasValues_ThenReturnFirstLine()
        {
            string[] pos = new string[10] { "a", "b", "c", "d", "4", "5", "6", "7", "8", "9" };
            string expected = "  a  |  b  |  c  ";
            string firstLine = Game.GetFirstLineTekst(pos);

            Assert.Equal(expected, firstLine);
        }
        [Fact]
        public void Test1GetSecondLineTekst_WhenHasValues_ThenReturnSecondLine()
        {
            string[] pos = new string[3] { "d", "b", "g" };
            string expected = "  d  |  b  |  g  ";
            string secondLine = Game.GetSecondLineTekst(pos);

            Assert.Equal(expected, secondLine);
        }
        [Fact]
        public void Test1GetThirdLineTekst_WhenHasValues_ThenReturnThirdLine()
        {
            string[] pos = new string[3] { "h", "v", "i" };
            string expected = "  h  |  v  |  i  ";
            string thirdLine = Game.GetThirdLineTekst(pos);

            Assert.Equal(expected, thirdLine);
        }
    }
}