using NUnit.Framework;
using NUnit.Framework.Constraints;

[TestFixture]
public class TTDDFizzBuzUnitTest
{
    [Test]
    public void GivenOne_Return_One()
    {
        int input = 1;
        string expected = "1";

        FizzBuzz fizzBuzz = CreateFizzBuzz();

        string results = fizzBuzz.GetFizzBuzz(input);

        Assert.AreEqual(expected, results);
    }

    private static FizzBuzz CreateFizzBuzz()
    {
        return new FizzBuzz();
    }

    [Test]
    public void GivenTwo_Return_Two()
    {
        int input = 2;
        string expected = "2";

        FizzBuzz fizzBuzz = CreateFizzBuzz();

        string results = fizzBuzz.GetFizzBuzz(input);

        Assert.AreEqual(expected, results);
    }

    [Test]
    public void GivenThree_Return_Fizz()
    {
        int input = 3;
        string expected = "Fizz";

        FizzBuzz fizzBuzz = CreateFizzBuzz();

        string results = fizzBuzz.GetFizzBuzz(input);

        Assert.AreEqual(expected, results);
    }

    [Test]
    public void GivenFour_Return_Four()
    {
        int input = 4;
        string expected = "4";

        FizzBuzz fizzBuzz = CreateFizzBuzz();

        string results = fizzBuzz.GetFizzBuzz(input);

        Assert.AreEqual(expected, results);
    }

    [Test]
    public void GivenFive_Return_Buzz()
    {
        int input = 5;
        string expected = "Buzz";

        FizzBuzz fizzBuzz = CreateFizzBuzz();

        string results = fizzBuzz.GetFizzBuzz(input);

        Assert.AreEqual(expected, results);
    }

    [Test]
    public void GivenSix_Return_Fizz()
    {
        int input = 6;
        string expected = "Fizz";

        FizzBuzz fizzBuzz = CreateFizzBuzz();

        string results = fizzBuzz.GetFizzBuzz(input);

        Assert.AreEqual(expected, results);
    }

    [Test]
    public void GivenTen_Return_Buzz()
    {
        int input = 10;
        string expected = "Buzz";

        FizzBuzz fizzBuzz = CreateFizzBuzz();

        string results = fizzBuzz.GetFizzBuzz(input);

        Assert.AreEqual(expected, results);
    }

    [Test]
    public void GivenFifteen_Return_FizzBuzz()
    {
        int input = 15;
        string expected = "FizzBuzz";

        FizzBuzz fizzBuzz = CreateFizzBuzz();

        string results = fizzBuzz.GetFizzBuzz(input);

        Assert.AreEqual(expected, results);
    }

    [Test]
    public void GivenThirthy_Return_FizzBuzz()
    {
        int input = 30;
        string expected = "FizzBuzz";

        FizzBuzz fizzBuzz = CreateFizzBuzz();

        string results = fizzBuzz.GetFizzBuzz(input);

        Assert.AreEqual(expected, results);
    }

}

public class FizzBuzz
{
    public string GetFizzBuzz(int number)
    {

        if (DivisibleByThree(number) && DivisibleByFive(number))
        {
            return "FizzBuzz";
        }

        if (DivisibleByThree(number))
        {
            return "Fizz";
        }
        return DivisibleByFiveOrNotByBothThreeAndFive(number);

        //return DivisibleByFive(number) ? "Buzz" : NotDivisibleByThreeAndFive(number);

      /*  if (DivisibleByFive(number))
        {
            return "Buzz";
        }

        return NotDivisibleByThreeAndFive(number);*/
    }

    private static string DivisibleByFiveOrNotByBothThreeAndFive(int number)
    {
        return DivisibleByFive(number) ? "Buzz" : NotDivisibleByThreeAndFive(number);
    }

    private static string NotDivisibleByThreeAndFive(int number)
    {
        return number.ToString();
    }

    private static bool DivisibleByFive(int number)
    {
        return number % 5 == 0;
    }

    private static bool DivisibleByThree(int number)
    {
        return number % 3 == 0;
    }
}