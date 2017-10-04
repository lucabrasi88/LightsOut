using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightsOutApp.Classes
{
    /// <summary>
    /// Keeps row number and column number for given light button
    /// </summary>
    public class Light
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }

        public Light(int rowNumber, int columnNumber)
        {
            RowNumber = rowNumber;
            ColumnNumber = columnNumber;
        }
    }
}
