---
title: "event Class"
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
  - "concrt/concurrency::event"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "event class"
ms.assetid: fba35a53-6568-4bfa-9aaf-07c0928cf73d
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# event Class
A manual reset event which is explicitly aware of the Concurrency Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[event::~event Destructor](#event___dtorevent_destructor)|Destroys an event.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[event::reset Method](#event__reset_method)|Resets the event to a non-signaled state.|  
|[event::set Method](#event__set_method)|Signals the event.|  
|[event::wait Method](#event__wait_method)|Waits for the event to become signaled.|  
|[event::wait_for_multiple Method](#event__wait_for_multiple_method)|Waits for multiple events to become signaled.|  
  
### Public Constants  
  
|Name|Description|  
|----------|-----------------|  
|[event::timeout_infinite Constant](#event__timeout_infinite_constant)|Value indicating that a wait should never time out.|  
  
## Remarks  
 For more information, see                 [Synchronization Data Structures](../vs140/synchronization-data-structures.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** concrt.h  
  
 **Namespace:** concurrency  
  
##  \<a name="event__event_constructor">\</a>  event::event Constructor  
 Constructs a new event.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="event___dtorevent_destructor">\</a>  event::~event Destructor  
 Destroys an event.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 It is expected that there are no threads waiting on the event when the destructor runs. Allowing the event to destruct with threads still waiting on it results in undefined behavior.  
  
##  \<a name="event__reset_method">\</a>  event::reset Method  
 Resets the event to a non-signaled state.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="event__set_method">\</a>  event::set Method  
 Signals the event.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 Signaling the event can cause an arbitrary number of contexts waiting on the event to become runnable.  
  
##  \<a name="event__timeout_infinite_constant">\</a>  event::timeout_infinite Constant  
 Value indicating that a wait should never time out.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="event__wait_method">\</a>  event::wait Method  
 Waits for the event to become signaled.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Indicates the number of milliseconds before the wait times out. The value                                 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> signifies that there is no timeout.  
  
### Return Value  
 If the wait was satisfied, the value                         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is returned; otherwise, the value                         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to indicate that the wait timed out without the event becoming signaled.  
  
> [!IMPORTANT]
>  In a                             [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, do not call                             <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> on the ASTA thread because this call can block the current thread and can cause the app to become unresponsive.  
  
##  \<a name="event__wait_for_multiple_method">\</a>  event::wait_for_multiple Method  
 Waits for multiple events to become signaled.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 An array of events to wait on. The number of events within the array is indicated by the                                 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The count of events within the array supplied in the                                 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 If set to the value                                 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the parameter specifies that all events within the array supplied in the                                 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> parameter must become signaled in order to satisfy the wait. If set to the value                                 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, it specifies that any event within the array supplied in the                                 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> parameter becoming signaled will satisfy the wait.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Indicates the number of milliseconds before the wait times out. The value                                 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> signifies that there is no timeout.  
  
### Return Value  
 If the wait was satisfied, the index within the array supplied in the                         <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter which satisfied the wait condition; otherwise, the value                         <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to indicate that the wait timed out without the condition being satisfied.  
  
### Remarks  
 If the parameter                         <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is set to the value                         <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to indicate that all events must become signaled to satisfy the wait, the index returned by the function carries no special significance other than the fact that it is not the value                         <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
> [!IMPORTANT]
>  In a                             [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app, do not call                             <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> on the ASTA thread because this call can block the current thread and can cause the app to become unresponsive.  
  
## See Also  
 [concurrency Namespace](../vs140/concurrency-namespace.md)