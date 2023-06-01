using MergeTowerDefence.Infrastructure.Modules.CustomLogger;
using MergeTowerDefence.Infrastructure.Modules.CustomLogger.Implementation;
using MergeTowerDefence.Infrastructure.Modules.CustomScreen;
using MergeTowerDefence.Infrastructure.Modules.CustomScreen.Implementation;
using VContainer;
using VContainer.Unity;

namespace MergeTowerDefence.Scopes.Project
{
    public class ProjectRootLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            RegisterCustomLoggerModule(builder);
            RegisterCustomScreenModule(builder);
        }

        /*
         *  Modules
         */

        private void RegisterCustomLoggerModule(IContainerBuilder builder)
        {
            builder
                .Register<ICustomLoggerModule, CustomLoggerModule>
                (Lifetime.Singleton);
        }

        private void RegisterCustomScreenModule(IContainerBuilder builder)
        {
            builder
                .Register<ICustomScreenModule, CustomScreenModule>
                    (Lifetime.Singleton);
        }
    }
}