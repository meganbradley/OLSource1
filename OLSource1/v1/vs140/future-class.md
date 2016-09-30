---
title: "future Class"
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
  - "future/std::future"
dev_langs: 
  - "C++"
ms.assetid: 495e82c3-5341-4e37-87dd-b40107fbdfb6
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# future Class
Describes an *asynchronous return object*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Each standard *asynchronous provider* returns an object whose type is an instantiation of this template. A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object provides the only access to the asynchronous provider that it is associated with. If you need multiple asynchronous return objects that are associated with the same asynchronous provider, copy the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object to a [shared_future](../vs140/shared_future-class.md) object.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[future::future Constructor](#future__future_constructor)|Constructs a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[future::get Method](#future__get_method)|Retrieves the result that is stored in the associated asynchronous state.|  
|[future::share Method](#future__share_method)|Converts the object to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.|  
|[future::valid Method](#future__valid_method)|Specifies whether the object is not empty.|  
|[future::wait Method](#future__wait_method)|Blocks the current thread until the associated asynchronous state is ready.|  
|[future::wait_for Method](#future__wait_for_method)|Blocks until the associated asynchronous state is ready or until the specified time has elapsed.|  
|[future::wait_until Method](#future__wait_until_method)|Blocks until the associated asynchronous state is ready or until a specified point in time.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[future::operator= Operator](#future__operator_eq)|Transfers the associated asynchronous state from a specified object.|  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
##  \<a name="future__future_constructor">\</a>  future::future Constructor  
 Constructs a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
### Remarks  
 The first constructor constructs a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object that has no associated asynchronous state.  
  
 The second constructor constructs a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object and transfers the associated asynchronous state from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> no longer has an associated asynchronous state.  
  
##  \<a name="future__get_method">\</a>  future::get Method  
 Retrieves the result that is stored in the associated asynchronous state.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 If the result is an exception, the method rethrows it. Otherwise, the result is returned.  
  
### Remarks  
 Before it retrieves the result, this method blocks the current thread until the associated asynchronous state is ready.  
  
 For the partial specialization <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, the stored value is effectively a reference to the object that was passed to the asynchronous provider as the return value.  
  
 Because no stored value exists for the specialization <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the method returns <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 In other specializations, the method moves its return value from the stored value. Therefore, call this method only once.  
  
##  \<a name="future__operator_eq">\</a>  future::operator=  
 Transfers an associated asynchronous state from a specified object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
### Return Value  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
### Remarks  
 After the transfer, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> no longer has an associated asynchronous state.  
  
##  \<a name="future__share_method">\</a>  future::share Method  
 Converts the object to a [shared_future](../vs140/shared_future-class.md) object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
##  \<a name="future__valid_method">\</a>  future::valid Method  
 Specifies whether the object has an associated asynchronous state.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if the object has an associated asynchronous state; otherwise, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
##  \<a name="future__wait_method">\</a>  future::wait Method  
 Blocks the current thread until the associated asynchronous state is *ready*.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 An associated asynchronous state is *ready* only if its asynchronous provider has stored a return value or stored an exception.  
  
##  \<a name="future__wait_for_method">\</a>  future::wait_for Method  
 Blocks the current thread until the associated asynchronous state is *ready* or until a specified time interval has elapsed.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A [chrono::duration](../vs140/duration-class.md) object that specifies a maximum time interval that the thread blocks.  
  
### Return Value  
 A [future_status](../vs140/-future--enums.md#future_status_enumeration) that indicates the reason for returning.  
  
### Remarks  
 An associated asynchronous state is ready only if its asynchronous provider has stored a return value or stored an exception.  
  
##  \<a name="future__wait_until_method">\</a>  future::wait_until Method  
 Blocks the current thread until the associated asynchronous state is *ready* or until after a specified time point.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A [chrono::time_point](../vs140/time_point-class.md) object that specifies a time after which the thread can unblock.  
  
### Return Value  
 A [future_status](../vs140/-future--enums.md#future_status_enumeration) that indicates the reason for returning.  
  
### Remarks  
 An associated asynchronous state is *ready* only if its asynchronous provider has stored a return value or stored an exception.  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<future>](../vs140/-future-.md)