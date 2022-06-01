using Xunit;

namespace tictactoe1.tests
{
    public class GameTests
    {
        [Fact]
        public void Test1GetFirstLineTekst_WhenHasValues_ThenReturnFirstLine()
        {
            string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string expected = "  1  |  2  |  3  ";
            string firstLine = Game.GetFirstLineTekst(pos);

            Assert.Equal(expected, firstLine);
        }
        [Fact]
        public void Test1GetSecondLineTekst_WhenHasValues_ThenReturnSecondLine()
        {
            string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
                
            string expected = "  4  |  5  |  6  ";
            string secondLine = Game.GetSecondLineTekst(pos);

            Assert.Equal(expected, secondLine);
        }
        [Fact]
        public void Test1GetThirdLineTekst_WhenHasValues_ThenReturnThirdLine()
        {
            string[] pos = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string expected = "  7  |  8  |  9  ";
            string thirdLine = Game.GetThirdLineTekst(pos);

            Assert.Equal(expected, thirdLine);
        }
    }
}