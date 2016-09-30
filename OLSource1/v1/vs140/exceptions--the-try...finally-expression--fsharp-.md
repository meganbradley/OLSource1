---
title: "Exceptions: The try...finally Expression (F#)"
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
  - "exceptions [F#], try...finally expression"
  - "try-finally expression [F#]"
  - "finally keyword [F#]"
  - "try...finally expression [F#]"
  - "try keyword [F#]"
ms.assetid: 767c7719-fdae-450a-897c-babc928eaae9
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exceptions: The try...finally Expression (F#)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> expression enables you to execute clean-up code even if a block of code throws an exception.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> expression can be used to execute the code in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the preceding syntax regardless of whether an exception is generated during the execution of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The type of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> does not contribute to the value of the whole expression; the type returned when an exception does not occur is the last value in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. When an exception does occur, no value is returned and the flow of control transfers to the next matching exception handler up the call stack. If no exception handler is found, the program terminates. Before the code in a matching handler is executed or the program terminates, the code in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> branch is executed.  
  
 The following code demonstrates the use of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> expression.  
  
 [!code[FsLangRef2#5701](../vs140/codesnippet/FSharp/exceptions--the-try...finally-expression--fsharp-_1.fs)]  
  
 The output to the console is as follows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 As you can see from the output, the stream was closed before the outer exception was handled, and the file <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> contains the text <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, which indicates that the buffers were flushed and written to disk even though the exception transferred control to the outer exception handler.  
  
 Note that the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> construct is a separate construct from the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> construct. Therefore, if your code requires both a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> block and a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> block, you have to nest the two constructs, as in the following code example.  
  
 [!code[FsLangRef2#5702](../vs140/codesnippet/FSharp/exceptions--the-try...finally-expression--fsharp-_2.fs)]  
  
 In the context of computation expressions, including sequence expressions and asynchronous workflows, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> expressions can have a custom implementation. For more information, see [Computation Expressions (F#)](../vs140/computation-expressions--fsharp-.md).  
  
## See Also  
 [Exception Handling](../vs140/exception-handling--fsharp-.md)   
 [Exceptions: the try .. with Expression](../vs140/exceptions--the-try...with-expression--fsharp-.md)