---
title: "Compiler Error CS0575"
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
  - "CS0575"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0575"
ms.assetid: e8f20960-94a6-41d0-807c-d49ad198ccf6
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0575
Only class types can contain destructors  
  
 A [struct](../vs140/struct--csharp-reference-.md) cannot contain a destructor.  
  
 The following sample generates CS0575:  
  
```  
// CS0575.cs  
namespace x  
{  
   public struct iii  
   {  
      ~iii()   // CS0575  
      {  
      }  
  
      public static void Main()  
      {  
      }  
   }  
}  
```