---
title: "Compiler Warning (level 3) CS0168"
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
  - "CS0168"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0168"
ms.assetid: 6f5b7fe3-1e91-462f-8a73-b931327ab3f5
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) CS0168
The variable 'var' is assigned but its value is never used  
  
 The compiler warns when a variable is declared but not used.  
  
 The following sample generates two CS0168 warnings:  
  
```  
// CS0168.cs  
// compile with: /W:3  
public class clx  
{  
   public int i;  
}  
  
public class clz  
{  
   public static void Main()  
   {  
      int j = 0;   // CS0168, uncomment the following line  
      // j++;  
      clx a;       // CS0168, try the following line instead  
      // clx a = new clx();  
   }  
}  
```