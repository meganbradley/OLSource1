---
title: "CSyncObject Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CSyncObject
dev_langs: 
  - C++
helpviewer_keywords: 
  - CSyncObject class
  - synchronization classes, CSyncObject
ms.assetid: c62ea6eb-a17b-4e01-aed4-321fc435a5f4
caps.latest.revision: 20
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSyncObject Class
A pure virtual class that provides functionality common to the synchronization objects in Win32.  
  
## Syntax  
  
```  
class CSyncObject : public CObject  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CSyncObject::CSyncObject](#csyncobject__csyncobject)|Constructs a `CSyncObject` object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CSyncObject::Lock](#csyncobject__lock)|Gains access to the synchronization object.|  
|[CSyncObject::Unlock](#csyncobject__unlock)|Gains access to the synchronization object.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CSyncObject::operator HANDLE](#csyncobject__operator_handle)|Provides access to the synchronization object.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CSyncObject::m_hObject](#csyncobject__m_hobject)|The handle to the underlying synchronization object.|  
  
## Remarks  
 The Microsoft Foundation Class Library provides several classes derived from `CSyncObject`. These are [CEvent](../vs140/cevent-class.md), [CMutex](../vs140/cmutex-class.md), [CCriticalSection](../vs140/ccriticalsection-class.md), and [CSemaphore](../vs140/csemaphore-class.md).  
  
 For information on how to use the synchronization objects, see the article [Multithreading: How to Use the Synchronization Classes](../vs140/multithreading--how-to-use-the-synchronization-classes.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 `CSyncObject`  
  
## Requirements  
 **Header:** afxmt.h  
  
##  <a name="csyncobject__csyncobject"></a>  CSyncObject::CSyncObject  
 Constructs a synchronization object with the supplied name.  
  
```  
explicit CSyncObject(    LPCTSTR  pstrName ); virtual ~CSyncObject( );  
  
```  
  
### Parameters  
 `pstrName`  
 The name of the object. If **NULL**,                                 *pstrName* will be null.  
  
##  <a name="csyncobject__lock"></a>  CSyncObject::Lock  
 Call this function to gain access to the resource controlled by the synchronization object.  
  
```  
virtual BOOL Lock(    DWORD  dwTimeout  = INFINITE  );  
  
```  
  
### Parameters  
 `dwTimeout`  
 Specifies the amount of time in milliseconds to wait for the synchronization object to be available (signaled). If **INFINITE**, `Lock` will wait until the object is signaled before returning.  
  
### Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
### Remarks  
 If the synchronization object is signaled, `Lock` will return successfully and the thread now owns the object. If the synchronization object is nonsignaled (unavailable), `Lock` will wait for the synchronization object to become signaled up to the number of milliseconds specified in the                         *dwTimeOut* parameter. If the synchronization object did not become signaled in the specified amount of time, `Lock` returns failure.  
  
##  <a name="csyncobject__m_hobject"></a>  CSyncObject::m_hObject  
 The handle to the underlying synchronization object.  
  
```  
HANDLE m_hObject;  
  
```  
  
##  <a name="csyncobject__operator_handle"></a>  CSyncObject::operator HANDLE  
 Use this operator to get the handle of the `CSyncObject` object.  
  
```  
operator HANDLE( ) const;  
  
```  
  
### Return Value  
 If successful, the handle of the synchronization object; otherwise, **NULL**.  
  
### Remarks  
 You can use the handle to call Windows APIs directly.  
  
##  <a name="csyncobject__unlock"></a>  CSyncObject::Unlock  
 The declaration of `Unlock` with no parameters is a pure virtual function, and must be overridden by all classes deriving from `CSyncObject`.  
  
```  
virtual BOOL Unlock( ) = 0; virtual BOOL Unlock(    LONG  lCount ,    LPLONG  lpPrevCount  = NULL );  
  
```  
  
### Parameters  
 `lCount`  
 Not used by default implementation.  
  
 `lpPrevCount`  
 Not used by default implementation.  
  
### Return Value  
 Default implementation always returns **TRUE**.  
  
### Remarks  
 The default implementation of the declaration with two parameters always returns **TRUE**. This function is called to release access to the synchronization object owned by the calling thread. The second declaration is provided for synchronization objects such as semaphores that allow more than one access of a controlled resource.  
  
## See Also  
 [Base Class](../vs140/cobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)