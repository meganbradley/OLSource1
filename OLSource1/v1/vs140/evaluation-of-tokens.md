---
title: "Evaluation of Tokens"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tokens, evaluating"
ms.assetid: 28870b62-dff6-4644-8b75-d58f340b48d2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Evaluation of Tokens
When the compiler interprets tokens, it includes as many characters as possible in a single token before moving on to the next token. Because of this behavior, the compiler may not interpret tokens as you intended if they are not properly separated by white space. Consider the following expression:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, the compiler first makes the longest possible operator (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>) from the three plus signs, then processes the remaining plus sign as an addition operator (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>). Thus, the expression is interpreted as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, not <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. In this and similar cases, use white space and parentheses to avoid ambiguity and ensure proper expression evaluation.  
  
 **Microsoft Specific**  
  
 The C compiler treats a CTRL+Z character as an end-of-file indicator. It ignores any text after CTRL+Z.  
  
 **END Microsoft Specific**  
  
## See Also  
 [C Tokens](../vs140/c-tokens.md)