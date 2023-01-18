using System.Data;

namespace App.Extensions
{
    internal static class DataGridExtension
    {
        public static void AddListToDataTable<T>(this DataGridView dataGridView, IList<T> list, params (string fieldName, string displayName)[] columnNames)
        {
            var dataTable = new DataTable();

            var columns = new List<DataColumn>(columnNames.Select(columnName => new DataColumn(columnName.displayName))).ToArray();

            try
            {
                dataTable.Columns.AddRange(columns);

                foreach (var item in list)
                {
                    if (item != null)
                    {
                        var properties = new List<string>();

                        var fieldNames = columnNames.Select(columnName => columnName.fieldName);
                        foreach (var fieldName in fieldNames)
                        {
                            var propertyInfo = item.GetType().GetProperty(fieldName);
                            if (propertyInfo != null)
                            {
                                var propertyValue = Convert.ToString(propertyInfo.GetValue(item));
                                properties.Add(propertyValue ?? string.Empty);
                            }
                        }
                        dataTable.Rows.Add(properties.ToArray());
                    }
                }
            }
            catch { }

            dataGridView.DataSource = dataTable;
        }
    }
}
