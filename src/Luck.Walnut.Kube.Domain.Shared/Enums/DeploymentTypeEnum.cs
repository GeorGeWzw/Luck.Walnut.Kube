namespace Luck.Walnut.Kube.Domain.Shared.Enums;

public enum DeploymentTypeEnum
{
    /// <summary>
    /// Deployment
    /// </summary>
    Pod = 0,

    /// <summary>
    /// Deployment
    /// </summary>
    Deployment = 1,

    /// <summary>
    /// DaemonSet
    /// </summary>
    DaemonSet = 2,

    /// <summary>
    /// StatefulSet
    /// </summary>
    StatefulSet = 3,

    /// <summary>
    /// ReplicaSet
    /// </summary>
    ReplicaSet = 4,

    /// <summary>
    /// Job
    /// </summary>
    Job = 5,

    /// <summary>
    /// CronJob
    /// </summary>
    CronJob = 5,
}