using SoulsFormats;

namespace ParamDbpEditor
{
    internal static class EditorJsonSerializer
    {
        internal static PARAMDBP ConvertDataToTypes(this PARAMDBP dbp)
        {
            for (int i = 0; i < dbp.Fields.Count; i++)
            {
                dbp.Fields[i].DisplayName = dbp.Fields[i].DisplayName.ToString();
                dbp.Fields[i].DisplayFormat = dbp.Fields[i].DisplayFormat.ToString();
                dbp.Fields[i].Default = PARAMDBP.Field.ConvertToDisplayType(dbp.Fields[i].Default.ToString(), dbp.Fields[i].DisplayType);
                dbp.Fields[i].Minimum = PARAMDBP.Field.ConvertToDisplayType(dbp.Fields[i].Minimum.ToString(), dbp.Fields[i].DisplayType);
                dbp.Fields[i].Maximum = PARAMDBP.Field.ConvertToDisplayType(dbp.Fields[i].Maximum.ToString(), dbp.Fields[i].DisplayType);
                dbp.Fields[i].Increment = PARAMDBP.Field.ConvertToDisplayType(dbp.Fields[i].Maximum.ToString(), dbp.Fields[i].DisplayType);
            }
            return dbp;
        }

        internal static DBPPARAM ConvertDataToTypes(this DBPPARAM param)
        {
            for (int i = 0; i < param.Cells.Count; i++)
            {
                param.Cells[i].DisplayName = param.Cells[i].DisplayName.ToString();
                param.Cells[i].DisplayFormat = param.Cells[i].DisplayFormat.ToString();
                param.Cells[i].Default = PARAMDBP.Field.ConvertToDisplayType(param.Cells[i].Default.ToString(), param.Cells[i].DisplayType);
                param.Cells[i].Minimum = PARAMDBP.Field.ConvertToDisplayType(param.Cells[i].Minimum.ToString(), param.Cells[i].DisplayType);
                param.Cells[i].Maximum = PARAMDBP.Field.ConvertToDisplayType(param.Cells[i].Maximum.ToString(), param.Cells[i].DisplayType);
                param.Cells[i].Increment = PARAMDBP.Field.ConvertToDisplayType(param.Cells[i].Maximum.ToString(), param.Cells[i].DisplayType);
            }
            return param;
        }
    }
}
