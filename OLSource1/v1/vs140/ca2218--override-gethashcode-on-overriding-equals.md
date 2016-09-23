---
title: "CA2218: Override GetHashCode on overriding Equals"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CA2218
  - OverrideGetHashCodeOnOverridingEquals
helpviewer_keywords: 
  - OverrideGetHashCodeOnOverridingEquals
  - CA2218
ms.assetid: 69b020cd-29e8-45a6-952e-32cf3ce2e21d
caps.latest.revision: 24
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CA2218: Override GetHashCode on overriding Equals
|||  
|-|-|  
|TypeName|OverrideGetHashCodeOnOverridingEquals|  
|CheckId|CA2218|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A public type overrides <xref:System.Object.Equals?qualifyHint=True> but does not override <xref:System.Object.GetHashCode?qualifyHint=True>.  
  
## Rule Description  
 <xref:System.Object.GetHashCode?qualifyHint=False> returns a value, based on the current instance, that is suited for hashing algorithms and data structures such as a hash table. Two objects that are the same type and are equal must return the same hash code to ensure that instances of the following types work correctly:  
  
-   <xref:System.Collections.HashTable?qualifyHint=True>  
  
-   <xref:System.Collections.SortedList?qualifyHint=True>  
  
-   <xref:System.Collections.Generic.Dictionary?qualifyHint=True>  
  
-   <xref:System.Collections.Generic.SortDictionary?qualifyHint=True>  
  
-   <xref:System.Collections.Generic.SortList?qualifyHint=True>  
  
-   <xref:System.Collections.Specialized.HybredDictionary?qualifyHint=True>  
  
-   <xref:System.Collections.Specialized.ListDictionary?qualifyHint=True>  
  
-   <xref:System.Collections.Specialized.OrderedDictionary?qualifyHint=True>  
  
-   Types that implement <xref:System.Collections.Generic.IEqualityComparer?qualifyHint=True>  
  
## How to Fix Violations  
 To fix a violation of this rule, provide an implementation of <xref:System.Object.GetHashCode?qualifyHint=False>. For a pair of objects of the same type, you must ensure that the implementation returns the same value if your implementation of <xref:System.Object.Equals?qualifyHint=False> returns `true` for the pair.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Class Example  
  
### Description  
 The following example shows a class (reference type) that violates this rule.  
  
### Code  
 [!code[FxCop.Usage.GetHashCodeErrorClass#1](../vs140/codesnippet/CSharp/ca2218--override-gethashcode-on-overriding-equals_1.cs)]
  
  
### Comments  
 The following example fixes the violation by overriding <xref:System.Object.GetHashCode?qualifyHint=False>.  
  
### Code  
 [!code[FxCop.Usage.GetHashCodeFixedClass#1](../vs140/codesnippet/CSharp/ca2218--override-gethashcode-on-overriding-equals_2.cs)]
  
  
## Structure Example  
  
### Description  
 The following example shows a structure (value type) that violates this rule.  
  
### Code  
 [!code[FxCop.Usage.GetHashCodeErrorStruct#1](../vs140/codesnippet/CSharp/ca2218--override-gethashcode-on-overriding-equals_3.cs)]
  
  
### Comments  
 The following example fixes the violation by overriding <xref:System.Object.GetHashCode?qualifyHint=False>.  
  
### Code  
 [!code[FxCop.Usage.GetHashCodeFixedStruct#1](../vs140/codesnippet/CSharp/ca2218--override-gethashcode-on-overriding-equals_4.cs)]
  
  
## Related Rules  
 [Do not override operator equals on reference types](../vs140/ca1046--do-not-overload-operator-equals-on-reference-types.md)  
  
 [Operator overloads have named alternates](../vs140/ca2225--operator-overloads-have-named-alternates.md)  
  
 [Operators should have symmetrical overloads](../vs140/ca2226--operators-should-have-symmetrical-overloads.md)  
  
 [Override equals on overriding operator equals](../vs140/ca2224--override-equals-on-overloading-operator-equals.md)  
  
 [Override operator equals on overriding value type equals](../vs140/ca2231--overload-operator-equals-on-overriding-valuetype.equals.md)  
  
## See Also  
 <xref:System.Object.Equals?qualifyHint=True>   
 <xref:System.Object.GetHashCode?qualifyHint=True>   
 <xref:System.Collections.HashTable?qualifyHint=True>   
 [Guidelines for Implementing Equals and the Equality Operator (==)](assetId:///bc496a91-fefb-4ce0-ab4c-61f09964119a)