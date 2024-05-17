using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSU_PMS
{
    public class ListViewFunctions
    {
        public static bool IsValueExists(ListView listView, string val)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if (item.SubItems[0].ToString() == val)
                {
                    return true;
                }
            }
            return false;
        }

        public static decimal CalculateColumnSum(ListView listView, int columnIndex)
        {
            if (listView == null || listView.Items.Count == 0)
                return 0;

            if (listView.DataBindings.Count > 0)
            {
                return listView.Items
                    .Cast<ListViewItem>()
                    .Sum(item => decimal.Parse(item.SubItems[columnIndex].Text));
            }
            else
            {
                decimal sum = 0;
                foreach (ListViewItem item in listView.Items)
                {
                    decimal value;
                    if (decimal.TryParse(item.SubItems[columnIndex].Text, out value))
                    {
                        sum += value;
                    }
                }
                return sum;
            }
        }
    }
}
