---
title: "parallel_invoke Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ppl/concurrency::parallel_invoke"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "parallel_invoke function"
ms.assetid: 8c8fe553-f372-4138-b9c6-e31b0e83eb9b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# parallel_invoke Function
Executes the function objects supplied as parameters in parallel, and blocks until they have finished executing. Each function object could be a lambda expression, a pointer to function, or any object that supports the function call operator with the signature <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type of the first function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type of the second function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The type of the third function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The type of the fourth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The type of the fifth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The type of the sixth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The type of the seventh function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The type of the eighth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The type of the ninth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The type of the tenth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The first function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The second function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The third function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The fourth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The fifth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 The sixth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The seventh function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The eighth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The ninth function object to be executed in parallel.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The tenth function object to be executed in parallel.  
  
## Remarks  
 Note that one or more of the function objects supplied as parameters may execute inline on the calling context.  
  
 If one or more of the function objects passed as parameters to this function throws an exception, the runtime will select one such exception of its choosing and propagate it out of the call to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 For more information, see [Parallel Algorithms](../vs140/parallel-algorithms.md).  
  
## Requirements  
 **Header:** ppl.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)