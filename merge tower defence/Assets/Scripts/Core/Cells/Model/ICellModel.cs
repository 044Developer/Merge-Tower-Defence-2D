using UnityEngine;

namespace MergeTowerDefence.Core.Cells.Model
{
    public interface ICellModel
    {
        Vector2Int CellPosition { get; set; }
    }
}