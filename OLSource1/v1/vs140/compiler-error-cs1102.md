---
title: "Compiler Error CS1102"
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
  - "CS1102"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1102"
ms.assetid: 7de798d4-1b4b-4842-ae43-9bc83e6dc9a3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1102
The parameter modifier 'out' cannot be used with 'this'.  
  
 When the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword modifies the first parameter of a static method, it signals to the compiler that the method is an extension method. No other modifiers are needed or allowed on the first parameter of an extension method.  
  
### To correct this error  
  
1.  Remove the unauthorized modifiers from the first parameter.  
  
## Example  
 The following example generates CS1102:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Extension Methods (C# Programming Guide)](../vs140/extension-methods--csharp-programming-guide-.md)   
 [this (C# Reference)](../vs140/this--csharp-reference-.md)   
 [out (C# Reference)](../vs140/out--csharp-reference-.md)