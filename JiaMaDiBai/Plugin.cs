
using ClassIsland.Core.Abstractions;//������Ļ���?
using ClassIsland.Core.Attributes;//����������??
using ClassIsland.Core.Controls.CommonDialog;//��־?
using ClassIsland.Core.Extensions.Registry;
using Microsoft.Extensions.DependencyInjection;//������˼�ܴ�
using Microsoft.Extensions.Hosting;//������˼�ܴ�

namespace JiaMaDiBai//�о�������ֲ�̫����,����Ҳ����������
{
    [PluginEntrance]//�������?
    public class Plugin : PluginBase
    {
        public override void Initialize(HostBuilderContext context, IServiceCollection services)
        {
            CommonDialog.ShowInfo("����ϰ�!!!�����ɹ�!");
            //services.AddSettingsPage<JiaMaDiBaiSettingPage>();//���ý��滹ûд����
        }//�����ʼ��,Ҫ�����������ط����ע�ᣬ��Ȼ����ù��ӳ�
    }
}
