
public class SumCalculator
{
    protected readonly int[] _numbers;
    protected int sum=0;
 
    public SumCalculator(int[] numbers)
    {
        _numbers = numbers;
    }
 
    public int Calculate()
    {
        for(int i=0;i<_numbers.Length;i++)
        {
            sum+=_numbers[i];
        }
        return sum;

    }
}