---
title: "Compiler Error CS1059"
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
  - "CS1059"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1059"
ms.assetid: 3ebd02ab-e40d-4aad-b901-a0cb6e2eace7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1059
The operand of an increment or decrement operator must be a variable, property or indexer.  
  
 This error is raised when you try to increment or decrement a constant value. It can also occur if you try to increment an expression such as <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
### To correct this error  
  
-   Make the variable non-const.  
  
-   Remove the increment or decrement operator.  
  
-   Store the expression in a variable, and then increment the variable.  
  
## Example  
 The following example generates CS1059 because <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a constant, not a variable, and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is an <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> type, whose elements are also constant values.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Constants (C# Programming Guide)](../vs140/constants--csharp-programming-guide-.md)