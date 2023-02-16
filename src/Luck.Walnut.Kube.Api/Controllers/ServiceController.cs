using Luck.Walnut.Kube.Application.NameSpaces;
using Luck.Walnut.Kube.Application.Services;
using Luck.Walnut.Kube.Dto.NameSpaces;
using Luck.Walnut.Kube.Dto.Services;
using Microsoft.AspNetCore.Mvc;

namespace Luck.Walnut.Kube.Api.Controllers;

/// <summary>
/// 命名空间管理
/// </summary>
[Route("api/services")]
public class ServiceController : BaseController
{
    /// <summary>
    /// 添加服务
    /// </summary>
    /// <param name="serviceApplication"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPost]
    public Task CreateService([FromServices] IServiceApplication serviceApplication, [FromBody] ServiceInputDto input)
        => serviceApplication.CreateServiceAsync(input);


    /// <summary>
    /// 修改服务
    /// </summary>
    /// <param name="serviceApplication"></param>
    /// <param name="id"></param>
    /// <param name="input"></param>
    /// <returns></returns>
    [HttpPut("{id}")]
    public Task UpdateService([FromServices] IServiceApplication serviceApplication, string id, [FromBody] ServiceInputDto input)
        => serviceApplication.UpdateServiceAsync(id, input);
    
    /// <summary>
    /// 发布服务
    /// </summary>
    /// <param name="serviceApplication"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpPut("{id}/publish")]
    public Task PublishService([FromServices] IServiceApplication serviceApplication, string id)
        => serviceApplication.PublishServiceAsync(id);


    /// <summary>
    /// 删除服务
    /// </summary>
    /// <param name="serviceApplication"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("{id}")]
    public Task DeleteService([FromServices] IServiceApplication serviceApplication, string id)
        => serviceApplication.DeleteServiceAsync(id);
    
    /// <summary>
    /// 删除服务
    /// </summary>
    /// <param name="serviceApplication"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpPut("{id}/off/publish")]
    public Task OffPublishService([FromServices] IServiceApplication serviceApplication, string id)
        => serviceApplication.OffPublishServiceAsync(id);
}