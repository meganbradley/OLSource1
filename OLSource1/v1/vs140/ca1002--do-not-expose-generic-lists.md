---
title: "CA1002: Do not expose generic lists"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DoNotExposeGenericLists"
  - "CA1002"
helpviewer_keywords: 
  - "CA1002"
  - "DoNotExposeGenericLists"
ms.assetid: 5caac810-1a79-47df-a27b-c46c5040bf34
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1002: Do not expose generic lists
|||  
|-|-|  
|TypeName|DoNotExposeGenericLists|  
|CheckId|CA1002|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A type contains an externally visible member that is a <xref:System.Collections.Generic.List<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>1*?displayProperty=fullName> type, or whose signature includes a <xref:System.Collections.Generic.List<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>1*?displayProperty=fullName> is a generic collection that is designed for performance and not inheritance. <xref:System.Collections.Generic.List<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>1*?displayProperty=fullName>.  
  
-   <xref:System.Collections.ObjectModel.Collection<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>1*?displayProperty=fullName>  
  
-   <xref:System.Collections.ObjectModel.KeyedCollection<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1*?displayProperty=fullName> type to one of the generic collections that is designed for inheritance.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule unless the assembly that raises this warning is not meant to be a reusable library. For example, it would be safe to suppress this warning in a performance tuned application where a performance benefit was gained from the use of generic lists.  
  
## Related Rules  
 [Avoid excessive parameters on generic types](../vs140/ca1005--avoid-excessive-parameters-on-generic-types.md)  
  
 [Collections should implement generic interface](../vs140/ca1010--collections-should-implement-generic-interface.md)  
  
 [Do not declare static members on generic types](../vs140/ca1000--do-not-declare-static-members-on-generic-types.md)  
  
 [Do not nest generic types in member signatures](../vs140/ca1006--do-not-nest-generic-types-in-member-signatures.md)  
  
 [Generic methods should provide type parameter](../vs140/ca1004--generic-methods-should-provide-type-parameter.md)  
  
 [Use generic event handler instances](../vs140/ca1003--use-generic-event-handler-instances.md)  
  
 [Use generics where appropriate](../vs140/ca1007--use-generics-where-appropriate.md)  
  
## See Also  
 [Generics (C# Programmers Reference)](../vs140/generics--csharp-programming-guide-.md)