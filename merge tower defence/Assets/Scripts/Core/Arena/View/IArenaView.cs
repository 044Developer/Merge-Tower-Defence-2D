using MergeTowerDefence.Core.Arena.Model;
using UnityEngine;

namespace MergeTowerDefence.Core.Arena.View
{
    public interface IArenaView
    {
        void Construct(IArenaModel arenaModel);
        Transform TilesRoot { get; }
        void AddNewTile(GameObject tile);
        void ClearAllTiles();
    }
}