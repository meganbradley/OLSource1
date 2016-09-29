---
title: "CA2218: Override GetHashCode on overriding Equals"
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
  - "CA2218"
  - "OverrideGetHashCodeOnOverridingEquals"
helpviewer_keywords: 
  - "OverrideGetHashCodeOnOverridingEquals"
  - "CA2218"
ms.assetid: 69b020cd-29e8-45a6-952e-32cf3ce2e21d
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA2218: Override GetHashCode on overriding Equals
|||  
|-|-|  
|TypeName|OverrideGetHashCodeOnOverridingEquals|  
|CheckId|CA2218|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 A public type overrides <xref:System.Object.Equals*?displayProperty=fullName> but does not override <xref:System.Object.GetHashCode*?displayProperty=fullName>.  
  
## Rule Description  
 <xref:System.Object.GetHashCode*> returns a value, based on the current instance, that is suited for hashing algorithms and data structures such as a hash table. Two objects that are the same type and are equal must return the same hash code to ensure that instances of the following types work correctly:  
  
-   <xref:System.Collections.HashTable*?displayProperty=fullName>  
  
-   <xref:System.Collections.SortedList*?displayProperty=fullName>  
  
-   <xref:System.Collections.Generic.Dictionary*?displayProperty=fullName>  
  
-   <xref:System.Collections.Generic.SortDictionary*?displayProperty=fullName>  
  
-   <xref:System.Collections.Generic.SortList*?displayProperty=fullName>  
  
-   <xref:System.Collections.Specialized.HybredDictionary*?displayProperty=fullName>  
  
-   <xref:System.Collections.Specialized.ListDictionary*?displayProperty=fullName>  
  
-   <xref:System.Collections.Specialized.OrderedDictionary*?displayProperty=fullName>  
  
-   Types that implement <xref:System.Collections.Generic.IEqualityComparer*?displayProperty=fullName>  
  
## How to Fix Violations  
 To fix a violation of this rule, provide an implementation of <xref:System.Object.GetHashCode*>. For a pair of objects of the same type, you must ensure that the implementation returns the same value if your implementation of <xref:System.Object.Equals*> returns `true` for the pair.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Class Example  
  
### Description  
 The following example shows a class (reference type) that violates this rule.  
  
### Code  
 [!code[FxCop.Usage.GetHashCodeErrorClass#1](../VS_csharp/codesnippet/CSharp/ca2218--override-gethashcode-on-overriding-equals_1.cs)]  
  
### Comments  
 The following example fixes the violation by overriding <xref:System.Object.GetHashCode*>.  
  
### Code  
 [!code[FxCop.Usage.GetHashCodeFixedClass#1](../VS_csharp/codesnippet/CSharp/ca2218--override-gethashcode-on-overriding-equals_2.cs)]  
  
## Structure Example  
  
### Description  
 The following example shows a structure (value type) that violates this rule.  
  
### Code  
 [!code[FxCop.Usage.GetHashCodeErrorStruct#1](../VS_csharp/codesnippet/CSharp/ca2218--override-gethashcode-on-overriding-equals_3.cs)]  
  
### Comments  
 The following example fixes the violation by overriding <xref:System.Object.GetHashCode*>.  
  
### Code  
 [!code[FxCop.Usage.GetHashCodeFixedStruct#1](../VS_csharp/codesnippet/CSharp/ca2218--override-gethashcode-on-overriding-equals_4.cs)]  
  
## Related Rules  
 [Do not override operator equals on reference types](../VS_csharp/ca1046--do-not-overload-operator-equals-on-reference-types.md)  
  
 [Operator overloads have named alternates](../VS_csharp/ca2225--operator-overloads-have-named-alternates.md)  
  
 [Operators should have symmetrical overloads](../VS_csharp/ca2226--operators-should-have-symmetrical-overloads.md)  
  
 [Override equals on overriding operator equals](../VS_csharp/ca2224--override-equals-on-overloading-operator-equals.md)  
  
 [Override operator equals on overriding value type equals](../VS_csharp/ca2231--overload-operator-equals-on-overriding-valuetype.equals.md)  
  
## See Also  
 <xref:System.Object.Equals*?displayProperty=fullName>   
 <xref:System.Object.GetHashCode*?displayProperty=fullName>   
 <xref:System.Collections.HashTable*?displayProperty=fullName>   
 [Guidelines for Implementing Equals and the Equality Operator (==)](assetId:///bc496a91-fefb-4ce0-ab4c-61f09964119a)