---
title: "Null-conditional Operators (C# and Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 9c7b2c8f-a785-44ca-836c-407bfb6d27f5
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Null-conditional Operators (C# and Visual Basic)
Used to test for null before performing a member access (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) or index (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) operation.  These operators help you write less code to handle null checks, especially for descending into data structures.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The last example demonstrates that the null-condition operators are short-circuiting.  If one operation in a chain of conditional member access and index operation returns null, then the rest of the chain’s execution stops.  Other operations with lower precedence in the expression continue.  For example, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the following always executes, and the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> operations execute.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Another use for the null-condition member access is invoking delegates in a thread-safe way with much less code.  The old way requires code like the following:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The new way is much simpler:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The new way is thread-safe because the compiler generates code to evaluate <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> one time only, keeping the result in temporary variable.  
  
 You need to explicitly call the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method because there is no null-conditional delegate invocation syntax <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  There were too many ambiguous parsing situations to allow it.  
  
## Language Specifications  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
 For more information, see the [Visual Basic Language Reference](../vs140/visual-basic-language-reference.md).  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Visual Basic Language Reference](../vs140/visual-basic-language-reference.md)   
 [Visual Basic Programming Guide](../vs140/visual-basic-programming-guide.md)