using MergeTowerDefence.Core.Cells.Model;
using UnityEngine;

namespace MergeTowerDefence.Core.Cells.View
{
    public abstract class BaseCellView : MonoBehaviour, ICellView
    {
        public ICellModel CellModel { get; protected set; }
    }
}