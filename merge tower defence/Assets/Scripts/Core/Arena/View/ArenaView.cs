using MergeTowerDefence.Core.Arena.Model;
using UnityEngine;
using VContainer;

namespace MergeTowerDefence.Core.Arena.View
{
    public sealed class ArenaView : MonoBehaviour, IArenaView
    {
        [SerializeField] private Transform _tilesRoot = null;
        
        private IArenaModel _arenaModel = null;
        
        public Transform TilesRoot => _tilesRoot;
        
        [Inject]
        public void Construct(IArenaModel arenaModel)
        {
            _arenaModel = arenaModel;
        }


        public void AddNewTile(GameObject tile)
        {
            _arenaModel.RegisterSpawnTile(tile);
            _arenaModel.RegisterFinishTile(tile);
            _arenaModel.RegisterWayPointTile(tile);
            _arenaModel.RegisterBuildingTile(tile);
            _arenaModel.RegisterRegularTile(tile);
        }

        public void ClearAllTiles()
        {
            _arenaModel.ClearAllTiles();
        }
    }
}