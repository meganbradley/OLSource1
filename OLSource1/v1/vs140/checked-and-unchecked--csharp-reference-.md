---
title: "Checked and Unchecked (C# Reference)"
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
helpviewer_keywords: 
  - "operators [C#], checked and unchecked"
  - "exceptions [C#], overflow checking"
  - "checked statement [C#]"
  - "overflow checking [C#]"
  - "unchecked statement [C#]"
  - "statements [C#], checked and unchecked"
ms.assetid: a84bc877-2c7f-4396-8735-1ce97c42f35e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Checked and Unchecked (C# Reference)
C# statements can execute in either checked or unchecked context. In a checked context, arithmetic overflow raises an exception. In an unchecked context, arithmetic overflow is ignored and the result is truncated.  
  
-   [checked](../vs140/checked--csharp-reference-.md) Specify checked context.  
  
-   [unchecked](../vs140/unchecked--csharp-reference-.md) Specify unchecked context.  
  
 If neither <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is specified, the default context depends on external factors such as compiler options.  
  
 The following operations are affected by the overflow checking:  
  
-   Expressions using the following predefined operators on integral types:  
  
     <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> - (unary)   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> -   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
-   Explicit numeric conversions between integral types.  
  
 The [/checked](../vs140/-checked--csharp-compiler-options-.md) compiler option lets you specify checked or unchecked context for all integer arithmetic statements that are not explicitly in the scope of a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword.  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Statement Keywords](../vs140/statement-keywords--csharp-reference-.md)