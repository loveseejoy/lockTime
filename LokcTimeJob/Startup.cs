using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;
using Hangfire.MemoryStorage;
using LockTime.Service;

[assembly: OwinStartup(typeof(LokcTimeJob.Startup))]

namespace LokcTimeJob
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //指定Hangfire使用内存存储后台任务信息
            GlobalConfiguration.Configuration.UseMemoryStorage();
            //启用HangfireServer这个中间件（它会自动释放）
            app.UseHangfireServer();
            //启用Hangfire的仪表盘（可以看到任务的状态，进度等信息）
            app.UseHangfireDashboard();


            RecurringJob.AddOrUpdate(() => JobService.LockTimeForRest(), "00 */2 * * *", TimeZoneInfo.Local);
            RecurringJob.AddOrUpdate(() => JobService.LockTimeForTeaMoring(), "30 09 * * *", TimeZoneInfo.Local);
            RecurringJob.AddOrUpdate(() => JobService.LockTimeForTeaAfternoon(), "00 13 * * *", TimeZoneInfo.Local);
            RecurringJob.AddOrUpdate(() => JobService.LockTimeForTeaEving(), "00 19 * * *",TimeZoneInfo.Local);
        }
    }
}
