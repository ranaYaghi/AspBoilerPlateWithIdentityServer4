using System.Collections.Generic;
using IdentityServer.Roles.Dto;

namespace IdentityServer.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
