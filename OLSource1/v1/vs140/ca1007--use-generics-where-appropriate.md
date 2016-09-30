---
title: "CA1007: Use generics where appropriate"
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
  - "CA1007"
  - "UseGenericsWhereAppropriate"
helpviewer_keywords: 
  - "CA1007"
  - "UseGenericsWhereAppropriate"
ms.assetid: eab780ea-3b1f-4d32-b15a-5d48da2df46b
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1007: Use generics where appropriate
|||  
|-|-|  
|TypeName|UseGenericsWhereAppropriate|  
|CheckId|CA1007|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 An externally visible method contains a reference parameter of type \<xref:System.Object*?displayProperty=fullName>, and the containing assembly targets [!INCLUDE[dnprdnlong](../vs140/includes/dnprdnlong_md.md)].  
  
## Rule Description  
 A reference parameter is a parameter that is modified by using the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]) keyword. The argument type that is supplied for a reference parameter must exactly match the reference parameter type. To use a type that is derived from the reference parameter type, the type must first be cast and assigned to a variable of the reference parameter type. Use of a generic method allows all types, subject to constraints, to be passed to the method without first casting the type to the reference parameter type.  
  
## How to Fix Violations  
 To fix a violation of this rule, make the method generic and replace the \<xref:System.Object*> parameter by using a type parameter.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a general-purpose swap routine that is implemented as both nongeneric and generic methods. Note how efficiently the strings are swapped by using the generic method compared to the nongeneric method.  
  
 [!code[FxCop.Design.UseGenerics#1](../vs140/codesnippet/VisualBasic/ca1007--use-generics-where-appropriate_1.vb)]
[!code[FxCop.Design.UseGenerics#1](../vs140/codesnippet/CSharp/ca1007--use-generics-where-appropriate_1.cs)]  
  
## Related Rules  
 [Avoid excessive parameters on generic types](../vs140/ca1005--avoid-excessive-parameters-on-generic-types.md)  
  
 [Collections should implement generic interface](../vs140/ca1010--collections-should-implement-generic-interface.md)  
  
 [Do not declare static members on generic types](../vs140/ca1000--do-not-declare-static-members-on-generic-types.md)  
  
 [Do not expose generic lists](../vs140/ca1002--do-not-expose-generic-lists.md)  
  
 [Do not nest generic types in member signatures](../vs140/ca1006--do-not-nest-generic-types-in-member-signatures.md)  
  
 [Generic methods should provide type parameter](../vs140/ca1004--generic-methods-should-provide-type-parameter.md)  
  
 [Use generic event handler instances](../vs140/ca1003--use-generic-event-handler-instances.md)  
  
## See Also  
 [Generics (C# Programmers Reference)](../vs140/generics--csharp-programming-guide-.md)