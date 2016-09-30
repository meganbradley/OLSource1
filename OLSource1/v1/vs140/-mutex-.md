---
title: "&lt;mutex&gt;"
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
  - "<mutex>"
dev_langs: 
  - "C++"
ms.assetid: efb60c89-687a-4e38-8fe4-694e11c4e8a3
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;mutex&gt;
Include the standard header \<mutex> to define the classes <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; the templates <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; and supporting types and functions that define mutual-exclusion code regions.  
  
> [!WARNING]
>  The STL synchronization types in Visual Studio 2015 are based on Windows synchronization primitives and no longer use ConcRT (except when the target platform is Windows XP). The types defined in \<mutex> should not be used with any ConcRT types or functions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
> [!NOTE]
>  In code that is compiled by using **/clr** or **/clr:pure**, this header is blocked.  
  
 The classes <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> are *mutex types*. A mutex type has a default constructor and a destructor that does not throw exceptions. These objects have methods that provide mutual exclusion when multiple threads try to lock the same object. Specifically, a mutex type contains the methods <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>:  
  
-   The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method blocks the calling thread until the thread obtains ownership of the mutex. Its return value is ignored.  
  
-   The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method tries to obtain ownership of the mutex without blocking. Its return type is convertible to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if the method obtains ownership, but is otherwise <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
-   The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method releases the ownership of the mutex from the calling thread.  
  
 You can use mutex types as type arguments to instantiate the templates <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. You can use objects of these types as the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> argument to the wait member functions in the template [condition_variable_any](../vs140/condition_variable_any-class.md).  
  
 A *timed mutex type* satisfies the requirements for a mutex type. In addition, it has the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> methods that must be callable by using one argument and must return a type that is convertible to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. A timed mutex type can define these functions by using additional arguments, provided that those additional arguments all have default values.  
  
-   The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method must be callable by using one argument, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, whose type is an instantiation of [chrono::duration](../vs140/duration-class.md). The method tries to obtain ownership of the mutex, but returns within the time that is designated by <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, regardless of success. The return value converts to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> if the method obtains ownership; otherwise, the return value converts to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
-   The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method must be callable by using one argument, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, whose type is an instantiation of [chrono::time_point](../vs140/time_point-class.md). The method tries to obtain ownership of the mutex, but returns no later than the time that is designated by <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, regardless of success. The return value converts to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> if the method obtains ownership; otherwise, the return value converts to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
 A mutex type is also known as a *lockable type*. If it does not provide the member function <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, it is a *basic lockable type*. A timed mutex type is also known as a *timed lockable type*.  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[lock_guard Class](../vs140/lock_guard-class.md)|Represents a template that can be instantiated to create an object whose destructor unlocks a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.|  
|[mutex Class](../vs140/mutex-class--stl-.md)|Represents a mutex type. Use objects of this type to enforce mutual exclusion within a program.|  
|[recursive_mutex Class](../vs140/recursive_mutex-class.md)|Represents a mutex type. In constrast to the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> class, the behavior of calling locking methods for objects that are already locked is well-defined.|  
|[recursive_timed_mutex Class](../vs140/recursive_timed_mutex-class.md)|Represents a timed mutex type. Use objects of this type to enforce mutual exclusion that has time-limited blocking within a program. Unlike objects of type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, the effect of calling locking methods for <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> objects is well-defined.|  
|[timed_mutex Class](../vs140/timed_mutex-class.md)|Represents a timed mutex type. Use objects of this type to enforce mutual exclusion that has time-limited blocking within a program.|  
|[unique_lock Class](../vs140/unique_lock-class.md)|Represents a template that can be instantiated to create objects that manage the locking and unlocking of a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.|  
  
### Functions  
  
|Name|Description|  
|----------|-----------------|  
|[call_once Function](../vs140/-mutex--functions.md#call_once_function)|Provides a mechanism for calling a specified callable object exactly once during execution.|  
|[lock Function](../vs140/-mutex--functions.md#lock_function)|Attempts to lock all arguments without deadlock.|  
  
### Structs  
  
|Name|Description|  
|----------|-----------------|  
|[adopt_lock_t Structure](../vs140/adopt_lock_t-structure.md)|Represents a type that is used to define an <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.|  
|[defer_lock_t Structure](../vs140/defer_lock_t-structure.md)|Represents a type that defines a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object that is used to select one of the overloaded constructors of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.|  
|[once_flag Structure](../vs140/once_flag-structure.md)|Represents a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> that is used with the template function <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> to ensure that initialization code is called only once, even in the presence of multiple threads of execution.|  
|[try_to_lock_t Structure](../vs140/try_to_lock_t-structure.md)|Represents a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> that defines a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object and is used to select one of the overloaded constructors of <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.|  
  
### Variables  
  
|Name|Description|  
|----------|-----------------|  
|[adopt_lock Variable](../vs140/-mutex--functions.md#adopt_lock_variable)|Represents an object that can be passed to constructors for <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to indicate that the mutex object that is also being passed to the constructor is locked.|  
|[defer_lock Variable](../vs140/-mutex--functions.md#defer_lock_variable)|Represents an object that can be passed to the constructor for <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, to indicate that the constructor should not lock the mutex object that is also being passed to it.|  
|[try_to_lock Variable](../vs140/-mutex--functions.md#try_to_lock_variable)|Represents an object that can be passed to the constructor for <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to indicate that the constructor should try to unlock the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> that is also being passed to it without blocking.|  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)