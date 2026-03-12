# 제네릭 스택 클래스

**제네릭 스택 클래스**를 구현하세요.

배열을 사용하여 간단한 스택 자료구조를 제네릭으로 구현합니다. 
스택은 LIFO(Last In First Out) 방식으로 동작하며, 마지막에 넣은 데이터가 먼저 나옵니다.

**구현 요구사항**

- `MyStack<T>` 클래스 구현
- 생성자: 용량(capacity)을 매개변수로 받아 내부 배열 생성
- `Push(T item)`: 스택에 요소 추가
- `Pop()`: 스택에서 요소 제거 후 반환
- `Peek()`: 스택의 최상단 요소를 제거하지 않고 반환
- `Count` 프로퍼티: 현재 저장된 요소 개수 반환
- `IsEmpty` 프로퍼티: 스택이 비었는지 확인

**테스트 코드**

```csharp
// 정수 스택 테스트
var intStack = new MyStack<int>(5);
intStack.Push(10);
intStack.Push(20);
intStack.Push(30);

Console.WriteLine("=== 정수 스택 테스트 ===");
Console.WriteLine($"Count: {intStack.Count}");
Console.WriteLine($"Peek: {intStack.Peek()}");
Console.WriteLine($"Pop: {intStack.Pop()}");
Console.WriteLine($"Pop: {intStack.Pop()}");
Console.WriteLine($"Count: {intStack.Count}");

// 문자열 스택 테스트
var stringStack = new MyStack<string>(5);
stringStack.Push("첫번째");
stringStack.Push("두번째");
stringStack.Push("세번째");

Console.WriteLine("\n=== 문자열 스택 테스트 ===");
Console.WriteLine($"Count: {stringStack.Count}");
Console.WriteLine($"Peek: {stringStack.Peek()}");
Console.WriteLine($"Pop: {stringStack.Pop()}");
Console.WriteLine($"IsEmpty: {stringStack.IsEmpty}");
```

## 예상 실행 결과

```
=== 정수 스택 테스트 ===
Count: 3
Peek: 30
Pop: 30
Pop: 20
Count: 1

=== 문자열 스택 테스트 ===
Count: 3
Peek: 세번째
Pop: 세번째
IsEmpty: False
```
