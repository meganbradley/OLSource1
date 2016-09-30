---
title: "Unhandled C++ Exceptions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "event handlers, unhandled exceptions"
  - "catch keyword [C++], handler not found"
  - "exceptions, unhandled"
  - "C++ exception handling, unhandled exceptions"
  - "unhandled exceptions"
ms.assetid: 13f09c53-9254-4407-9db9-14e730e047cc
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unhandled C++ Exceptions
If a matching handler (or ellipsis **catch** handler) cannot be found for the current exception, the predefined <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> run-time function is called. (You can also explicitly call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in any of your handlers.) The default action of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is to call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If you want <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to call some other function in your program before exiting the application, call the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> function with the name of the function to be called as its single argument. You can call <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> at any point in your program. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> routine always calls the last function given as an argument to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Example  
 The following example throws a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> exception, but does not contain a handler designated to catch exceptions of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The call to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> instructs <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to call <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> function should terminate the program or current thread, ideally by calling <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. If it doesn't, and instead returns to its caller, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is called.  
  
## See Also  
 [C++ Exception Handling](../vs140/c---exception-handling.md)