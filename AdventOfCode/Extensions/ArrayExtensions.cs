namespace AdventOfCode.Extensions
{
    public static class ArrayExtensions
    {
        public static T GetElementHalfWayAround<T>(this T[] array, int currentIndex, int jumpIndex)
        {
            if (array.Length > currentIndex + jumpIndex)
                return array[currentIndex + jumpIndex];

            var newIndex = currentIndex + jumpIndex - array.Length;

            return array[newIndex];
        }
    }
}
