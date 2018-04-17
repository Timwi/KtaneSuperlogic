﻿using System;
using System.Collections;
using System.Collections.Generic;
using Rnd = UnityEngine.Random;

namespace Superlogic
{
    static class Ut
    {
        /// <summary>
        ///     Brings the elements of the given list into a random order.</summary>
        /// <typeparam name="T">
        ///     Type of elements in the list.</typeparam>
        /// <param name="list">
        ///     List to shuffle.</param>
        /// <returns>
        ///     The list operated on.</returns>
        public static T Shuffle<T>(this T list) where T : IList
        {
            if (list == null)
                throw new ArgumentNullException("list");
            for (int j = list.Count; j >= 1; j--)
            {
                int item = Rnd.Range(0, j);
                if (item < j - 1)
                {
                    var t = list[item];
                    list[item] = list[j - 1];
                    list[j - 1] = t;
                }
            }
            return list;
        }

        public static T PickRandomAndRemove<T>(this List<T> list)
        {
            var ix = Rnd.Range(0, list.Count);
            var t = list[ix];
            list.RemoveAt(ix);
            return t;
        }
    }
}
