---
title: "Compiler Error CS0115"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0115"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0115"
ms.assetid: a0e4bd8a-a6c2-4568-8ea5-8bb1d2ad0e95
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0115
'function' : no suitable method found to override  
  
 A method was marked as an override, but the compiler found no method to override. For more information, see [override (C# Programmer's Reference)](../vs140/override--csharp-reference-.md), and [Knowing When to Use Override and New Keywords (C# Programmer's Reference)](../vs140/knowing-when-to-use-override-and-new-keywords--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0115. You can resolve CS0115 in one of two ways:  
  
-   Remove the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword from the method in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
-   Use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> as a base class for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>