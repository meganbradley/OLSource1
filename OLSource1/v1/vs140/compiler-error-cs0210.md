---
title: "Compiler Error CS0210"
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
  - "CS0210"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0210"
ms.assetid: 9f2ec1b8-6ca4-4147-b004-e3b43e7e8754
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0210
You must provide an initializer in a fixed or using statement declaration  
  
 You must declare and initialize the variable in a [fixed statement](../vs140/fixed-statement--csharp-reference-.md). For more information, see [Unsafe Code and Pointers (C# Programmers Reference)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md).  
  
 The following sample generates CS0210:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample also generates CS0210 because the [using statement](../vs140/using-statement--csharp-reference-.md) has no initializer.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>