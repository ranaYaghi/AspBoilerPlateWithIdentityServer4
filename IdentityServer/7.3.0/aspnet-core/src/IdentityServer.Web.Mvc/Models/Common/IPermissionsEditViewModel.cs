using System.Collections.Generic;
using IdentityServer.Roles.Dto;

namespace IdentityServer.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}