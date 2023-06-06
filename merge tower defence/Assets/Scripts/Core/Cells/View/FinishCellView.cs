using MergeTowerDefence.Core.Cells.Model;
using VContainer;

namespace MergeTowerDefence.Core.Cells.View
{
    public sealed class FinishCellView : BaseCellView
    {
        [Inject]
        public void Construct(ICellModel cellModel)
        {
            CellModel = cellModel;
        }
    }
}