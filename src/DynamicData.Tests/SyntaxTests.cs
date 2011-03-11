using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DynamicData.Tests
{
    [TestFixture]
    public class SyntaxTests
    {
        [Test]
        public void Paged_IsValid_Method_OnTable()
        {
            IDynamicTable table = new DynamicTable("Users");

            var query = table.Paged(pageSize: 20, currentPage: 1);

            Assert.IsNotNull(query);
            Assert.AreEqual(query.PageSize, 20);
            Assert.AreEqual(query.CurrentPage, 1);
        }

        [Test]
        public void Find_Each_Accepts_Action_Argument()
        {
            var table = new DynamicTable("Users");

            var result = table.FindEach(x =>
            {

            });
        }
    }
}
