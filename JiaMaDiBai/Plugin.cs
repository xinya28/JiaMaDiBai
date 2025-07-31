
using ClassIsland.Core.Abstractions;//给插件的基类?
using ClassIsland.Core.Attributes;//给插件的入口??
using ClassIsland.Core.Controls.CommonDialog;//日志?
using ClassIsland.Core.Extensions.Registry;//什么时候冒出来的，看不懂思密达
using Microsoft.Extensions.DependencyInjection;//看不懂思密达
using Microsoft.Extensions.Hosting;//看不懂思密达
using System.IO;//看不懂
using ClassIsland.Shared.Helpers;//看不懂
//using JiaMaDiBai.Models;
using JiaMaDiBai.Views.SettingsPages;//设置界面引用，名字好乱，别瞎改
using YamlDotNet.Serialization;//看不懂

namespace JiaMaDiBai//感觉这个名字不太好用,但是也不易重名吧
{
    [PluginEntrance]//入口在这?
    public class Plugin : PluginBase
    {
        public Settings Settings { get; set; } = new();
        
        
        public override void Initialize(HostBuilderContext context, IServiceCollection services)
        {


            /*
            Settings = ConfigureFileHelper.LoadConfig<Settings>(Path.Combine(PluginConfigFolder, "Settings.json"));  // 加载配置文件
            Settings.PropertyChanged += (sender, args) =>
            {
                ConfigureFileHelper.SaveConfig<Settings>(Path.Combine(PluginConfigFolder, "Settings.json"), Settings);  // 保存配置文件
            };
            //读取和保存配置文件
            */


            services.AddSettingsPage<MainPage>();//设置界面
            //services.AddSingleton<JiaMaDiBai_Ser>();//服务注册,没写，别急
            //sservices.AddComponent<JiaMaDiBai_Compnt>();//组件注册，没写，别急
            CommonDialog.ShowInfo("加码迪拜!!!启动成功!");
        }//插件初始化,要在这里完成相关服务的注册，不然有你好果子吃
        //public override void OnShutdown() { }
    }
}
