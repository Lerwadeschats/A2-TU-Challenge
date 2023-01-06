using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {
        public static int Add(int a, int b)
        {
            return (a + b);
        }

        public static bool IsMajeur(int age)
        {
            if (age < 0 || age >= 150)
            {
                throw new ArgumentException();
            }
            else if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsEven(int a)
        {
            if(a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDivisible(int a, int b)
        {
            if (a % b == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsPrimary(int a)
        {
            if (a > 1)
            {
                for (int i = 2; i < a; i++)
                {

                    if (IsDivisible(a, i))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static List<int> GetAllPrimary(int a)
        {
            List<int> result = new List<int>();
            for (int i = 2; i < a + 1; i++)
            {
                if (IsPrimary(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static int Power(int a, int b)
        {
            int result = a;
            for (int i = 0; i < b - 1; i++)
            {
                result *= a;
            }
            return result;
        }

        public static int IsInOrder(int a, int b)
        {
            if(a < b)
            {
                return 1;
            }
            else if(a > b)
            {
                return (-1);
            }
            else if(a == b)
            {
                return 0;
            }
            return 0;
        }

        public static int IsInOrderDesc(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (a < b)
            {
                return (-1);
            }
            else if (a == b)
            {
                return 0;
            }
            return 0;
        }

        public static bool IsListInOrder(List<int> list)
        {
            for (int i = 0; i < list.Count-1; i++)
            {
                if(list[i] > list[i + 1])
                {
                    return false;
                }
                
            }
            return true;
        }

        public static bool IsListInOrderDesc(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (IsInOrderDesc(list[i], list[i + 1]) == -1)
                {
                    return false;
                }

            }
            return true;
        }

        public static List<int> Sort(List<int> listToSort)
        {
            int temp;
            while (!IsListInOrder(listToSort))
            {
                for (int i = 0; i < listToSort.Count - 1; i++)
                {
                    if(IsInOrder(listToSort[i], listToSort[i + 1]) == -1)
                    {
                        temp = listToSort[i];
                        listToSort[i] = listToSort[i + 1];
                        listToSort[i + 1] = temp;
                    }
                }
            }
            return listToSort;
        }

        public static List<int> GenericSort(List<int> listToSort, Func<int, int, int> isinorder)
        {
            if(isinorder == MyMathImplementation.IsInOrder)
            {
                return Sort(listToSort);
            }
            else if(isinorder == MyMathImplementation.IsInOrderDesc)
            {
                int temp;
                while (!IsListInOrderDesc(listToSort))
                {
                    for (int i = listToSort.Count - 1; i > 0; i--)
                    {
                        if (IsInOrderDesc(listToSort[i - 1], listToSort[i]) == -1)
                        {
                            temp = listToSort[i];
                            listToSort[i] = listToSort[i - 1];
                            listToSort[i - 1] = temp;
                        }
                    }
                }
            }
            return listToSort;
        }
    }
}
