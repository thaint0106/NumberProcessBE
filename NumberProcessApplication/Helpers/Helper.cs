using System.Collections.Generic;
using System.Linq;

namespace NumberProcessApplication.Helpers
{
    public static class Helper
    {
        public static List<int> ConvertStringToList(string str)
        {
            var strs = str.Split(',').ToList();
            List<int> numbers = new List<int>();
            foreach (var item in strs)
            {
                try
                {
                    numbers.Add(int.Parse(item.Trim()));
                }
                catch
                {
                    //exception
                }
            }
            return numbers;
        }




        static public int Partition(List<int> arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        //quick sort
        static public void QuickSort(List<int> arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }
        /// <summary>
        /// Move max items to center array
        /// </summary>
        /// <param name="arr">array number</param>
        /// <param name="amountItem">number item moved</param>
        static public void MoveMaxItemToCenter(List<int> arr, int amountItem)
        {
            //You can use quick sort method
            //QuickSort(arr, 0, arr.Count - 1);
            arr.Sort();
            int center = (int)(arr.Count - amountItem) / 2;
            for (int i = 0; i < amountItem; i++)
            {
                //index item be moved
                var index = arr.Count - amountItem + i;
                //value item move
                var item = arr[index];
                //move item from array
                arr.RemoveAt(index);
                //insert to center
                arr.Insert(center + i, item);
            }
        }

        //Find pair number meet the conditions sum(a+b) is the number 
        public static Dictionary<int, int> FindPairNumber(List<int> numbers, int sum)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                //tồn tại key tương ứng với với value =sum - numbers[i] thì add vào result
                if (dic.ContainsKey(sum - numbers[i]))
                {
                    result.Add(numbers[i], sum - numbers[i]);
                }
                dic.Add(numbers[i], i);
            }
            return result;
        }
    }
}
