using Luck.Walnut.Kube.Dto.ApplicationDeployments;

namespace Luck.Walnut.Kube.Domain.AggregateRoots.ApplicationDeployments;

public class ApplicationContainer : FullEntity
{
    public ApplicationContainer(string containerName, string restartPolicy, string imagePullPolicy, bool isInitContainer, string image)
    {
        ContainerName = containerName;
        RestartPolicy = restartPolicy;
        ImagePullPolicy = imagePullPolicy;
        IsInitContainer = isInitContainer;
        Image = image;
    }

    /// <summary>
    /// 容器名称
    /// </summary>
    public string ContainerName { get; private set; }

    /// <summary>
    /// 是否初始容器
    /// </summary>
    public bool IsInitContainer { get; private set; }

    /// <summary>
    /// 镜像名称
    /// </summary>
    public string Image { get; private set; }


    /// <summary>
    /// 重启策略
    /// </summary>

    public string RestartPolicy { get; private set; }

    /// <summary>
    /// 镜像拉取策略
    /// </summary>

    public string ImagePullPolicy { get; private set; }

    /// <summary>
    /// 准备完成探针配置
    /// </summary>
    public ContainerSurviveConfiguration? ReadinessProbe { get; private set; } = default!;

    /// <summary>
    /// 存活探针配置
    /// </summary>
    public ContainerSurviveConfiguration? LiveNessProbe { get; private set; } = default!;

    /// <summary>
    /// 容器Cpu资源限制
    /// </summary>
    public ContainerResourceQuantity? Limits { get; private set; } = default!;

    /// <summary>
    /// 容器内存资源限制
    /// </summary>
    public ContainerResourceQuantity? Requests { get; private set; } = default!;

    /// <summary>
    /// 环境变量
    /// </summary>
    public EnvironmentConfiguration? Environments { get; private set; } = default!;

    /// <summary>
    /// 容器端口配置
    /// </summary>
    public ICollection<ContainerPortConfiguration> ContainerPortConfigurations { get; private set; } = new HashSet<ContainerPortConfiguration>();


    /// <summary>
    /// 
    /// </summary>
    public ApplicationDeployment ApplicationDeployment { get; private set; } = default!;


    public string ApplicationDeploymentId { get; private set; } = default!;


    public ApplicationContainer Update(ApplicationContainerInputDto input)
    {
        ContainerName = input.ContainerName;
        RestartPolicy = input.RestartPolicy;
        ImagePullPolicy = input.ImagePullPolicy;
        IsInitContainer = input.IsInitContainer;
        Image = input.Image;
        return this;
    }

    public ApplicationContainer SetReadinessProbe()
    {
        return this;
    }

    public ApplicationContainer SetLiveNessProbe()
    {
        return this;
    }

    public ApplicationContainer SetLimits()
    {
        return this;
    }

    public ApplicationContainer SetRequests()
    {
        return this;
    }

    public ApplicationContainer SetEnvironments()
    {
        return this;
    }

    public ApplicationContainer SetContainerPortConfigurations()
    {
        return this;
    }
}