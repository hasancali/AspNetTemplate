using System;
using System.Threading.Tasks;
using Abp.TestBase;
using AspNetTemplate.EntityFrameworkCore;
using AspNetTemplate.Tests.TestDatas;

namespace AspNetTemplate.Tests
{
    public class AspNetTemplateTestBase : AbpIntegratedTestBase<AspNetTemplateTestModule>
    {
        public AspNetTemplateTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<AspNetTemplateDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<AspNetTemplateDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<AspNetTemplateDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<AspNetTemplateDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<AspNetTemplateDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<AspNetTemplateDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<AspNetTemplateDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<AspNetTemplateDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
