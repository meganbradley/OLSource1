---
title: "packaged_task Class"
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
  - "future/std::packaged_task"
dev_langs: 
  - "C++"
ms.assetid: 0a72cbe3-f22a-4bfe-8e50-dcb268c98780
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# packaged_task Class
Describes an *asynchronous provider* that is a call wrapper whose call signature is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Its *associated asynchronous state* holds a copy of its callable object in addition to the potential result.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[packaged_task::packaged::task Constructor](#packaged_task__packaged_task_constructor)|Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
|[packaged_task::~packaged_task Destructor](#packaged_task___dtorpackaged_task_destructor)|Destroys a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[packaged_task::get_future Method](#packaged_task__get_future_method)|Returns a [future](../vs140/future-class.md) object that has the same associated asynchronous state.|  
|[packaged_task::make_ready_at_thread_exit Method](#packaged_task__make_ready_at_thread_exit_method)|Calls the callable object that's stored in the associated asynchronous state and atomically stores the returned value.|  
|[packaged_task::reset Method](#packaged_task__reset_method)|Replaces the associated asynchronous state.|  
|[packaged_task::swap Method](#packaged_task__swap_method)|Exchanges the associated asynchronous state with that of a specified object.|  
|[packaged_task::valid Method](#packaged_task__valid_method)|Specifies whether the object has an associated asynchronous state.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[packaged_task::operator=](#packaged_task__operator_eq)|Transfers an associated asynchronous state from a specified object.|  
|[packaged_task::operator()](#packaged_task__operator__)|Calls the callable object that's stored in the associated asynchronous state, atomically stores the returned value, and sets the state to *ready*.|  
|[packaged_task::operator bool](#packaged_task__operator_bool)|Specifies whether the object has an associated asynchronous state.|  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
##  \<a name="packaged_task__get_future_method">\</a>  packaged_task::get_future Method  
 Returns an object of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> that has the same *associated asynchronous state*.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object does not have an associated asynchronous state, this method throws a [future_error](../vs140/future_error-class.md) that has an error code of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 If this method has already been called for a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object that has the same associated asynchronous state, the method throws a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
##  \<a name="packaged_task__make_ready_at_thread_exit_method">\</a>  packaged_task::make_ready_at_thread_exit Method  
 Calls the callable object that's stored in the *associated asynchronous state* and atomically stores the returned value.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 If the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object doesn't have an associated asynchronous state, this method throws a [future_error](../vs140/future_error-class.md) that has an error code of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 If this method or [make_ready_at_thread_exit](#packaged_task__make_ready_at_thread_exit_method) has already been called for a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object that has the same associated asynchronous state, the method throws a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
 Otherwise, this operator calls <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, where                         *fn* is the callable object that's stored in the associated asynchronous state. Any returned value is stored atomically as the returned result of the associated asynchronous state.  
  
 In contrast to [packaged_task::operator() Operator](#packaged_task__operator__), the associated asynchronous state is not set to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> until after all thread-local objects in the calling thread have been destroyed. Typically, threads that are blocked on the associated asynchronous state are not unblocked until the calling thread exits.  
  
##  \<a name="packaged_task__operator_eq">\</a>  packaged_task::operator=  
 Transfers the *associated asynchronous state* from a specified object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
### Remarks  
 After the operation, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> no longer has an associated asynchronous state.  
  
##  \<a name="packaged_task__operator__">\</a>  packaged_task::operator()  
 Calls the callable object that's stored in the *associated asynchronous state*, atomically stores the returned value, and sets the state to *ready*.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 If the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object doesn't have an associated asynchronous state, this method throws a [future_error](../vs140/future_error-class.md) that has an error code of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
 If this method or [make_ready_at_thread_exit](#packaged_task__make_ready_at_thread_exit_method) has already been called for a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object that has the same associated asynchronous state, the method throws a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 Otherwise, this operator calls <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, where                         *fn* is the callable object that's stored in the associated asynchronous state. Any returned value is stored atomically as the returned result of the associated asynchronous state, and the state is set to ready. As a result, any threads that are blocked on the associated asynchronous state become unblocked.  
  
##  \<a name="packaged_task__operator_bool">\</a>  packaged_task::operator bool  
 Specifies whether the object has an <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> if the object has an associated asynchronous state; otherwise, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
##  \<a name="packaged_task__packaged_task_constructor">\</a>  packaged_task::packaged_task Constructor  
 Constructs a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A memory allocator. For more information, see [\<allocators>](../vs140/-allocators-.md).  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A function object.  
  
### Remarks  
 The first constructor constructs a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object that has no *associated asynchronous state*.  
  
 The second constructor constructs a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object and transfers the associated asynchronous state from <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. After the operation, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> no longer has an associated asynchronous state.  
  
 The third constructor constructs a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> object that has a copy of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> stored in its associated asynchronous state.  
  
 The fourth constructor constructs a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object that has a copy of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> stored in its associated asynchronous state, and uses <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> for memory allocation.  
  
##  \<a name="packaged_task___dtorpackaged_task_destructor">\</a>  packaged_task::~packaged_task Destructor  
 Destroys a <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 If the *associated asynchronous state* is not *ready*, the destructor stores a [future_error](../vs140/future_error-class.md) exception that has an error code of <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> as the result in the associated asynchronous state, and any threads that are blocked on the associated asynchronous state become unblocked.  
  
##  \<a name="packaged_task__reset_method">\</a>  packaged_task::reset Method  
 Uses a new *associated asynchronous state* to replace the existing associated asynchronous state.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 In effect, this method executes <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, where                         *fn* is the function object that's stored in the associated asynchronous state for this object. Therefore, the state of the object is cleared, and [get_future](#packaged_task__get_future_method), [operator()](#packaged_task__operator__), and [make_ready_at_thread_exit](#packaged_task__make_ready_at_thread_exit_method) can be called as if on a newly-constructed object.  
  
##  \<a name="packaged_task__swap_method">\</a>  packaged_task::swap Method  
 Exchanges the associated asynchronous state with that of a specified object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.  
  
##  \<a name="packaged_task__valid_method">\</a>  packaged_task::valid Method  
 Specifies whether the object has an <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> if the object has an associated asynchronous state; otherwise, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<future>](../vs140/-future-.md)