---
title: "Compiler Error CS1011"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CS1011
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS1011
ms.assetid: d4568471-b0f8-4c24-89f3-9c543521d1d8
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS1011
Empty character literal  
  
 A [char](../vs140/char--csharp-reference-.md) was declared and initialized to a null. The initialization of a `char` must specify a character.  
  
 The following sample generates CS1011:  
  
```  
// CS1011.cs  
class Sample  
{  
   public char CharField = '';   // CS1011  
}  
```