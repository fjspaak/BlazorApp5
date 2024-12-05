using BlazorApp5.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp5.Authorization;

public class UserInDatabaseHandler : AuthorizationHandler<UserInDatabaseRequirement>
{
    private readonly DwhNlPortalContext _dbContext;
    private readonly AuthenticationStateProvider _authenticationStateProvider;



    public UserInDatabaseHandler(DwhNlPortalContext dbContext, AuthenticationStateProvider authenticationStateProvider)
    {
        _dbContext = dbContext;
        _authenticationStateProvider = authenticationStateProvider;
    }



    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, UserInDatabaseRequirement requirement)
    {


        //var httpContext = _httpContextAccessor.HttpContext;

        //if (httpContext == null || httpContext.User == null || !httpContext.User.Identity?.IsAuthenticated == true)
        //{
        //    context.Fail();
        //    return;
        //}

        //var windowsUserName = httpContext.User.Identity.Name;

        //if (string.IsNullOrEmpty(windowsUserName))
        //{
        //    context.Fail();
        //    return;
        //}

        //var userName = windowsUserName.Contains("\\") ? windowsUserName.Split('\\')[1] : windowsUserName;

        //var userExists = await _dbContext.Users
        //    .AnyAsync(u => u.LoginName == windowsUserName || u.LoginName == userName);


        //TRY 2
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        //var loginName = user.Identity?.Name?.Split('\\').LastOrDefault() ?? string.Empty;

        var loginName = "fjspa2";

        var dbUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.LoginName == loginName);

        var userExists = dbUser != null;

        if (userExists)
        {
            context.Succeed(requirement);
        }
        else
        {
            context.Fail();
        }
    }
}
