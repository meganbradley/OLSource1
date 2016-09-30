---
title: "async Function"
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
  - "future/std::async"
dev_langs: 
  - "C++"
ms.assetid: 9ca49127-584e-4d92-a01a-9fa8bd9f5f7a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# async Function
Represents an *asynchronous provider*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A [launch](../vs140/launch-enumeration.md) value.  
  
## Remarks  
 Definitions of abbreviations:  
  
|||  
|-|-|  
|*dfn*|The result of calling <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.|  
|*dargs*|The results of the calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.|  
|*Ty*|The type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
  
 The first template function returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 The second function returns a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object whose *associated asynchronous state* holds a result together with the values of *dfn* and *dargs* and a thread object to manage a separate thread of execution.  
  
 Unless <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is a type other than launch, the second function does not participate in overload resolution.  
  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, the function might choose <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. In this implementation, the function uses <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the function creates a thread that evaluates <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. The function returns after it creates the thread without waiting for results. If the system can't start a new thread, the function throws a [system_error](../vs140/system_error-class.md) that has an error code of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the function marks its associated asynchronous state as holding a *deferred function* and returns. The first call to any non-timed function that waits for the associated asynchronous state to be ready in effect calls the deferred function by evaluating <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 In all cases, the associated asynchronous state of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object is not set to *ready* until the evaluation of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> completes, either by throwing an exception or by returning normally. The result of the associated asynchronous state is an exception if one was thrown, or any value that's returned by the evaluation.  
  
> [!NOTE]
>  For a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>—or the last [shared_future](../vs140/shared_future-class.md)—that's attached to a task started with <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, the destructor blocks if the task has not completed; that is, it blocks if this thread did not yet call <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and the task is still running. If a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> obtained from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is moved outside the local scope, other code that uses it must be aware that its destructor may block for the shared state to become ready.  
  
 The pseudo-function <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is defined in [\<functional>](../vs140/-functional-.md).  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<future>](../vs140/-future-.md)   
 [result_of Class](../vs140/result_of-class2.md)   
 [future Class](../vs140/future-class.md)