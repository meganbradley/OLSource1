---
title: "&lt;future&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 1e3acc1e-736a-42dc-ade2-b2fe69aa96bc
caps.latest.revision: 13
---
# &lt;future&gt; functions
||||  
|-|-|-|  
|[async Function](#async_function)|[future_category Function](#future_category_function)|[make_error_code Function](#make_error_code_function)|  
|[make_error_condition Function](#make_error_condition_function)|[swap Function](#swap_function)|  
  
##  \<a name="async_function">\</a>  async Function  
 Represents an *asynchronous provider*.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A [launch](../vs140/-future--enums.md#launch_enumeration) value.  
  
### Remarks  
 Definitions of abbreviations:  
  
|||  
|-|-|  
|*dfn*|The result of calling <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|*dargs*|The results of the calls <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|  
|*Ty*|The type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
  
 The first template function returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The second function returns a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object whose *associated asynchronous state* holds a result together with the values of                         *dfn* and                         *dargs* and a thread object to manage a separate thread of execution.  
  
 Unless <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is a type other than launch, the second function does not participate in overload resolution.  
  
 If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the function might choose <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. In this implementation, the function uses <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the function creates a thread that evaluates <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. The function returns after it creates the thread without waiting for results. If the system can't start a new thread, the function throws a [system_error](../vs140/system_error-class.md) that has an error code of <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, the function marks its associated asynchronous state as holding a *deferred function* and returns. The first call to any non-timed function that waits for the associated asynchronous state to be ready in effect calls the deferred function by evaluating <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 In all cases, the associated asynchronous state of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object is not set to *ready* until the evaluation of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> completes, either by throwing an exception or by returning normally. The result of the associated asynchronous state is an exception if one was thrown, or any value that's returned by the evaluation.  
  
> [!NOTE]
>  For a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>—or the last [shared_future](../vs140/shared_future-class.md)—that's attached to a task started with <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, the destructor blocks if the task has not completed; that is, it blocks if this thread did not yet call <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and the task is still running. If a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> obtained from <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is moved outside the local scope, other code that uses it must be aware that its destructor may block for the shared state to become ready.  
  
 The pseudo-function <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> is defined in [\<functional>](../vs140/-functional-.md).  
  
##  \<a name="future_category_function">\</a>  future_category Function  
 Returns a reference to the [error_category](../vs140/error_category-class.md) object that characterizes errors that are associated with <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="make_error_code_function">\</a>  make_error_code Function  
 Creates an [error_code](../vs140/error_code-class.md) together with the [error_category](../vs140/error_category-class.md) object that characterizes [future](../vs140/future-class.md) errors.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A [future_errc](../vs140/-future--enums.md#future_errc_enumeration) value that identifies the reported error.  
  
### Return Value  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
##  \<a name="make_error_condition_function">\</a>  make_error_condition Function  
 Creates an [error_condition](../vs140/error_condition-class.md) together with the [error_category](../vs140/error_category-class.md) object that characterizes [future](../vs140/future-class.md) errors.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A [future_errc](../vs140/-future--enums.md#future_errc_enumeration) value that identifies the reported error.  
  
### Return Value  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
##  \<a name="swap_function">\</a>  swap Function  
 Exchanges the *associated asynchronous state* of one <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object with that of another.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The left <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The right <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.  
  
## See Also  
 [&lt;future&gt;](../vs140/-future-.md)