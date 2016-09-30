---
title: "CA2231: Overload operator equals on overriding ValueType.Equals"
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
  - "OverloadOperatorEqualsOnOverridingValueTypeEquals"
  - "CA2231"
  - "OverrideOperatorEqualsOnOverridingValueTypeEquals"
helpviewer_keywords: 
  - "OverloadOperatorEqualsOnOverridingValueTypeEquals"
  - "CA2231"
ms.assetid: 114c0161-261a-40ad-8b2c-0932d6909d2a
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2231: Overload operator equals on overriding ValueType.Equals
|||  
|-|-|  
|TypeName|OverloadOperatorEqualsOnOverridingValueTypeEquals|  
|CheckId|CA2231|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A value type overrides \<xref:System.Object.Equals*?displayProperty=fullName> but does not implement the equality operator.  
  
## Rule Description  
 In most programming languages there is no default implementation of the equality operator (==) for value types. If your programming language supports operator overloads, you should consider implementing the equality operator. Its behavior should be identical to that of \<xref:System.Object.Equals*>.  
  
 You cannot use the default equality operator in an overloaded implementation of the equality operator. Doing so will cause a stack overflow. To implement the equality operator, use the Object.Equals method in your implementation. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## How to Fix Violations  
 To fix a violation of this rule, implement the equality operator.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule; however, we recommend that you provide the equality operator if possible.  
  
## Example  
 The following example defines a type that violates this rule.  
  
 [!code[FxCop.Usage.EqualsGetHashCode#1](../vs140/codesnippet/CSharp/ca2231--overload-operator-equals-on-overriding-valuetype.equals_1.cs)]  
  
## Related Rules  
 [Do not override operator equals on reference types](../vs140/ca1046--do-not-overload-operator-equals-on-reference-types.md)  
  
 [Operator overloads have named alternates](../vs140/ca2225--operator-overloads-have-named-alternates.md)  
  
 [Operators should have symmetrical overloads](../vs140/ca2226--operators-should-have-symmetrical-overloads.md)  
  
 [Override equals on overriding operator equals](../vs140/ca2224--override-equals-on-overloading-operator-equals.md)  
  
 [Override GetHashCode on overriding Equals](../vs140/ca2218--override-gethashcode-on-overriding-equals.md)  
  
## See Also  
 \<xref:System.Object.Equals*?displayProperty=fullName>