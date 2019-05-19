![Logo](/logo.png)

[![CI Status](https://cpgithub.visualstudio.com/GitHubPipelines/_apis/build/status/conplementAG.30-seconds-of-c-sharp)](https://cpgithub.visualstudio.com/GitHubPipelines/_build/latest?definitionId=7)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.md)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](http://makeapullrequest.com)

# 30 seconds of C#
> A curated collection of useful C# snippets that you can understand in 30 seconds or less.

Note: This project is inspired by [30 Seconds of Code](https://github.com/Chalarangelo/30-seconds-of-code), but there is no affiliation with that project.

## Table of Contents

### ⏱️ Date

<details>
<summary>View contents</summary>

* [`dayOfYear`](#dayOfYear)
* [`formatDuration`](#formatDuration)
* [`getColonTimeFromDate`](#getColonTimeFromDate)
* [`getDaysDiffBetweenDates`](#getDaysDiffBetweenDates)
* [`getMeridiumSuffixOfInteger`](#getMeridiumSuffixOfInteger)
* [`isAfterDate`](#isAfterDate)
* [`isBeforeDate`](#isBeforeDate)
* [`isSameDate`](#isSameDate)
* [`maxDate`](#maxDate)
* [`minDate`](#minDate)
* [`tomorrow`](#tomorrow)

</details>

### 📚 Enumerable

<details>
<summary>View contents</summary>

* [`allEqual`](#allEqual)
* [`arrayToCsv`](#arrayToCsv)
* [`bifurcate`](#bifurcate)
* [`bubbleSort`](#bubbleSort)
* [`chunk`](#chunk)
* [`compact`](#compact)
* [`countBy`](#countBy)
* [`countOccurences`](#countOccurences)
* [`deepFlatten`](#deepflatten)
* [`difference`](#difference)
* [`differenceBy`](#differenceBy)
* [`differenceWith`](#differenceWith)
* [`drop`](#drop)
* [`dropRight`](#dropRight)
* [`dropRightWhile`](#dropRightWhile)
* [`dropWhile`](#dropWhile)
* [`everyNth`](#everyNth)
* [`filterNonUnique`](#filterNonUnique)
* [`filterNonUniqueBy`](#filterNonUniqueBy)
* [`findLast`](#findLast)
* [`findLastIndex`](#findLastIndex)
* [`flatten`](#flatten)
* [`forEachRight`](#forEachRight)
* [`groupBy`](#groupBy)
* [`hasDuplicates`](#hasDuplicates)
* [`head`](#head)
* [`indexOfAll`](#indexOfAll)
* [`initial`](#initial)
* [`initialize2DArray`](#initialize2DArray)
* [`initializeArrayWithRange`](#initializeArrayWithRange)
* [`initializeArrayWithRangeRight`](#initializeArrayWithRangeRight)
* [`initializeArrayWithValues`](#initializeArrayWithValues)
* [`initializeNDArray`](#initializeNDArray)
* [`intersection`](#intersection)
* [`intersectionBy`](#intersectionBy)
* [`intersectionWith`](#intersectionWith)
* [`isSorted`](#isSorted)
* [`join`](#join)
* [`jsonToCsv`](#jsonToCsv)
* [`last`](#last)
* [`longestItem`](#longestItem)
* [`maxN`](#maxN)
* [`minN`](#minN)
* [`none`](#none)
* [`nthElement`](#nthElement)
* [`offset`](#offset)
* [`orderBy`](#orderBy)
* [`partition`](#partition)
* [`permutations`](#permutations)
* [`pluck`](#pluck)
* [`pull`](#pull)
* [`pullAtIndex`](#pullAtIndex)
* [`pullAtValue`](#pullAtValue)
* [`pullBy`](#pullBy)
* [`reduceFilter`](#reduceFilter)
* [`reduceSuccessive`](#reduceSuccessive)
* [`reduceWhich`](#reduceWhich)
* [`reject`](#reject)
* [`remove`](#remove)
* [`sample`](#sample)
* [`sampleSize`](#sampleSize)
* [`shank`](#shank)
* [`shuffle`](#shuffle)
* [`similarity`](#similarity)
* [`sortedIndex`](#sortedIndex)
* [`sortedIndexBy`](#sortedIndexBy)
* [`sortedLastIndex`](#sortedLastIndex)
* [`sortedLastIndexBy`](#sortedLastIndexBy)
* [`stableSort`](#stableSort)
* [`symmetricDifference`](#symmetricDifference)
* [`symmetricDifferenceBy`](#symmetricDifferenceBy)
* [`symmetricDifferenceWith`](#symmetricDifferenceWith)
* [`tail`](#tail)
* [`take`](#take)
* [`takeRight`](#takeRight)
* [`takeRightWhile`](#takeRightWhile)
* [`takeWhile`](#takeWhile)
* [`toHash`](#toHash)
* [`union`](#union)
* [`unionBy`](#unionBy)
* [`unionWith`](#unionWith)
* [`uniqueElements`](#uniqueElements)
* [`uniqueElementsBy`](#uniqueElementsBy)
* [`uniqueElementsByRight`](#uniqueElementsByRight)
* [`uniqueSymmetricDifference`](#uniqueSymmetricDifference)
* [`without`](#without)
* [`xProd`](#xProd)

</details>

### ➗ Math

<details>
<summary>View contents</summary>

* [`approximatelyEqual`](#approximatelyEqual)
* [`average`](#average)
* [`averageBy`](#averageBy)
* [`binomialCoefficient`](#binomialCoefficient)
* [`degreesToRads`](#degreesToRads)
* [`digitize`](#digitize)
* [`distance`](#distance)
* [`factorial`](#factorial)
* [`fibonacci`](#fibonacci)
* [`gcd`](#gcd)
* [`geometricProgression`](#geometricProgression)
* [`inRange`](#inRange)
* [`isDivisible`](#isDivisible)
* [`isEven`](#isEven)
* [`isPrime`](#isPrime)
* [`isOdd`](#isOdd)
* [`lcm`](#lcm)
* [`luhnCheck`](#luhnCheck)
* [`max`](#max)
* [`median`](#median)
* [`min`](#min)
* [`primes`](#primes)
* [`radsToDegrees`](#radsToDegrees)
* [`randomIntArrayInRange`](#randomIntArrayInRange)
* [`randomIntegerInRange`](#randomIntegerInRange)
* [`randomNumberInRange`](#randomNumberInRange)
* [`round`](#round)
* [`sdbm`](#sdbm)
* [`standardDeviation`](#standardDeviation)
* [`sum`](#sum)
* [`sumBy`](#sumBy)

</details>

### 🎛️ Method

<details>
<summary>View contents</summary>

* [`hz`](#hz)
* [`times`](#times)

</details>

### 📜 String

<details>
<summary>View contents</summary>

* [`byteSize`](#byteSize)
* [`capitalize`](#capitalize)
* [`capitalizeEveryWord`](#capitalizeEveryWord)
* [`countVowels`](#countVowels)
* [`csvToArray`](#csvToArray)
* [`csvToJson`](#csvToJson)
* [`decapitalize`](#decapitalize)
* [`endsWithRegex`](#endsWithRegex)
* [`escapeHtml`](#escapeHtml)
* [`escapeRegExp`](#escapeRegExp)
* [`fromCamelCase`](#fromCamelCase)
* [`indentString`](#indentString)
* [`isAbsoluteUrl`](#isAbsoluteUrl)
* [`isAnagram`](#isAnagram)
* [`isLowerCase`](#isLowerCase)
* [`isUpperCase`](#isUpperCase)
* [`mask`](#mask)
* [`pad`](#pad)
* [`palindrome`](#palindrome)
* [`pluralize`](#pluralize)
* [`removeNonAscii`](#removeNonAscii)
* [`reverseString`](#reverseString)
* [`sortCharactersInString`](#sortCharactersInString)
* [`splitLines`](#splitLines)
* [`startsWithRegex`](#startsWithRegex)
* [`stringPermutations`](#stringPermutations)
* [`stripHtmlTags`](#stripHtmlTags)
* [`toCamelCase`](#toCamelCase)
* [`toKebabCase`](#toKebabCase)
* [`toSnakeCase`](#toSnakeCase)
* [`toTitleCase`](#toTitleCase)
* [`truncateString`](#truncateString)
* [`unescapeHTML`](#unescapeHTML)
* [`urlJoin`](#urlJoin)
* [`words`](#words)

</details>

### 📃️ Type

<details>
<summary>View contents</summary>

* [`is`](#is)
* [`isValidJson`](#isValidJson)

</details>

### 🔧 Utility

<details>
<summary>View contents</summary>

* [`coalesce`](#coalesce)
* [`extendHex`](#extendHex)
* [`getUrlParameters`](#getUrlParameters)
* [`hexToRgb`](#hexToRgb)
* [`mostPerformant`](#mostPerformant)
* [`prettyBytes`](#prettyBytes)
* [`randomHexColorCode`](#randomHexColorCode)
* [`rgbToHex`](#rgbToHex)
* [`timeTaken`](#timeTaken)
* [`toOrdinalSuffix`](#toOrdinalSuffix)
* [`yesNo`](#yesNo)

</details>

---
 ## ⏱️ Date

### dayOfYear

Returns the day of the current year

Already integrated into C#
https://docs.microsoft.com/de-de/dotnet/api/system.datetime.dayofyear?view=netframework-4.7.2

``` c#
using System;

namespace Conplement.Snippets.Date
{
    public static partial class Date
    {
        public static int DayOfYear()
        {
            return DateTime.UtcNow.DayOfYear;
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
Conplement.Snippets.Date.DayOfYear() # 12/31/2016: day 366 of 2016 (Leap Year)
```

</details>

<br>[↑ Back to top](#table-of-contents)

### formatDuration

Returns the human readable format of the given number of milliseconds.

```c#
namespace Conplement.Snippets.Date
{
    public static partial class Date
    {
        public static string FormatDuration(ulong milliseconds)
        {
            var dictionary = new Dictionary<string, Tuple<ulong, uint>>
            {
                { "week", new Tuple<ulong, uint>(7* 24 * 60 * 60 * 1000, int.MaxValue) },
                { "day", new Tuple<ulong, uint>(24 * 60 * 60 * 1000, 7) },
                { "hour", new Tuple<ulong, uint>(60 * 60 * 1000, 24) },
                { "minute", new Tuple<ulong, uint>(60 * 1000, 60) },
                { "second", new Tuple<ulong, uint>(1000, 60) },
                { "millisecond", new Tuple<ulong, uint>(1, 1000) }
            };

            var stringArray = dictionary
                .Select(item =>
                    ((milliseconds / item.Value.Item1) % item.Value.Item2) > 0
                    ? $"{((milliseconds / item.Value.Item1) % item.Value.Item2)} {item.Key}{(((milliseconds / item.Value.Item1) % item.Value.Item2) > 1 ? "s" : string.Empty)}"
                    : string.Empty)
                .Where(x => !string.IsNullOrEmpty(x))
                .ToArray();

            return stringArray.Length > 0
                ? string.Join(", ", stringArray)
                : "0 millisecond";
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var actual = Date.FormatDuration(34325055574ul); # "56 weeks, 5 days, 6 hours, 44 minutes, 15 seconds, 574 milliseconds"
```

</details>

<br>[↑ Back to top](#table-of-contents)

### getColonTimeFromDate

Returns a string of the form `HH:MM:SS` from a `DateTime` or `TimeSpan` object.

```c#
namespace Conplement.Snippets.Date
{
    public static partial class Date
    {
        public static string GetColonTimeFromDate(this DateTime dateTime)
        {
            return $"{dateTime.Hour.ToString("D2")}:{dateTime.Minute.ToString("D2")}:{dateTime.Second.ToString("D2")}";
        }

        public static string GetColonTimeFromDate(this TimeSpan timeSpan)
        {
            return $"{timeSpan.Hours.ToString("D2")}:{timeSpan.Minutes.ToString("D2")}:{timeSpan.Seconds.ToString("D2")}";
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
new DateTime(2018, 11, 22, 17, 53, 23).GetColonTimeFromDate() # 17:53:23
new DateTime(1990, 1, 2, 3, 41, 5).GetColonTimeFromDate() # 03:41:05
new TimeSpan(1, 33, 7).GetColonTimeFromDate() # 01:33:07
```

</details>

<br>[↑ Back to top](#table-of-contents)

### getDaysDiffBetweenDates

Returns the difference (in days) between two dates.

``` c#
using System;

namespace Conplement.Snippets.Date
{
    public static partial class Date
    {
        public static double GetDaysDiffBetweenDates(DateTime dateTime1, DateTime dateTime2)
        {
            if (dateTime1.Kind != dateTime2.Kind)
            {
                throw new ArgumentException($"The DateTime values have to be in the same timezone! {nameof(dateTime1)} uses {dateTime1.Kind}, while {nameof(dateTime2)} uses {dateTime2.Kind}!");
            }

            return (dateTime1 - dateTime2).TotalDays;
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
Date.GetDaysDiffBetweenDates(new DateTime(2018, 11, 22), new DateTime(2018, 11, 14)); # 8.0
```

</details>

<br>[↑ Back to top](#table-of-contents)

### getMeridiumSuffixOfInteger

Converts an integer to a suffixed string, adding `am` or `pm` based on its value.

``` c#
using System;

namespace Conplement.Snippets.Date
{
    public static partial class Date
    {
        public static string GetMeridiemSuffixOfInteger(this int value)
        {
            if (value < 0 || value > 24)
            {
                throw new ArgumentOutOfRangeException($"Invalid value {value} in method {nameof(GetMeridiemSuffixOfInteger)}", nameof(value));
            }

            return value == 0 || value == 24
                ? "12am" : value == 12
                    ? "12pm" : value < 12
                        ? $"{value % 12}am" : $"{value % 12}pm";
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
0.GetMeridiemSuffixOfInteger(); # 12am
11.GetMeridiemSuffixOfInteger(); # 11am
13.GetMeridiemSuffixOfInteger(); # 1pm
18.GetMeridiemSuffixOfInteger(); # 6pm
24.GetMeridiemSuffixOfInteger(); # 12am
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isAfterDate

Check if a date is after another date.

``` c#
using System;

namespace Conplement.Snippets.Date
{
    public static partial class Date
    {
        public static bool IsAfterDate(this DateTime dateTime1, DateTime dateTime2)
        {
            if (dateTime1.Kind != dateTime2.Kind)
            {
                throw new ArgumentException($"The DateTime values have to be in the same timezone! {nameof(dateTime1)} uses {dateTime1.Kind}, while {nameof(dateTime2)} uses {dateTime2.Kind}!");
            }

            return dateTime1 > dateTime2;
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
DateTime(2018, 11, 21).IsAfterDate(new DateTime(2018, 11, 22)) # false
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isBeforeDate

Check if a date is before another date.

``` c#
using System;

namespace Conplement.Snippets.Date
{
    public static partial class Date
    {
        public static bool IsBeforeDate(this DateTime dateTime1, DateTime dateTime2)
        {
            if (dateTime1.Kind != dateTime2.Kind)
            {
                throw new ArgumentException($"The DateTime values have to be in the same timezone! {nameof(dateTime1)} uses {dateTime1.Kind}, while {nameof(dateTime2)} uses {dateTime2.Kind}!");
            }

            return dateTime1 < dateTime2;
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
DateTime(2018, 11, 21).IsBeforeDate(new DateTime(2018, 11, 22)) # true
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isSameDate

Check if a date is the same as another date.

```c#
namespace Conplement.Snippets.Date
{
    public static partial class Date
    {
        public static bool IsSameDate(this DateTime dateTime1, DateTime dateTime2)
        {
            return dateTime1 == dateTime2 && dateTime1.Kind == dateTime2.Kind;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var actual = new DateTime(2018, 11, 26).IsSameDate(new DateTime(2018, 11, 26)); # true
var actual = new DateTime(203940201L).IsSameDate(new DateTime(203940202L)); # false
```

</details>

<br>[↑ Back to top](#table-of-contents)

### maxDate

Returns the maximum of the given dates.

```c#
namespace Conplement.Snippets.Date
{
    public static partial class Date
    {
        public static DateTime MaxDate(params DateTime[] dateTimeList)
        {
            if (dateTimeList == null || !dateTimeList.Any())
            {
                throw new ArgumentException("The dateTimeList may not be empty!", nameof(dateTimeList));
            }

            if (!dateTimeList.All(x => dateTimeList.First().Kind == x.Kind))
            {
                throw new ArgumentException("All params have to have the same timezone!", nameof(dateTimeList));
            }

            return dateTimeList.Max();
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
DateTime[] list = { new DateTime(2018, 11, 27, 22, 2, 15), new DateTime(2018, 11, 27, 22, 2, 15), new DateTime(2018, 11, 27), new DateTime(2019) };
var actual = Date.MaxDate(list); # new DateTime(2019)
```

</details>

<br>[↑ Back to top](#table-of-contents)

### minDate

Returns the minimum of the given dates.

```c#
namespace Conplement.Snippets.Date
{
    public static partial class Date
    {
        public static DateTime MinDate(params DateTime[] dateTimeList)
        {
            if (dateTimeList == null || !dateTimeList.Any())
            {
                throw new ArgumentException("The dateTimeList may not be empty!", nameof(dateTimeList));
            }

            if (!dateTimeList.All(x => dateTimeList.First().Kind == x.Kind))
            {
                throw new ArgumentException("All params have to have the same timezone!", nameof(dateTimeList));
            }

            return dateTimeList.Min();
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
DateTime[] list = { new DateTime(2018, 11, 27, 22, 2, 15), new DateTime(2018, 11, 27, 22, 2, 15), new DateTime(2018, 11, 27), new DateTime(2018) };
var actual = Date.MinDate(list); # new DateTime(2018)
```

</details>

<br>[↑ Back to top](#table-of-contents)

### tomorrow

Returns tomorrow's date.

```c#
namespace Conplement.Snippets.Date
{
    public static partial class Date
    {
        public static DateTime Tomorrow(DateTimeKind dateTimeKind = DateTimeKind.Utc)
        {
            return (dateTimeKind == DateTimeKind.Local
                ? DateTime.Now
                : DateTime.UtcNow)
                + TimeSpan.FromDays(1);
            // Instead of TimeSpan you can also use https://github.com/conplementAG/FluentTimeSpan to add one day like tomorrow = DateTime.UtcNow + 1.Days()
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var actual = Date.Tomorrow(DateTimeKind.Local); # If today is 15.05.2019, it will return 16.05.2019
```

</details>

<br>[↑ Back to top](#table-of-contents)


---
 ## 📚 Enumerable

### allEqual

Check if all elements in an array are equal.

``` c#
using System;

namespace Conplement.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static bool AllEqual<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            var testList = enumerable.ToList();
            if (testList.Count <= 1)
            {
                return true;
            }

            var compareObject = testList[0];
            for (int index = 0; index < testList.Count; index++)
            {
                var entry = testList[index];
                if ((entry == null || !entry.Equals(compareObject))
                    && !(entry == null && compareObject == null))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
new double[] { 1.25, 1.25, 1.5, -1.5 }.AllEqual(); # false
```

</details>

<br>[↑ Back to top](#table-of-contents)

### arrayToCsv

Converts a 2D array to a comma-separated values (CSV) string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### bifurcate

Splits values into two groups. If an element in `filter` is truthy, the corresponding element in the collection belongs to the first group; otherwise, it belongs to the second group.

``` c#
using System;

namespace Conplement.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static (IEnumerable<T>, IEnumerable<T>) Bifurcate<T>(this IEnumerable<T> list, Func<T, bool> filter)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            IEnumerable<T> enumerable1 = list.Where(filter);
            IEnumerable<T> enumerable2 = list.Where(x => !enumerable1.Any(y => y.Equals(x)));

            return (enumerable1, enumerable2);
        }
    }
}
```

<details>
<summary>Examples</summary>

``` c#
var list = new List<int>
{
    1, 2, 3, 4, 1
};
(IEnumerable<int> actual1, IEnumerable<int> actual2) = list.Bifurcate(x => x > 1); # actual1 has three entries (2, 3, 4), actual2 has two entries (1, 1)
```

</details>

<br>[↑ Back to top](#table-of-contents)

### bubbleSort

bubbleSort uses the technique of comparing and swapping

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### chunk

Chunks an array into smaller arrays of a specified size.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### compact

Removes invalid values from an array.

```c#
namespace Conplement.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> Compact<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (!enumerable.Any())
            {
                yield break; ;
            }

            foreach (var element in enumerable)
            {

                switch (element)
                {
                    case string y:
                        if (string.IsNullOrEmpty(y))
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case bool y:
                        if (!y)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                    case byte y:
                        if (y == 0)
                        {
                            continue;
                        }
                        yield return element;
                        break;
						
						// ... more definitions necessary, Please have a look into the code
						
                    default:
                        if (element == null)
                        {
                            continue;
                        }
                        yield return element;
                        break;
                }
            }
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var enumerable = new List<object> { new object(), null, new object(), new object(), null, false, true, 1, 0, "Hello", "", "World" }.Compact(); # List with seven entries: new List<object> { new object(), new object(), new object(), true, 1, "Hello", "World" };
```

</details>

<br>[↑ Back to top](#table-of-contents)

### countBy

Groups the elements of an array based on the given function and returns the count of elements in each group.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### countOccurrences

Counts the occurrences of a value in an array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### deepFlatten

Deep flattens an array of arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### difference

Returns the difference between two arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### differenceBy

Returns the difference between two arrays, after applying the provided function to each array element of both.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### differenceWith

Filters out all values from an array for which the comparator function does not return `true`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### drop

Returns a new array with `n` elements removed from the left.

```c#
namespace Conplement.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> Drop<T>(this IEnumerable<T> enumerable, uint dropCount)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (enumerable.Count() < dropCount)
            {
                throw new ArgumentOutOfRangeException(nameof(enumerable));
            }

            return enumerable.Skip((int)dropCount);
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var enumerable = new bool[] { false, false, true, true }.Drop(3); # List with one entry: true
```

</details>

<br>[↑ Back to top](#table-of-contents)

### dropRight

Returns a new array with `n` elements removed from the right.

```c#
namespace Conplement.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> Drop<T>(this IEnumerable<T> enumerable, uint dropCount)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (enumerable.Count() < dropCount)
            {
                throw new ArgumentOutOfRangeException(nameof(enumerable));
            }

            return enumerable.Take(enumerable.Count() - (int)dropCount);
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var enumerable = new bool[] { false, false, true, true }.DropRight(3); # List with one entry: false
```

</details>

<br>[↑ Back to top](#table-of-contents)

### dropRightWhile

Removes elements from the end of an array until the passed function returns `true`. Returns the remaining elements in the array.

```c#
namespace Conplement.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> DropRightWhile<T>(this IEnumerable<T> enumerable, Func<T, bool> filter)
        {
            if (enumerable == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            var reachedDropPoint = false;

            for (var index = enumerable.Count() - 1; index >= 0; index--)
            {
                var element = enumerable.ElementAt(index);

                if (!reachedDropPoint && !filter(element))
                {
                    continue;
                }

                reachedDropPoint = true;

                yield return element;
            }

            yield break;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var enumerable = new int[] { 1, 2, 3, 4, 1 }.DropRightWhile(x => x > 2); # List with four entries: new List<int> { 1, 2, 3, 4 }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### dropWhile

Removes elements in an array until the passed function returns `true`. Returns the remaining elements in the array.

```c#
namespace Conplement.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static IEnumerable<T> DropWhile<T>(this IEnumerable<T> list, Func<T, bool> filter)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }

            var reachedDropPoint = false;

            foreach (var element in list)
            {
                if (!reachedDropPoint && !filter(element))
                {
                    continue;
                }

                reachedDropPoint = true;

                yield return element;
            }

            yield break;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
new List<int>{ 1, 2, 3, 4, 1}.DropWhile(x => x => x > 2); # new List<int> { 3, 4, 1 }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### everyNth

Returns every nth element in an array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### filterNonUnique

Filters out the non-unique values in an array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### filterNonUniqueBy

Filters out the non-unique values in an array, based on a provided comparator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### findLast

Returns the last element for which the provided function returns a truthy value.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### findLastIndex

Returns the index of the last element for which the provided function returns a truthy value.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### flatten

Flattens an array up to the specified depth.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### forEachRight

Executes a provided function once for each array element, starting from the array's last element.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### groupBy

Groups the elements of an array based on the given function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### hasDuplicates

Checks an array for duplicate values. Returns true if duplicate values exist and false if values are all unique.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### head

Returns the head of a list.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### indexOfAll

Returns all indices of a `value` in an array.
If the `value` never occurs, returns `[]`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### initial

Returns all the elements of an array except the last one.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### initialize2DArray

Initializes a 2D array of given width and height and value.

```c#
namespace Conplement.Snippets.Enumerable
{
    public static partial class Enumerable
    {
        public static T[,] Initialize2DArray<T>(uint width, uint height, T defaultValue = default(T))
        {
            if (width == 0)
            {
                throw new ArgumentException($"Minimum {nameof(width)} has to be 1", nameof(width));
            }

            if (height == 0)
            {
                throw new ArgumentException($"Minimum {nameof(height)} has to be 1", nameof(height));
            }

            var newArray = new T[width, height];

            for (int widthIndex = 0; widthIndex < width; widthIndex++)
            {
                for (int heightIndex = 0; heightIndex < height; heightIndex++)
                {
                    newArray[widthIndex, heightIndex] = defaultValue;
                }
            }

            return newArray;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
Enumerable.Initialize2DArray(2, 2, 0) # new int[2, 2] { { 0, 0 }, { 0, 0 } }
```

</details>

<br>[↑ Back to top](#table-of-contents)

### initializeArrayWithRange

Initializes an array containing the numbers in the specified range where `start` and `end` are inclusive with their common difference `step`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### initializeArrayWithRangeRight

Initializes an array containing the numbers in the specified range (in reverse) where `start` and `end` are inclusive with their common difference `step`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### initializeArrayWithValues

Initializes and fills an array with the specified values.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### initializeNDArray

Create a n-dimensional array with given value.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### intersection

Returns a list of elements that exist in both arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### intersectionBy

Returns a list of elements that exist in both arrays, after applying the provided function to each array element of both.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### intersectionWith

Returns a list of elements that exist in both arrays, using a provided comparator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isSorted

Returns `1` if the array is sorted in ascending order, `-1` if it is sorted in descending order or `0` if it is not sorted.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### join

Joins all elements of an array into a string and returns this string.
Uses a separator and an end separator.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### jsonToCsv ![advanced](/advanced.svg)

Converts an array of objects to a comma-separated values (CSV) string that contains only the `columns` specified.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### last

Returns the last element in an array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### longestItem

Takes any number of iterable objects or objects with a `length` property and returns the longest one.
If multiple objects have the same length, the first one will be returned.
Returns `-1` if no arguments are provided.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### maxN

Returns the `n` maximum elements from the provided array.
If `n` is greater than or equal to the provided array's length, then return the original array (sorted in descending order).

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### minN

Returns the `n` minimum elements from the provided array.
If `n` is greater than or equal to the provided array's length, then return the original array (sorted in ascending order).

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### none

Returns `true` if the provided predicate function returns `false` for all elements in a collection, `false` otherwise.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### nthElement

Returns the nth element of an array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### offset

Moves the specified amount of elements to the end of the array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### orderBy

Sorts a collection of arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### partition

Groups the elements into two arrays, depending on the provided function's truthiness for each element.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### permutations ![advanced](/advanced.svg)

⚠️ **WARNING**: This function's execution time increases exponentially with each array element.

Generates all permutations of an array's elements (contains duplicates).

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pluck

Retrieves all of the values for a given key.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pull

Mutates the original array to filter out the values specified.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pullAtIndex ![advanced](/advanced.svg)

Mutates the original array to filter out the values at the specified indexes.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pullAtValue ![advanced](/advanced.svg)

Mutates the original array to filter out the values specified. Returns the removed elements.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pullBy ![advanced](/advanced.svg)

Mutates the original array to filter out the values specified, based on a given iterator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### reduceFilter

Filter an array of objects based on a condition while also filtering out unspecified keys.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### reduceSuccessive

Applies a function against an accumulator and each element in the array (from left to right), returning an array of successively reduced values.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### reduceWhich

Returns the minimum/maximum value of an array, after applying the provided function to set comparing rule.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### reject

Takes a predicate and array, like `Array.prototype.filter()`, but only keeps `x` if `pred(x) === false`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### remove

Removes elements from an array for which the given function returns `false`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sample

Returns a random element from an array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sampleSize

Gets `n` random elements at unique keys from `array` up to the size of `array`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### shank

This method changes the contents of an array by removing existing elements and/or adding new elements.
Similar to the JavaScript version [`Array.prototype.splice()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/splice)

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### shuffle

Randomizes the order of the values of an array, returning a new array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### similarity

Returns an array of elements that appear in both arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sortedIndex

Returns the lowest index at which value should be inserted into array in order to maintain its sort order.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sortedIndexBy

Returns the lowest index at which value should be inserted into array in order to maintain its sort order, based on a provided iterator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sortedLastIndex

Returns the highest index at which value should be inserted into array in order to maintain its sort order.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sortedLastIndexBy

Returns the highest index at which value should be inserted into array in order to maintain its sort order, based on a provided iterator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### stableSort ![advanced](/advanced.svg)

Performs stable sorting of an array, preserving the initial indexes of items when their values are the same.
Does not mutate the original array, but returns a new array instead.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### symmetricDifference

Returns the symmetric difference between two arrays, without filtering out duplicate values.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### symmetricDifferenceBy

Returns the symmetric difference between two arrays, after applying the provided function to each array element of both.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### symmetricDifferenceWith

Returns the symmetric difference between two arrays, using a provided function as a comparator.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### tail

Returns all elements in an array except for the first one.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### take

Returns an array with n elements removed from the beginning.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### takeRight

Returns an array with n elements removed from the end.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### takeRightWhile

Removes elements from the end of an array until the passed function returns `true`. Returns the removed elements.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### takeWhile

Removes elements in an array until the passed function returns `true`. Returns the removed elements.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### toHash

Reduces a given Array-like into a value hash (keyed data store).

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### union

Returns every element that exists in any of the two arrays once.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### unionBy

Returns every element that exists in any of the two arrays once, after applying the provided function to each array element of both.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### unionWith

Returns every element that exists in any of the two arrays once, using a provided comparator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### uniqueElements

Returns all unique values of an array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### uniqueElementsBy

Returns all unique values of an array, based on a provided comparator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### uniqueElementsByRight

Returns all unique values of an array, based on a provided comparator function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### uniqueSymmetricDifference

Returns the unique symmetric difference between two arrays, not containing duplicate values from either array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### without

Filters out the elements of an array, that have one of the specified values.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### xProd

Creates a new array out of the two supplied by creating each possible pair from the arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)


---
 ## ➗ Math

### approximatelyEqual

Checks if two numbers are approximately equal to each other.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### average

Returns the average of two or more numbers.

The method excepts numbers as params and returns the average as a result

Linq documentation
https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum?view=netframework-4.7.2

```c#
namespace Conplement.Snippets.Math
{
    public static partial class Math
    {
        public static double Average(this uint[] elements)
        {
            if (elements.Length == 0) return 0;
            return elements.Aggregate(0.0, (current, element) => current + element) / elements.Length;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
{ 4, 5, 9, 1, 0 }.Average() # 3.8
```

</details>

<br>[↑ Back to top](#table-of-contents)

### averageBy

Returns the average of an array, after mapping each element to a value using the provided function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### binomialCoefficient

Evaluates the binomial coefficient of two integers `n` and `k`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### degreesToRads

Converts an angle from degrees to radians.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### digitize

Converts a number to an array of digits.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### distance

Returns the distance between two points.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### factorial

Calculates the factorial of a number.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### fibonacci

Generates an array, containing the Fibonacci sequence, up until the nth term.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### gcd

Calculates the greatest common divisor between two or more numbers/arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### geometricProgression

Initializes an array containing the numbers in the specified range where `start` and `end` are inclusive and the ratio between two terms is `step`.
Returns an error if `step` equals `1`.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### inRange

Checks if the given number falls within the given range.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isDivisible

Checks if the first numeric argument is divisible by the second one.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isEven

Returns `true` if the given number is even, `false` otherwise.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isPrime

Checks if the provided integer is a prime number.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isOdd

Returns `true` if the given number is odd, `false` otherwise.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### lcm

Returns the least common multiple of two or more numbers.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### luhnCheck ![advanced](/advanced.svg)

Implementation of the [Luhn Algorithm](https://en.wikipedia.org/wiki/Luhn_algorithm) used to validate a variety of identification numbers, such as credit card numbers, IMEI numbers, National Provider Identifier numbers etc.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### max

Returns the maximum value from the  provided enumerable.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### median

Returns the median of an array of numbers.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### min

Returns the minimum value from the  provided enumerable.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### primes

Generates primes up to a given number, using the Sieve of Eratosthenes.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### radsToDegrees

Converts an angle from radians to degrees.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### randomIntArrayInRange

Returns an array of n random integers in the specified range.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### randomIntegerInRange

Returns a random integer in the specified range.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### randomNumberInRange

Returns a random number in the specified range.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### round

Rounds a number to a specified amount of digits.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sdbm

Hashes the input string into a whole number.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### standardDeviation

Returns the standard deviation of an array of numbers.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sum

Returns the sum of two or more numbers/arrays.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sumBy

Returns the sum of an array, after mapping each element to a value using the provided function.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)


---
 ## 🎛️ Method

### hz

Returns the number of times a function executed per second. 
`hz` is the unit for `hertz`, the unit of frequency defined as one cycle per second.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### times

Iterates over a callback `n` times

```c#
namespace Conplement.Snippets.Method
{
    public static partial class Method
    {
        public static IList<T1> Times<T1>(Func<T1> func, uint times)
        {
            var list = new List<T1>();

            for (var index = 0; index < times; index++)
            {
                list.Add(func());
            }

            return list;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
Method.Times((() => true), 3) # list of size 3, all values true
Method.Times(((int start, int end) => new Random().Next(start, end)), 6, 0, 100) # list of size 6 with 6 random integers between 0 and 100
```

</details>

<br>[↑ Back to top](#table-of-contents)


---
 ## 📜 String

### byteSize

Returns the length of a string in bytes.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### capitalize

Capitalizes the first letter of a string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### capitalizeEveryWord

Capitalizes the first letter of every word in a string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### countVowels

Returns number of vowels in provided string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### csvToArray

Converts a comma-separated values (CSV) string to a 2D array.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### csvToJson ![advanced](/advanced.svg)

Converts a comma-separated values (CSV) string to a 2D array of objects.
The first row of the string is used as the title row.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### decapitalize

Decapitalizes the first letter of a string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### endsWithRegex

Check if a string is ends with a given substring using a regex

The method excepts the string to test and a regex

Most other checks are already integrated into C#
https://docs.microsoft.com/en-us/dotnet/api/system.string.endswith?view=netframework-4.7.2

```c#
namespace Conplement.Snippets.String
{
    public static partial class String
    {
        public static bool EndsWithRegex(this string input, Regex regex)
        {
            return regex.IsMatch(input);
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
"Hello World".EndsWithRegex(new Regex(@"[dolrwDOLRW]{5}$")) # true
```

</details>

<br>[↑ Back to top](#table-of-contents)

### escapeHtml

Escapes a string for use in HTML.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### escapeRegExp

Escapes a string to use in a regular expression.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### fromCamelCase

Converts a string from camelcase.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### indentString

Indents each line in the provided string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isAbsoluteUrl

Returns `true` if the given string is an absolute URL, `false` otherwise.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isAnagram

Checks if a string is an anagram of another string (case-insensitive, ignores spaces, punctuation and special characters).

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isLowerCase

Checks if a string is lower case.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isUpperCase

Checks if a string is upper case.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### mask

Replaces all but the last `num` of characters with the specified mask character.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pad

Pads a string on both sides with the specified character, if it's shorter than the specified length.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### palindrome

Returns `true` if the given string is a palindrome, `false` otherwise.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### pluralize

Returns the singular or plural form of the word based on the input number. If the first argument is an `object`, it will use a closure by returning a function that can auto-pluralize words that don't simply end in `s` if the supplied dictionary contains the word.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### removeNonAscii

Removes non-printable ASCII characters.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### reverseString

Reverses a string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### sortCharactersInString

Alphabetically sorts the characters in a string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### splitLines

Splits a multiline string into an array of lines.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### startsWithRegex

Check if a string starts with a given regex.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### stringPermutations ![advanced](/advanced.svg)

⚠️ **WARNING**: This function's execution time increases exponentially with each character.

Generates all permutations of a string (contains duplicates).

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### stripHtmlTags

Removes HTML/XML tags from string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### toCamelCase

Converts a string to camelcase.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### toKebabCase

Converts a string to kebab case.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### toSnakeCase

Converts a string to snake case.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### toTitleCase

Converts a string to title case.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### truncateString

Truncates a string up to a specified length.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### unescapeHTML

Unescapes escaped HTML characters.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### urlJoin ![advanced](/advanced.svg)

Joins all given URL segments together, then normalizes the resulting URL

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### words

Converts a given string into an array of words.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)


---
 ## 📃️ Type

### is

Checks if the provided value is of the specified type.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### isValidJson

Checks if the provided argument is a valid JSON.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)


---
 ## 🔧 Utility

### coalesce

Returns the first non-null argument.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### extendHex

Extends a 3-digit color code to a 6-digit color code.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### getUrlParameters

Returns an object containing the parameters of the current URL.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### hexToRgb ![advanced](/advanced.svg)

Converts a color code to a `rgb()` or `rgba()` string if alpha value is provided.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### mostPerformant

Returns the index of the function in an array of functions which executed the fastest.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### prettyBytes ![advanced](/advanced.svg)

Converts a number in bytes to a human-readable string.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### randomHexColorCode

Generates a random hexadecimal color code.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### rgbToHex

Converts the values of RGB components to a color code.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### timeTaken

Measures the time taken by a function to execute.

Stopwatch documentation
https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.stopwatch?redirectedfrom=MSDN&view=netframework-4.7.2

```c#
namespace Conplement.Snippets.Utility
{
    public static partial class Utility
    {
        public static (long, T1) TimeTaken<T1>(Func<T1> func)
        {
            var watch = Stopwatch.StartNew();
            T1 result = func.Invoke();
            watch.Stop();
            return (watch.ElapsedMilliseconds, result);
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
Utility.TimeTaken(() => true) # 13.37ms, true
```

</details>

<br>[↑ Back to top](#table-of-contents)

### toOrdinalSuffix

Adds an ordinal suffix to a number.

```c#
// TODO
```

<details>
<summary>Examples</summary>

```c#
// TODO
```

</details>

<br>[↑ Back to top](#table-of-contents)

### yesNo

Returns `true` if the string is `y`/`yes` or `false` if the string is `n`/`no`.

```c#
namespace Conplement.Snippets.Utility
{
    public static partial class Utility
    {
        public static bool YesNo(this string test, bool defaultVal = false)
        {
            return new Regex(@"^(y|yes)$", RegexOptions.IgnoreCase).IsMatch(test)
                ? true
                : new Regex(@"^(n|no)$", RegexOptions.IgnoreCase).IsMatch(test)
                    ? false
                    : defaultVal;
        }
    }
}
```

<details>
<summary>Examples</summary>

```c#
var empty = "".YesNo(); # false
var yes = "yes".YesNo(); # true
var y = "y".YesNo(); # true
var NO = "NO".YesNo(); # false
var nO = "nO".YesNo(); # false
```

</details>

<br>[↑ Back to top](#table-of-contents)



## Contribute

You're always welcome to contribute to this project. Please read the [contribution guide](CONTRIBUTING.md).

## License

This project is licensed under the MIT License - see the [License File](LICENSE.md) for details
