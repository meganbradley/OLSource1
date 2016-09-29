---
title: "CMultiLock::Lock"
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
  - "CMultiLock.Lock"
  - "CMultiLock::Lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lock method"
ms.assetid: 66b2c56e-10ab-405e-ad34-de27b6512cb7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMultiLock::Lock
Call this function to gain access to one or more of the resources controlled by the synchronization objects supplied to the **CMultiLock** constructor.  
  
## Syntax  
  
```  
  
      DWORD Lock(  
   DWORD dwTimeOut = INFINITE,  
   BOOL bWaitForAll = TRUE,  
   DWORD dwWakeMask = 0   
);  
```  
  
#### Parameters  
 *dwTimeOut*  
 Specifies the amount of time to wait for the synchronization object to be available (signaled). If **INFINITE**, `Lock` will wait until the object is signaled before returning.  
  
 `bWaitForAll`  
 Specifies whether all objects waited on must become signaled at the same time before returning. If **FALSE**, `Lock` will return when any one of the objects waited on is signaled.  
  
 `dwWakeMask`  
 Specifies other conditions that are allowed to abort the wait. For a full list of the available options for this parameter, see [MsgWaitForMultipleObjects](http://msdn.microsoft.com/library/windows/desktop/ms684242) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 If `Lock` fails, it returns – 1. If successful, it returns one of the following values:  
  
-   Between **WAIT_OBJECT_0** and **WAIT_OBJECT_0** + (number of objects – 1)  
  
     If `bWaitForAll` is **TRUE**, all objects are signaled (available). If `bWaitForAll` is **FALSE**, the return value – **WAIT_OBJECT_0** is the index in the array of objects of the object that is signaled (available).  
  
-   **WAIT_OBJECT_0** + (number of objects)  
  
     An event specified in `dwWakeMask` is available in the thread's input queue.  
  
-   Between **WAIT_ABANDONED_0** and **WAIT_ABANDONED_0** + (number of objects – 1)  
  
     If `bWaitForAll` is **TRUE**, all objects are signaled, and at least one of the objects is an abandoned mutex object. If `bWaitForAll` is **FALSE**, the return value – **WAIT_ABANDONED_0** is the index in the array of objects of the abandoned mutex object that satisfied the wait.  
  
-   **WAIT_TIMEOUT**  
  
     The timeout interval specified in *dwTimeOut* expired without the wait succeeding.  
  
## Remarks  
 If `bWaitForAll` is **TRUE**, `Lock` will return successfully as soon as all the synchronization objects become signaled simultaneously. If `bWaitForAll` is **FALSE**, `Lock` will return as soon as one or more of the synchronization objects becomes signaled.  
  
 If `Lock` is not able to return immediately, it will wait for no more than the number of milliseconds specified in the *dwTimeOut* parameter before returning. If *dwTimeOut* is **INFINITE**, `Lock` will not return until access to an object is gained or a condition specified in `dwWakeMask` was met. Otherwise, if `Lock` was able to acquire a synchronization object, it will return successfully; if not, it will return failure.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CMultiLock Class](../vs140/cmultilock-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)