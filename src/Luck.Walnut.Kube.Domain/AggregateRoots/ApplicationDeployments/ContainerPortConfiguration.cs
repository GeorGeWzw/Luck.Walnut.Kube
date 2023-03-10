namespace Luck.Walnut.Kube.Domain.AggregateRoots.ApplicationDeployments;

/// <summary>
/// 容器端口配置
/// </summary>
public class ContainerPortConfiguration
{
    public ContainerPortConfiguration(string name, uint containerPort, string protocol)
    {
        Name = name;
        ContainerPort = containerPort;
        Protocol = protocol;
    }

    /// <summary>
    /// 端口名称
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// 容器端口
    /// </summary>
    public uint ContainerPort { get; private set; }

    /// <summary>
    /// 端口协议
    /// </summary>
    public string Protocol { get; private set; }
}