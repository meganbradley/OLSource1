---
title: "Compiler Error CS0558"
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
  - "CS0558"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0558"
ms.assetid: af63b9ba-2790-4362-a49d-b69a5292a555
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0558
User-defined operator 'operator' must be declared static and public  
  
 Both the **static** and **public** access [modifiers](../vs140/modifiers--csharp-reference-.md) must be specified on user-defined operators.  
  
 The following sample generates CS0558:  
  
```  
// CS0558.cs  
namespace x  
{  
   public class ii  
   {  
      public class iii  
      {  
         static implicit operator int(iii aa)   // CS0558, add public  
         {  
            return 0;  
         }  
      }  
  
      public static void Main()  
      {  
      }  
   }  
}  
```