---
title: "&lt;mutex&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 78ab3c8b-c7db-4226-ac93-e2e78ff8b964
caps.latest.revision: 13
---
# &lt;mutex&gt; functions
||||  
|-|-|-|  
|[adopt_lock Variable](#adopt_lock_variable)|[call_once Function](#call_once_function)|[defer_lock Variable](#defer_lock_variable)|  
|[lock Function](#lock_function)|[try_to_lock Variable](#try_to_lock_variable)|  
  
##  \<a name="adopt_lock_variable">\</a>  adopt_lock Variable  
 Represents an object that can be passed to constructors for [lock_guard](../vs140/lock_guard-class.md) and [unique_lock](../vs140/unique_lock-class.md) to indicate that the mutex object that is also being passed to the constructor is locked.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
##  \<a name="call_once_function">\</a>  call_once Function  
 Provides a mechanism for calling a specified callable object exactly once during execution.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A [once_flag](../vs140/once_flag-structure.md) object that ensures that the callable object is only called once.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A callable object.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 An argument list.  
  
### Remarks  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is not valid, the function throws a [system_error](../vs140/system_error-class.md) that has an error code of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Otherwise, the template function uses its <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> argument to ensure that it calls <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> successfully exactly once, regardless of how many times the template function is called. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> exits by throwing an exception, the call was not successful.  
  
##  \<a name="defer_lock_variable">\</a>  defer_lock Variable  
 Represents an object that can be passed to the constructor for [unique_lock](../vs140/unique_lock-class.md). This indicates that the constructor should not lock the mutex object that's also being passed to it.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="lock_function">\</a>  lock Function  
 Attempts to lock all arguments without deadlock.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 The arguments to the template function must be *mutex types*, except that calls to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> might throw exceptions.  
  
 The function locks all of its arguments without deadlock by calls to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. If a call to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> throws an exception, the function calls <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> on any of the mutex objects that were successfully locked before rethrowing the exception.  
  
##  \<a name="try_to_lock_variable">\</a>  try_to_lock Variable  
 Represents an object that can be passed to the constructor for [unique_lock](../vs140/unique_lock-class.md) to indicate that the constructor should try to unlock the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> that is also being passed to it without blocking.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [&lt;mutex&gt;](../vs140/-mutex-.md)