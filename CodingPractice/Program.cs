using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

// 1.
{
    Stack stack = new();
    stack.Push(100);
    stack.Push(200);

    Console.WriteLine((int)stack.Pop());
    Console.WriteLine((int)stack.Pop());
}
Console.WriteLine();

// 2.
{
    Stack<int> stack = new();
    stack.Push(100);
    stack.Push(200);

    Console.WriteLine(stack.Pop());
    Console.WriteLine(stack.Pop());
}
Console.WriteLine();

// 3.
{
    Cup<string> cupS = new();
    Cup<int> cupI = new();

    cupS.Value = "커피";
    cupI.Value = 500;

    Console.WriteLine($"{cupS.Value}, {cupI.Value}");
}
Console.WriteLine();

// 4.
{
    Pair<string, int> hero = new("용사", 100);
    Pair<int, double> score = new(1, 95.5);

    Console.WriteLine($"{hero.First}, {hero.Second}");
    Console.WriteLine($"{score.First}, {score.Second}");
}
Console.WriteLine();

// 5.
{
    int x = 10, y = 20;
    Console.WriteLine($"교환 전: x={x}, y={y}");

    Swap(ref x, ref y);
    Console.WriteLine($"교환 후: x={x}, y={y}");

    string first = "사과", second = "바나나";
    Console.WriteLine($"교환 전: first={first}, second={second}");

    Swap(ref first, ref second);
    Console.WriteLine($"교환 후: first={first}, second={second}");

    void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
Console.WriteLine();

// 6.
{
    NumberContainer<int> number1 = new() { Value = 100 } ;
    NumberContainer<double> number2 = new() { Value = 3.14 };

    Console.WriteLine($"{number1.Value}, {number2.Value}");
}
Console.WriteLine();

// 7.
{
    Monster monster = CreateInstance<Monster>();
    Console.WriteLine($"생성된 몬스터: {monster.Name}, HP: {monster.HP}");

    T CreateInstance<T>() where T : new()
    {
        return new T();
    }
}
Console.WriteLine();

// 8.
{
    Console.WriteLine($"더 큰 정수: {GetMax(10, 25)}");
    Console.WriteLine($"사전 순 뒤: {GetMax("apple", "banana")}");

    T GetMax<T>(T a, T b) where T : IComparable<T>
    {
        return (a.CompareTo(b) > 0) ? a : b;
    }
}
Console.WriteLine();

// 9.
{
    Console.WriteLine($"int 기본값: {GetDefaultValue<int>()}");
    Console.WriteLine($"bool 기본값: {GetDefaultValue<bool>()}");
    Console.WriteLine($"string 기본값: {GetDefaultValue<string>() ?? "null"}");

    T GetDefaultValue<T>()
    {
        return default(T);
    }
}
Console.WriteLine();

// 10.
{
    List<string> names = new() { "철수", "영희", "민수" };
    Dictionary<string, int> nameScore = new()
    {
        { "철수", 95 },
        { "영희", 88 },
        { "민수", 92 }
    };

    Console.WriteLine("이름 목록: ");
    foreach (string name in names)
    {
        Console.WriteLine($"- {name}");
    }
    Console.WriteLine();

    Console.WriteLine("점수: ");
    foreach (var pair in nameScore)
    {
        Console.WriteLine($"{pair.Key}: {pair.Value}점");
    }
}
Console.WriteLine();

// 11.
{
    SpecialContainer<string> special = new() { Item = "특별한 아이템", Description = "레어 등급" };
    IntContainer price = new() { Item = 50 };

    Console.WriteLine($"{special.Item} ({special.Description})");
    Console.WriteLine($"값: {price.Item}, 두 배: {price.Double()}");
}
Console.WriteLine();

// 12.
{
    Counter<int>.Count = 2;
    Counter<string>.Count = "1";

    Console.WriteLine($"Counter<int>.Count: {Counter<int>.Count}");
    Console.WriteLine($"Counter<string>.Count: {Counter<string>.Count}");
}
Console.WriteLine();

// 12.
class Counter<T>
{
    public static T Count;
}

// 11.
class Container<T>
{
    public T Item { get; set; }
}

class SpecialContainer<T> : Container<T>
{
    public string Description { get; set; }
}

class IntContainer : Container<int>
{
    public int Double() => Item * 2;
}

// 7.
class Monster
{
    public string Name { get; set; } = "슬라임";
    public int HP { get; set; } = 50;
}

// 6.
class NumberContainer<T> where T : struct
{
    public T Value { get; set; }
}

// 4.
class Pair<TFirst, TSecond>
{
    public TFirst First { get; set; }
    public TSecond Second { get; set; }

    public Pair(TFirst first, TSecond second)
    {
        First = first;
        Second = second;
    }
}

// 3.
class Cup<T>
{
    public T Value { get; set; }
}