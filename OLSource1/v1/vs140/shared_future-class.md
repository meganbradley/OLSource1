---
title: "shared_future Class"
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
  - "future/std::shared_future"
dev_langs: 
  - "C++"
ms.assetid: 454ebedd-f42b-405f-99a5-a25cc9ad7c90
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# shared_future Class
Describes an *asynchronous return object*. In contrast with a [future](../vs140/future-class.md) object, an *asynchronous provider* can be associated with any number of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Do not call any methods other than <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, and the destructor on a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object that's *empty*.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> objects are not synchronized. Calling methods on the same object from multiple threads introduces a data race that has unpredictable results.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[shared_future::shared_future Constructor](#shared_future__shared_future_constructor)|Constructs a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[shared_future::get Method](#shared_future__get_method)|Retrieves the result that's stored in the *associated asynchronous state*.|  
|[shared_future::valid Method](#shared_future__valid_method)|Specifies whether the object is not empty.|  
|[shared_future::wait Method](#shared_future__wait_method)|Blocks the current thread until the associated asynchronous state is ready.|  
|[shared_future::wait_for Method](#shared_future__wait_for_method)|Blocks until the associated asynchronous state is ready or until the specified time has elapsed.|  
|[shared_future::wait_until Method](#shared_future__wait_until_method)|Blocks until the associated asynchronous state is ready or until a specified point in time.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[shared_future::operator= Operator](#shared_future__operator_eq)|Assigns a new associated asynchronous state.|  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
##  \<a name="shared_future__get_method">\</a>  shared_future::get Method  
 Retrieves the result that's stored in the *associated asynchronous state*.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 If the result is an exception, the method rethrows it. Otherwise, the result is returned.  
  
 Before it retrieves the result, this method blocks the current thread until the associated asynchronous state is ready.  
  
 For the partial specialization <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the stored value is effectively a reference to the object that was passed to the *asynchronous provider* as the return value.  
  
 Because no stored value exists for the specialization <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, the method returns <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
##  \<a name="shared_future__operator_eq">\</a>  shared_future::operator=  
 Transfers an *associated asynchronous state* from a specified object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
### Remarks  
 For the first operator, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> no longer has an associated asynchronous state after the operation.  
  
 For the second method, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> maintains its associated asynchronous state.  
  
##  \<a name="shared_future__shared_future_constructor">\</a>  shared_future::shared_future Constructor  
 Constructs a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A [future](../vs140/future-class.md) or <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The first constructor constructs a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object that has no *associated asynchronous state*.  
  
 The second and third constructors construct a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object and transfer the associated asynchronous state from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> no longer has an associated asynchronous state.  
  
 The fourth constructor constructs a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> object that has the same associated asynchronous state as <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
##  \<a name="shared_future__valid_method">\</a>  shared_future::valid Method  
 Specifies whether the object has an *associated asynchronous state*.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> if the object has an associated asynchronous state; otherwise, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
##  \<a name="shared_future__wait_method">\</a>  shared_future::wait Method  
 Blocks the current thread until the *associated asynchronous state* is *ready*.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 An associated asynchronous state is ready only if its asynchronous provider has stored a return value or stored an exception.  
  
##  \<a name="shared_future__wait_for_method">\</a>  shared_future::wait_for Method  
 Blocks the current thread until the associated asynchronous state is *ready* or until a specified time has elapsed.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A [chrono::duration](../vs140/duration-class.md) object that specifies a maximum time interval that the thread blocks.  
  
### Return Value  
 A [future_status](../vs140/-future--enums.md#future_status_enumeration) that indicates the reason for returning.  
  
### Remarks  
 An associated asynchronous state is *ready* only if its asynchronous provider has stored a return value or stored an exception.  
  
##  \<a name="shared_future__wait_until_method">\</a>  shared_future::wait_until Method  
 Blocks the current thread until the associated asynchronous state is *ready* or until after a specified time point.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A [chrono::time_point](../vs140/time_point-class.md) object that specifies a time after which the thread can unblock.  
  
### Return Value  
 A [future_status](../vs140/-future--enums.md#future_status_enumeration) that indicates the reason for returning.  
  
### Remarks  
 An associated asynchronous state is ready only if its asynchronous provider has stored a return value or stored an exception.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<future>](../vs140/-future-.md)