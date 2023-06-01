using System.Collections.Generic;
using UnityEngine;

namespace MergeTowerDefence.Core.Arena.Model
{
    public interface IArenaModel
    {
        GameObject SpawnTile { get; }
        GameObject FinishTile { get; }
        IEnumerable<GameObject> AllTiles { get; }
        IEnumerable<GameObject> WayPointTiles { get; }
        IEnumerable<GameObject> BuildingTiles { get; }

        void RegisterSpawnTile(GameObject spawnTile);
        void RegisterFinishTile(GameObject finishTile);
        void RegisterRegularTile(GameObject regularTile);
        void RegisterBuildingTile(GameObject buildingTile);
        void RegisterWayPointTile(GameObject wayPointTile);
        void ClearAllTiles();
    }
}