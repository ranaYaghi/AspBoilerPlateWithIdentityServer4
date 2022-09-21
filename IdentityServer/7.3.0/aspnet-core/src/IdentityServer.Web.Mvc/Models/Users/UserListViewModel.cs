using System.Collections.Generic;
using IdentityServer.Roles.Dto;

namespace IdentityServer.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
