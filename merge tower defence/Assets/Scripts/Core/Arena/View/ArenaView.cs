using MergeTowerDefence.Core.Arena.Model;
using MergeTowerDefence.Core.Cells.View;
using UnityEngine;
using VContainer;

namespace MergeTowerDefence.Core.Arena.View
{
    public sealed class ArenaView : MonoBehaviour, IArenaView
    {
        [Header("Cell Root")]
        [SerializeField] private Transform _buildCellRoot = null;
        [SerializeField] private Transform _wayPointCellRoot = null;
        [SerializeField] private Transform _regularCellRoot = null;
        
        private IArenaModel _arenaModel = null;
        
        public Transform BuildCellRoot => _buildCellRoot;
        public Transform WayPointCellRoot => _wayPointCellRoot;
        public Transform RegularCellRoot => _regularCellRoot;
        public IArenaModel ArenaModel => _arenaModel;

        [Inject]
        public void Construct(IArenaModel arenaModel)
        {
            _arenaModel = arenaModel;
        }
        
        public void AddNewCell(ICellView cell)
        {
            _arenaModel.RegisterSpawnTile(cell);
            _arenaModel.RegisterFinishTile(cell);
            _arenaModel.RegisterWayPointTile(cell);
            _arenaModel.RegisterBuildingTile(cell);
            _arenaModel.RegisterRegularTile(cell);
        }

        public void ClearAllTiles()
        {
            _arenaModel.ClearAllTiles();
        }
    }
}