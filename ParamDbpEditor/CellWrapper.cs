using SoulsFormats;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ParamDbpEditor
{
    /// <summary>
    /// A wrapper to make managing cell value setting easier.
    /// </summary>
    internal class CellWrapper
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
            get => Cell.Dbp.DisplayTypeToString();
            set
            {
                var oldtype = Cell.DisplayType;
                try
                {
                    Cell.DisplayType = PARAMDBP.Field.GetDisplayType(value);
                }
                catch (NotImplementedException)
                {
                    Cell.DisplayType = oldtype;
                }
            }
        }

        /// <summary>
        /// The Description of the cell from its dbp field.
        /// </summary>
        public string Description
        {
            get => Cell.Description;
            set
            {
                Cell.Description = value;
            }
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
        public CellWrapper(DBPPARAM.Cell cell)
        {
            Cell = cell;
            Description = cell.Description;
            DisplayType = cell.Dbp.DisplayTypeToString();
        }

        /// <summary>
        /// Get a list of cellwrappers from a list of cells.
        /// </summary>
        /// <param name="cells">The list of cells to get a list of cell wrappers from.</param>
        /// <returns>A list of cellwrappers.</returns>
        public static List<CellWrapper> CellsToWrapper(IEnumerable<DBPPARAM.Cell> cells)
        {
            var wrappers = new List<CellWrapper>();
            foreach (DBPPARAM.Cell cell in cells)
                wrappers.Add(new CellWrapper(cell));
            return wrappers;
        }
    }
}
