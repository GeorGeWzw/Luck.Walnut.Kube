

using Luck.Walnut.Kube.Dto.ApplicationDeployments;
using Luck.Walnut.Kube.Dto;

namespace Luck.Walnut.Kube.Query.DeploymentConfigurations;

public interface IDeploymentConfigurationQueryService:IScopedDependency
{

    /// <summary>
    /// ��ҳ��ѯ��������
    /// </summary>
    /// <param name="appId"></param>
    /// <param name="query"></param>
    /// <returns></returns>
    Task<PageBaseResult<DeploymentConfigurationOutputDto>> GetDeploymentConfigurationPageListAsync(string appId, DeploymentConfigurationQueryDto query);


    Task<DeploymentConfigurationOutputDto?> GetApplicationDeploymentDetailByIdAsync(string id);
}