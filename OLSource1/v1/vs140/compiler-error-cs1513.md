---
title: "Compiler Error CS1513"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1513"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1513"
ms.assetid: 28dacbb5-bf60-49ac-878e-c0ce469114eb
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1513
} expected  
  
 The compiler expected a closing curly brace (`}`) that was not found.  
  
 The following sample generates CS1513:  
  
```  
// CS1513  
namespace y   // CS1513, no close curly brace  
{  
   class x  
   {  
      public static void Main()  
      {  
      }  
   }  
```