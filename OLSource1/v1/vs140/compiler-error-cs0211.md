---
title: "Compiler Error CS0211"
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
  - "CS0211"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0211"
ms.assetid: 720be9a9-b0c1-4391-94e5-4c4027e83036
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0211
Cannot take the address of the given expression  
  
 You can take the address of fields, local variables, and indirection of pointers, but you cannot take, for example, the address of the sum of two local variables. For more information, see [Unsafe Code and Pointers (C# Programmers Reference)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md).  
  
 The following sample generates CS0211:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>