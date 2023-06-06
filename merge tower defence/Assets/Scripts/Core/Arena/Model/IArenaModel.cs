using System.Collections.Generic;
using MergeTowerDefence.Core.Cells.View;

namespace MergeTowerDefence.Core.Arena.Model
{
    public interface IArenaModel
    {
        StartCellView SpawnTile { get; }
        FinishCellView FinishTile { get; }
        IEnumerable<ICellView> AllTiles { get; }
        IEnumerable<WaypointCellView> WayPointTiles { get; }
        IEnumerable<BuildingCellView> BuildingTiles { get; }

        void RegisterSpawnTile(ICellView spawnTile);
        void RegisterFinishTile(ICellView finishTile);
        void RegisterRegularTile(ICellView regularTile);
        void RegisterBuildingTile(ICellView buildingTile);
        void RegisterWayPointTile(ICellView wayPointTile);
        void ClearAllTiles();
    }
}