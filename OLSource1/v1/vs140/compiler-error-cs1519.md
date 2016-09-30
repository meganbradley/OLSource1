---
title: "Compiler Error CS1519"
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
  - "CS1519"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1519"
ms.assetid: 186cef8e-c6c7-49aa-8b43-f6c2cb628414
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1519
Invalid token 'token' in class, struct, or interface member declaration  
  
 This error is generated whenever a token is encountered in a location where it does not belong. A *token* is a keyword; an identifier (the name of a class, struct, method, and so on); a string, character, or numeric literal value such as 108, "Hello", or 'A'; or an operator or punctuator such as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 Any [class](../vs140/class--csharp-reference-.md), struct, or interface member declaration that contains invalid modifiers before the type will generate this error. To fix the error, remove the invalid modifiers.  
  
 The following sample generates CS1519 in five places because tokens are placed in locations where they are not valid:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Classes (C# Programming Guide)](../vs140/classes--csharp-programming-guide-.md)   
 [Structs (C# Programming Guide)](../vs140/structs--csharp-programming-guide-.md)   
 [Interfaces (C# Programming Guide)](../vs140/interfaces--csharp-programming-guide-.md)   
 [Methods (C# Programming Guide)](../vs140/methods--csharp-programming-guide-.md)