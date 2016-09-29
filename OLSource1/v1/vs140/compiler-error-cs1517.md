---
title: "Compiler Error CS1517"
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
  - "CS1517"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1517"
ms.assetid: 3b0201fb-8fab-4e6a-9ad9-f04c0de89517
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1517
Invalid preprocessor expression  
  
 The compiler encountered an invalid preprocessor expression.  
  
 For more information, see [Preprocessor Directives](../vs140/csharp-preprocessor-directives.md).  
  
 The following sample shows some valid and invalid preprocessor expressions:  
  
```  
// CS1517.cs  
#if symbol      // OK  
#endif  
#if !symbol     // OK  
#endif  
#if (symbol)    // OK  
#endif  
#if true        // OK  
#endif  
#if false       // OK  
#endif  
#if 1           // CS1517  
#endif  
#if ~symbol     // CS1517  
#endif  
#if *           // CS1517  
#endif  
  
class x  
{  
   public static void Main()  
   {  
   }  
}  
```