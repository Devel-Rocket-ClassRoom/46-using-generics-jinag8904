# 코딩 연습 - 제네릭 사용하기

`Program.cs`에 아래 과제들의 코드를 순서대로 작성하세요.
모든 과제를 작성한 후 실행하면 각 과제의 실행 결과가 순서대로 출력됩니다.

> 💡 변수 이름이 겹치는 경우 중괄호 `{ }`로 코드를 감싸면 각 블록에서 같은 이름을 사용할 수 있습니다.

---

## 1. 제네릭 사용 전 (object 기반)

`using System.Collections;`를 추가하고, 비제네릭 `Stack`에 정수 두 개를 Push한 후 
`(int)` 형변환으로 Pop하여 출력하세요.

**실행 결과**

```
값1: 200, 값2: 100
```

---

## 2. 제네릭 사용 후

`using System.Collections.Generic;`를 추가하고, `Stack<int>`에 정수 두 개를 Push한 후 형변환 없이 Pop하여 출력하세요.

**실행 결과**

```
값1: 200, 값2: 100
```

---

## 3. 제네릭 클래스 만들기 - Cup\<T\>

제네릭 클래스 `Cup<T>`를 정의하고, `Cup<string>`과 `Cup<int>`를 각각 생성하여 
값을 저장하고 출력하세요.

**실행 결과**

```
음료: 커피
용량: 500ml
```

---

## 4. 두 개의 타입 매개변수 - Pair\<TFirst, TSecond\>

두 개의 타입 매개변수를 가진 `Pair<TFirst, TSecond>` 클래스를 정의하고, 
`Pair<string, int>`와 `Pair<int, double>`을 생성하여 출력하세요.

**실행 결과**

```
이름: 용사, HP: 100
순위: 1등, 점수: 95.5점
```

---

## 5. 제네릭 메서드 - Swap\<T\>

두 변수의 값을 교환하는 제네릭 로컬 함수 `Swap<T>`를 작성하고, 
int와 string 타입으로 각각 테스트하세요.

**실행 결과**

```
교환 전: x=10, y=20
교환 후: x=20, y=10
교환 전: first=사과, second=바나나
교환 후: first=바나나, second=사과
```

---

## 6. 값 타입 제약조건

`where T : struct` 제약조건을 사용하여 값 타입만 허용하는 `NumberContainer<T>` 
클래스를 정의하고, int와 float로 테스트하세요.

**실행 결과**

```
정수값: 100
실수값: 3.14
```

---

## 7. new() 제약조건

`where T : new()` 제약조건을 사용하여 인스턴스를 생성하는 제네릭 로컬 함수 
`CreateInstance<T>`를 작성하세요. `Monster` 클래스를 정의하고 인스턴스를 생성하여 
출력하세요.

**실행 결과**

```
생성된 몬스터: 슬라임, HP: 50
```

---

## 8. 인터페이스 제약조건

`where T : IComparable<T>` 제약조건을 사용하여 두 값 중 큰 값을 반환하는 `GetMax<T>` 
로컬 함수를 작성하세요. int와 string으로 테스트하세요.

**실행 결과**

```
더 큰 정수: 25
사전순 뒤: banana
```

---

## 9. default 키워드

제네릭 타입의 기본값을 반환하는 `GetDefaultValue<T>` 로컬 함수를 작성하고, 
int, bool, string 타입의 기본값을 출력하세요. null인 경우 "(null)"로 표시하세요.

**실행 결과**

```
int 기본값: 0
bool 기본값: False
string 기본값: (null)
```

---

## 10. 제네릭 컬렉션

`List<string>`에 이름 3개를 추가하여 출력하고, `Dictionary<string, int>`에 
이름-점수 쌍 3개를 추가하여 출력하세요.

**실행 결과**

```
이름 목록:
  - 철수
  - 영희
  - 민수

점수:
  철수: 95점
  영희: 88점
  민수: 92점
```

---

## 11. 제네릭 상속

기반 제네릭 클래스 `Container<T>`를 정의하고, 타입 매개변수를 유지하는 
`SpecialContainer<T>`와 구체적 타입으로 고정하는 `IntContainer`를 각각 상속하여 구현하세요.

**실행 결과**

```
특별한 아이템 (레어 등급)
값: 50, 두 배: 100
```

---

## 12. 정적 멤버와 제네릭

정적 `Count` 필드를 가진 `Counter<T>` 클래스를 정의하고, `Counter<int>`와 
`Counter<string>`의 Count가 독립적임을 확인하세요.

**실행 결과**

```
Counter<int>.Count: 2
Counter<string>.Count: 1
```
