# OpcUaHelper ![Build status](https://ci.appveyor.com/api/projects/status/oajkgccisoe98gip?svg=true) [![NuGet Status](https://img.shields.io/nuget/v/OpcUaHelper.svg)](https://www.nuget.org/packages/OpcUaHelper/) [![Gitter](https://badges.gitter.im/Join%20Chat.svg)](http://shang.qq.com/wpa/qunwpa?idkey=2278cb9c2e0c04fc305c43e41acff940499a34007dfca9e83a7291e726f9c4e8)

## 版权声明
本组件版权归Richard.Hu所有
## 授权协议
使用请遵循LGPL-3.0协议说明，除了协议中已经规定的内容外，附加下面三个条款（与原协议如有冲突以附加条款为准）：

* 允许用户使用本工具库（从NuGet下载）集成到自己的项目中作为闭源软件一部分，只需要声明版权出处并出具一份LGPL-3.0的授权协议即可。
* 源代码仅作为个人学习使用。

## NuGet安装
说明：NuGet为稳定版本，组件的使用必须从NuGet下载，此处发布的项目有可能为还没有通过编译的测试版，NuGet安装如下：

Install-Package OpcUaHelper

## 联系作者
* 技术支持QQ群：[592132877](http://shang.qq.com/wpa/qunwpa?idkey=2278cb9c2e0c04fc305c43e41acff940499a34007dfca9e83a7291e726f9c4e8)
* 邮箱地址：hsl200909@163.com

## 项目目标
本项目的目标在于开发一个.Net下大多数软件系统都会包含了基础类库功能，实现一些常用的数据通信，日志记录等等类，以及版本类。

## 项目介绍
[http://www.cnblogs.com/dathlin/p/7724834.html](http://www.cnblogs.com/dathlin/p/7724834.html)

## 示例代码
详细的操作参见项目介绍里的博客地址，此处列举两个读写操作：
<pre>
<code>
private void button2_Click(object sender, EventArgs e)
{
    // 一个读取的操作
    try
    {
        string value = opcUaClient.ReadNode<string>("ns=2;s=Machines/Machine A/Name");
        MessageBox.Show(value); // 显示测试数据
    }
    catch(Exception ex)
    {
        // 使用了opc ua的错误处理机制来处理错误，网络不通或是读取拒绝
        Opc.Ua.Client.Controls.ClientUtils.HandleException(Text, ex);
    }
}
private void button3_Click(object sender, EventArgs e)
{
    // 一个写入的操作
    try
    {
        bool IsSuccess = opcUaClient.WriteNode("ns=2;s=Machines/Machine B/Name","abcd测试写入啊");
        MessageBox.Show(IsSuccess.ToString()); // 显示True，如果成功的话
    }
    catch(Exception ex)
    {
        // 使用了opc ua的错误处理机制来处理错误，网络不通或是读取拒绝
        Opc.Ua.Client.Controls.ClientUtils.HandleException(Text, ex);
    }
}
</code>
</pre>

## 免责声明
引用的4个组件分别为

* Opc.Ua.Client.dll
* Opc.Ua.ClientControls.dll
* Opc.Ua.Configuration.dll
* Opc.Ua.Core.dll

OPC-UA相关的组件版权归OPC Foundation所有，在使用本组件前请确认是否遵循OPC Foundation的规章要求。组件来源地址：[https://github.com/OPCFoundation/UA-.NET](https://github.com/OPCFoundation/UA-.NET)

本组件订阅功能和异步读写功能的部分代码参考了下面的项目，对作者表示感谢：
[https://github.com/hylasoft-usa/h-opc](https://github.com/hylasoft-usa/h-opc)

## 代码贡献
热烈欢迎对本项目的代码提出改进意见，可以发起Pull Request，对于代码量贡献较多的小伙伴，会有额外的组件使用权，并在特别感谢里写明。

## 特别感谢
* 无
