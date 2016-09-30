---
title: "Compiler Error CS0549"
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
  - "CS0549"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0549"
ms.assetid: ae965019-9dee-4f28-9e9a-6f379bd0d757
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0549
'function' is a new virtual member in sealed class 'class'  
  
 A [sealed](../vs140/sealed--csharp-reference-.md)[class](../vs140/class--csharp-reference-.md) cannot be used as a base class.  Therefore, it is useless to have a virtual method in sealed class.  
  
 The following sample generates CS0549:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>