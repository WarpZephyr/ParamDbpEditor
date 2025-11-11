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
                dbp.Fields[i].Default = PARAMDBP.Field.ConvertToDbpType(dbp.Fields[i].Default.ToString(), dbp.Fields[i].DisplayType);
                dbp.Fields[i].Minimum = PARAMDBP.Field.ConvertToDbpType(dbp.Fields[i].Minimum.ToString(), dbp.Fields[i].DisplayType);
                dbp.Fields[i].Maximum = PARAMDBP.Field.ConvertToDbpType(dbp.Fields[i].Maximum.ToString(), dbp.Fields[i].DisplayType);
                dbp.Fields[i].Increment = PARAMDBP.Field.ConvertToDbpType(dbp.Fields[i].Maximum.ToString(), dbp.Fields[i].DisplayType);
            }
            return dbp;
        }
    }
}
