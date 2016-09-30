---
title: "Compiler Error CS0208"
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
  - "CS0208"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0208"
ms.assetid: 03534893-1522-4dab-9822-8b9ed97b3bd0
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0208
Cannot take the address of, get the size of, or declare a pointer to a managed type ('type')  
  
 Even when used with the [unsafe](../vs140/unsafe--csharp-reference-.md) keyword, taking the address of a managed object, getting the size of a managed object, or declaring a pointer to a managed type is not allowed. A managed type is:  
  
-   any reference type  
  
-   any struct that contains a reference type as a field or property  
  
 For more information, see [Unsafe Code and Pointers (C# Programmers Reference)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md) and [sizeof](../vs140/sizeof--csharp-reference-.md).  
  
## Example  
 The following sample generates CS0208:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [sizeof (C# Reference)](../vs140/sizeof--csharp-reference-.md)