using ClassIsland.Core.Abstractions.Controls;
using ClassIsland.Core.Attributes;
using ClassIsland.Core.Enums.SettingsWindow;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JiaMaDiBai.Views.SettingsPages;

/// <summary>
/// SettingsPage1.xaml 的交互逻辑
/// </summary>

[SettingsPageInfo(
    "JMDB.MainPage",
    "加码迪拜的主设置页面",
    PackIconKind.CogOutline,
    PackIconKind.Cog,
    SettingsPageCategory.External
)]
public partial class MainPage : SettingsPageBase
{
    public MainPage()
    {
        InitializeComponent();
    }
}
