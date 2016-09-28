---
title: "CA1006: Do not nest generic types in member signatures"
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
  - "DoNotNestGenericTypesInMemberSignatures"
  - "CA1006"
helpviewer_keywords: 
  - "CA1006"
  - "DoNotNestGenericTypesInMemberSignatures"
ms.assetid: dfc867bc-f4af-45d7-b071-db04a248f9fc
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1006: Do not nest generic types in member signatures
|||  
|-|-|  
|TypeName|DoNotNestGenericTypesInMemberSignatures|  
|CheckId|CA1006|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 An externally visible member has a signature that contains a nested type argument.  
  
## Rule Description  
 A nested type argument is a type argument that is also a generic type. To call a member whose signature contains a nested type argument, the user must instantiate one generic type and pass this type to the constructor of a second generic type. The required procedure and syntax are complex and should be avoided.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the design to remove the nested type argument.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Providing generics in a syntax that is easy to understand and use reduces the time that is required to learn and increases the adoption rate of new libraries.  
  
## Example  
 The following example shows a method that violates the rule and the syntax that is required to call the violating method.  
  
 [!code[FxCop.Design.NestedGenerics#1](../vs140/codesnippet/VisualBasic/ca1006--do-not-nest-generic-types-in-member-signatures_1.vb)][!code[FxCop.Design.NestedGenerics#1](../vs140/codesnippet/CSharp/ca1006--do-not-nest-generic-types-in-member-signatures_1.cs)]  
  
## Related Rules  
 [Avoid excessive parameters on generic types](../vs140/ca1005--avoid-excessive-parameters-on-generic-types.md)  
  
 [Collections should implement generic interface](../vs140/ca1010--collections-should-implement-generic-interface.md)  
  
 [Do not declare static members on generic types](../vs140/ca1000--do-not-declare-static-members-on-generic-types.md)  
  
 [Do not expose generic lists](../vs140/ca1002--do-not-expose-generic-lists.md)  
  
 [Generic methods should provide type parameter](../vs140/ca1004--generic-methods-should-provide-type-parameter.md)  
  
 [Use generic event handler instances](../vs140/ca1003--use-generic-event-handler-instances.md)  
  
 [Use generics where appropriate](../vs140/ca1007--use-generics-where-appropriate.md)  
  
## See Also  
 [Generics (C# Programmers Reference)](../vs140/generics--csharp-programming-guide-.md)