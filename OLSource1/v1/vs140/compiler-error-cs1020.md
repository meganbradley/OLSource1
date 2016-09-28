---
title: "Compiler Error CS1020"
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
  - "CS1020"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1020"
ms.assetid: e8860769-a847-4248-a37b-77a59863467c
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1020
Overloadable binary operator expected  
  
 An attempt was made to define an [operator overload](../vs140/overloadable-operators--csharp-programming-guide-.md), but the operator was not a binary operator, which takes two parameters.  
  
 The following sample generates CS1020:  
  
```  
// CS1020.cs  
public class iii  
{  
   public static int operator ++(iii aa, int bb)   // CS1020, change ++ to +  
   {  
      return 0;  
   }  
  
   public static void Main()  
   {  
   }  
}  
```