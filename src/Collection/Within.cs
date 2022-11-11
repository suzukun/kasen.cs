#pragma warning disable SA1300, SA1649
namespace KasenCS
{
    using System.Collections.Generic;

    /// <summary>
    /// __
    /// </summary>
    public static partial class __
    {
        public static Dictionary<TK, TV> Within<TK, TV>(Dictionary<TK, TV> dictionary, params TV[] values)
        {
            List<TV> targets = new List<TV>(values);

            return Filter(dictionary, (v, k) => Includes(targets, v));
        }

        public static List<T> Within<T>(List<T> dictionary, params T[] values)
        {
            List<T> targets = new List<T>(values);

            return Filter(dictionary, (v, k) => Includes(targets, v));
        }
    }
}
#pragma warning restore SA1300, SA1649
