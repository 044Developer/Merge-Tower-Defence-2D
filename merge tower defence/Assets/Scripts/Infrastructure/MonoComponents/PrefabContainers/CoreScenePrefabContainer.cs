using MergeTowerDefence.Core.Arena.View;
using UnityEngine;

namespace MergeTowerDefence.Infrastructure.MonoComponents.PrefabContainers
{
    [CreateAssetMenu(menuName = "Containers/Prefabs/Core", fileName = "core_prefab_container")]
    public class CoreScenePrefabContainer : ScriptableObject
    {
        [Header("Arena Prefabs")]
        [SerializeField] private ArenaView _arenaPrefab = null;

        public ArenaView ArenaPrefab => _arenaPrefab;
    }
}