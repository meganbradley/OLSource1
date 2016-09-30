---
title: "CMultiLock Class"
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
  - "CMultiLock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMultiLock class"
  - "synchronization objects, access control"
ms.assetid: c5b7c78b-1f81-4387-b7dd-2c813c5b6b61
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMultiLock Class
Represents the access-control mechanism used in controlling access to resources in a multithreaded program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMultiLock::CMultiLock](#cmultilock__cmultilock)|Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMultiLock::IsLocked](#cmultilock__islocked)|Determines if a specific synchronization object in the array is locked.|  
|[CMultiLock::Lock](#cmultilock__lock)|Waits on the array of synchronization objects.|  
|[CMultiLock::Unlock](#cmultilock__unlock)|Releases any owned synchronization objects.|  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> does not have a base class.  
  
 To use the synchronization classes [CSemaphore](../vs140/csemaphore-class.md), [CMutex](../vs140/cmutex-class.md), and [CEvent](../vs140/cevent-class.md), you can create either a **CMultiLock** or [CSingleLock](../vs140/csinglelock-class.md) object to wait on and release the synchronization object. Use **CMultiLock** when there are multiple objects that you could use at a particular time. Use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> when you only need to wait on one object at a time.  
  
 To use a **CMultiLock** object, first create an array of the synchronization objects that you wish to wait on. Next, call the **CMultiLock** object's constructor inside a member function in the controlled resource's class. Then call the [Lock](#cmultilock__lock) member function to determine if a resource is available (signaled). If one is, continue with the remainder of the member function. If no resource is available, either wait for a specified amount of time for a resource to be released, or return failure. After use of a resource is complete, either call the [Unlock](#cmultilock__unlock) function if the **CMultiLock** object is to be used again, or allow the **CMultiLock** object to be destroyed.  
  
 **CMultiLock** objects are most useful when a thread has a large number of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects it can respond to. Create an array containing all the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> pointers, and call <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. This will cause the thread to wait until one of the events is signaled.  
  
 For more information on how to use **CMultiLock** objects, see the article [Multithreading: How to Use the Synchronization Classes](../vs140/multithreading--how-to-use-the-synchronization-classes.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxmt.h  
  
##  \<a name="cmultilock__cmultilock">\</a>  CMultiLock::CMultiLock  
 Constructs a **CMultiLock** object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Array of pointers to the synchronization objects to be waited on. Cannot be **NULL**.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Number of objects in <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Must be greater than 0.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Specifies whether to initially attempt to access any of the supplied objects.  
  
### Remarks  
 This function is called after creating the array of synchronization objects to be waited on. It is usually called from within the thread that must wait for one of the synchronization objects to become available.  
  
##  \<a name="cmultilock__islocked">\</a>  CMultiLock::IsLocked  
 Determines if the specified object is nonsignaled (unavailable).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 *dwItem*  
 The index in the array of objects corresponding to the object whose state is being queried.  
  
### Return Value  
 Nonzero if the specified object is locked; otherwise 0.  
  
##  \<a name="cmultilock__lock">\</a>  CMultiLock::Lock  
 Call this function to gain access to one or more of the resources controlled by the synchronization objects supplied to the **CMultiLock** constructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *dwTimeOut*  
 Specifies the amount of time to wait for the synchronization object to be available (signaled). If **INFINITE**, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> will wait until the object is signaled before returning.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Specifies whether all objects waited on must become signaled at the same time before returning. If **FALSE**, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> will return when any one of the objects waited on is signaled.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Specifies other conditions that are allowed to abort the wait. For a full list of the available options for this parameter, see                                 [MsgWaitForMultipleObjects](http://msdn.microsoft.com/library/windows/desktop/ms684242) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Return Value  
 If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> fails, it returns – 1. If successful, it returns one of the following values:  
  
-   Between **WAIT_OBJECT_0** and **WAIT_OBJECT_0** + (number of objects – 1)  
  
     If <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is **TRUE**, all objects are signaled (available). If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is **FALSE**, the return value – **WAIT_OBJECT_0** is the index in the array of objects of the object that is signaled (available).  
  
-   **WAIT_OBJECT_0** + (number of objects)  
  
     An event specified in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is available in the thread's input queue.  
  
-   Between **WAIT_ABANDONED_0** and **WAIT_ABANDONED_0** + (number of objects – 1)  
  
     If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is **TRUE**, all objects are signaled, and at least one of the objects is an abandoned mutex object. If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is **FALSE**, the return value – **WAIT_ABANDONED_0** is the index in the array of objects of the abandoned mutex object that satisfied the wait.  
  
-   **WAIT_TIMEOUT**  
  
     The timeout interval specified in                                 *dwTimeOut* expired without the wait succeeding.  
  
### Remarks  
 If <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is **TRUE**, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> will return successfully as soon as all the synchronization objects become signaled simultaneously. If <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is **FALSE**, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> will return as soon as one or more of the synchronization objects becomes signaled.  
  
 If <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is not able to return immediately, it will wait for no more than the number of milliseconds specified in the                         *dwTimeOut* parameter before returning. If                         *dwTimeOut* is **INFINITE**, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> will not return until access to an object is gained or a condition specified in <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> was met. Otherwise, if <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> was able to acquire a synchronization object, it will return successfully; if not, it will return failure.  
  
##  \<a name="cmultilock__unlock">\</a>  CMultiLock::Unlock  
 Releases the synchronization object owned by <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Number of reference counts to release. Must be greater than 0. If the specified amount would cause the object's count to exceed its maximum, the count is not changed and the function returns **FALSE**.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Points to a variable to receive the previous count for the synchronization object. If **NULL**, the previous count is not returned.  
  
### Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
### Remarks  
 This function is called by <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>'s destructor.  
  
 The first form of <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> tries to unlock the synchronization object managed by <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>. The second form of <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> tries to unlock the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> objects owned by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> does not own any locked <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> object, the function returns **FALSE**; otherwise, it returns **TRUE**. <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> are exactly the same as the parameters of [CSingleLock::Unlock](../vs140/csinglelock-class.md#csinglelock__unlock). The second form of <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is rarely applicable to multilock situations.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)