namespace WithoutLiskov
{

    public class EvenNumbersSumCalculator:SumCalculator
    {
         public EvenNumbersSumCalculator(int[] numbers)
        :base(numbers)
    {
    }
 
    public new int Calculate() 
    {
        for(int i=0;i<_numbers.Length;i++)
        {
            if(_numbers[i]%2==0)
            {
                sum+=_numbers[i];
            }
        }
        return sum;
    }
    
}
}