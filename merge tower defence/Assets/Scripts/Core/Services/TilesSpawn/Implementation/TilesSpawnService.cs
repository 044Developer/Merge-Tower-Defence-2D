using System;
using MergeTowerDefence.Core.Arena.View;
using MergeTowerDefence.Core.Cells.View;
using UnityEngine;

namespace MergeTowerDefence.Core.Services.TilesSpawn.Implementation
{
    public class TilesSpawnService : ITilesSpawnService
    {
        private readonly Func<Transform, BuildingCellView> _buildCellFactory = null;
        private readonly Func<Transform, WaypointCellView> _wayPointCellFactory = null;
        private readonly Func<Transform, StartCellView> _startCellFactory = null;
        private readonly Func<Transform, FinishCellView> _finishCellFactory = null;
        private readonly Func<Transform, RegularCellView> _regularCellFactory = null;
        private readonly IArenaView _arenaView = null;

        public TilesSpawnService(
            Func<Transform, BuildingCellView> buildCellFactory, 
            Func<Transform, WaypointCellView> wayPointCellFactory,
            Func<Transform, StartCellView> startCellFactory,
            Func<Transform, FinishCellView> finishCellFactory,
            Func<Transform, RegularCellView> regularCellFactory,
            IArenaView arenaView
            )
        {
            _buildCellFactory = buildCellFactory;
            _wayPointCellFactory = wayPointCellFactory;
            _startCellFactory = startCellFactory;
            _finishCellFactory = finishCellFactory;
            _regularCellFactory = regularCellFactory;
            _arenaView = arenaView;
        }

        private void SpawnBuildCell(Vector2Int position)
        {
            BuildingCellView buildCell = _buildCellFactory.Invoke(_arenaView.BuildCellRoot);

            buildCell.CellModel.CellPosition = position;
            
            _arenaView.AddNewCell(buildCell);
        }

        private void SpawnWayPointCell(Vector2Int position)
        {
            WaypointCellView waypointCell = _wayPointCellFactory.Invoke(_arenaView.WayPointCellRoot);

            waypointCell.CellModel.CellPosition = position;
            
            _arenaView.AddNewCell(waypointCell);
        }

        private void SpawnStartCell(Vector2Int position)
        {
            StartCellView startCell = _startCellFactory.Invoke(_arenaView.WayPointCellRoot);

            startCell.CellModel.CellPosition = position;
            
            _arenaView.AddNewCell(startCell);
        }

        private void SpawnFinishCell(Vector2Int position)
        {
            FinishCellView finishCell = _finishCellFactory.Invoke(_arenaView.WayPointCellRoot);

            finishCell.CellModel.CellPosition = position;
            
            _arenaView.AddNewCell(finishCell);
        }

        private void SpawnRegularCell(Vector2Int position)
        {
            RegularCellView regularCell = _regularCellFactory.Invoke(_arenaView.RegularCellRoot);

            regularCell.CellModel.CellPosition = position;
            
            _arenaView.AddNewCell(regularCell);
        }
    }
}