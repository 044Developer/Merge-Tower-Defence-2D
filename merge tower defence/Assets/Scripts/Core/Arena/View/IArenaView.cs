using UnityEngine;

namespace MergeTowerDefence.Core.Arena.View
{
    public interface IArenaView
    {
        void AddNewTile(GameObject tile);
        void ClearAllTiles();
    }
}