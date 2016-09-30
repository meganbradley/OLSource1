---
title: "Compiler Error CS1528"
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
  - "CS1528"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1528"
ms.assetid: 38aabc5c-b32f-4bea-a585-c4212f42751d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1528
Expected ; or = (cannot specify constructor arguments in declaration)  
  
 A reference to a class was formed as if an object to the class was being created. For example, there was an attempt to pass a variable to a constructor. Use the [new](../vs140/new--csharp-reference-.md) operator to create an object of a class.  
  
 The following sample generates CS1528:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>