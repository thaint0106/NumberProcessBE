using System;
using System.Collections.Generic;
using System.Text;

namespace NumberProcessApplication.Interfaces
{
    public interface INumberProcessService
    {
        void MoveMaxItemsToCenter(List<int> numbers, int amountItem);
    }
}
