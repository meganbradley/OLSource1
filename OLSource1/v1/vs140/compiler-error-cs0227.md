---
title: "Compiler Error CS0227"
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
  - "CS0227"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0227"
ms.assetid: b595a1c9-8204-4ff7-a1d0-258b0b1d6ff7
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0227
Unsafe code may only appear if compiling with /unsafe  
  
 If source code contains the [unsafe](../vs140/unsafe--csharp-reference-.md) keyword, then the [/unsafe](../vs140/-unsafe--csharp-compiler-options-.md) compiler option must also be used. For more information, see [Unsafe Code and Pointers (C# Programmers Reference)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md).  
  
 To set the unsafe option in [!INCLUDE[vs_current_long](../vs140/includes/vs_current_long_md.md)], click on **Project** in the main menu, select the **Build** pane, and check the box that says "allow unsafe code."  
  
 The following sample, when compiled without **/unsafe**, will generate CS0227:  
  
```  
// CS0227.cs  
public class MyClass  
{  
   unsafe public static void Main()   // CS0227  
   {  
   }  
}  
```  
  
## See Also  
 [C# Compiler Errors](../vs140/csharp-compiler-errors.md)