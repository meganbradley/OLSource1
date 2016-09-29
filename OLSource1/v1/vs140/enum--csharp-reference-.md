---
title: "enum (C# Reference)"
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
  - "enum"
  - "enum_CSharpKeyword"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "enum keyword [C#]"
ms.assetid: bbeb9a0f-e9b3-41ab-b0a6-c41b1a08974c
caps.latest.revision: 40
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# enum (C# Reference)
The `enum` keyword is used to declare an enumeration, a distinct type that consists of a set of named constants called the enumerator list.  
  
 Usually it is best to define an enum directly within a namespace so that all classes in the namespace can access it with equal convenience. However, an enum can also be nested within a class or struct.  
  
 By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1. For example, in the following enumeration, `Sat` is `0`, `Sun` is `1`, `Mon` is `2`, and so forth.  
  
```  
  
enum Days {Sat, Sun, Mon, Tue, Wed, Thu, Fri};  
```  
  
 Enumerators can use initializers to override the default values, as shown in the following example.  
  
```  
  
enum Days {Sat=1, Sun, Mon, Tue, Wed, Thu, Fri};  
```  
  
 In this enumeration, the sequence of elements is forced to start from `1` instead of `0`. However, including a constant that has the value of 0 is recommended. For more information, see [Enumerated Types (C# Programming Guide)](../vs140/enumeration-types--csharp-programming-guide-.md).  
  
 Every enumeration type has an underlying type, which can be any integral type except [char](../vs140/char--csharp-reference-.md). The default underlying type of enumeration elements is [int](../vs140/int--csharp-reference-.md). To declare an enum of another integral type, such as [byte](../vs140/byte--csharp-reference-.md), use a colon after the identifier followed by the type, as shown in the following example.  
  
```  
  
enum Days : byte {Sat=1, Sun, Mon, Tue, Wed, Thu, Fri};  
```  
  
 The approved types for an enum are `byte`, [sbyte](../vs140/sbyte--csharp-reference-.md), [short](../vs140/short--csharp-reference-.md), [ushort](../vs140/ushort--csharp-reference-.md), [int](../vs140/int--csharp-reference-.md), [uint](../vs140/uint--csharp-reference-.md), [long](../vs140/long--csharp-reference-.md), or [ulong](../vs140/ulong--csharp-reference-.md).  
  
 A variable of type `Days` can be assigned any value in the range of the underlying type; the values are not limited to the named constants.  
  
 The default value of an `enum E` is the value produced by the expression `(E)0`.  
  
> [!NOTE]
>  An enumerator cannot contain white space in its name.  
  
 The underlying type specifies how much storage is allocated for each enumerator. However, an explicit cast is necessary to convert from `enum` type to an integral type. For example, the following statement assigns the enumerator `Sun` to a variable of the type [int](../vs140/int--csharp-reference-.md) by using a cast to convert from `enum` to `int`.  
  
```  
  
int x = (int)Days.Sun;  
```  
  
 When you apply <xref:System.FlagsAttribute*?displayProperty=fullName> to an enumeration that contains elements that can be combined with a bitwise `OR` operation, the attribute affects the behavior of the `enum` when it is used with some tools. You can notice these changes when you use tools such as the <xref:System.Console*> class methods and the Expression Evaluator. (See the third example.)  
  
## Robust Programming  
 Just as with any constant, all references to the individual values of an enum are converted to numeric literals at compile time. This can create potential versioning issues as described in [Constants (C# Programming Guide)](../vs140/constants--csharp-programming-guide-.md).  
  
 Assigning additional values to new versions of enums, or changing the values of the enum members in a new version, can cause problems for dependent source code. Enum values often are used in [switch](../vs140/switch--csharp-reference-.md) statements. If additional elements have been added to the `enum` type, the default section of the switch statement can be selected unexpectedly.  
  
 If other developers use your code, you should provide guidelines about how their code should react if new elements are added to any `enum` types.  
  
## Example  
 In the following example, an enumeration, `Days`, is declared. Two enumerators are explicitly converted to integer and assigned to integer variables.  
  
 [!code[csrefKeywordsTypes#10](../vs140/codesnippet/CSharp/enum--csharp-reference-_1.cs)]  
  
## Example  
 In the following example, the base-type option is used to declare an `enum` whose members are of type `long`. Notice that even though the underlying type of the enumeration is `long`, the enumeration members still must be explicitly converted to type `long` by using a cast.  
  
 [!code[csrefKeywordsTypes#11](../vs140/codesnippet/CSharp/enum--csharp-reference-_2.cs)]  
  
## Example  
 The following code example illustrates the use and effect of the <xref:System.FlagsAttribute*?displayProperty=fullName> attribute on an `enum` declaration.  
  
 [!code[csrefKeywordsTypes#12](../vs140/codesnippet/CSharp/enum--csharp-reference-_3.cs)]  
  
## Comments  
 If you remove `Flags`, the example displays the following values:  
  
 `5`  
  
 `5`  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [Enumerated Types (C# Programming Guide)](../vs140/enumeration-types--csharp-programming-guide-.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Integral Types Table](../vs140/integral-types-table--csharp-reference-.md)   
 [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md)   
 [Implicit Numeric Conversions Table](../vs140/implicit-numeric-conversions-table--csharp-reference-.md)   
 [Explicit Numeric Conversions Table (Visual C#)](../vs140/explicit-numeric-conversions-table--csharp-reference-.md)