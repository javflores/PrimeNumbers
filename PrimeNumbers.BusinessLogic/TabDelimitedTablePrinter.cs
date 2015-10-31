using System;
using System.Text;

namespace PrimeNumbers.BusinessLogic
{
    public class TabDelimitedTablePrinter : ITablePrinter
    {
        public const string Tab = "\t";

        public void Print(PrimeTable table)
        {
            if (table == null || table.AxisX == null)
                return;

            PrintHeader(table);
            for (var i = 0; i < table.AxisX.Length; i++)
            {
                PrintRow(table, i);
            }
        }

        private void PrintHeader(PrimeTable table)
        {
            var builder = new StringBuilder();
            builder.Append(Tab);

            for (var i = 0; i < table.AxisX.Length; i++)
            {
                builder.Append(table.AxisX[i]);

                if ((i + 1) < table.AxisX.Length)
                    builder.Append(Tab);
            }

            var output = builder.ToString();
            Console.WriteLine(output);
        }

        private void PrintRow(PrimeTable table, int index)
        {
            var builder = new StringBuilder();
            builder.Append(table.AxisY[index]);
            builder.Append(Tab);

            for (var i = 0; i < table.AxisX.Length; i++)
            {
                var cellValue = table.GetCellValue(index, i);
                builder.Append(cellValue);

                if ((i + 1) < table.AxisX.Length)
                    builder.Append(Tab);
            }

            var output = builder.ToString();
            Console.WriteLine(output);
        }
    }
}
