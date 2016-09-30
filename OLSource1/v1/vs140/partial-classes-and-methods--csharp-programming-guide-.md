---
title: "Partial Classes and Methods (C# Programming Guide)"
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
  - "partial methods [C#]"
  - "partial classes [C#]"
  - "C# language, partial classes and methods"
ms.assetid: 804cecb7-62db-4f97-a99f-60975bd59fa1
caps.latest.revision: 39
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Partial Classes and Methods (C# Programming Guide)
It is possible to split the definition of a [class](../vs140/class--csharp-reference-.md) or a [struct](../vs140/struct--csharp-reference-.md), an [interface](../vs140/interface--csharp-reference-.md) or a method over two or more source files. Each source file contains a section of the type or method definition, and all parts are combined when the application is compiled.  
  
## Partial Classes  
 There are several situations when splitting a class definition is desirable:  
  
-   When working on large projects, spreading a class over separate files enables multiple programmers to work on it at the same time.  
  
-   When working with automatically generated source, code can be added to the class without having to recreate the source file. Visual Studio uses this approach when it creates Windows Forms, Web service wrapper code, and so on. You can create code that uses these classes without having to modify the file created by Visual Studio.  
  
-   To split a class definition, use the [partial](../vs140/partial--type---csharp-reference-.md) keyword modifier, as shown here:  
  
 [!code[csProgGuideObjects#26](../vs140/codesnippet/CSharp/partial-classes-and-methods--csharp-programming-guide-_1.cs)]  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword indicates that other parts of the class, struct, or interface can be defined in the namespace. All the parts must use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> keyword. All the parts must be available at compile time to form the final type. All the parts must have the same accessibility, such as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and so on.  
  
 If any part is declared abstract, then the whole type is considered abstract. If any part is declared sealed, then the whole type is considered sealed. If any part declares a base type, then the whole type inherits that class.  
  
 All the parts that specify a base class must agree, but parts that omit a base class still inherit the base type. Parts can specify different base interfaces, and the final type implements all the interfaces listed by all the partial declarations. Any class, struct, or interface members declared in a partial definition are available to all the other parts. The final type is the combination of all the parts at compile time.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> modifier is not available on delegate or enumeration declarations.  
  
 The following example shows that nested types can be partial, even if the type they are nested within is not partial itself.  
  
 [!code[csProgGuideObjects#25](../vs140/codesnippet/CSharp/partial-classes-and-methods--csharp-programming-guide-_2.cs)]  
  
 At compile time, attributes of partial-type definitions are merged. For example, consider the following declarations:  
  
 [!code[csProgGuideObjects#23](../vs140/codesnippet/CSharp/partial-classes-and-methods--csharp-programming-guide-_3.cs)]  
  
 They are equivalent to the following declarations:  
  
 [!code[csProgGuideObjects#24](../vs140/codesnippet/CSharp/partial-classes-and-methods--csharp-programming-guide-_4.cs)]  
  
 The following are merged from all the partial-type definitions:  
  
-   XML comments  
  
-   interfaces  
  
-   generic-type parameter attributes  
  
-   class attributes  
  
-   members  
  
 For example, consider the following declarations:  
  
 [!code[csProgGuideObjects#21](../vs140/codesnippet/CSharp/partial-classes-and-methods--csharp-programming-guide-_5.cs)]  
  
 They are equivalent to the following declarations:  
  
 [!code[csProgGuideObjects#22](../vs140/codesnippet/CSharp/partial-classes-and-methods--csharp-programming-guide-_6.cs)]  
  
### Restrictions  
 There are several rules to follow when you are working with partial class definitions:  
  
-   All partial-type definitions meant to be parts of the same type must be modified with <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. For example, the following class declarations generate an error:  
  
     [!code[csProgGuideObjects#20](../vs140/codesnippet/CSharp/partial-classes-and-methods--csharp-programming-guide-_7.cs)]  
  
-   The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> modifier can only appear immediately before the keywords <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
-   Nested partial types are allowed in partial-type definitions as illustrated in the following example:  
  
     [!code[csProgGuideObjects#19](../vs140/codesnippet/CSharp/partial-classes-and-methods--csharp-programming-guide-_8.cs)]  
  
-   All partial-type definitions meant to be parts of the same type must be defined in the same assembly and the same module (.exe or .dll file). Partial definitions cannot span multiple modules.  
  
-   The class name and generic-type parameters must match on all partial-type definitions. Generic types can be partial. Each partial declaration must use the same parameter names in the same order.  
  
-   The following keywords on a partial-type definition are optional, but if present on one partial-type definition, cannot conflict with the keywords specified on another partial definition for the same type:  
  
    -   [public](../vs140/public--csharp-reference-.md)  
  
    -   [private](../vs140/private--csharp-reference-.md)  
  
    -   [protected](../vs140/protected--csharp-reference-.md)  
  
    -   [internal](../vs140/internal--csharp-reference-.md)  
  
    -   [abstract](../vs140/abstract--csharp-reference-.md)  
  
    -   [sealed](../vs140/sealed--csharp-reference-.md)  
  
    -   base class  
  
    -   [new](../vs140/new--csharp-reference-.md) modifier (nested parts)  
  
    -   generic constraints  
  
         For more information, see [Constraints on Type Parameters (C# Programming Guide)](../vs140/constraints-on-type-parameters--csharp-programming-guide-.md).  
  
## Example 1  
  
### Description  
 In the following example, the fields and the constructor of the class, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, are declared in one partial class definition, and the member, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, is declared in another partial class definition.  
  
### Code  
 [!code[csProgGuideObjects#17](../vs140/codesnippet/CSharp/partial-classes-and-methods--csharp-programming-guide-_9.cs)]  
  
## Example 2  
  
### Description  
 The following example shows that you can also develop partial structs and interfaces.  
  
### Code  
 [!code[csProgGuideObjects#18](../vs140/codesnippet/CSharp/partial-classes-and-methods--csharp-programming-guide-_10.cs)]  
  
## Partial Methods  
 A partial class or struct may contain a partial method. One part of the class contains the signature of the method. An optional implementation may be defined in the same part or another part. If the implementation is not supplied, then the method and all calls to the method are removed at compile time.  
  
 Partial methods enable the implementer of one part of a class to define a method, similar to an event. The implementer of the other part of the class can decide whether to implement the method or not. If the method is not implemented, then the compiler removes the method signature and all calls to the method. The calls to the method, including any results that would occur from evaluation of arguments in the calls, have no effect at run time. Therefore, any code in the partial class can freely use a partial method, even if the implementation is not supplied. No compile-time or run-time errors will result if the method is called but not implemented.  
  
 Partial methods are especially useful as a way to customize generated code. They allow for a method name and signature to be reserved, so that generated code can call the method but the developer can decide whether to implement the method. Much like partial classes, partial methods enable code created by a code generator and code created by a human developer to work together without run-time costs.  
  
 A partial method declaration consists of two parts: the definition, and the implementation. These may be in separate parts of a partial class, or in the same part. If there is no implementation declaration, then the compiler optimizes away both the defining declaration and all calls to the method.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   Partial method declarations must begin with the contextual keyword [partial](../vs140/partial--type---csharp-reference-.md) and the method must return [void](../vs140/void--csharp-reference-.md).  
  
-   Partial methods can have [ref](../vs140/ref--csharp-reference-.md) but not [out](../vs140/out--csharp-reference-.md) parameters.  
  
-   Partial methods are implicitly [private](../vs140/private--csharp-reference-.md), and therefore they cannot be [virtual](../vs140/virtual--csharp-reference-.md).  
  
-   Partial methods cannot be [extern](../vs140/extern--csharp-reference-.md), because the presence of the body determines whether they are defining or implementing.  
  
-   Partial methods can have [static](../vs140/static--csharp-reference-.md) and [unsafe](../vs140/unsafe--csharp-reference-.md) modifiers.  
  
-   Partial methods can be generic. Constraints are put on the defining partial method declaration, and may optionally be repeated on the implementing one. Parameter and type parameter names do not have to be the same in the implementing declaration as in the defining one.  
  
-   You can make a [delegate](../vs140/delegate--csharp-reference-.md) to a partial method that has been defined and implemented, but not to a partial method that has only been defined.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Classes (C#)](../vs140/classes--csharp-programming-guide-.md)   
 [Structs (C#)](../vs140/structs--csharp-programming-guide-.md)   
 [Interfaces (Visual C#)](../vs140/interfaces--csharp-programming-guide-.md)   
 [partial (Type) (C# Reference)](../vs140/partial--type---csharp-reference-.md)