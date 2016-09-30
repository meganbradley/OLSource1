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
  
-   [Structs](../vs140/struct--csharp-reference-.md)  
  
-   [Enumerations](../vs140/enum--csharp-reference-.md)  
  
 Structs fall into these categories:  
  
-   Numeric types  
  
    -   [Integral types](../vs140/integral-types-table--csharp-reference-.md)  
  
    -   [Floating-point types](../vs140/floating-point-types-table--csharp-reference-.md)  
  
    -   [decimal](../vs140/decimal--csharp-reference-.md)  
  
-   [bool](../vs140/bool--csharp-reference-.md)  
  
-   User defined structs.  
  
## Main Features of Value Types  
 Variables that are based on value types directly contain values. Assigning one value type variable to another copies the contained value. This differs from the assignment of reference type variables, which copies a reference to the object but not the object itself.  
  
 All value types are derived implicitly from the \<xref:System.ValueType*?displayProperty=fullName>.  
  
 Unlike with reference types, you cannot derive a new type from a value type. However, like reference types, structs can implement interfaces.  
  
 Unlike reference types, a value type cannot contain the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value. However, the [nullable types](../vs140/nullable-types--csharp-programming-guide-.md) feature does allow for value types to be assigned to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 Each value type has an implicit default constructor that initializes the default value of that type. For information about default values of value types, see [Default Values Table](../vs140/default-values-table--csharp-reference-.md).  
  
## Main Features of Simple Types  
 All of the simple types -- those integral to the C# language -- are aliases of the .NET Framework System types. For example, [int](../vs140/int--csharp-reference-.md) is an alias of \<xref:System.Int32*?displayProperty=fullName>. For a complete list of aliases, see [Built-in Types Table (Visual C#)](../vs140/built-in-types-table--csharp-reference-.md).  
  
 Constant expressions, whose operands are all simple type constants, are evaluated at compilation time.  
  
 Simple types can be initialized by using literals. For example, 'A' is a literal of the type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and 2001 is a literal of the type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Initializing Value Types  
 Local variables in C# must be initialized before they are used. For example, you might declare a local variable without initialization as in the following example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 You cannot use it before you initialize it. You can initialize it using the following statement:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This statement is equivalent to the following statement:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 You can, of course, have the declaration and the initialization in the same statement as in the following examples:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 –or–  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Using the [new](../vs140/new--csharp-reference-.md) operator calls the default constructor of the specific type and assigns the default value to the variable. In the preceding example, the default constructor assigned the value <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. For more information about values assigned by calling default constructors, see [Default Values Table](../vs140/default-values-table--csharp-reference-.md).  
  
 With user-defined types, use [new](../vs140/new--csharp-reference-.md) to invoke the default constructor. For example, the following statement invokes the default constructor of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> struct:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 After this call, the struct is considered to be definitely assigned; that is, all its members are initialized to their default values.  
  
 For more information about the new operator, see [new](../vs140/new--csharp-reference-.md).  
  
 For information about formatting the output of numeric types, see [Formatting Numeric Results Table](../vs140/formatting-numeric-results-table--csharp-reference-.md).  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Types](../vs140/types--csharp-reference-.md)   
 [Reference Tables for Types](../vs140/reference-tables-for-types--csharp-reference-.md)   
 [Reference Types](../vs140/reference-types--csharp-reference-.md)