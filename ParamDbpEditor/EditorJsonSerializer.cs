using SoulsFormats;

namespace ParamDbpEditor
{
    internal static class EditorJsonSerializer
    {
        internal static PARAMDBP ConvertDataToTypes(this PARAMDBP dbp)
        {
            for (int i = 0; i < dbp.Fields.Count; i++)
            {
                dbp.Fields[i].Description = dbp.Fields[i].Description.ToString();
                dbp.Fields[i].DisplayFormat = dbp.Fields[i].DisplayFormat.ToString();
                dbp.Fields[i].Default = PARAMDBP.Field.ConvertToFieldType(dbp.Fields[i].Default.ToString(), dbp.Fields[i].DisplayType);
                dbp.Fields[i].Minimum = PARAMDBP.Field.ConvertToFieldType(dbp.Fields[i].Minimum.ToString(), dbp.Fields[i].DisplayType);
                dbp.Fields[i].Maximum = PARAMDBP.Field.ConvertToFieldType(dbp.Fields[i].Maximum.ToString(), dbp.Fields[i].DisplayType);
                dbp.Fields[i].Increment = PARAMDBP.Field.ConvertToFieldType(dbp.Fields[i].Maximum.ToString(), dbp.Fields[i].DisplayType);
            }
            return dbp;
        }

        internal static DBPPARAM ConvertDataToTypes(this DBPPARAM param)
        {
            for (int i = 0; i < param.Cells.Count; i++)
            {
                param.Cells[i].Description = param.Cells[i].Description.ToString();
                param.Cells[i].DisplayFormat = param.Cells[i].DisplayFormat.ToString();
                param.Cells[i].Default = PARAMDBP.Field.ConvertToFieldType(param.Cells[i].Default.ToString(), param.Cells[i].DisplayType);
                param.Cells[i].Minimum = PARAMDBP.Field.ConvertToFieldType(param.Cells[i].Minimum.ToString(), param.Cells[i].DisplayType);
                param.Cells[i].Maximum = PARAMDBP.Field.ConvertToFieldType(param.Cells[i].Maximum.ToString(), param.Cells[i].DisplayType);
                param.Cells[i].Increment = PARAMDBP.Field.ConvertToFieldType(param.Cells[i].Maximum.ToString(), param.Cells[i].DisplayType);
            }
            return param;
        }
    }
}
