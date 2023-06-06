using MergeTowerDefence.Core.Arena.View;
using MergeTowerDefence.Core.Cells.View;
using UnityEngine;

namespace MergeTowerDefence.Infrastructure.MonoComponents.PrefabContainers
{
    [CreateAssetMenu(menuName = "Containers/Prefabs/Core", fileName = "core_prefab_container")]
    public class CoreScenePrefabContainer : ScriptableObject
    {
        [Header("Arena Prefabs")]
        [SerializeField] private ArenaView _arenaPrefab = null;

        [Header("Cells")]
        [SerializeField] private BuildingCellView _buildingCell = null;
        [SerializeField] private WaypointCellView _wayPointCell = null;
        [SerializeField] private StartCellView _startCell = null;
        [SerializeField] private FinishCellView _finishCell = null;
        [SerializeField] private RegularCellView _regularCell = null;

        public ArenaView ArenaPrefab => _arenaPrefab;

        public BuildingCellView BuildingCell => _buildingCell;

        public WaypointCellView WayPointCell => _wayPointCell;

        public StartCellView StartCell => _startCell;

        public FinishCellView FinishCell => _finishCell;

        public RegularCellView RegularCell => _regularCell;
    }
}