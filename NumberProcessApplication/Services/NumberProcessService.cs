using NumberProcessApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NumberProcessApplication.Services
{
    public class NumberProcessService : INumberProcessService
    {

        public void MoveMaxItemsToCenter(List<int> numbers, int amountItem)
        {
            Helpers.Helper.MoveMaxItemToCenter(numbers, amountItem);
        }
    }
}
