---
title: "Value Types (C# Reference)"
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
  - "cs.valuetypes"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "value types [C#]"
  - "types [C#], value types"
  - "C# language, value types"
ms.assetid: 471eb994-2958-49d5-a6be-19b4313f80a3
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Value Types (C# Reference)
The value types consist of two main categories:  
  
-   [Structs](../VS_csharp/struct--csharp-reference-.md)  
  
-   [Enumerations](../VS_csharp/enum--csharp-reference-.md)  
  
 Structs fall into these categories:  
  
-   Numeric types  
  
    -   [Integral types](../VS_csharp/integral-types-table--csharp-reference-.md)  
  
    -   [Floating-point types](../VS_csharp/floating-point-types-table--csharp-reference-.md)  
  
    -   [decimal](../VS_csharp/decimal--csharp-reference-.md)  
  
-   [bool](../VS_csharp/bool--csharp-reference-.md)  
  
-   User defined structs.  
  
## Main Features of Value Types  
 Variables that are based on value types directly contain values. Assigning one value type variable to another copies the contained value. This differs from the assignment of reference type variables, which copies a reference to the object but not the object itself.  
  
 All value types are derived implicitly from the <xref:System.ValueType*?displayProperty=fullName>.  
  
 Unlike with reference types, you cannot derive a new type from a value type. However, like reference types, structs can implement interfaces.  
  
 Unlike reference types, a value type cannot contain the `null` value. However, the [nullable types](../VS_csharp/nullable-types--csharp-programming-guide-.md) feature does allow for value types to be assigned to `null`.  
  
 Each value type has an implicit default constructor that initializes the default value of that type. For information about default values of value types, see [Default Values Table](../VS_csharp/default-values-table--csharp-reference-.md).  
  
## Main Features of Simple Types  
 All of the simple types -- those integral to the C# language -- are aliases of the .NET Framework System types. For example, [int](../VS_csharp/int--csharp-reference-.md) is an alias of <xref:System.Int32*?displayProperty=fullName>. For a complete list of aliases, see [Built-in Types Table (Visual C#)](../VS_csharp/built-in-types-table--csharp-reference-.md).  
  
 Constant expressions, whose operands are all simple type constants, are evaluated at compilation time.  
  
 Simple types can be initialized by using literals. For example, 'A' is a literal of the type `char` and 2001 is a literal of the type `int`.  
  
## Initializing Value Types  
 Local variables in C# must be initialized before they are used. For example, you might declare a local variable without initialization as in the following example:  
  
```  
int myInt;  
```  
  
 You cannot use it before you initialize it. You can initialize it using the following statement:  
  
```  
myInt = new int();  // Invoke default constructor for int type.  
```  
  
 This statement is equivalent to the following statement:  
  
```  
myInt = 0;         // Assign an initial value, 0 in this example.  
```  
  
 You can, of course, have the declaration and the initialization in the same statement as in the following examples:  
  
```  
int myInt = new int();  
```  
  
 –or–  
  
```  
int myInt = 0;  
```  
  
 Using the [new](../VS_csharp/new--csharp-reference-.md) operator calls the default constructor of the specific type and assigns the default value to the variable. In the preceding example, the default constructor assigned the value `0` to `myInt`. For more information about values assigned by calling default constructors, see [Default Values Table](../VS_csharp/default-values-table--csharp-reference-.md).  
  
 With user-defined types, use [new](../VS_csharp/new--csharp-reference-.md) to invoke the default constructor. For example, the following statement invokes the default constructor of the `Point` struct:  
  
```  
Point p = new Point(); // Invoke default constructor for the struct.  
```  
  
 After this call, the struct is considered to be definitely assigned; that is, all its members are initialized to their default values.  
  
 For more information about the new operator, see [new](../VS_csharp/new--csharp-reference-.md).  
  
 For information about formatting the output of numeric types, see [Formatting Numeric Results Table](../VS_csharp/formatting-numeric-results-table--csharp-reference-.md).  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Types](../VS_csharp/types--csharp-reference-.md)   
 [Reference Tables for Types](../VS_csharp/reference-tables-for-types--csharp-reference-.md)   
 [Reference Types](../VS_csharp/reference-types--csharp-reference-.md)