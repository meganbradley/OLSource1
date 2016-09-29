---
title: "Compiler Warning (level 4) CS0028"
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
  - "CS0028"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0028"
ms.assetid: 47df919f-01fa-45ae-a4b7-912445e679e2
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) CS0028
'function declaration' has the wrong signature to be an entry point  
  
 The method declaration for `Main` was invalid: it was declared with an invalid signature. `Main` must be declared as static and it must return either [int](../vs140/int--csharp-reference-.md) or [void](../vs140/void--csharp-reference-.md). For more information, see [Main() and Command-Line Arguments](../vs140/main---and-command-line-arguments--csharp-programming-guide-.md).  
  
 The following sample generates CS0028:  
  
```  
// CS0028.cs  
// compile with: /W:4 /warnaserror  
public class a  
{  
    public static double Main(int i)   // CS0028  
    // Try the following line instead:  
    // public static void Main()  
    {  
    }  
}  
```