---
title: "Equality Comparisons (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "object equality [C#]"
ms.assetid: 10b865ea-4e7b-4127-9242-c9b8f57d9f04
caps.latest.revision: 14
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Equality Comparisons (C# Programming Guide)
It is sometimes necessary to compare two values for equality. In some cases, you are testing for *value equality*, also known as *equivalence*, which means that the values that are contained by the two variables are equal. In other cases, you have to determine whether two variables refer to the same underlying object in memory. This type of equality is called *reference equality*, or *identity*. This topic describes these two kinds of equality and provides links to other topics for more information.  
  
## Reference Equality  
 Reference equality means that two object references refer to the same underlying object. This can occur through simple assignment, as shown in the following example.  
  
 [!code[csProgGuideStatements#18](../VS_csharp/codesnippet/CSharp/equality-comparisons--csharp-programming-guide-_1.cs)]  
  
 In this code, two objects are created, but after the assignment statement, both references refer to the same object. Therefore they have reference equality. Use the \<xref:System.Object.ReferenceEquals*> method to determine whether two references refer to the same object.  
  
 The concept of reference equality applies only to reference types. Value type objects cannot have reference equality because when an instance of a value type is assigned to a variable, a copy of the value is made. Therefore you can never have two unboxed structs that refer to the same location in memory. Furthermore, if you use \<xref:System.Object.ReferenceEquals*> to compare two value types, the result will always be `false`, even if the values that are contained in the objects are all identical. This is because each variable is boxed into a separate object instance. For more information, see [How to: Test for Reference Equality (Identity)](../VS_csharp/how-to--test-for-reference-equality--identity---csharp-programming-guide-.md).  
  
## Value Equality  
 Value equality means that two objects contain the same value or values. For primitive value types such as [int](../VS_csharp/int--csharp-reference-.md) or [bool](../VS_csharp/bool--csharp-reference-.md), tests for value equality are straightforward. You can use the [==](../VS_csharp/==-operator--csharp-reference-.md) operator, as shown in the following example.  
  
```c#  
int a = GetOriginalValue();  
int b = GetCurrentValue();  
  
// Test for value equality.   
if( b == a)   
{  
    // The two integers are equal.  
}  
```  
  
 For most other types, testing for value equality is more complex because it requires that you understand how the type defines it. For classes and structs that have multiple fields or properties, value equality is often defined to mean that all fields or properties have the same value. For example, two `Point` objects might be defined to be equivalent if pointA.X is equal to pointB.X and pointA.Y is equal to pointB.Y.  
  
 However, there is no requirement that equivalence be based on all the fields in a type. It can be based on a subset. When you compare types that you do not own, you should make sure to understand specifically how equivalence is defined for that type. For more information about how to define value equality in your own classes and structs, see [How to: Define Value Equality for a Type](../VS_csharp/how-to--define-value-equality-for-a-type--csharp-programming-guide-.md).  
  
### Value Equality for Floating Point Values  
 Equality comparisons of floating point values ([double](../VS_csharp/double--csharp-reference-.md) and [float](../VS_csharp/float--csharp-reference-.md)) are problematic because of the imprecision of floating point arithmetic on binary computers. For more information, see the remarks in the topic \<xref:System.Double?displayProperty=fullName>.  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[How to: Test for Reference Equality (Identity)](../VS_csharp/how-to--test-for-reference-equality--identity---csharp-programming-guide-.md)|Describes how to determine whether two variables have reference equality.|  
|[How to: Define Value Equality for a Type](../VS_csharp/how-to--define-value-equality-for-a-type--csharp-programming-guide-.md)|Describes how to provide a custom definition of value equality for a type.|  
|[C# Programming Guide](../VS_csharp/csharp-programming-guide.md)|Provides links to detailed information about important C# language features and features that are available to C# through the .NET Framework.|  
|[Types](../VS_csharp/types--csharp-programming-guide-.md)|Provides information about the C# type system and links to additional information.|  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)