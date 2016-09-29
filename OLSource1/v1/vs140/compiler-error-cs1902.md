---
title: "Compiler Error CS1902"
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
  - "CS1902"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1902"
ms.assetid: 120c5978-9ebc-4ec1-bcec-f840af6fdf5d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1902
Invalid option 'option' for /debug; must be full or pdbonly  
  
 An invalid option was passed to the [/debug](../vs140/-debug--csharp-compiler-options-.md) compiler option.  
  
 The following sample generates CS1902:  
  
```  
// CS1902.cs  
// compile with: /debug:x  
// CS1902 expected  
class x  
{  
   public static void Main()  
   {  
   }  
}  
```