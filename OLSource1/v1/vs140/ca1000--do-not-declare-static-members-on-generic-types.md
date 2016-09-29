---
title: "CA1000: Do not declare static members on generic types"
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
  - "CA1000"
  - "DoNotDeclareStaticMembersOnGenericTypes"
helpviewer_keywords: 
  - "DoNotDeclareStaticMembersOnGenericTypes"
  - "CA1000"
ms.assetid: 5c0da594-f8d0-4f40-953d-56bf7fbd2087
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1000: Do not declare static members on generic types
|||  
|-|-|  
|TypeName|DoNotDeclareStaticMembersOnGenericTypes|  
|CheckId|CA1000|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 An externally visible generic type contains a `static` (`Shared` in Visual Basic) member.  
  
## Rule Description  
 When a `static` member of a generic type is called, the type argument must be specified for the type. When a generic instance member that does not support inference is called, the type argument must be specified for the member. The syntax for specifying the type argument in these two cases is different and easily confused, as the following calls demonstrate:  
  
```vb  
' Shared method in a generic type.  
GenericType(Of Integer).SharedMethod()  
  
' Generic instance method that does not support inference.  
someObject.GenericMethod(Of Integer)()  
```  
  
```c#  
// Static method in a generic type.  
GenericType<int>.StaticMethod();  
  
// Generic instance method that does not support inference.  
someObject.GenericMethod<int>();  
```  
  
 Generally, both of the prior declarations should be avoided so that the type argument does not have to be specified when the member is called. This results in a syntax for calling members in generics that is no different from the syntax for non-generics. For more information, see [Generic methods should provide type parameter](../vs140/ca1004--generic-methods-should-provide-type-parameter.md).  
  
## How to Fix Violations  
 To fix a violation of this rule, remove the static member or change it to an instance member.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Providing generics in a syntax that is easy to understand and use reduces the time that is required to learn and increases the adoption rate of new libraries.  
  
## Related Rules  
 [Avoid excessive parameters on generic types](../vs140/ca1005--avoid-excessive-parameters-on-generic-types.md)  
  
 [Collections should implement generic interface](../vs140/ca1010--collections-should-implement-generic-interface.md)  
  
 [Do not expose generic lists](../vs140/ca1002--do-not-expose-generic-lists.md)  
  
 [Do not nest generic types in member signatures](../vs140/ca1006--do-not-nest-generic-types-in-member-signatures.md)  
  
 [Generic methods should provide type parameter](../vs140/ca1004--generic-methods-should-provide-type-parameter.md)  
  
 [Use generic event handler instances](../vs140/ca1003--use-generic-event-handler-instances.md)  
  
 [Use generics where appropriate](../vs140/ca1007--use-generics-where-appropriate.md)  
  
## See Also  
 [Generics (C# Programmers Reference)](../vs140/generics--csharp-programming-guide-.md)