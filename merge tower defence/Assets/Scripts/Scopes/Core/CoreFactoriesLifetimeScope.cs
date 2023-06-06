using MergeTowerDefence.Core.Arena.Model;
using MergeTowerDefence.Core.Cells.Model;
using MergeTowerDefence.Core.Cells.View;
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
            RegisterModels(builder);
            
            RegisterArena(builder);
            
            RegisterFactories(builder);
        }

        private void RegisterModels(IContainerBuilder builder)
        {
            builder.Register<IArenaModel, ArenaModel>(Lifetime.Singleton);

            builder.Register<ICellModel, CellModel>(Lifetime.Transient);
        }

        private void RegisterFactories(IContainerBuilder builder)
        {
            RegisterBuildingCellFactory(builder);
            
            RegisterWaypointCellFactory(builder);
            
            RegisterStartCellFactory(builder);
            
            RegisterFinishCellFactory(builder);
            
            RegisterRegularCellFactory(builder);
        }
        
        /*
         *  Arena
         */
        
        private void RegisterArena(IContainerBuilder builder)
        {
            builder.RegisterComponentInNewPrefab(_coreScenePrefabContainer.ArenaPrefab, Lifetime.Singleton);
        }
        
        /*
         *  Cells
         */

        private void RegisterBuildingCellFactory(IContainerBuilder builder)
        {
            builder.RegisterFactory<Transform, BuildingCellView>(container =>
            {
                return parent =>
                {
                    BuildingCellView buildingCell = container.Instantiate(_coreScenePrefabContainer.BuildingCell, parent);

                    return buildingCell;
                };
            }, Lifetime.Singleton);
        }

        private void RegisterWaypointCellFactory(IContainerBuilder builder)
        {
            builder.RegisterFactory<Transform, WaypointCellView>(container =>
            {
                return parent =>
                {
                    WaypointCellView waypointCell = container.Instantiate(_coreScenePrefabContainer.WayPointCell, parent);

                    return waypointCell;
                };
            }, Lifetime.Singleton);
        }

        private void RegisterStartCellFactory(IContainerBuilder builder)
        {
            builder.RegisterFactory<Transform, StartCellView>(container =>
            {
                return parent =>
                {
                    StartCellView startCell = container.Instantiate(_coreScenePrefabContainer.StartCell, parent);

                    return startCell;
                };
            }, Lifetime.Singleton);
        }

        private void RegisterFinishCellFactory(IContainerBuilder builder)
        {
            builder.RegisterFactory<Transform, FinishCellView>(container =>
            {
                return parent =>
                {
                    FinishCellView finishCell = container.Instantiate(_coreScenePrefabContainer.FinishCell, parent);

                    return finishCell;
                };
            }, Lifetime.Singleton);
        }

        private void RegisterRegularCellFactory(IContainerBuilder builder)
        {
            builder.RegisterFactory<Transform, RegularCellView>(container =>
            {
                return parent =>
                {
                    RegularCellView regularCell = container.Instantiate(_coreScenePrefabContainer.RegularCell, parent);

                    return regularCell;
                };
            }, Lifetime.Singleton);
        }
    }
}
