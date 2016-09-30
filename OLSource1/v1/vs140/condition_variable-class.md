---
title: "condition_variable Class"
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
  - "condition_variable/std::condition_variable"
dev_langs: 
  - "C++"
ms.assetid: 80b1295c-b73d-4d46-b664-6e183f2eec1b
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# condition_variable Class
Use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class to wait for an event when you have a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. Objects of this type may have better performance than objects of type [condition_variable_any<unique_lock\<mutex>>](../vs140/condition_variable_any-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[condition_variable::condition_variable Constructor](#condition_variable__condition_variable_constructor)|Constructs a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[condition_variable::native_handle Method](#condition_variable__native_handle_method)|Returns the implementation-specific type representing the condition_variable handle.|  
|[condition_variable::notify_all Method](#condition_variable__notify_all_method)|Unblocks all threads that are waiting for the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
|[condition_variable::notify_one Method](#condition_variable__notify_one_method)|Unblocks one of the threads that are waiting for the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.|  
|[condition_variable::wait Method](#condition_variable__wait_method)|Blocks a thread.|  
|[condition_variable::wait_for Method](#condition_variable__wait_for_method)|Blocks a thread, and sets a time interval after which the thread unblocks.|  
|[condition_variable::wait_until Method](#condition_variable__wait_until_method)|Blocks a thread, and sets a maximum point in time at which the thread unblocks.|  
  
## Requirements  
 **Header:** condition_variable  
  
 **Namespace:** std  
  
##  \<a name="condition_variable__condition_variable_constructor">\</a>  condition_variable::condition_variable Constructor  
 Constructs a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If not enough memory is available, the constructor throws a [system_error](../vs140/system_error-class.md) object that has a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> error code. If the object cannot be constructed because some other resource is not available, the constructor throws a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object that has a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> error code.  
  
##  \<a name="condition_variable__native_handle_method">\</a>  condition_variable::native_handle Method  
 Returns the implementation-specific type that represents the condition_variable handle.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is defined as a pointer to Concurrency Runtime internal data structures.  
  
##  \<a name="condition_variable__notify_all_method">\</a>  condition_variable::notify_all Method  
 Unblocks all threads that are waiting for the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="condition_variable__notify_one_method">\</a>  condition_variable::notify_one Method  
 Unblocks one of the threads that are waiting on the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
##  \<a name="condition_variable__wait_method">\</a>  condition_variable::wait Method  
 Blocks a thread.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A [unique_lock\<mutex>](../vs140/unique_lock-class.md) object.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Any expression that returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first method blocks until the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object is signaled by a call to [notify_one](#condition_variable__notify_one_method) or [notify_all](#condition_variable__notify_all_method). It can also wake up spuriously.  
  
 In effect, the second method executes the following code.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="condition_variable__wait_for_method">\</a>  condition_variable::wait_for Method  
 Blocks a thread, and sets a time interval after which the thread unblocks.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A [unique_lock\<mutex>](../vs140/unique_lock-class.md) object.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object that specifies the amount of time before the thread wakes up.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Any expression that returns <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
### Return Value  
 The first method returns <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> if the wait terminates when <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> has elapsed. Otherwise, the method returns <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 The second method returns the value of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first method blocks until the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> object is signaled by a call to [notify_one](#condition_variable__notify_one_method) or [notify_all](#condition_variable__notify_all_method) or until the time interval <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> has elapsed. It can also wake up spuriously.  
  
 In effect, the second method executes the following code.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="condition_variable__wait_until_method">\</a>  condition_variable::wait_until Method  
 Blocks a thread, and sets a maximum point in time at which the thread unblocks.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A [unique_lock\<mutex>](../vs140/unique_lock-class.md) object.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A [chrono::time_point](../vs140/time_point-class.md) object.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Any expression that returns <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
### Return Value  
 Methods that return a <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> type return <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> if the wait terminates when <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> elapses. Otherwise, the methods return <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
 Methods that return a <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> return the value of <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first method blocks until the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object is signaled by a call to [notify_one](#condition_variable__notify_one_method) or [notify_all](#condition_variable__notify_all_method) or until <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. It can also wake up spuriously.  
  
 In effect, the second method executes the following code  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The third and fourth methods use a pointer to an object of type <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> to replace the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> object specifies the maximum amount of time to wait for a signal.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<condition_variable>](../vs140/-condition_variable-.md)