using MergeTowerDefence.Core.Services.BoardSpawn;
using MergeTowerDefence.Core.Services.BoardSpawn.Implementation;
using MergeTowerDefence.Core.Services.LevelSetUp;
using MergeTowerDefence.Core.Services.LevelSetUp.Implementation;
using MergeTowerDefence.Core.Services.TilesSpawn;
using MergeTowerDefence.Core.Services.TilesSpawn.Implementation;
using VContainer;
using VContainer.Unity;

namespace MergeTowerDefence.Scopes.Core
{
    public class CoreServicesLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            RegisterBoardSpawnService(builder);
            
            RegisterTilesSpawnService(builder);
            
            RegisterLevelSetupService(builder);
        }

        /*
         * Level 
         */
        
        private void RegisterLevelSetupService(IContainerBuilder builder)
        {
            builder
                .Register<ILevelSetUpService, LevelSetUpService>
                    (Lifetime.Singleton);
        }
        
        /*
         *  Board
         */
        
        private void RegisterBoardSpawnService(IContainerBuilder builder)
        {
            builder
                .Register<IBoardSpawnService, BoardSpawnService>
                    (Lifetime.Singleton);
        }
        
        private void RegisterTilesSpawnService(IContainerBuilder builder)
        {
            builder
                .Register<ITilesSpawnService, TilesSpawnService>
                    (Lifetime.Singleton);
        }
    }
}