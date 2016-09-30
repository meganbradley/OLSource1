---
title: "Compiler Error CS0146"
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
  - "CS0146"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0146"
ms.assetid: 2be796e5-da2c-4939-af12-3145cd1828c8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0146
Circular base class dependency involving 'class1' and 'class2'  
  
 The inheritance list for a class includes a direct or indirect reference to itself. A class cannot inherit from itself. For more information, see [Inheritance (C# Programmer's Reference)](../vs140/inheritance--csharp-programming-guide-.md).  
  
 The following sample generates CS0146:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>