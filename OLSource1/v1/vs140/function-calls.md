---
title: "Function Calls"
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
  - "function calls, C functions"
  - "functions [C], calling"
  - "function calls, about function calls"
  - "function calls"
ms.assetid: 2cfa897d-3874-4820-933c-e624f75d1712
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Function Calls
A *function call* is an expression that passes control and arguments (if any) to a function and has the form:  
  
 *expression* (*expression-list*opt)  
  
 where *expression* is a function name or evaluates to a function address and *expression-list* is a list of expressions (separated by commas). The values of these latter expressions are the arguments passed to the function. If the function does not return a value, then you declare it to be a function that returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 If a declaration exists before the function call, but no information is given concerning the parameters, any undeclared arguments simply undergo the usual arithmetic conversions.  
  
> [!NOTE]
>  The expressions in the function argument list can be evaluated in any order, so arguments whose values may be changed by side effects from another argument have undefined values. The sequence point defined by the function-call operator guarantees only that all side effects in the argument list are evaluated before control passes to the called function. (Note that the order in which arguments are pushed on the stack is a separate matter.) See [Sequence Points](../vs140/c-sequence-points.md) for more information.  
  
 The only requirement in any function call is that the expression before the parentheses must evaluate to a function address. This means that a function can be called through any function-pointer expression.  
  
## Example  
 This example illustrates function calls called from a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In this example, the function call in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>,  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 passes an integer variable, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and the address of the function <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to the function <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Note that the function address is passed simply by giving the function identifier, since a function identifier evaluates to a pointer expression. To use a function identifier in this way, the function must be declared or defined before the identifier is used; otherwise, the identifier is not recognized. In this case, a prototype for <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is given at the beginning of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function.  
  
 The parameter <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is declared to be a pointer to a function taking one <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> argument and returning a **long** value. The parentheses around the parameter name are required; without them, the declaration would specify a function returning a pointer to a **long** value.  
  
 The function <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> calls the selected function from inside the **for** loop by using the following function call:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 One argument, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, is passed to the called function.  
  
## See Also  
 [Functions (C)](../vs140/functions--c-.md)