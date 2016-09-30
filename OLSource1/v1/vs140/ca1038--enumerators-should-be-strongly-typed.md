---
title: "CA1038: Enumerators should be strongly typed"
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
  - "EnumeratorsShouldBeStronglyTyped"
  - "CA1038"
helpviewer_keywords: 
  - "EnumeratorsShouldBeStronglyTyped"
  - "CA1038"
ms.assetid: 8919f526-d487-42a4-87dc-2b2ee25260c4
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CA1038: Enumerators should be strongly typed
|||  
|-|-|  
|TypeName|EnumeratorsShouldBeStronglyTyped|  
|CheckId|CA1038|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected type implements \<xref:System.Collections.IEnumerator*?displayProperty=fullName> but does not provide a strongly typed version of the \<xref:System.Collections.IEnumerator.Current*?displayProperty=fullName> property. Types that are derived from the following types are exempt from this rule:  
  
-   \<xref:System.Collections.CollectionBase*?displayProperty=fullName>  
  
-   \<xref:System.Collections.DictionaryBase*?displayProperty=fullName>  
  
-   \<xref:System.Collections.ReadOnlyCollectionBase*?displayProperty=fullName>  
  
## Rule Description  
 This rule requires \<xref:System.Collections.IEnumerator*> implementations to also provide a strongly typed version of the \<xref:System.Collections.IEnumerator.Current*> property so that users are not required to cast the return value to the strong type when they use the functionality that is provided by the interface. This rule assumes that the type that implements \<xref:System.Collections.IEnumerator*> contains a collection of instances of a type that is stronger than \<xref:System.Object*>.  
  
## How to Fix Violations  
 To fix a violation of this rule, implement the interface property explicitly (declare it as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>). Add a public strongly typed version of the property, declared as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and have it return a strongly typed object.  
  
## When to Suppress Warnings  
 Suppress a warning from this rule when you implement an object-based enumerator for use with an object-based collection, such as a binary tree. Types that extend the new collection will define the strongly typed enumerator and expose the strongly typed property.  
  
## Example  
 The following example demonstrates the correct way to implement a strongly typed \<xref:System.Collections.IEnumerator*> type.  
  
 [!code[FxCop.Design.IEnumeratorStrongTypes#1](../vs140/codesnippet/CSharp/ca1038--enumerators-should-be-strongly-typed_1.cs)]  
  
## Related Rules  
 [ICollection implementations have strongly typed members](../vs140/ca1035--icollection-implementations-have-strongly-typed-members.md)  
  
 [Lists are strongly typed](../vs140/ca1039--lists-are-strongly-typed.md)  
  
## See Also  
 \<xref:System.Collections.IEnumerator*?displayProperty=fullName>   
 \<xref:System.Collections.CollectionBase*?displayProperty=fullName>   
 \<xref:System.Collections.DictionaryBase*?displayProperty=fullName>   
 \<xref:System.Collections.ReadOnlyCollectionBase*?displayProperty=fullName>