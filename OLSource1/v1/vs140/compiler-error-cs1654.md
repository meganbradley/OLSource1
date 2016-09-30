---
title: "Compiler Error CS1654"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1654"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1654"
ms.assetid: 471c1298-1908-449d-b765-8dc3cd81a11d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1654
Cannot modify members of 'variable' because it is a 'read-only variable type'  
  
 This error occurs when you try to modify members of a variable which is read-only because it is in a special construct.  
  
 One common area that this occurs is within [foreach](../vs140/foreach--in--csharp-reference-.md) loops. It is a compile-time error to modify the value of the collection elements. Therefore, you cannot make any modifications to elements that are [value types](../vs140/value-types--csharp-reference-.md), including [structs](../vs140/structs--csharp-programming-guide-.md). In a collection whose elements are [reference types](../vs140/reference-types--csharp-reference-.md), you can modify accessible members of each element, but any try to add or remove or replace complete elements will generate [Compiler Error CS1656](../vs140/compiler-error-cs1656.md).  
  
## Example  
 The following example generates error CS1654 because <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. To fix the error, change the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to a [class](../vs140/class--csharp-reference-.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>