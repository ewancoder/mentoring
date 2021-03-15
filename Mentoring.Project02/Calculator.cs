namespace Mentoring.Project02
{
    public sealed class Calculator
    {
        public int Sum(int firstNumber, int secondNumber, int thirdNumber)
        {
            var firstSum = firstNumber + secondNumber;
            var secondSum = secondNumber + thirdNumber;

            return firstSum + secondSum;
        }
    }
}
