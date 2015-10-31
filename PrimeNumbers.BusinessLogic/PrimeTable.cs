namespace PrimeNumbers.BusinessLogic
{
    public class PrimeTable
    {
        private readonly int[] _axis;

        public PrimeTable(int[] axis)
        {
            _axis = axis;
        }

        public int[] AxisX
        {
            get { return _axis; }
        }

        public int[] AxisY
        {
            get {return _axis;}
        }

        public int GetCellValue(int x, int y)
        {
            return AxisX[x]*AxisY[y];
        }
    }
}