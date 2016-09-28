---
title: "CA1004: Generic methods should provide type parameter"
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
  - "CA1004"
  - "GenericMethodsShouldProvideTypeParameter"
helpviewer_keywords: 
  - "GenericMethodsShouldProvideTypeParameter"
  - "CA1004"
ms.assetid: 38755f6a-fb45-4bf2-932e-0354ad826499
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1004: Generic methods should provide type parameter
|||  
|-|-|  
|TypeName|GenericMethodsShouldProvideTypeParameter|  
|CheckId|CA1004|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 The parameter signature of an externally visible generic method does not contain types that correspond to all the type parameters of the method.  
  
## Rule Description  
 Inference is how the type argument of a generic method is determined by the type of argument that is passed to the method, instead of by the explicit specification of the type argument. To enable inference, the parameter signature of a generic method must include a parameter that is of the same type as the type parameter for the method. In this case, the type argument does not have to be specified. When you use inference for all type parameters, the syntax for calling generic and nongeneric instance methods is identical. This simplifies the usability of generic methods.  
  
## How to Fix Violations  
 To fix a violation of this rule, change the design so that the parameter signature contains the same type for each type parameter of the method.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule. Providing generics in a syntax that is easy to understand and use reduces the time that is required to learn and increases the adoption rate of new libraries.  
  
## Example  
 The following example shows the syntax for calling two generic methods. The type argument for `InferredTypeArgument` is inferred, and the type argument for `NotInferredTypeArgument` must be explicitly specified.  
  
 [!code[FxCop.Design.Inference#1](../vs140/codesnippet/VisualBasic/ca1004--generic-methods-should-provide-type-parameter_1.vb)][!code[FxCop.Design.Inference#1](../vs140/codesnippet/CSharp/ca1004--generic-methods-should-provide-type-parameter_1.cs)]  
  
## Related Rules  
 [Avoid excessive parameters on generic types](../vs140/ca1005--avoid-excessive-parameters-on-generic-types.md)  
  
 [Collections should implement generic interface](../vs140/ca1010--collections-should-implement-generic-interface.md)  
  
 [Do not declare static members on generic types](../vs140/ca1000--do-not-declare-static-members-on-generic-types.md)  
  
 [Do not expose generic lists](../vs140/ca1002--do-not-expose-generic-lists.md)  
  
 [Do not nest generic types in member signatures](../vs140/ca1006--do-not-nest-generic-types-in-member-signatures.md)  
  
 [Use generic event handler instances](../vs140/ca1003--use-generic-event-handler-instances.md)  
  
 [Use generics where appropriate](../vs140/ca1007--use-generics-where-appropriate.md)  
  
## See Also  
 [Generics (C# Programmers Reference)](../vs140/generics--csharp-programming-guide-.md)