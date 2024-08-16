using Autofac;
using BookShelf.Api.Security;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;

namespace BookShelf.Api;

public sealed class RegistrationModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        builder.RegisterType<LoginService>().As<ILoginService>().InstancePerLifetimeScope();
        builder.RegisterType<JwtTokenValidationProperties>().As<IJwtTokenValidationProperties>().SingleInstance();
        builder.RegisterType<JwtTokenGenerator>().As<IJwtTokenGenerator>().SingleInstance();
        builder.RegisterType<JwtBearerOptionsInitializer>().As<IPostConfigureOptions<JwtBearerOptions>>()
            .SingleInstance();
    }
}