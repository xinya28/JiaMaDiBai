
using ClassIsland.Core.Abstractions;//������Ļ���?
using ClassIsland.Core.Attributes;//����������??
using ClassIsland.Core.Controls.CommonDialog;//��־?
using ClassIsland.Core.Extensions.Registry;//ʲôʱ��ð�����ģ�������˼�ܴ�
using Microsoft.Extensions.DependencyInjection;//������˼�ܴ�
using Microsoft.Extensions.Hosting;//������˼�ܴ�

namespace JiaMaDiBai//�о�������ֲ�̫����,����Ҳ����������
{
    [PluginEntrance]//�������?
    public class Plugin : PluginBase
    {
        public override void Initialize(HostBuilderContext context, IServiceCollection services)
        {
            //services.AddSettingsPage<JiaMaDiBaiSettingPage>();//���ý��滹ûд����
            //services.AddSingleton<JiaMaDiBai_Ser>();//����ע��,ûд����
            //sservices.AddComponent<JiaMaDiBai_Compnt>();//���ע�ᣬûд����
            CommonDialog.ShowInfo("����ϰ�!!!�����ɹ�!");
        }//�����ʼ��,Ҫ�����������ط����ע�ᣬ��Ȼ����ù��ӳ�
    }
}
