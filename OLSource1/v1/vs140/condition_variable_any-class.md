---
title: "condition_variable_any Class"
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
  - "condition_variable/std::condition_variable_any"
dev_langs: 
  - "C++"
ms.assetid: d8afe5db-1561-4ec2-8e85-21ea03ee4321
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# condition_variable_any Class
Use the class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to wait for an event that has any <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[condition_variable_any::condition_variable_any Constructor](#condition_variable_any__condition_variable_any_constructor)|Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[condition_variable_any::notify_all Method](#condition_variable_any__notify_all_method)|Unblocks all threads that are waiting for the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
|[condition_variable_any::notify_one Method](#condition_variable_any__notify_one_method)|Unblocks one of the threads that are waiting for the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
|[condition_variable_any::wait Method](#condition_variable_any__wait_method)|Blocks a thread.|  
|[condition_variable_any::wait_for Method](#condition_variable_any__wait_for_method)|Blocks a thread, and sets a time interval after which the thread unblocks.|  
|[condition_variable_any::wait_until Method](#condition_variable_any__wait_until_method)|Blocks a thread, and sets a maximum point in time at which the thread unblocks.|  
  
## Requirements  
 **Header:** condition_variable  
  
 **Namespace:** std  
  
##  \<a name="condition_variable_any__condition_variable_any_constructor">\</a>  condition_variable_any::condition_variable_any Constructor  
 Constructs a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If not enough memory is available, the constructor throws a [system_error](../vs140/system_error-class.md) object that has a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> error code. If the object cannot be constructed because some other resource is not available, the constructor throws a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object that has a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> error code.  
  
##  \<a name="condition_variable_any__notify_all_method">\</a>  condition_variable_any::notify_all Method  
 Unblocks all threads that are waiting for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
##  \<a name="condition_variable_any__notify_one_method">\</a>  condition_variable_any::notify_one Method  
 Unblocks one of the threads that are waiting on the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="condition_variable_any__wait_method">\</a>  condition_variable_any::wait Method  
 Blocks a thread.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object of any type.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Any expression that returns <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first method blocks until the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object is signaled by a call to [notify_one](../vs140/condition_variable-class.md#condition_variable__notify_one_method) or [notify_all](../vs140/condition_variable-class.md#condition_variable__notify_all_method). It can also wake up spuriously.  
  
 The second method in effect executes the following code.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="condition_variable_any__wait_for_method">\</a>  condition_variable_any::wait_for Method  
 Blocks a thread, and sets a time interval after which the thread unblocks.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object of any type.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object that specifies the amount of time before the thread wakes up.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Any expression that returns <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Return Value  
 The first method returns <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> if the wait terminates when <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> has elapsed. Otherwise, the method returns <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 The second method returns the value of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first method blocks until the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object is signaled by a call to [notify_one](../vs140/condition_variable-class.md#condition_variable__notify_one_method) or [notify_all](../vs140/condition_variable-class.md#condition_variable__notify_all_method), or until the time interval <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> has elapsed. It can also wake up spuriously.  
  
 The second method in effect executes the following code.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="condition_variable_any__wait_until_method">\</a>  condition_variable_any::wait_until Method  
 Blocks a thread, and sets a maximum point in time at which the thread unblocks.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 A mutex object.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A [chrono::time_point](../vs140/time_point-class.md) object.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Any expression that returns <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
### Return Value  
 Methods that return a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> type return <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> if the wait terminates when <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> elapses. Otherwise, the methods return <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
 Methods that return a <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> return the value of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>.  
  
### Remarks  
 The first method blocks until the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object is signaled by a call to [notify_one](../vs140/condition_variable-class.md#condition_variable__notify_one_method) or [notify_all](../vs140/condition_variable-class.md#condition_variable__notify_all_method), or until <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>. It can also wake up spuriously.  
  
 The second method in effect executes the following code.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The third and fourth methods use a pointer to an object of type <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> to replace the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> object. The <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> object specifies the maximum amount of time to wait for a signal.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<condition_variable>](../vs140/-condition_variable-.md)