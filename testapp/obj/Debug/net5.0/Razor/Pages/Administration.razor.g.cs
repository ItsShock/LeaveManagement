#pragma checksum "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1408feb9a254c9860d22e449f8f191ee86c1767"
// <auto-generated/>
#pragma warning disable 1591
namespace testapp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Pjoter\source\repos\testapp\testapp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pjoter\source\repos\testapp\testapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pjoter\source\repos\testapp\testapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Pjoter\source\repos\testapp\testapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Pjoter\source\repos\testapp\testapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Pjoter\source\repos\testapp\testapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Pjoter\source\repos\testapp\testapp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Pjoter\source\repos\testapp\testapp\_Imports.razor"
using testapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Pjoter\source\repos\testapp\testapp\_Imports.razor"
using testapp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/administration")]
    public partial class Administration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Zarządzanie</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 11 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
         if (@context.User.IsInRole(ADMINISTRATION_ROLE)) 
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(3, "table");
                __builder2.AddAttribute(4, "class", "table");
                __builder2.AddMarkupContent(5, "<thead><tr><th>Id</th>\r\n                        <th>User Name</th>\r\n                        <th>Email</th></tr></thead>\r\n                ");
                __builder2.OpenElement(6, "tbody");
#nullable restore
#line 22 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                     foreach (var user in ColUsers)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(7, "tr");
                __builder2.OpenElement(8, "td");
                __builder2.AddContent(9, 
#nullable restore
#line 25 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                 user.Id.Substring(0, 5)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(10, " ...");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n                            ");
                __builder2.OpenElement(12, "td");
                __builder2.AddContent(13, 
#nullable restore
#line 26 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                 user.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                            ");
                __builder2.OpenElement(15, "td");
                __builder2.AddContent(16, 
#nullable restore
#line 27 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                 user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n                            ");
                __builder2.OpenElement(18, "td");
                __builder2.OpenElement(19, "button");
                __builder2.AddAttribute(20, "class", "btn btn-primary");
                __builder2.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                                  (() => EditUser(user))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(22, "\r\n                                    Edytuj\r\n                                    ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 35 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 39 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
             if(ShowPopup)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "modal");
                __builder2.AddAttribute(25, "tabindex", "-1");
                __builder2.AddAttribute(26, "style", "display:block");
                __builder2.AddAttribute(27, "role", "dialog");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "modal-dialog");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "modal-content");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "modal-header");
                __builder2.AddMarkupContent(34, "<h3 class=\"modal-title\">Edytuj Użytkownika</h3>\r\n                                ");
                __builder2.OpenElement(35, "button");
                __builder2.AddAttribute(36, "type", "button");
                __builder2.AddAttribute(37, "class", "close");
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                                  ClosePopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(39, "<span aria-hidden=\"true\">X</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "modal-body");
#nullable restore
#line 52 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(43, "p");
                __builder2.AddContent(44, 
#nullable restore
#line 54 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                        objUser.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 55 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(45, "p");
                __builder2.AddContent(46, 
#nullable restore
#line 58 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                        objUser.UserName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 59 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(47, "input");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "type", "text");
                __builder2.AddAttribute(50, "placeholder", "Nazwa użytkownika");
                __builder2.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                                  objUser.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.UserName = __value, objUser.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
#nullable restore
#line 65 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "type", "text");
                __builder2.AddAttribute(56, "placeholder", "Email");
                __builder2.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                              objUser.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.Email = __value, objUser.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                                ");
                __builder2.OpenElement(60, "input");
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "type", "password");
                __builder2.AddAttribute(63, "placeholder", "Hasło");
                __builder2.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                              objUser.PasswordHash

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objUser.PasswordHash = __value, objUser.PasswordHash));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                                ");
                __builder2.OpenElement(67, "select");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 73 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                                CurrentUserRole

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentUserRole = __value, CurrentUserRole));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 74 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                     foreach (var option in Options)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(71, "option");
                __builder2.AddAttribute(72, "value", 
#nullable restore
#line 76 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                                        option

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(73, 
#nullable restore
#line 77 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                             option

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 79 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                                <br><br>\r\n                                ");
                __builder2.OpenElement(75, "button");
                __builder2.AddAttribute(76, "class", "btn btn-primary");
                __builder2.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                                  SaveUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(78, "\r\n                                    Zapisz\r\n                                ");
                __builder2.CloseElement();
#nullable restore
#line 86 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                 if (objUser.Id != "")
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(79, "button");
                __builder2.AddAttribute(80, "class", "btn btn-danger");
                __builder2.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                                      DeleteUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(82, "\r\n                                        Usuń\r\n                                    ");
                __builder2.CloseElement();
#nullable restore
#line 92 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(83, "<br>\r\n                                ");
                __builder2.OpenElement(84, "span");
                __builder2.AddAttribute(85, "style", "color:red");
                __builder2.AddContent(86, 
#nullable restore
#line 94 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                                         strError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 99 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(87, "button");
                __builder2.AddAttribute(88, "class", "btn btn-success");
                __builder2.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 100 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                                                      AddNewUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(90, "Dodaj nowego użytkownika");
                __builder2.CloseElement();
#nullable restore
#line 101 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(91, "p");
                __builder2.AddMarkupContent(92, "Nie jesteś ");
                __builder2.AddContent(93, 
#nullable restore
#line 104 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
                           ADMINISTRATION_ROLE

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(94, ".");
                __builder2.CloseElement();
#nullable restore
#line 105 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.AddAttribute(95, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(96, "<p>Nie jesteś zalogowany.</p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "C:\Users\Pjoter\source\repos\testapp\testapp\Pages\Administration.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    string ADMINISTRATION_ROLE = "Adminem";
    System.Security.Claims.ClaimsPrincipal CurrentUser;
    protected override async Task OnInitializedAsync()
    {
        var RoleResult = await _RoleManager.FindByNameAsync(ADMINISTRATION_ROLE);
        if (RoleResult == null)
        {
            await _RoleManager.CreateAsync(new IdentityRole(ADMINISTRATION_ROLE));
        }

        var user = await _UserManager.FindByNameAsync("domianpiotr111@gmail.com");
        if (user != null)
        {
            var UserResult = await _UserManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
            if (!UserResult)
            {
                await _UserManager.AddToRoleAsync(user, ADMINISTRATION_ROLE);
            }
        }
        CurrentUser = (await authenticationStateTask).User;
        GetUsers();
    }

    IdentityUser objUser = new IdentityUser();
    string CurrentUserRole { get; set; } = "Users";
    List<IdentityUser> ColUsers = new List<IdentityUser>();
    List<string> Options = new List<string>() { "Users", "Managers", "Administrators" };
    string strError = "";
    bool ShowPopup = false;

    void AddNewUser()
    {
        objUser = new IdentityUser();
        objUser.PasswordHash = "*****";
        objUser.Id = "";
        ShowPopup = true;
    }
    async Task SaveUser()
    {
        try
        {
            if (objUser.Id != "")
            {
                var user = await _UserManager.FindByIdAsync(objUser.Id);
                user.Email = objUser.Email;
                await _UserManager.UpdateAsync(user);
                if (objUser.PasswordHash != "*****")
                {
                    var resetToken =
                        await _UserManager.GeneratePasswordResetTokenAsync(user);
                    var passworduser =
                        await _UserManager.ResetPasswordAsync(
                            user,
                            resetToken,
                            objUser.PasswordHash);
                    if (!passworduser.Succeeded)
                    {
                        if (passworduser.Errors.FirstOrDefault() != null)
                        {
                            strError =
                                passworduser
                                .Errors
                                .FirstOrDefault()
                                .Description;
                        }
                        else
                        {
                            strError = "Błąd z hasłem";
                        }
                        return;
                    }
                }
                var UserResult =
                    await _UserManager
                    .IsInRoleAsync(user, ADMINISTRATION_ROLE);
                if (
                    (CurrentUserRole == ADMINISTRATION_ROLE)
                    &
                    (!UserResult))
                {
                    await _UserManager
                        .AddToRoleAsync(user, ADMINISTRATION_ROLE);
                }
                else
                {
                    if ((CurrentUserRole != ADMINISTRATION_ROLE)
                        &
                        (UserResult))
                    {
                        await _UserManager
                            .RemoveFromRoleAsync(user, ADMINISTRATION_ROLE);
                    }
                }
            }
            else
            {
                var NewUser =
                    new IdentityUser
                    {
                        UserName = objUser.UserName,
                        Email = objUser.Email
                    };
                var CreateResult =
                    await _UserManager
                    .CreateAsync(NewUser, objUser.PasswordHash);
                if (!CreateResult.Succeeded)
                {
                    if (CreateResult
                        .Errors
                        .FirstOrDefault() != null)
                    {
                        strError =
                            CreateResult
                            .Errors
                            .FirstOrDefault()
                            .Description;
                    }
                    else
                    {
                        strError = "Create error";
                    }
                    return;
                }
                else
                {
                    if (CurrentUserRole == ADMINISTRATION_ROLE)
                    {
                        await _UserManager
                            .AddToRoleAsync(NewUser, ADMINISTRATION_ROLE);
                    }
                }
            }
            ShowPopup = false;
            GetUsers();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }
    async Task EditUser(IdentityUser _IdentityUser)
    {
        objUser = _IdentityUser;
        var user = await _UserManager.FindByIdAsync(objUser.Id);
        if (user != null)
        {
            var UserResult =
                await _UserManager
                .IsInRoleAsync(user, ADMINISTRATION_ROLE);
            if (UserResult)
            {
                CurrentUserRole = ADMINISTRATION_ROLE;
            }
            else
            {
                CurrentUserRole = "Users";
            }
        }
        ShowPopup = true;
    }
    async Task DeleteUser()
    {
        ShowPopup = false;
        var user = await _UserManager.FindByIdAsync(objUser.Id);
        if (user != null)
        {
            await _UserManager.DeleteAsync(user);
        }
        GetUsers();
    }
    void ClosePopup()
    {
        ShowPopup = false;
    }

    public void GetUsers()
    {
        strError = "";
        ColUsers = new List<IdentityUser>();
        var user = _UserManager.Users.Select(x => new IdentityUser
        {
            Id = x.Id,
            UserName = x.UserName,
            Email = x.Email,
            PasswordHash = "*****"
        });
        foreach (var item in user)
        {
            ColUsers.Add(item);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> _UserManager { get; set; }
    }
}
#pragma warning restore 1591
