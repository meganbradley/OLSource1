---
title: "Compiler Error CS1579"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1579"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1579"
ms.assetid: 1eba84ce-58df-4fe3-9134-e26efefdc4ab
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1579
foreach statement cannot operate on variables of type 'type1' because 'type2' does not contain a public definition for 'identifier'  
  
 To iterate through a collection using the [foreach](../vs140/foreach--in--csharp-reference-.md) statement, the collection must meet the following requirements:  
  
-   It must be an interface, class or struct.  
  
-   It must include a public \<xref:System.Collections.IEnumerable.GetEnumerator*> method that returns a type.  
  
-   The return type must contain a public property named \<xref:System.Collections.IEnumerator.Current*>, and a public method named \<xref:System.Collections.IEnumerator.MoveNext*>.  
  
-   For more information, see [How to: Access a Collection Class with foreach (C#)](../vs140/how-to--access-a-collection-class-with-foreach--csharp-programming-guide-.md).  
  
## Example  
 In this sample, [foreach](../vs140/foreach--in--csharp-reference-.md) is not able to iterate through the collection because there is no <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>\<xref:System.Collections.IEnumerable.GetEnumerator*> method in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 The following sample generates CS1579.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>