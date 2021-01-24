using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        /// <summary>
        /// 特定のテキストを正規表現で抜き出します。
        /// </summary>
        /// <param name="text">対象の文字列</param>
        /// <param name="regex">正規表現</param>
        /// <param name="param">パラメーター</param>
        /// <returns></returns>
        public static string? RegexString(this string text, string regex, string param)
        {
            var mc = Regex.Matches(text, regex, RegexOptions.IgnoreCase | RegexOptions.Singleline);

            foreach (Match m in mc)
                return m.Groups[param].Value;

            return null;
        }

        /// <summary>
        /// 特定のテキストを正規表現で複数抜き出します。
        /// </summary>
        /// <param name="text">対象の文字列</param>
        /// <param name="regex">正規表現</param>
        /// <param name="param">パラメーター</param>
        /// <returns></returns>
        public static string[] RegexStrings(this string text, string regex, string param)
        {
            var mc = Regex.Matches(text, regex, RegexOptions.IgnoreCase | RegexOptions.Singleline);

            List<string> value = new();

            foreach (Match m in mc)
                value.Add(m.Groups[param].Value);

            return value.ToArray();
        }
    }
}