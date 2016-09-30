---
title: "promise Class"
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
  - "future/std::promise"
dev_langs: 
  - "C++"
ms.assetid: 2931558c-d94a-4ba1-ac4f-20bf7b6e23f9
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# promise Class
Describes an *asynchronous provider*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[promise::promise Constructor](#promise__promise_constructor)|Constructs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[promise::get_future Method](#promise__get_future_method)|Returns a [future](../vs140/future-class.md) associated with this promise.|  
|[promise::set_exception Method](#promise__set_exception_method)|Atomically sets the result of this promise to indicate an exception.|  
|[promise::set_exception_at_thread_exit Method](#promise__set_exception_at_thread_exit_method)|Atomically sets the result of this promise to indicate an exception, and delivers the notification only after all thread-local objects in the current thread have been destroyed (usually at thread exit).|  
|[promise::set_value Method](#promise__set_value_method)|Atomically sets the result of this promise to indicate a value.|  
|[promise::set_value_at_thread_exit Method](#promise__set_value_at_thread_exit_method)|Atomically sets the result of this promise to indicate a value, and delivers the notification only after all thread-local objects in the current thread have been destroyed (usually at thread exit).|  
|[promise::swap Method](#promise__swap_method)|Exchanges the *associated asynchronous state* of this promise with that of a specified promise object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[promise::operator= Operator](#promise__operator_eq)|Assignment of the shared state of this promise object.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
##  \<a name="promise__get_future_method">\</a>  promise::get_future Method  
 Returns a [future](../vs140/future-class.md) object that has the same *associated asynchronous state* as this promise.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If the promise object is empty, this method throws a [future_error](../vs140/future_error-class.md) that has an [error_code](../vs140/error_code-class.md) of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 If this method has already been called for a promise object that has the same associated asynchronous state, the method throws a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> that has an <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
##  \<a name="promise__operator_eq">\</a>  promise::operator=  
 Transfers the *associated asynchronous state* from a specified <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
### Remarks  
 This operator transfers the associated asynchronous state from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. After the transfer, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is *empty*.  
  
##  \<a name="promise__promise_constructor">\</a>  promise::promise Constructor  
 Constructs a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A memory allocator. See [\<allocators>](../vs140/-allocators-.md) for more information.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The first constructor constructs an *empty*<CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
 The second constructor constructs an empty <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object and uses <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> for memory allocation.  
  
 The third constructor constructs a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object and transfers the associated asynchronous state from <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, and leaves <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> empty.  
  
##  \<a name="promise__set_exception_method">\</a>  promise::set_exception Method  
 Atomically stores an exception as the result of this <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object and sets the *associated asynchronous state* to *ready*.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 An [exception_ptr](../vs140/transporting-exceptions-between-threads.md) that's stored by this method as the exception result.  
  
### Remarks  
 If the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object has no associated asynchronous state, this method throws a [future_error](../vs140/future_error-class.md) that has an error code of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 If <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, [set_exception_at_thread_exit](#promise__set_exception_at_thread_exit_method), [set_value](#promise__set_value_method), or [set_value_at_thread_exit](#promise__set_value_at_thread_exit_method) has already been called for a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object that has the same associated asynchronous state, this method throws a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 As a result of this method, any threads that are blocked on the associated asynchronous state become unblocked.  
  
##  \<a name="promise__set_exception_at_thread_exit_method">\</a>  promise::set_exception_at_thread_exit Method  
 Atomically sets the result of this <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> to indicate an exception, delivering the notification only after all thread-local objects in the current thread have been destroyed (usually at thread exit).  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 An [exception_ptr](../vs140/transporting-exceptions-between-threads.md) that's stored by this method as the exception result.  
  
### Remarks  
 If the promise object has no *associated asynchronous state*, this method throws a [future_error](../vs140/future_error-class.md) that has an error code of <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
 If [set_exception](#promise__set_exception_method), <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, [set_value](#promise__set_value_method), or [set_value_at_thread_exit](#promise__set_value_at_thread_exit_method) has already been called for a <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object that has the same associated asynchronous state, this method throws a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 In contrast to [set_exception](#promise__set_exception_method), this method does not set the associated asynchronous state to ready until after all thread-local objects in the current thread have been destroyed. Typically, threads that are blocked on the associated asynchronous state are not unblocked until the current thread exits.  
  
##  \<a name="promise__set_value_method">\</a>  promise::set_value Method  
 Atomically stores a value as the result of this <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> object and sets the *associated asynchronous state* to *ready*.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The value to be stored as the result.  
  
### Remarks  
 If the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> object has no associated asynchronous state, this method throws a [future_error](../vs140/future_error-class.md) that has an error code of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
 If [set_exception](#promise__set_exception_method), [set_exception_at_thread_exit](#promise__set_exception_at_thread_exit_method), <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, or [set_value_at_thread_exit](#promise__set_value_at_thread_exit_method) has already been called for a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object that has the same associated asynchronous state, this method throws a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
 As a result of this method, any threads that are blocked on the associated asynchronous state become unblocked.  
  
 The first method also throws any exception that is thrown when <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is copied into the associated asynchronous state. In this situation, the associated asynchronous state is not set to ready.  
  
 The second method also throws any exception that is thrown when <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is moved into the associated asynchronous state. In this situation, the associated asynchronous state is not set to ready.  
  
 For the partial specialization <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, the stored value is in effect a reference to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
 For the specialization <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>, no stored value exists.  
  
##  \<a name="promise__set_value_at_thread_exit_method">\</a>  promise::set_value_at_thread_exit Method  
 Atomically stores a value as the result of this <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 The value to be stored as the result.  
  
### Remarks  
 If the promise object has no *associated asynchronous state*, this method throws a [future_error](../vs140/future_error-class.md) that has an error code of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
 If [set_exception](#promise__set_exception_method), [set_exception_at_thread_exit](#promise__set_exception_at_thread_exit_method), [set_value](#promise__set_value_method), or <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> has already been called for a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object that has the same associated asynchronous state, this method throws a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
 In contrast to <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, the associated asynchronous state is not set to ready until after all thread-local objects in the current thread have been destroyed. Typically, threads that are blocked on the associated asynchronous state are not unblocked until the current thread exits.  
  
 The first method also throws any exception that is thrown when <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is copied into the associated asynchronous state.  
  
 The second method also throws any exception that is thrown when <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is moved into the associated asynchronous state.  
  
 For the partial specialization <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, the stored value is effectively a reference to <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
 For the specialization <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, no stored value exists.  
  
##  \<a name="promise__swap_method">\</a>  promise::swap Method  
 Exchanges the *associated asynchronous state* of this promise object with that of a specified object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> object.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)