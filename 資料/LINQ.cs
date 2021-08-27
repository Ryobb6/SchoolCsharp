using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    static class LINQ
    {
        static void Main(String[] args)
        {
            Console.WriteLine("単一要素の取得");
            単一要素の取得();
            Console.WriteLine("----");

            Console.WriteLine("複数要素の取得");
            複数要素の取得();
            Console.WriteLine("----");

            Console.WriteLine("集計");
            集計();
            Console.WriteLine("----");

            Console.WriteLine("判定");
            判定();
            Console.WriteLine("----");

            Console.WriteLine("集合");
            集合();
            Console.WriteLine("----");

            Console.WriteLine("ソート");
            ソート();
            Console.WriteLine("----");

            Console.WriteLine("射影");
            射影();
            Console.WriteLine("----");

            Console.WriteLine("結合");
            結合();
            Console.WriteLine("----");

            Console.WriteLine("変換");
            変換();
            Console.WriteLine("----");
        }

        private static void 単一要素の取得()
        {
            var source = new[] { 10, 20, 30, 40 };

            Console.WriteLine(source.ElementAt(1));
            // -> 20

            Console.WriteLine(source.ElementAtOrDefault(5));
            // -> 0

            Console.WriteLine(source.First());
            // -> 10

            Console.WriteLine(source.First(e => e > 15));
            // -> 20

            Console.WriteLine(source.Last());
            // -> 40

            Console.WriteLine(source.Last(e => e < 35));
            // -> 30

            try
            {
                Console.WriteLine(source.Single());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            // -> System.InvalidOperationException: シーケンスに複数の要素が含まれています
            // (Sequence contains more than one element)

            Console.WriteLine(source.Single(e => e > 35));
            // -> 40
        }

        private static void 複数要素の取得()
        {
            var source = new[] { 10, 10, 20, 30, 40 };

            Console.WriteLine(source.Where(e => e > 15).ToResult());
            // -> { 20, 30, 40 }

            Console.WriteLine(source.Distinct().ToResult());
            // -> { 10, 20, 30, 40 }

            Console.WriteLine(source.Skip(3).ToResult());
            // -> { 30, 40 }

            Console.WriteLine(source.SkipWhile(e => e < 15).ToResult());
            // -> { 20, 30, 40 }

            Console.WriteLine(source.Take(3).ToResult());
            // -> { 10, 20, 30 }

            Console.WriteLine(source.TakeWhile(e => e < 15).ToResult());
            // -> { 10, 10 }
        }

        private static void 集計()
        {
            var source = new[] { 10, 20, 30, 40 };

            Console.WriteLine(source.Max());
            // -> 40

            Console.WriteLine(source.Min());
            // -> 10

            Console.WriteLine(source.Average());
            // -> 25

            Console.WriteLine(source.Sum());
            // -> 100

            Console.WriteLine(source.Count());
            // -> 4

            Console.WriteLine(source.Aggregate((now, next) => now * next));
            // -> 24000

            // 参考：標本分散
            double ave = source.Average();
            Console.WriteLine(source.Sum(e => Math.Pow(e - ave, 2)) / source.Count());
            // -> 125
        }

        private static void 判定()
        {
            var source = new[] { 10, 20, 30 };

            Console.WriteLine(source.All(e => e > 15));
            // -> False

            Console.WriteLine(source.Any(e => e > 15));
            // -> True

            Console.WriteLine(source.Contains(20));
            // -> True

            Console.WriteLine(source.SequenceEqual(new[] { 10, 20, 30 }));
            // -> True
        }

        private static void 集合()
        {
            var first = new[] { 10, 20, 30, 40 };
            var second = new[] { 60, 50, 40, 30 };

            Console.WriteLine(first.Union(second).ToResult());
            // -> {10, 20, 30, 40, 60, 50}

            Console.WriteLine(first.Except(second).ToResult());
            // -> {10, 20}

            Console.WriteLine(first.Intersect(second).ToResult());
            // -> {30, 40}
        }

        private static void ソート()
        {
            var source = new[] {
                new{ Name = "A", Value = 20 },
                new{ Name = "B", Value = 10 },
                new{ Name = "C", Value = 20 },
                new{ Name = "D", Value = 30 },
            };

            Console.WriteLine(source.OrderBy(e => e.Value).ToResult());
            // -> {{ Name = B, Value = 10 },
            //     { Name = A, Value = 20 },
            //     { Name = C, Value = 20 }, 
            //     { Name = D, Value = 30 }}

            Console.WriteLine(source.OrderByDescending(e => e.Value).ToResult());
            // -> {{ Name = D, Value = 30 },
            //     { Name = A, Value = 20 },
            //     { Name = C, Value = 20 },
            //     { Name = B, Value = 10 }}

            Console.WriteLine(source.OrderBy(e => e.Value)
                                    .ThenBy(e => e.Name).ToResult());
            // -> {{ Name = B, Value = 10 },
            //     { Name = A, Value = 20 },
            //     { Name = C, Value = 20 }, 
            //     { Name = D, Value = 30 }}

            Console.WriteLine(source.OrderBy(e => e.Value)
                                    .ThenByDescending(e => e.Name).ToResult());
            // -> {{ Name = B, Value = 10 },
            //     { Name = C, Value = 20 },
            //     { Name = A, Value = 20 }, 
            //     { Name = D, Value = 30 }}

            Console.WriteLine(source.Reverse().ToResult());
            // -> {{ Name = D, Value = 30 },
            //     { Name = C, Value = 20 },
            //     { Name = B, Value = 10 }, 
            //     { Name = A, Value = 20 }}
        }

        private static void 射影()
        {
            var source = new[] {
                new{ Name = "A", Value = 20 },
                new{ Name = "B", Value = 10 },
                new{ Name = "C", Value = 20 },
                new{ Name = "D", Value = 30 },
            };

            Console.WriteLine(source.Select(e => e.Name).ToResult());
            // -> { A, B, C, D }

            Console.WriteLine(source.SelectMany(e => new object[] { e.Name, e.Value }).ToResult());
            // -> { A, 20, B, 10, C, 20, D, 30 }

            Console.WriteLine(source.GroupBy(e => e.Value).ToResult());
            // -> { Key = 20, Element = { { Name = A, Value = 20 }, { Name = C, Value = 20 } },
            //      Key = 10, Element = { { Name = B, Value = 10 } },
            //      Key = 30, Element = { { Name = D, Value = 30 } } }
        }

        private static void 結合()
        {
            var outer = new[] {
                new{ Name = "A", Value = 10 },
                new{ Name = "B", Value = 20 },
                new{ Name = "C", Value = 30 },
            };

            var inner = new[] {
                new{ Name = "X", Value = 20 },
                new{ Name = "Y", Value = 30 },
                new{ Name = "Z", Value = 30 }
            };

            var empty = new int[0];

            Console.WriteLine(outer.Join(
                inner,
                o => o.Value,
                i => i.Value,
                (o, i) => new {
                    oName = o.Name,
                    oValue = o.Value,
                    iName = i.Name,
                    iValue = i.Value 
                }
            ).ToResult());
            // -> {{ oName = B, oValue = 20, iName = X, iValue = 20 },
            //     { oName = C, oValue = 30, iName = Y, iValue = 30 },
            //     { oName = C, oValue = 30, iName = Z, iValue = 30 }}

            Console.WriteLine(outer.GroupJoin(
                inner,
                o => o.Value,
                i => i.Value,
                (o, i) => new {
                    Name = o.Name,
                    Value = o.Value,
                    Group = i.Select( i => i.Name ).ToResult() 
                }
            ).ToResult());
            // -> {{ Name = A, Value = 10, Group = {} },
            //     { Name = B, Value = 20, Group = { X } },
            //     { Name = C, Value = 30, Group = { Y, Z } }}

            Console.WriteLine(outer.Concat(inner).ToResult());
            // -> {{ Name = A, Value = 10 },
            //     { Name = B, Value = 20 },
            //     { Name = C, Value = 30 },
            //     { Name = X, Value = 20 },
            //     { Name = Y, Value = 30 },
            //     { Name = Z, Value = 30 }}

            Console.WriteLine(empty.DefaultIfEmpty().ToResult());
            // -> { 0 }

            Console.WriteLine(outer.Zip(inner, (o, i) => o.Name + "&" + i.Name).ToResult());
            // -> { A&X, B&Y, C&Z }
        }

        private static void 変換()
        {
            var mixed = new object[] { "A", "B", 1, 2 };

            var source = new[] {
                new{ Name = "A", Value = 20 },
                new{ Name = "B", Value = 10 },
                new{ Name = "C", Value = 20 },
                new{ Name = "D", Value = 30 },
            };

            Console.WriteLine(mixed.OfType<string>().ToResult());
            // -> { A, B }

            try
            {
                Console.WriteLine(mixed.Cast<string>().ToResult());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            // -> System.InvalidCastException: 型 'System.Int32' のオブジェクトを型 'System.String' にキャストできません。
            // (Unable to cast object of type 'System.Int32' to type 'System.String'.)

            Console.WriteLine(source.ToArray().ToResult());
            // -> {{ Name = A, Value = 20 },
            //     { Name = B, Value = 10 },
            //     { Name = C, Value = 20 },
            //     { Name = D, Value = 30 }}

            Console.WriteLine(source.ToDictionary(x => x.Name, x => x.Value).ToResult());
            // -> { [A, 20], [B, 10], [C, 20], [D, 30] }

            Console.WriteLine(source.ToLookup(x => x.Value, x => x.Name).ToResult());
            // -> { Key = 20, Element = { A, C },
            //      Key = 10, Element = { B },
            //      Key = 30, Element = { D } }
        }

        /// <summary>
        /// IEnumerable&lt;T&gt; を文字列に変換します。
        /// </summary>
        /// <typeparam name="TSource">要素の型</typeparam>
        /// <param name="source">変換元の IEnumerable&lt;T&gt;</param>
        /// <returns>変換した文字列</returns>
        static String ToResult<TSource>(this IEnumerable<TSource> source)
        {
            return "{" + string.Join(", ", source) + "}";
        }

        /// <summary>
        /// IEnumerable&lt;IGrouping&lt;TKey, TSource&gt;&gt; を文字列に変換します。
        /// </summary>
        /// <typeparam name="TKey">キーの型</typeparam>
        /// <typeparam name="TElement">要素の型</typeparam>
        /// <param name="source">変換元の IEnumerable&lt;IGrouping&lt;TKey, TSource&gt;&gt;</param>
        /// <returns>変換した文字列</returns>
        static String ToResult<TKey, TElement>(this IEnumerable<IGrouping<TKey, TElement>> source)
        {
            return source.Select(group => string.Format("Key={0}, Element={1}", group.Key, group.ToResult())).ToResult();
        }
    }
}
