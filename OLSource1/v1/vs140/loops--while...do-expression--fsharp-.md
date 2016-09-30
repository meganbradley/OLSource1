---
title: "Loops: while...do Expression (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "loops [F#]"
  - "do keyword [F#]"
  - "while keyword [F#]"
ms.assetid: 69b80e73-83e2-4939-aa56-47e8d122f508
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Loops: while...do Expression (F#)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expression is used to perform iterative execution (looping) while a specified test condition is true.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is evaluated; if it is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is executed and the test expression is evaluated again. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> must have type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. If the test expression is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the iteration ends.  
  
 The following example illustrates the use of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> expression.  
  
 [!code[FsLangRef2#5301](../vs140/codesnippet/FSharp/loops--while...do-expression--fsharp-_1.fs)]  
  
 The output of the previous code is a stream of random numbers between 1 and 20, the last of which is 10.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
> [!NOTE]
>  You can use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in sequence expressions and other computation expressions, in which case a customized version of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> expression is used. For more information, see [Sequences (F#)](../vs140/sequences--fsharp-.md), [Asynchronous Workflows (F#)](../vs140/asynchronous-workflows--fsharp-.md), and [Computation Expressions (F#)](../vs140/computation-expressions--fsharp-.md).  
  
## See Also  
 [F# Language Reference](../vs140/fsharp-language-reference.md)   
 [Loops: for...in Expression](../vs140/loops--for...in-expression--fsharp-.md)   
 [Loops: for...to Expression](../vs140/loops--for...to-expression--fsharp-.md)