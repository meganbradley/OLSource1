---
title: "Nullable Types (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
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
  - "nullable types [C#]"
  - "C# language, nullable types"
  - "types [C#], nullable"
ms.assetid: e473cb01-28ca-42be-9cea-f717055d72c6
caps.latest.revision: 48
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Nullable Types (C# Programming Guide)
Nullable types are instances of the <xref:System.Nullable`1*?displayProperty=fullName> struct. A nullable type can represent the correct range of values for its underlying value type, plus an additional `null` value. For example, a `Nullable<Int32>`, pronounced "Nullable of Int32," can be assigned any value from -2147483648 to 2147483647, or it can be assigned the `null` value. A `Nullable<bool>` can be assigned the values [true](../VS_csharp/true--csharp-reference-.md)[false](../VS_csharp/false--csharp-reference-.md), or [null](../VS_csharp/null--csharp-reference-.md). The ability to assign `null` to numeric and Boolean types is especially useful when you are dealing with databases and other data types that contain elements that may not be assigned a value. For example, a Boolean field in a database can store the values `true` or `false`, or it may be undefined.  
  
 [!code[csProgGuideTypes#3](../VS_csharp/codesnippet/CSharp/nullable-types--csharp-programming-guide-_1.cs)]  
  
 The example will display the output:  
  
 `num = Null`  
  
 `Nullable object must have a value.`  
  
 For more examples, see [Using Nullable Types (C# Programming Guide)](../VS_csharp/using-nullable-types--csharp-programming-guide-.md)  
  
## Nullable Types Overview  
 Nullable types have the following characteristics:  
  
-   Nullable types represent value-type variables that can be assigned the value of `null`. You cannot create a nullable type based on a reference type. (Reference types already support the `null` value.)  
  
-   The syntax `T?` is shorthand for <xref:System.Nullable`1*>, where `T` is a value type. The two forms are interchangeable.  
  
-   Assign a value to a nullable type just as you would for an ordinary value type, for example `int? x = 10;` or `double? d = 4.108`. A nullable type can also be assigned the value `null`: `int? x = null.`  
  
-   Use the <xref:System.Nullable`1.GetValueOrDefault*?displayProperty=fullName> method to return either the assigned value, or the default value for the underlying type if the value is `null`, for example `int j = x.GetValueOrDefault();`  
  
-   Use the <xref:System.Nullable`1.HasValue*> and <xref:System.Nullable`1.Value*> read-only properties to test for null and retrieve the value, as shown in the following example: `if(x.HasValue) j = x.Value;`  
  
    -   The `HasValue` property returns `true` if the variable contains a value, or `false` if it is `null`.  
  
    -   The `Value` property returns a value if one is assigned. Otherwise, a <xref:System.InvalidOperationException*?displayProperty=fullName> is thrown.  
  
    -   The default value for `HasValue` is `false`. The `Value` property has no default value.  
  
    -   You can also use the `==` and `!=` operators with a nullable type, as shown in the following example: `if (x != null) y = x;`  
  
-   Use the `??` operator to assign a default value that will be applied when a nullable type whose current value is `null` is assigned to a non-nullable type, for example `int? x = null; int y = x ?? -1;`  
  
-   Nested nullable types are not allowed. The following line will not compile: `Nullable<Nullable<int>> n;`  
  
## Related Sections  
 For more information:  
  
-   [Using Nullable Types (C#)](../VS_csharp/using-nullable-types--csharp-programming-guide-.md)  
  
-   [Boxing Nullable Types (C# Programming Guide)](../VS_csharp/boxing-nullable-types--csharp-programming-guide-.md)  
  
-   [?? operator (C# Programming Guide)](../VS_csharp/---operator--csharp-reference-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 <xref:System.Nullable*>   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Visual C#](../VS_csharp/csharp.md)   
 [C# Programmer's Reference](../VS_csharp/csharp-reference.md)   
 [What exactly does 'lifted' mean?](http://go.microsoft.com/fwlink/?LinkId=112382)