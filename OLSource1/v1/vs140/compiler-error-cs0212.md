---
title: "Compiler Error CS0212"
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
  - "CS0212"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0212"
ms.assetid: 1b8973b8-03c9-42a6-bf61-2e401b89387e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0212
You can only take the address of an unfixed expression inside of a fixed statement initializer  
  
 For more information, see [Unsafe Code and Pointers (C# Programmer's Reference)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md).  
  
 The following sample shows how to take the address of an unfixed expression. The following sample generates CS0212.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample also generates CS0212 and shows how to resolve the error:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>