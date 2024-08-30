using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace uPools
{
    public static class ExtensionMethods
    {
        public static bool TryPop<T>(this Stack<T> stack, out T obj) where T : class
        {
            if (stack.Count > 0)
            {
                obj = stack.Pop();
                return true;
            }
            obj = null;
            return false;
        }
    }
}
