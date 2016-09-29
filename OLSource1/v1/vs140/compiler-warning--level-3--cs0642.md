---
title: "Compiler Warning (level 3) CS0642"
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
  - "CS0642"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0642"
ms.assetid: e2df58c0-9b7e-4e50-8e31-e0134955f62c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) CS0642
Possible mistaken empty statement  
  
 A semicolon after a conditional statement may cause your code to execute differently than intended.  
  
 You can use **/nowarn** compiler option or `#pragmas warning` to disable this warning; see [/nowarn (Suppress Specified Warnings) (C# Compiler Options)](../vs140/-nowarn--csharp-compiler-options-.md) or [#pragma warning (C# Reference)](../vs140/sharppragma-warning--csharp-reference-.md) for more information.  
  
 The following sample generates CS0642:  
  
```  
// CS0642.cs  
// compile with: /W:3  
class MyClass  
{  
   public static void Main()  
   {  
      int i;  
  
      for (i = 0; i < 10; i += 1);   // CS0642 semicolon intentional?  
      {  
         System.Console.WriteLine (i);  
      }  
   }  
}  
```