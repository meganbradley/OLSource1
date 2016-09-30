---
title: "CSingleLock Class"
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
  - "CSingleLock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSingleLock class"
  - "threading [MFC], access control"
  - "synchronization objects, access control"
  - "threading [MFC], synchronization"
ms.assetid: 7dae7288-8066-4a3e-85e0-78d28bfc6bc8
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSingleLock Class
Represents the access-control mechanism used in controlling access to a resource in a multithreaded program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSingleLock::CSingleLock](#csinglelock__csinglelock)|Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSingleLock::IsLocked](#csinglelock__islocked)|Determines if the object is locked.|  
|[CSingleLock::Lock](#csinglelock__lock)|Waits on a synchronization object.|  
|[CSingleLock::Unlock](#csinglelock__unlock)|Releases a synchronization object.|  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> does not have a base class.  
  
 In order to use the synchronization classes [CSemaphore](../vs140/csemaphore-class.md), [CMutex](../vs140/cmutex-class.md), [CCriticalSection](../vs140/ccriticalsection-class.md), and [CEvent](../vs140/cevent-class.md), you must create either a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or [CMultiLock](../vs140/cmultilock-class.md) object to wait on and release the synchronization object. Use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when you only need to wait on one object at a time. Use **CMultiLock** when there are multiple objects that you could use at a particular time.  
  
 To use a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object, call its constructor inside a member function in the controlled resource's class. Then call the [IsLocked](#csinglelock__islocked) member function to determine if the resource is available. If it is, continue with the remainder of the member function. If the resource is unavailable, either wait for a specified amount of time for the resource to be released, or return failure. After use of the resource is complete, either call the [Unlock](#csinglelock__unlock) function if the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object is to be used again, or allow the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object to be destroyed.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> objects require the presence of an object derived from [CSyncObject](../vs140/csyncobject-class.md). This is usually a data member of the controlled resource's class. For more information on how to use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> objects, see the article [Multithreading: How to Use the Synchronization Classes](../vs140/multithreading--how-to-use-the-synchronization-classes.md).  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxmt.h  
  
##  \<a name="csinglelock__csinglelock">\</a>  CSingleLock::CSingleLock  
 Constructs a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Points to the synchronization object to be accessed. Cannot be **NULL**.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Specifies whether to initially attempt to access the supplied object.  
  
### Remarks  
 This function is generally called from within an access member function of the controlled resource.  
  
### Example  
 [!code[NVC_MFC_Utilities#19](../vs140/codesnippet/CPP/csinglelock-class_1.h)]  
  
##  \<a name="csinglelock__islocked">\</a>  CSingleLock::IsLocked  
 Determines if the object associated with the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object is nonsignaled (unavailable).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the object is locked; otherwise 0.  
  
### Example  
 [!code[NVC_MFC_Utilities#20](../vs140/codesnippet/CPP/csinglelock-class_2.h)]  
  
##  \<a name="csinglelock__lock">\</a>  CSingleLock::Lock  
 Call this function to gain access to the resource controlled by the synchronization object supplied to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> constructor.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *dwTimeOut*  
 Specifies the amount of time to wait for the synchronization object to be available (signaled). If **INFINITE**, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> will wait until the object is signaled before returning.  
  
### Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
### Remarks  
 If the synchronization object is signaled, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> will return successfully and the thread now owns the object. If the synchronization object is nonsignaled (unavailable), <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> will wait for the synchronization object to become signaled up to the number of milliseconds specified in the                         *dwTimeOut* parameter. If the synchronization object did not become signaled in the specified amount of time, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> returns failure.  
  
### Example  
 [!code[NVC_MFC_Utilities#21](../vs140/codesnippet/CPP/csinglelock-class_3.h)]  
  
##  \<a name="csinglelock__unlock">\</a>  CSingleLock::Unlock  
 Releases the synchronization object owned by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Number of accesses to release. Must be greater than 0. If the specified amount would cause the object's count to exceed its maximum, the count is not changed and the function returns **FALSE**.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Points to a variable to receive the previous count of the synchronization object. If **NULL**, the previous count is not returned.  
  
### Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
### Remarks  
 This function is called by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>'s destructor.  
  
 If you need to release more than one access count of a semaphore, use the second form of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and specify the number of accesses to release.  
  
### Example  
 [!code[NVC_MFC_Utilities#21](../vs140/codesnippet/CPP/csinglelock-class_3.h)]  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMultiLock](../vs140/cmultilock-class.md)