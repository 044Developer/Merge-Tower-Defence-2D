using MergeTowerDefence.Core.Arena.Model;
using MergeTowerDefence.Core.Arena.View;
using MergeTowerDefence.Infrastructure.MonoComponents.PrefabContainers;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace MergeTowerDefence.Scopes.Core
{
    public class CoreFactoriesLifetimeScope : LifetimeScope
    {
        [SerializeField] private CoreScenePrefabContainer _coreScenePrefabContainer = null;
        
        protected override void Configure(IContainerBuilder builder)
        {
            RegisterArenaFactory(builder);
        }
        
        /*
         *  Arena
         */
        
        private void RegisterArenaFactory(IContainerBuilder builder)
        {
            builder.Register<IArenaModel, ArenaModel>(Lifetime.Singleton);

            builder.RegisterFactory<IArenaView>(container =>
            {
                return () =>
                {
                    IArenaView arena = container.Instantiate(_coreScenePrefabContainer.ArenaPrefab);

                    return arena;
                };
            }, Lifetime.Singleton);
        }
    }
}
