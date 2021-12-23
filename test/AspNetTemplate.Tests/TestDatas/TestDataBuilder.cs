using AspNetTemplate.EntityFrameworkCore;

namespace AspNetTemplate.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly AspNetTemplateDbContext _context;

        public TestDataBuilder(AspNetTemplateDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}