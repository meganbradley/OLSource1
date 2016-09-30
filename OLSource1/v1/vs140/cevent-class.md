---
title: "CEvent Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "synchronization objects, event"
  - "synchronization classes, CEvent class"
  - "CEvent class"
ms.assetid: df676042-ce27-4702-800a-e73ff4f44395
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEvent Class
Represents an event, which is a synchronization object that enables one thread to notify another that an event has occurred.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CEvent::CEvent](#cevent__cevent)|Constructs a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CEvent::PulseEvent](#cevent__pulseevent)|Sets the event to available (signaled), releases waiting threads, and sets the event to unavailable (nonsignaled).|  
|[CEvent::ResetEvent](#cevent__resetevent)|Sets the event to unavailable (nonsignaled).|  
|[CEvent::SetEvent](#cevent__setevent)|Sets the event to available (signaled) and releases any waiting threads.|  
|[CEvent::Unlock](#cevent__unlock)|Releases the event object.|  
  
## Remarks  
 Events are useful when a thread must know when to perform its task. For example, a thread that copies data to a data archive must be notified when new data is available. By using a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object to notify the copy thread when new data is available, the thread can perform its task as soon as possible.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects have two types: manual and automatic.  
  
 An automatic <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object automatically returns to a non-signaled (unavailable) state after at least one thread is released. By default, a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object is automatic unless you pass <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter during construction.  
  
 A manual <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object stays in the state set by [SetEvent](#cevent__setevent) or [ResetEvent](#cevent__resetevent) until the other function is called. To create a manual <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object, pass <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> for the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter during construction.  
  
 To use a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object, construct the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object when it is required. Specify the name of the event you want to wait on, and also specify that your application should initially own it. You can then access the event when the constructor returns. Call [SetEvent](#cevent__setevent) to signal (make available) the event object and then call [Unlock](#cevent__unlock) when you are done accessing the controlled resource.  
  
 An alternative method for using <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> objects is to add a variable of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> as a data member to the class you want to control. During construction of the controlled object, call the constructor of the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> data member and specify whether the event is initially signaled, and also specifythe type of event object you want, the name of the event (if it will be used across process boundaries), and any security attributes you want.  
  
 To access a resource controlled by a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object in this manner, first create a variable of either type [CSingleLock](../vs140/csinglelock-class.md) or type [CMultiLock](../vs140/cmultilock-class.md) in the access method of your resource. Then call the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> method of the lock object (for example, [CMultiLock::Lock](../vs140/cmultilock-class.md#cmultilock__lock)). At this point, your thread will either gain access to the resource, wait for the resource to be released and gain access, or wait for the resource to be released, time out, and fail to gain access to the resource. In any case, your resource has been accessed in a thread-safe manner. To release the resource, call <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to signal the event object, and then use the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> method of the lock object (for example, [CMultiLock::Unlock](../vs140/cmultilock-class.md#cmultilock__unlock)), or let the lock object fall out of scope.  
  
 For more information about how to use <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> objects, see [Multithreading: How to Use the Synchronization Classes](../vs140/multithreading--how-to-use-the-synchronization-classes.md).  
  
## Example  
 [!code[NVC_MFC_Utilities#45](../vs140/codesnippet/CPP/cevent-class_1.cpp)]  
  
 [!code[NVC_MFC_Utilities#46](../vs140/codesnippet/CPP/cevent-class_2.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CSyncObject](../vs140/csyncobject-class.md)  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxmt.h  
  
##  \<a name="cevent__cevent">\</a>  CEvent::CEvent  
 Constructs a named or unnamed <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 If **TRUE**, the thread for the **CMultilock** or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object is enabled. Otherwise, all threads wanting to access the resource must wait.  
  
 *bManualReset*  
 If **TRUE**, specifies that the event object is a manual event, otherwise the event object is an automatic event.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Name of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object. Must be supplied if the object will be used across process boundaries. If the name matches an existing event, the constructor builds a new <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object which references the event of that name. If the name matches an existing synchronization object that is not an event, the construction will fail. If **NULL**, the name will be null.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Security attributes for the event object. For a full description of this structure, see                                 [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 To access or release a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object, create a [CMultiLock](../vs140/cmultilock-class.md) or [CSingleLock](../vs140/csinglelock-class.md) object and call its [Lock](../vs140/csinglelock-class.md#csinglelock__lock) and [Unlock](../vs140/csinglelock-class.md#csinglelock__unlock) member functions.  
  
 To change the state of a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object to signaled (threads do not have to wait), call [SetEvent](#cevent__setevent) or [PulseEvent](#cevent__pulseevent). To set the state of a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object to nonsignaled (threads must wait), call [ResetEvent](#cevent__resetevent).  
  
> [!IMPORTANT]
>  After creating the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object, use                             [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) to ensure that the mutex didn't already exist. If the mutex did exist unexpectedly, it may indicate a rogue process is squatting and may be intending to use the mutex maliciously. In this case, the recommended security-conscious procedure is to close the handle and continue as if there was a failure in creating the object.  
  
##  \<a name="cevent__pulseevent">\</a>  CEvent::PulseEvent  
 Sets the state of the event to signaled (available), releases any waiting threads, and resets it to nonsignaled (unavailable) automatically.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
### Remarks  
 If the event is manual, all waiting threads are released, the event is set to nonsignaled, and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> returns. If the event is automatic, a single thread is released, the event is set to nonsignaled, and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> returns.  
  
 If no threads are waiting, or no threads can be released immediately, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> sets the state of the event to nonsignaled and returns.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> uses the underlying Win32 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> function, which can be momentarily removed from the wait state by a kernel-mode asynchronous procedure call. Therefore, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is unreliable and should not be used by new applications. For more information, see the                         [PulseEvent function](http://msdn.microsoft.com/library/windows/desktop/ms684914).  
  
##  \<a name="cevent__resetevent">\</a>  CEvent::ResetEvent  
 Sets the state of the event to nonsignaled until explicitly set to signaled by the [SetEvent](#cevent__setevent) member function.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
### Remarks  
 This causes all threads wishing to access this event to wait.  
  
 This member function is not used by automatic events.  
  
##  \<a name="cevent__setevent">\</a>  CEvent::SetEvent  
 Sets the state of the event to signaled, releasing any waiting threads.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the function was successful, otherwise 0.  
  
### Remarks  
 If the event is manual, the event will remain signaled until [ResetEvent](#cevent__resetevent) is called. More than one thread can be released in this case. If the event is automatic, the event will remain signaled until a single thread is released. The system will then set the state of the event to nonsignaled. If no threads are waiting, the state remains signaled until one thread is released.  
  
##  \<a name="cevent__unlock">\</a>  CEvent::Unlock  
 Releases the event object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the thread owned the event object and the event is an automatic event; otherwise 0.  
  
### Remarks  
 This member function is called by threads that currently own an automatic event to release it after they are done, if their lock object is to be reused. If the lock object is not to be reused, this function will be called by the lock object's destructor.  
  
## See Also  
 [Base Class](../vs140/csyncobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)