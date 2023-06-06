using MergeTowerDefence.Core.Cells.Model;

namespace MergeTowerDefence.Core.Cells.View
{
    public interface ICellView
    {
        ICellModel CellModel { get; }
    }
}