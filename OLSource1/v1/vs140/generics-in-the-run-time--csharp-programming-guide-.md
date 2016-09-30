---
title: "Generics in the Run Time (C# Programming Guide)"
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
  - "generics [C#], at run time"
ms.assetid: 119df7e6-9ceb-49df-af36-24f8f8c0747f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generics in the Run Time (C# Programming Guide)
When a generic type or method is compiled into Microsoft intermediate language (MSIL), it contains metadata that identifies it as having type parameters. How the MSIL for a generic type is used differs based on whether the supplied type parameter is a value type or reference type.  
  
 When a generic type is first constructed with a value type as a parameter, the runtime creates a specialized generic type with the supplied parameter or parameters substituted in the appropriate locations in the MSIL. Specialized generic types are created one time for each unique value type that is used as a parameter.  
  
 For example, suppose your program code declared a stack that is constructed of integers:  
  
 [!code[csProgGuideGenerics#42](../vs140/codesnippet/CSharp/generics-in-the-run-time--csharp-programming-guide-_1.cs)]  
  
 At this point, the runtime generates a specialized version of the <xref:System.Collections.Generic.Stack<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>1*> class. In the following example, two instances of a stack of integers are created, and they share a single instance of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> code:  
  
 [!code[csProgGuideGenerics#43](../vs140/codesnippet/CSharp/generics-in-the-run-time--csharp-programming-guide-_2.cs)]  
  
 However, suppose that another <xref:System.Collections.Generic.Stack<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>long<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>long<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>Customer<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>Order<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>Customer<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>1*> class that stores object references that will be filled in later instead of storing data. Suppose the next line of code creates a stack of another reference type, which is named <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>:  
  
 [!code[csProgGuideGenerics#45](../vs140/codesnippet/CSharp/generics-in-the-run-time--csharp-programming-guide-_5.cs)]  
  
 Unlike with value types, another specialized version of the <xref:System.Collections.Generic.Stack<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>Order<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>1*> class is created and the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> variable is set to reference it. Suppose that you then encountered a line of code to create a stack of a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> type:  
  
 [!code[csProgGuideGenerics#46](../vs140/codesnippet/CSharp/generics-in-the-run-time--csharp-programming-guide-_6.cs)]  
  
 As with the previous use of the <xref:System.Collections.Generic.Stack<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>Order<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>1*> class is created. The pointers that are contained therein are set to reference an area of memory the size of a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> type. Because the number of reference types can vary wildly from program to program, the C# implementation of generics greatly reduces the amount of code by reducing to one the number of specialized classes created by the compiler for generic classes of reference types.  
  
 Moreover, when a generic C# class is instantiated by using a value type or reference type parameter, reflection can query it at runtime and both its actual type and its type parameter can be ascertained.  
  
## See Also  
 \<xref:System.Collections.Generic*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Generics Overview (C# Programmers Reference)](../vs140/introduction-to-generics--csharp-programming-guide-.md)   
 [Generics in the .NET Framework](assetId:///2994d786-c5c7-4666-ab23-4c83129fe39c)