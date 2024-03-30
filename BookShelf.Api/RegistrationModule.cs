using Autofac;
using BookShelf.Api.Security;

namespace BookShelf.Api;

public sealed class RegistrationModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);

        builder.RegisterType<LoginService>().As<ILoginService>().InstancePerLifetimeScope();
    }
}