namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int minValue;

        private int maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public override bool IsValid(object obj)
        {
            int age = int.Parse(obj.ToString());

            if (minValue <= age && age <= maxValue)
            {
                return true;
            }

            return false;
        }
    }
}
