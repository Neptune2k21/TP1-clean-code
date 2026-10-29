namespace Tp1.CleanCode.Tests;
public class UnitTest1
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "II")]
    [InlineData(3, "III")]
    [InlineData(4, "IV")]
    public void Test_Un_Vaut_I(int num, string sortie)
    {
            string result = ConvertiseurService.ConvertRomain(num);

            Assert.Equal(sortie, result);
    }
    /*[Fact]
    public void Test_Deux_Vaut_II()
    {
            int num = 2;
            string result = ConvertiseurService.ConvertRomain(num);

            Assert.Equal("II", result);
    }
    [Fact]
    public void Test_Trois_Vaut_III()
    {
            int num = 3;
            string result = ConvertiseurService.ConvertRomain(num);

            Assert.Equal("III", result);
    }
    [Fact]
    public void Test_Quatre_Vaut_IV()
    {
            int num = 4;
            string result = ConvertiseurService.ConvertRomain(num);

            Assert.Equal("IV", result);
    }*/
}
