---
title: "CA1010: Collections should implement generic interface"
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
  - "CA1010"
  - "CollectionsShouldImplementGenericInterface"
helpviewer_keywords: 
  - "CA1010"
  - "CollectionsShouldImplementGenericInterface"
ms.assetid: c7d7126f-fa70-40be-8f93-3243e1760dc5
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1010: Collections should implement generic interface
|||  
|-|-|  
|TypeName|CollectionsShouldImplementGenericInterface|  
|CheckId|CA1010|  
|Category|Microsoft.Design|  
|Breaking Change|Non-breaking|  
  
## Cause  
 An externally visible type implements the \<xref:System.Collections.IEnumerable*?displayProperty=fullName> interface but does not implement the <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>1*?displayProperty=fullName>  
  
-   <xref:System.Collections.Generic.Queue<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>1*?displayProperty=fullName>  
  
## How to Fix Violations  
 To fix a violation of this rule, implement one of the following generic collection interfaces:  
  
-   <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>1*?displayProperty=fullName>  
  
-   <xref:System.Collections.Generic.IList<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>CollectionBase<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>Collection<T><CodeContentPlaceHolder>5\</CodeContentPlaceHolder>CollectionBase<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>Collection<T><CodeContentPlaceHolder>7\</CodeContentPlaceHolder>Collection(Of T)<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>IEnumerable<T><CodeContentPlaceHolder>9\</CodeContentPlaceHolder>ICollection<T><CodeContentPlaceHolder>10\</CodeContentPlaceHolder>IList<T><CodeContentPlaceHolder>11\</CodeContentPlaceHolder>IEnumerable(Of T)<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>ICollection(Of T)<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>IList(Of T)` in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]).  
  
### Code  
 [!code[FxCop.Design.CollectionsGenericInterface#1](../vs140/codesnippet/CSharp/ca1010--collections-should-implement-generic-interface_3.cs)]  
  
## Related Rules  
 [Avoid excessive parameters on generic types](../vs140/ca1005--avoid-excessive-parameters-on-generic-types.md)  
  
 [Do not declare static members on generic types](../vs140/ca1000--do-not-declare-static-members-on-generic-types.md)  
  
 [Do not expose generic lists](../vs140/ca1002--do-not-expose-generic-lists.md)  
  
 [Do not nest generic types in member signatures](../vs140/ca1006--do-not-nest-generic-types-in-member-signatures.md)  
  
 [Generic methods should provide type parameter](../vs140/ca1004--generic-methods-should-provide-type-parameter.md)  
  
 [Use generic event handler instances](../vs140/ca1003--use-generic-event-handler-instances.md)  
  
 [Use generics where appropriate](../vs140/ca1007--use-generics-where-appropriate.md)  
  
## See Also  
 [Generics (C# Programmers Reference)](../vs140/generics--csharp-programming-guide-.md)