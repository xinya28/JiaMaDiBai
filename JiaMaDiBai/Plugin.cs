
using ClassIsland.Core.Abstractions;//������Ļ���?
using ClassIsland.Core.Attributes;//����������??
using ClassIsland.Core.Controls.CommonDialog;//��־?
using ClassIsland.Core.Extensions.Registry;//ʲôʱ��ð�����ģ�������˼�ܴ�
using Microsoft.Extensions.DependencyInjection;//������˼�ܴ�
using Microsoft.Extensions.Hosting;//������˼�ܴ�
using System.IO;//������
using ClassIsland.Shared.Helpers;//������
//using JiaMaDiBai.Models;
using JiaMaDiBai.Views.SettingsPages;//���ý������ã����ֺ��ң���Ϲ��
using YamlDotNet.Serialization;//������

namespace JiaMaDiBai//�о�������ֲ�̫����,����Ҳ����������
{
    [PluginEntrance]//�������?
    public class Plugin : PluginBase
    {
        public Settings Settings { get; set; } = new();
        
        
        public override void Initialize(HostBuilderContext context, IServiceCollection services)
        {


            /*
            Settings = ConfigureFileHelper.LoadConfig<Settings>(Path.Combine(PluginConfigFolder, "Settings.json"));  // ���������ļ�
            Settings.PropertyChanged += (sender, args) =>
            {
                ConfigureFileHelper.SaveConfig<Settings>(Path.Combine(PluginConfigFolder, "Settings.json"), Settings);  // ���������ļ�
            };
            //��ȡ�ͱ��������ļ�
            */


            services.AddSettingsPage<MainPage>();//���ý���
            //services.AddSingleton<JiaMaDiBai_Ser>();//����ע��,ûд����
            //sservices.AddComponent<JiaMaDiBai_Compnt>();//���ע�ᣬûд����
            CommonDialog.ShowInfo("����ϰ�!!!�����ɹ�!");
        }//�����ʼ��,Ҫ�����������ط����ע�ᣬ��Ȼ����ù��ӳ�
        //public override void OnShutdown() { }
    }
}
