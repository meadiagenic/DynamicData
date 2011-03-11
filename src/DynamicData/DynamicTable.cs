using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicData
{
    public class DynamicTable : IDynamicTable
    {
        public DynamicTable(string name)
        {
        }

        public string Name { get; set; }



        public Query Paged(int pageSize = 20, int currentPage = 1)
        {
            return new Query
        }
    }
}
