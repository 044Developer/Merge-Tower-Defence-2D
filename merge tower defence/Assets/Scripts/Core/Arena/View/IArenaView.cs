using MergeTowerDefence.Core.Arena.Model;
using MergeTowerDefence.Core.Cells.View;
using UnityEngine;

namespace MergeTowerDefence.Core.Arena.View
{
    public interface IArenaView
    {
        void AddNewCell(ICellView cell);
        void ClearAllTiles();
        Transform BuildCellRoot { get; }
        Transform WayPointCellRoot { get; }
        Transform RegularCellRoot { get; }
        IArenaModel ArenaModel { get; }
    }
}