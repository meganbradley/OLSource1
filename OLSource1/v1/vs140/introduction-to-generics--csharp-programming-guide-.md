---
title: "Introduction to Generics (C# Programming Guide)"
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
  - "generics [C#], about generics"
ms.assetid: a1ad761e-42f7-41dd-a62f-452a2de26b9d
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Introduction to Generics (C# Programming Guide)
Generic classes and methods combine reusability, type safety and efficiency in a way that their non-generic counterparts cannot. Generics are most frequently used with collections and the methods that operate on them. Version 2.0 of the .NET Framework class library provides a new namespace, \<xref:System.Collections.Generic*>, which contains several new generic-based collection classes. It is recommended that all applications that target the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] 2.0 and later use the new generic collection classes instead of the older non-generic counterparts such as \<xref:System.Collections.ArrayList*>. For more information, see [Generics in the Base Class Library](../vs140/generics-in-the-.net-framework-class-library--csharp-programming-guide-.md).  
  
 Of course, you can also create custom generic types and methods to provide your own generalized solutions and design patterns that are type-safe and efficient. The following code example shows a simple generic linked-list class for demonstration purposes. (In most cases, you should use the <xref:System.Collections.Generic.List<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>T<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>AddHead<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>GetNext<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>Data<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>Node<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>Node<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>GenericList<T><CodeContentPlaceHolder>7\</CodeContentPlaceHolder>GenericList<int><CodeContentPlaceHolder>8\</CodeContentPlaceHolder>T<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>int<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>GenericList<T>` class to create a list of integers. Simply by changing the type argument, the following code could easily be modified to create lists of strings or any other custom type:  
  
 [!code[csProgGuideGenerics#3](../vs140/codesnippet/CSharp/introduction-to-generics--csharp-programming-guide-_2.cs)]  
  
## See Also  
 \<xref:System.Collections.Generic*>   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Generics](../vs140/generics--csharp-programming-guide-.md)