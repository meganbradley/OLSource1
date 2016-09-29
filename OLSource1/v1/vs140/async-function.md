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
  
```cpp  
template<class Fn, class... ArgTypes>  
   future<typename result_of<Fn(ArgTypes...)>::type>;  
      async(Fn&& fn, ArgTypes&&... args);  
template<class Fn, class... ArgTypes>  
   future<typename result_of<Fn(ArgTypes...)>::type>;  
      async(launch policy, Fn&& fn, ArgTypes&&... args);  
```  
  
#### Parameters  
 `policy`  
 A [launch](../vs140/launch-enumeration.md) value.  
  
## Remarks  
 Definitions of abbreviations:  
  
|||  
|-|-|  
|*dfn*|The result of calling `decay_copy(forward<Fn>(fn))`.|  
|*dargs*|The results of the calls `decay_copy(forward<ArgsTypes>(args…))`.|  
|*Ty*|The type `result_of<Fn(ArgTypes…)>::type`.|  
  
 The first template function returns `async(launch::any, fn, args…)`.  
  
 The second function returns a `future<Ty>` object whose *associated asynchronous state* holds a result together with the values of *dfn* and *dargs* and a thread object to manage a separate thread of execution.  
  
 Unless `decay<Fn>::type` is a type other than launch, the second function does not participate in overload resolution.  
  
 If `policy` is `launch::any`, the function might choose `launch::async` or `launch::deferred`. In this implementation, the function uses `launch::async`.  
  
 If `policy` is `launch::async`, the function creates a thread that evaluates `INVOKE(dfn, dargs..., Ty)`. The function returns after it creates the thread without waiting for results. If the system can't start a new thread, the function throws a [system_error](../vs140/system_error-class.md) that has an error code of `resource_unavailable_try_again`.  
  
 If `policy` is `launch::deferred`, the function marks its associated asynchronous state as holding a *deferred function* and returns. The first call to any non-timed function that waits for the associated asynchronous state to be ready in effect calls the deferred function by evaluating `INVOKE(dfn, dargs..., Ty)`.  
  
 In all cases, the associated asynchronous state of the `future` object is not set to *ready* until the evaluation of `INVOKE(dfn, dargs…, Ty)` completes, either by throwing an exception or by returning normally. The result of the associated asynchronous state is an exception if one was thrown, or any value that's returned by the evaluation.  
  
> [!NOTE]
>  For a `future`—or the last [shared_future](../vs140/shared_future-class.md)—that's attached to a task started with `std::async`, the destructor blocks if the task has not completed; that is, it blocks if this thread did not yet call `.get()` or `.wait()` and the task is still running. If a `future` obtained from `std::async` is moved outside the local scope, other code that uses it must be aware that its destructor may block for the shared state to become ready.  
  
 The pseudo-function `INVOKE` is defined in [\<functional>](../vs140/-functional-.md).  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<future>](../vs140/-future-.md)   
 [result_of Class](../vs140/result_of-class2.md)   
 [future Class](../vs140/future-class.md)