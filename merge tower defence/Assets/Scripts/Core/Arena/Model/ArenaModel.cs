using System.Collections.Generic;
using UnityEngine;

namespace MergeTowerDefence.Core.Arena.Model
{
    public sealed class ArenaModel : IArenaModel
    {
        private List<GameObject> _allTiles = new();
        private List<GameObject> _wayPointTiles = new();
        private List<GameObject> _buildingTiles = new();
        
        public GameObject SpawnTile { get; private set; }
        public GameObject FinishTile { get; private set; }
        public IEnumerable<GameObject> AllTiles => _allTiles;
        public IEnumerable<GameObject> WayPointTiles => _wayPointTiles;
        public IEnumerable<GameObject> BuildingTiles => _buildingTiles;
        
        public void RegisterSpawnTile(GameObject spawnTile)
        {
            SpawnTile = spawnTile;
            _wayPointTiles.Add(spawnTile);
            _allTiles.Add(spawnTile);
        }

        public void RegisterFinishTile(GameObject finishTile)
        {
            FinishTile = finishTile;
            _wayPointTiles.Add(finishTile);
            _allTiles.Add(finishTile);
        }

        public void RegisterRegularTile(GameObject regularTile)
        {
            _allTiles.Add(regularTile);
        }

        public void RegisterBuildingTile(GameObject buildingTile)
        {
            _allTiles.Add(buildingTile);
            _buildingTiles.Add(buildingTile);
        }

        public void RegisterWayPointTile(GameObject wayPointTile)
        {
            _allTiles.Add(wayPointTile);
            _wayPointTiles.Add(wayPointTile);
        }

        public void ClearAllTiles()
        {
            _allTiles.Clear();
            _wayPointTiles.Clear();
            _buildingTiles.Clear();
        }
    }
}