> Notice: **This repository** contains **exploratory** work and is not intended to be a maintained project or finished product. It is **not open** for contributions and will probably be **deleted** at some point.

# scaffold-identity-cli

Explore scaffolding for identity using the dotnet CLI on Linux.

---

(2022-11-10)

- [Install .NET on Ubuntu - .NET | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/core/install/linux-ubuntu#2004)

- [Scaffold Identity in ASP.NET Core projects | Microsoft Learn](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/scaffold-identity?view=aspnetcore-7.0&amp;tabs=netcore-cli)


Install the **dotnet-aspnet-codegenerator** tool and required packages.

    dotnet tool install -g dotnet-aspnet-codegenerator

*The above command **failed** because the current version of the tool is for .NET version 7x and the installed SDK is 6x.*

Specify versions to install.

    dotnet tool install --global dotnet-aspnet-codegenerator --version 6.0.10

    dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.11

    dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 6.0.11

    dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 6.0.10

    dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 6.0.11

    dotnet add package Microsoft.AspNetCore.Identity.UI --version 6.0.11

    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.11

List available **aspnet-codegenerator** commands for scaffolding identity.

    dotnet aspnet-codegenerator identity -h

List available **identity** templates.

    dotnet aspnet-codegenerator identity --listFiles
    
>   Building project ...
    Finding the generator 'identity'...
    Running the generator 'identity'...
    File List:
    Account._StatusMessage
    Account.AccessDenied
    Account.ConfirmEmail
    Account.ConfirmEmailChange
    Account.ExternalLogin
    Account.ForgotPassword
    Account.ForgotPasswordConfirmation
    Account.Lockout
    Account.Login
    Account.LoginWith2fa
    Account.LoginWithRecoveryCode
    Account.Logout
    Account.Manage._Layout
    Account.Manage._ManageNav
    Account.Manage._StatusMessage
    Account.Manage.ChangePassword
    Account.Manage.DeletePersonalData
    Account.Manage.Disable2fa
    Account.Manage.DownloadPersonalData
    Account.Manage.Email
    Account.Manage.EnableAuthenticator
    Account.Manage.ExternalLogins
    Account.Manage.GenerateRecoveryCodes
    Account.Manage.Index
    Account.Manage.PersonalData
    Account.Manage.ResetAuthenticator
    Account.Manage.SetPassword
    Account.Manage.ShowRecoveryCodes
    Account.Manage.TwoFactorAuthentication
    Account.Register
    Account.RegisterConfirmation
    Account.ResendEmailConfirmation
    Account.ResetPassword
    Account.ResetPasswordConfirmation

---

A SQLite database file is created by applying the EF migrations.

    dotnet ef migrations add Initial-migration
    dotnet ef database update

You can use the [Command Line Shell For SQLite](https://www.sqlite.org/cli.html) to export the schema of the database.

```bash
sqlite3 "${DATABASE}" .schema > "${TEXTFILE}"
```

---

## Additional Links

[dotnet tool install command - .NET CLI | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-tool-install?source=recommendations)

[.NET tools - .NET CLI | Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/core/tools/global-tools)

[NuGet Gallery | Microsoft.EntityFrameworkCore.Sqlite 7.0.0](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite)

[NuGet Gallery | Microsoft.VisualStudio.Web.CodeGeneration.Design 6.0.10](https://www.nuget.org/packages/Microsoft.VisualStudio.Web.CodeGeneration.Design/6.0.10)

[NuGet Gallery | Microsoft.AspNetCore.Identity.EntityFrameworkCore 6.0.11](https://www.nuget.org/packages/Microsoft.AspNetCore.Identity.EntityFrameworkCore/6.0.11)

[NuGet Gallery | Microsoft.AspNetCore.Identity.UI 6.0.11](https://www.nuget.org/packages/Microsoft.AspNetCore.Identity.UI/6.0.11)

[NuGet Gallery | Microsoft.EntityFrameworkCore.Tools 6.0.11](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools/6.0.11)

[NuGet Gallery | Microsoft.EntityFrameworkCore.Design 6.0.11](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/6.0.11)

[NuGet Gallery | Microsoft.EntityFrameworkCore.Sqlite 6.0.11](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/6.0.11)

[NuGet Gallery | dotnet-aspnet-codegenerator 6.0.10](https://www.nuget.org/packages/dotnet-aspnet-codegenerator/6.0.10)
