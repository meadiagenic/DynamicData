using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicData
{
    public interface IDynamicTable
    {
        Query Paged(int pageSize = 20, int currentPage = 1);
    }
}
