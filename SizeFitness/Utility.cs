using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SizeFitness
{
    public static class Utility
    {
        /// <summary>
        /// プロパティを書き換えます。
        /// </summary>
        /// <typeparam name="T">クラス</typeparam>
        /// <param name="target">書き換え先</param>
        /// <param name="contents">書き換え内容</param>
        public static void SetValues<T>(T target, T contents) where T : class
        {
            var properties = target.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                property.SetValue(target, property.GetValue(contents));
            }
        }
    }
}
