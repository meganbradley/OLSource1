---
title: "Compiler Error CS1520"
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
  - "CS1520"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1520"
ms.assetid: 1aeeee83-52a6-45dc-b197-a9a6de3a220c
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1520
Method must have a return type  
  
 A method that is declared in a class, struct, or interface must have an explicit return type. In the following example, the Square method has a return value of [string](../vs140/string--csharp-reference-.md):  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following sample generates CS1520:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Alternatively, this error might be encountered when the case of a constructor's name differs from that of the class or struct declaration, as in the following sample. Because the name is not exactly the same as the class name, the compiler interprets it as a regular method, not a constructor, and produces the error:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Methods (C# Programming Guide)](../vs140/methods--csharp-programming-guide-.md)   
 [Constructors (C# Programming Guide)](../vs140/constructors--csharp-programming-guide-.md)