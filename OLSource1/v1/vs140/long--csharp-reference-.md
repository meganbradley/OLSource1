---
title: "long (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "long_CSharpKeyword"
  - "long"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "long keyword [C#]"
ms.assetid: f9b24319-1f39-48be-a42b-d528ee28a7fd
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# long (C# Reference)
The `long` keyword denotes an integral type that stores values according to the size and range shown in the following table.  
  
|Type|Range|Size|.NET Framework type|  
|----------|-----------|----------|-------------------------|  
|`long`|–9,223,372,036,854,775,808 to 9,223,372,036,854,775,807|Signed 64-bit integer|\<xref:System.Int64*?displayProperty=fullName>|  
  
## Literals  
 You can declare and initialize a `long` variable like this example:  
  
```  
  
long long1 = 4294967296;  
```  
  
 When an integer literal has no suffix, its type is the first of these types in which its value can be represented: [int](../vs140/int--csharp-reference-.md), [uint](../vs140/uint--csharp-reference-.md), `long`, [ulong](../vs140/ulong--csharp-reference-.md). In the preceding example, it is of the type `long` because it exceeds the range of [uint](../vs140/uint--csharp-reference-.md) (see [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md) for the storage sizes of integral types).  
  
 You can also use the suffix L with the `long` type like this:  
  
```  
  
long long2 = 4294967296L;  
```  
  
 When you use the suffix L, the type of the literal integer is determined to be either `long` or [ulong](../vs140/ulong--csharp-reference-.md) according to its size. In the case it is `long` because it less than the range of [ulong](../vs140/ulong--csharp-reference-.md).  
  
 A common use of the suffix is with calling overloaded methods. Consider, for example, the following overloaded methods that use `long` and [int](../vs140/int--csharp-reference-.md) parameters:  
  
```  
public static void SampleMethod(int i) {}  
public static void SampleMethod(long l) {}  
```  
  
 Using the suffix L guarantees that the correct type is called, for example:  
  
```  
SampleMethod(5);    // Calling the method with the int parameter  
SampleMethod(5L);   // Calling the method with the long parameter  
```  
  
 You can use the `long` type with other numeric integral types in the same expression, in which case the expression is evaluated as `long` (or [bool](../vs140/bool--csharp-reference-.md) in the case of relational or Boolean expressions). For example, the following expression evaluates as `long`:  
  
```  
898L + 88  
```  
  
> [!NOTE]
>  You can also use the lowercase letter "l" as a suffix. However, this generates a compiler warning because the letter "l" is easily confused with the digit "1." Use "L" for clarity.  
  
 For information on arithmetic expressions with mixed floating-point types and integral types, see [float](../vs140/float--csharp-reference-.md) and [double](../vs140/double--csharp-reference-.md).  
  
## Conversions  
 There is a predefined implicit conversion from `long` to [float](../vs140/float--csharp-reference-.md), [double](../vs140/double--csharp-reference-.md), or [decimal](../vs140/decimal--csharp-reference-.md). Otherwise a cast must be used. For example, the following statement will produce a compilation error without an explicit cast:  
  
```  
int x = 8L;        // Error: no implicit conversion from long to int  
int x = (int)8L;   // OK: explicit conversion to int  
```  
  
 There is a predefined implicit conversion from [sbyte](../vs140/sbyte--csharp-reference-.md), [byte](../vs140/byte--csharp-reference-.md), [short](../vs140/short--csharp-reference-.md), [ushort](../vs140/ushort--csharp-reference-.md), [int](../vs140/int--csharp-reference-.md), [uint](../vs140/uint--csharp-reference-.md), or [char](../vs140/char--csharp-reference-.md) to `long`.  
  
 Notice also that there is no implicit conversion from floating-point types to `long`. For example, the following statement generates a compiler error unless an explicit cast is used:  
  
```  
  
      long x = 3.0;         // Error: no implicit conversion from double  
long y = (long)3.0;   // OK: explicit conversion  
```  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 \<xref:System.Int64*>   
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table](../vs140/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)