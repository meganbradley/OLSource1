---
title: "thread Class"
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
  - "thread/std::thread"
dev_langs: 
  - "C++"
ms.assetid: df249bc7-ff81-4ff9-a6d6-5e3d9a8f56a1
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# thread Class
Defines an object that's used to observe and manage a thread of execution within an application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 You can use a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object to observe and manage a thread of execution within an application. A thread object that's created by using the default constructor is not associated with any thread of execution. A thread object that's constructed by using a callable object creates a new thread of execution and calls the callable object in that thread. Thread objects can be moved but not copied. Therefore, a thread of execution can be associated with only one thread object.  
  
 Every thread of execution has a unique identifier of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. The function <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> returns the identifier of the calling thread. The member function <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns the identifier of the thread that's managed by a thread object. For a default-constructed thread object, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method returns an object that has a value that's the same for all default-constructed thread objects and different from the value that's returned by <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> for any thread of execution that could be joined at the time of the call.  
  
## Members  
  
### Public Classes  
  
|Name|Description|  
|----------|-----------------|  
|[thread::id Class](#thread__id_class)|Uniquely identifies the associated thread.|  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[thread::thread Constructor](#thread__thread_constructor)|Constructs a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[thread::detach Method](#thread__detach_method)|Detaches the associated thread from the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
|[thread::get_id Method](#thread__get_id_method)|Returns the unique identifier of the associated thread.|  
|[thread::hardware_concurrency Method](#thread__hardware_concurrency_method)|Static. Returns an estimate of the number of hardware thread contexts.|  
|[thread::join Method](#thread__join_method)|Blocks until the associated thread completes.|  
|[thread::joinable Method](#thread__joinable_method)|Specifies whether the associated thread is joinable.|  
|[thread::native_handle Method](#thread__native_handle_method)|Returns the implementation-specific type that represents the thread handle.|  
|[thread::swap Method](#thread__swap_method)|Swaps the object state with a specified <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[thread::operator= Operator](#thread__operator_eq)|Associates a thread with the current <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
  
## Requirements  
 **Header:** thread  
  
 **Namespace:** std  
  
##  \<a name="thread__detach_method">\</a>  thread::detach Method  
 Detaches the associated thread. The operating system becomes responsible for releasing thread resources on termination.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 After a call to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, subsequent calls to [get_id](#thread__get_id_method) return [id](#thread__id_class).  
  
 If the thread that's associated with the calling object is not joinable, the function throws a [system_error](../vs140/system_error-class.md) that has an error code of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 If the thread that's associated with the calling object is invalid, the function throws a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
##  \<a name="thread__get_id_method">\</a>  thread::get_id Method  
 Returns a unique identifier for the associated thread.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A [thread::id](#thread__id_class) object that uniquely identifies the associated thread, or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> if no thread is associated with the object.  
  
##  \<a name="thread__hardware_concurrency_method">\</a>  thread::hardware_concurrency Method  
 Static method that returns an estimate of the number of hardware thread contexts.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 An estimate of the number of hardware thread contexts. If the value cannot be computed or is not well defined, this method returns 0.  
  
##  \<a name="thread__id_class">\</a>  thread::id Class  
 Provides a unique identifier for each thread of execution in the process.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The default constructor creates an object that does not compare equal to the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object for any existing thread.  
  
 All default-constructed <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> objects compare equal.  
  
##  \<a name="thread__join_method">\</a>  thread::join Method  
 Blocks until the thread of execution that's associated with the calling object completes.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 If the call succeeds, subsequent calls to [get_id](#thread__get_id_method) for the calling object return a default [thread::id](#thread__id_class) that does not compare equal to the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> of any existing thread; if the call does not succeed, the value that's returned by <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is unchanged.  
  
##  \<a name="thread__joinable_method">\</a>  thread::joinable Method  
 Specifies whether the associated thread is *joinable*.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if the associated thread is *joinable*; otherwise, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
### Remarks  
 A thread object is *joinable* if <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
##  \<a name="thread__native_handle_method">\</a>  thread::native_handle Method  
 Returns the implementation-specific type that represents the thread handle. The thread handle can be used in implementation-specific ways.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is defined as a Win32 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> that's cast as <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
##  \<a name="thread__operator_eq">\</a>  thread::operator=  
 Associates the thread of a specified object with the current object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
### Remarks  
 The method calls detach if the calling object is joinable.  
  
 After the association is made, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is set to a default-constructed state.  
  
##  \<a name="thread__swap_method">\</a>  thread::swap Method  
 Swaps the object state with that of a specified <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.  
  
##  \<a name="thread__thread_constructor">\</a>  thread::thread Constructor  
 Constructs a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 An application-defined function to be executed by the thread.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A list of arguments to be passed to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 An existing <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The first constructor constructs an object that's not associated with a thread of execution. The value that's returned by a call to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> for the constructed object is <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
 The second constructor constructs an object that's associated with a new thread of execution and executes the pseudo-function <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> that's defined in [\<functional>](../vs140/-functional-.md). If not enough resources are available to start a new thread, the function throws a [system_error](../vs140/system_error-class.md) object that has an error code of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. If the call to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> terminates with an uncaught exception, [terminate](../vs140/-exception--functions.md#terminate) is called.  
  
 The third constructor constructs an object that's associated with the thread that's associated with <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is then set to a default-constructed state.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<thread>](../vs140/-thread-.md)