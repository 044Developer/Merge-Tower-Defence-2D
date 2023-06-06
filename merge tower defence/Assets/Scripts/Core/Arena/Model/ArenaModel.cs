using System.Collections.Generic;
using MergeTowerDefence.Core.Cells.View;

namespace MergeTowerDefence.Core.Arena.Model
{
    public sealed class ArenaModel : IArenaModel
    {
        private List<ICellView> _allTiles = new();
        private List<WaypointCellView> _wayPointTiles = new();
        private List<BuildingCellView> _buildingTiles = new();
        
        public StartCellView SpawnTile { get; private set; }
        public FinishCellView FinishTile { get; private set; }
        public IEnumerable<ICellView> AllTiles => _allTiles;
        public IEnumerable<WaypointCellView> WayPointTiles => _wayPointTiles;
        public IEnumerable<BuildingCellView> BuildingTiles => _buildingTiles;
        
        public void RegisterSpawnTile(ICellView spawnTile)
        {
            SpawnTile = spawnTile as StartCellView;
            _allTiles.Add(spawnTile);
        }

        public void RegisterFinishTile(ICellView finishTile)
        {
            FinishTile = finishTile as FinishCellView;
            _allTiles.Add(finishTile);
        }

        public void RegisterRegularTile(ICellView regularTile)
        {
            _allTiles.Add(regularTile);
        }

        public void RegisterBuildingTile(ICellView buildingTile)
        {
            _allTiles.Add(buildingTile);
            _buildingTiles.Add(buildingTile as BuildingCellView);
        }

        public void RegisterWayPointTile(ICellView wayPointTile)
        {
            _allTiles.Add(wayPointTile);
            _wayPointTiles.Add(wayPointTile as WaypointCellView);
        }

        public void ClearAllTiles()
        {
            _allTiles.Clear();
            _wayPointTiles.Clear();
            _buildingTiles.Clear();
        }
    }
}