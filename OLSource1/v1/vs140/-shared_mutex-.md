---
title: "&lt;shared_mutex&gt;"
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
  - "<shared_mutex>"
  - "shared_mutex/std::swap"
  - "shared_mutex/std::shared_lock"
  - "shared_mutex/std::shared_lock::shared_lock"
  - "shared_mutex/std::shared_lock::operator="
  - "shared_mutex/std::shared_lock::operator ="
  - "shared_mutex/std::shared_lock::lock"
  - "shared_mutex/std::shared_lock::try_lock"
  - "shared_mutex/std::shared_lock::try_lock_for"
  - "shared_mutex/std::shared_lock::try_lock_until"
  - "shared_mutex/std::shared_lock::unlock"
  - "shared_mutex/std::shared_lock::swap"
  - "shared_mutex/std::shared_lock::release"
  - "shared_mutex/std::shared_lock::owns_lock"
  - "shared_mutex/std::shared_lock::operator bool"
  - "shared_mutex/std::shared_lock::mutex"
  - "shared_mutex/std::shared_mutex"
  - "shared_mutex/std::shared_mutex::native_handle_type"
  - "shared_mutex/std::shared_mutex::shared_mutex"
  - "shared_mutex/std::shared_mutex::operator="
  - "shared_mutex/std::shared_mutex::operator ="
  - "shared_mutex/std::shared_mutex::lock"
  - "shared_mutex/std::shared_mutex::try_lock"
  - "shared_mutex/std::shared_mutex::unlock"
  - "shared_mutex/std::shared_mutex::lock_shared"
  - "shared_mutex/std::shared_mutex::try_lock_shared"
  - "shared_mutex/std::shared_mutex::unlock_shared"
  - "shared_mutex/std::shared_mutex::native_handle"
  - "shared_mutex/std::shared_timed_mutex"
  - "shared_mutex/std::shared_timed_mutex::shared_timed_mutex"
  - "shared_mutex/std::shared_timed_mutex::operator="
  - "shared_mutex/std::shared_timed_mutex::operator ="
  - "shared_mutex/std::shared_timed_mutex::lock"
  - "shared_mutex/std::shared_timed_mutex::try_lock"
  - "shared_mutex/std::shared_timed_mutex::try_lock_for"
  - "shared_mutex/std::shared_timed_mutex::try_lock_until"
  - "shared_mutex/std::shared_timed_mutex::unlock"
  - "shared_mutex/std::shared_timed_mutex::lock_shared"
  - "shared_mutex/std::shared_timed_mutex::try_lock_shared"
  - "shared_mutex/std::shared_timed_mutex::try_lock_shared_for"
  - "shared_mutex/std::shared_timed_mutex::try_lock_shared_until"
  - "shared_mutex/std::shared_timed_mutex::unlock_shared"
dev_langs: 
  - "C++"
ms.assetid: 0b37a97d-ee5d-4050-b29f-09db9f76beb3
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# &lt;shared_mutex&gt;
The \<shared_mutex> header provides synchronization primitives for protection of shared data that can be accessed by multiple threads. In addition to the exclusive access control provided by mutex classes, the shared mutex classes also allow shared ownership by multiple threads for non-exclusive access. Shared mutexes can be used to control resources that can be read by several threads without causing a race condition, but must be written exclusively by a single thread.  
  
 The header \<shared_mutex> defines the classes <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the template class <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and the template function <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for shared mutex support.  
  
|Classes|Description|  
|-------------|-----------------|  
|[shared_mutex Class](../vs140/-shared_mutex-.md#class_shared_mutex)|A shared mutex type that can be locked exclusively by one agent or shared non-exclusively by multiple agents.|  
|[shared_timed_mutex Class](../vs140/-shared_mutex-.md#class_shared_timed_mutex)|A shared timed mutex type that can be locked exclusively by one agent or shared non-exclusively by multiple agents.|  
|[shared_lock Class](../vs140/-shared_mutex-.md#class_shared_lock)|A template class that wraps a shared mutex to support timed lock operations and non-exclusive sharing by multiple agents.|  
  
|Functions|Description|  
|---------------|-----------------|  
|[swap Function](../vs140/-shared_mutex-.md#function_swap)|Swaps the content of the shared mutex objects referenced by the function parameters.|  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 An instance of the class <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is a *shared mutex type*, a type that controls the shared ownership of a mutex within a scope. A shared mutex type meets all the requirements of a mutex type, as well as members to support shared non-exclusive ownership.  
  
 A shared mutex type supports the additional methods <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>:  
  
-   The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method blocks the calling thread until the thread obtains shared ownership of the mutex.  
  
-   The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method releases shared ownership of the mutex held by the calling thread.  
  
-   The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method tries to obtain shared ownership of the mutex without blocking. Its return type is convertible to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and is <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> if the method obtains ownership, but is otherwise <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 The class <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a *shared timed mutex type*, a type that meets the requirements of both a shared mutex type and a timed mutex type.  
  
 A shared timed mutex type supports the additional methods <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>:  
  
-   The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> method attempts to obtain shared ownership of the mutex until the duration specified by the parameter has passed. If the duration is not positive, the method is equivalent to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. The method does not return within the duration specified unless shared ownership is obtained. Its return value is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if the method obtains ownership, but is otherwise <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
-   The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> method attempts to obtain shared ownership of the mutex until the specified absolute time has passed. If the specified time has already passed, the method is equivalent to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. The method does not return before the time specified unless shared ownership is obtained. Its return value is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if the method obtains ownership, but is otherwise <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> template class extends support for timed locking and transfer of ownership to a shared mutex. Ownership of the mutex may be obtained at or after construction, and may be transferred to another <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object. Objects of type <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> can be moved, but not copied.  
  
> [!WARNING]
>  The STL synchronization types in Visual Studio 2015 are based on Windows synchronization primitives and no longer use ConcRT (except when the target platform is Windows XP). The types defined in \<shared_mutex> should not be used with any ConcRT types or functions.  
  
## Classes  
  
###  \<a name="class_shared_mutex">\</a> shared_mutex Class  
 Class <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> implements a non-recursive mutex with shared ownership semantics.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
###  \<a name="class_shared_timed_mutex">\</a> shared_timed_mutex Class  
 Class <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> implements a non-recursive mutex with shared ownership semantics that meets the requirements of a timed mutex type.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
###  \<a name="class_shared_lock">\</a> shared_lock Class  
 Template class <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> controls the shared ownership of a shared mutex object within a scope. The template parameter must be a shared mutex type.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Functions  
  
###  \<a name="function_swap">\</a> swap Function  
 Swaps the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> objects.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Exchanges the content of two <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> objects. Effectively the same as <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<shared_mutex>  
  
 **Namespace:** std  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<mutex>](../vs140/-mutex-.md)