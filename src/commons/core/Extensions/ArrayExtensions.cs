// ReSharper disable once CheckNamespace
namespace FamilyBudget.Common;

public static class ArrayExtensions
{
    extension<T>(T[] array)
    {
        public bool IsEmpty => array.Length == 0;
        public bool IsNotEmpty => array.Length > 0;
        
        public void ForEach(Action<T> action) 
        {
            foreach (var item in array)
            {
                action(item);
            }
        }
    }
}