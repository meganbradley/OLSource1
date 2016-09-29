---
title: "Compiler Warning (level 2) CS0652"
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
  - "CS0652"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0652"
ms.assetid: 1ec1cee6-858a-4104-aa15-2668723c6331
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) CS0652
Comparison to integral constant is useless; the constant is outside the range of type 'type'  
  
 The compiler detected a comparison between a constant and a variable where the constant is out of the range of the variable.  
  
 The following sample generates CS0652:  
  
```  
// CS0652.cs  
// compile with: /W:2  
public class Class1  
{  
   private static byte i = 0;  
   public static void Main()  
   {  
      short j = 256;  
      if (i == 256)   // CS0652, 256 is out of range for byte  
         i = 0;  
   }  
}  
```