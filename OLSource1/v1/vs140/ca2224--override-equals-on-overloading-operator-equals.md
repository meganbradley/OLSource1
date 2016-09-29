---
title: "CA2224: Override equals on overloading operator equals"
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
  - "CA2224"
  - "OverrideEqualsOnOverloadingOperatorEquals"
  - "OverrideEqualsOnOverridingOperatorEquals"
helpviewer_keywords: 
  - "OverrideEqualsOnOverloadingOperatorEquals"
  - "CA2224"
ms.assetid: 7312afd9-84ba-417f-923e-7a159b53bf70
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2224: Override equals on overloading operator equals
|||  
|-|-|  
|TypeName|OverrideEqualsOnOverloadingOperatorEquals|  
|CheckId|CA2224|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A public type implements the equality operator, but does not override <xref:System.Object.Equals*?displayProperty=fullName>.  
  
## Rule Description  
 The equality operator is intended to be a syntactically convenient way to access the functionality of the <xref:System.Object.Equals*> method. If you implement the equality operator, its logic must be identical to that of <xref:System.Object.Equals*>.  
  
 The C# compiler issues a warning if your code violates this rule.  
  
## How to Fix Violations  
 To fix a violation of this rule, you should either remove the implementation of the equality operator, or override <xref:System.Object.Equals*> and have the two methods return the same values. If the equality operator does not introduce inconsistent behavior, you can fix the violation by providing an implementation of <xref:System.Object.Equals*> that calls the <xref:System.Object.Equals*> method in the base class.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the equality operator returns the same value as the inherited implementation of <xref:System.Object.Equals*>. The Example section includes a type that could safely suppress a warning from this rule.  
  
## Examples of Inconsistent Equality Definitions  
  
### Description  
 The following example shows a type with inconsistent definitions of equality. `BadPoint` changes the meaning of equality by providing a custom implementation of the equality operator, but does not override <xref:System.Object.Equals*> so that it behaves identically.  
  
### Code  
 [!code[FxCop.Usage.OperatorEqualsRequiresEquals#1](../vs140/codesnippet/CSharp/ca2224--override-equals-on-overloading-operator-equals_1.cs)]  
  
## Example  
 The following code tests the behavior of `BadPoint`.  
  
 [!code[FxCop.Usage.TestOperatorEqualsRequiresEquals#1](../vs140/codesnippet/CSharp/ca2224--override-equals-on-overloading-operator-equals_2.cs)]  
  
 This example produces the following output.  
  
 **a =  ([0] 1,1) and b = ([1] 2,2) are equal? No**  
**a == b ? No**  
**a1 and a are equal? Yes**  
**a1 == a ? Yes**  
**b and bcopy are equal ? No**  
**b == bcopy ? Yes**   
## Example  
 The following example shows a type that technically violates this rule, but does not behave in an inconsistent manner.  
  
 [!code[FxCop.Usage.ValueTypeEquals#1](../vs140/codesnippet/CSharp/ca2224--override-equals-on-overloading-operator-equals_3.cs)]  
  
## Example  
 The following code tests the behavior of `GoodPoint`.  
  
 [!code[FxCop.Usage.TestValueTypeEquals#1](../vs140/codesnippet/CSharp/ca2224--override-equals-on-overloading-operator-equals_4.cs)]  
  
 This example produces the following output.  
  
 **a =  (1,1) and b = (2,2) are equal? No**  
**a == b ? No**  
**a1 and a are equal? Yes**  
**a1 == a ? Yes**  
**b and bcopy are equal ? Yes**  
**b == bcopy ? Yes**   
## Class Example  
  
### Description  
 The following example shows a class (reference type) that violates this rule.  
  
### Code  
 [!code[FxCop.Usage.OverrideEqualsClassViolation#1](../vs140/codesnippet/CSharp/ca2224--override-equals-on-overloading-operator-equals_5.cs)]  
  
## Example  
 The following example fixes the violation by overriding <xref:System.Object.Equals*?displayProperty=fullName>.  
  
 [!code[FxCop.Usage.OverrideEqualsClassFixed#1](../vs140/codesnippet/CSharp/ca2224--override-equals-on-overloading-operator-equals_6.cs)]  
  
## Structure Example  
  
### Description  
 The following example shows a structure (value type) that violates this rule.  
  
### Code  
 [!code[FxCop.Usage.OverrideEqualsStructViolation#1](../vs140/codesnippet/CSharp/ca2224--override-equals-on-overloading-operator-equals_7.cs)]  
  
## Example  
 The following example fixes the violation by overriding <xref:System.ValueType.Equals*?displayProperty=fullName>.  
  
 [!code[FxCop.Usage.OverrideEqualsStructFixed#1](../vs140/codesnippet/CSharp/ca2224--override-equals-on-overloading-operator-equals_8.cs)]  
  
## Related Rules  
 [Do not override operator equals on reference types](../vs140/ca1046--do-not-overload-operator-equals-on-reference-types.md)  
  
 [Operator overloads have named alternates](../vs140/ca2225--operator-overloads-have-named-alternates.md)  
  
 [Operators should have symmetrical overloads](../vs140/ca2226--operators-should-have-symmetrical-overloads.md)  
  
 [Override GetHashCode on overriding Equals](../vs140/ca2218--override-gethashcode-on-overriding-equals.md)  
  
 [Override operator equals on overriding value type equals](../vs140/ca2231--overload-operator-equals-on-overriding-valuetype.equals.md)