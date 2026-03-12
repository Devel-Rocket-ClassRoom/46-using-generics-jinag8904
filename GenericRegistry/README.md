# GenericRegistry

## 문제

**제네릭 레지스트리 클래스**를 구현하세요.

키-값 쌍을 저장하고 관리하는 제네릭 클래스를 배열 기반으로 구현합니다. 
키 타입에는 `IEquatable<TKey>` 제약조건을 적용하여 키 비교가 가능하도록 합니다.

**구현 요구사항**

- `Registry<TKey, TValue>` 클래스 구현
- `TKey`에 `where TKey : IEquatable<TKey>` 제약조건 적용
- 내부적으로 키 배열(`TKey[]`)과 값 배열(`TValue[]`), `_count` 필드로 관리
- 생성자: 최대 용량(capacity)을 매개변수로 받아 내부 배열 생성
- `Register(TKey key, TValue value)`: 키-값 등록 (이미 존재하는 키면 값 덮어쓰기)
- `Find(TKey key)`: 키로 값 검색, 없으면 `default(TValue)` 반환
- `Contains(TKey key)`: 키 존재 여부 반환
- `Count` 프로퍼티: 현재 등록된 항목 수 반환
- `PrintAll()`: 전체 항목을 `[키] 값` 형식으로 출력

**테스트 코드**

```csharp
// 게임 점수 레지스트리
var scoreBoard = new Registry<string, int>(10);

// 점수 등록
scoreBoard.Register("철수", 1500);
scoreBoard.Register("영희", 2300);
scoreBoard.Register("민수", 1800);

Console.WriteLine("=== 점수 등록 완료 ===");
Console.WriteLine($"등록된 플레이어 수: {scoreBoard.Count}");
scoreBoard.PrintAll();

// 점수 조회
Console.WriteLine($"\n영희의 점수: {scoreBoard.Find("영희")}");
Console.WriteLine($"철수의 점수: {scoreBoard.Find("철수")}");

// 존재하지 않는 키 조회
Console.WriteLine($"존재하지 않는 키 조회: {scoreBoard.Find("길동")}");

// 키 존재 여부 확인
Console.WriteLine($"\n영희 존재 여부: {scoreBoard.Contains("영희")}");
Console.WriteLine($"길동 존재 여부: {scoreBoard.Contains("길동")}");

// 점수 갱신 (덮어쓰기)
scoreBoard.Register("철수", 2000);
Console.WriteLine($"\n철수 점수 갱신 후: {scoreBoard.Find("철수")}");
Console.WriteLine($"등록된 플레이어 수: {scoreBoard.Count}");
```

## 예상 실행 결과

```
=== 점수 등록 완료 ===
등록된 플레이어 수: 3
[철수] 1500
[영희] 2300
[민수] 1800

영희의 점수: 2300
철수의 점수: 1500

존재하지 않는 키 조회: 0

영희 존재 여부: True
길동 존재 여부: False

철수 점수 갱신 후: 2000
등록된 플레이어 수: 3
```
