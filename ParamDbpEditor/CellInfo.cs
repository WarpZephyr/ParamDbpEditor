using SoulsFormats;
using System.Collections.Generic;

namespace ParamDbpEditor
{
    /// <summary>
    /// A wrapper to make managing cell value setting easier.
    /// </summary>
    internal class CellInfo
    {
        /// <summary>
        /// The underlying cell.
        /// </summary>
        public DBPPARAM.Cell Cell { get; set; }

        /// <summary>
        /// The DisplayType of the cell from its dbp field as a string.
        /// </summary>
        public string DisplayType
        {
            get => Cell.Dbp.DisplayType.ToString();
        }

        /// <summary>
        /// The DisplayName of the cell from its dbp field.
        /// </summary>
        public string DisplayName
        {
            get => Cell.DisplayName;
        }

        /// <summary>
        /// The value of the cell.
        /// </summary>
        public object Value
        {
            get => Cell.Value;
            set
            {
                object oldvalue = Cell.Value;
                try
                {
                    Cell.Value = value;
                }
                catch
                {
                    Cell.Value = oldvalue;
                }
            }
        }

        /// <summary>
        /// Create a new cell wrapper.
        /// </summary>
        /// <param name="cell">The underlying cell.</param>
        public CellInfo(DBPPARAM.Cell cell)
        {
            Cell = cell;
        }

        /// <summary>
        /// Get a list of cellwrappers from a list of cells.
        /// </summary>
        /// <param name="cells">The list of cells to get a list of cell wrappers from.</param>
        /// <returns>A list of cellwrappers.</returns>
        public static List<CellInfo> CellsToWrapper(IEnumerable<DBPPARAM.Cell> cells)
        {
            var wrappers = new List<CellInfo>();
            foreach (DBPPARAM.Cell cell in cells)
                wrappers.Add(new CellInfo(cell));
            return wrappers;
        }
    }
}
