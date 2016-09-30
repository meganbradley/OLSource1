---
title: "Implicitly Typed Local Variables (C# Programming Guide)"
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
  - "implicitly-typed local variables [C#]"
  - "var [C#]"
ms.assetid: b9218fb2-ef5d-4814-8a8e-2bc29b0bbc9b
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implicitly Typed Local Variables (C# Programming Guide)
Local variables can be given an inferred "type" of `var` instead of an explicit type. The `var` keyword instructs the compiler to infer the type of the variable from the expression on the right side of the initialization statement. The inferred type may be a built-in type, an anonymous type, a user-defined type, or a type defined in the .NET Framework class library. For more information about how to initialize arrays with `var`, see [Implicitly-typed Arrays (C# Programming Guide)](../vs140/implicitly-typed-arrays--csharp-programming-guide-.md).  
  
 The following examples show various ways in which local variables can be declared with `var`:  
  
 [!code[csProgGuideLINQ#43](../vs140/codesnippet/CSharp/implicitly-typed-local-variables--csharp-programming-guide-_1.cs)]  
  
 It is important to understand that the `var` keyword does not mean "variant" and does not indicate that the variable is loosely typed, or late-bound. It just means that the compiler determines and assigns the most appropriate type.  
  
 The `var` keyword may be used in the following contexts:  
  
-   On local variables (variables declared at method scope) as shown in the previous example.  
  
-   In a [for](../vs140/for--csharp-reference-.md) initialization statement.  
  
    ```  
    for(var x = 1; x < 10; x++)  
    ```  
  
-   In a [foreach](../vs140/foreach--in--csharp-reference-.md) initialization statement.  
  
    ```  
    foreach(var item in list){...}  
    ```  
  
-   In a [using](../vs140/using-statement--csharp-reference-.md) statement.  
  
    ```  
    using (var file = new StreamReader("C:\\myfile.txt")) {...}  
    ```  
  
 For more information, see [How to: Use Implicitly Typed Local Variables and Arrays in a Query Expression (C# Programming Guide)](../vs140/6b7354d2-af79-427a-b6a8-f74eb8fd0b91.md).  
  
## var and Anonymous Types  
 In many cases the use of `var` is optional and is just a syntactic convenience. However, when a variable is initialized with an anonymous type you must declare the variable as `var` if you need to access the properties of the object at a later point. This is a common scenario in [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query expressions. For more information, see [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md).  
  
 From the perspective of your source code, an anonymous type has no name. Therefore, if a query variable has been initialized with `var`, then the only way to access the properties in the returned sequence of objects is to use `var` as the type of the iteration variable in the `foreach` statement.  
  
 [!code[csProgGuideLINQ#44](../vs140/codesnippet/CSharp/implicitly-typed-local-variables--csharp-programming-guide-_2.cs)]  
  
## Remarks  
 The following restrictions apply to implicitly-typed variable declarations:  
  
-   `var` can only be used when a local variable is declared and initialized in the same statement; the variable cannot be initialized to null, or to a method group or an anonymous function.  
  
-   `var` cannot be used on fields at class scope.  
  
-   Variables declared by using `var` cannot be used in the initialization expression. In other words, this expression is legal`: int i = (i = 20);` but this expression produces a compile-time error: `var i = (i = 20);`  
  
-   Multiple implicitly-typed variables cannot be initialized in the same statement.  
  
-   If a type named `var` is in scope, then the `var` keyword will resolve to that type name and will not be treated as part of an implicitly typed local variable declaration.  
  
 You may find that `var` can also be useful with query expressions in which the exact constructed type of the query variable is difficult to determine. This can occur with grouping and ordering operations.  
  
 The `var` keyword can also be useful when the specific type of the variable is tedious to type on the keyboard, or is obvious, or does not add to the readability of the code. One example where `var` is helpful in this manner is with nested generic types such as those used with group operations. In the following query, the type of the query variable is `IEnumerable<IGrouping<string, Student>>`. As long as you and others who must maintain your code understand this, there is no problem with using implicit typing for convenience and brevity.  
  
 [!code[cscsrefQueryKeywords#13](../vs140/codesnippet/CSharp/implicitly-typed-local-variables--csharp-programming-guide-_3.cs)]  
  
 However, the use of `var` does have at least the potential to make your code more difficult to understand for other developers. For that reason, the C# documentation generally uses `var` only when it is required.  
  
## See Also  
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [Implicitly-typed Arrays (C# Programming Guide)](../vs140/implicitly-typed-arrays--csharp-programming-guide-.md)   
 [How to: Use Implicitly Typed Local Variables and Arrays in a Query Expression (C# Programming Guide)](../vs140/6b7354d2-af79-427a-b6a8-f74eb8fd0b91.md)   
 [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md)   
 [Object and Collection Initializers (C# Programming Guide)](../vs140/object-and-collection-initializers--csharp-programming-guide-.md)   
 [var (C# Reference)](../vs140/var--csharp-reference-.md)   
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)   
 [Language-Integrated Query (LINQ)](../vs140/linq--language-integrated-query-.md)   
 [for (C# Reference)](../vs140/for--csharp-reference-.md)   
 [foreach, in (C# Reference)](../vs140/foreach--in--csharp-reference-.md)   
 [using Statement (C# Reference)](../vs140/using-statement--csharp-reference-.md)