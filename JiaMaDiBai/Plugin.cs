
using ClassIsland.Core.Abstractions;//给插件的基类?
using ClassIsland.Core.Attributes;//给插件的入口??
using ClassIsland.Core.Controls.CommonDialog;//日志?
using ClassIsland.Core.Extensions.Registry;
using Microsoft.Extensions.DependencyInjection;//看不懂思密达
using Microsoft.Extensions.Hosting;//看不懂思密达

namespace JiaMaDiBai//感觉这个名字不太好用,但是也不易重名吧
{
    [PluginEntrance]//入口在这?
    public class Plugin : PluginBase
    {
        public override void Initialize(HostBuilderContext context, IServiceCollection services)
        {
            CommonDialog.ShowInfo("加码迪拜!!!启动成功!");
            //services.AddSettingsPage<JiaMaDiBaiSettingPage>();//设置界面还没写，别急
        }//插件初始化,要在这里完成相关服务的注册，不然有你好果子吃
    }
}
