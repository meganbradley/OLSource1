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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dwTimeOut*  
 Specifies the amount of time to wait for the synchronization object to be available (signaled). If **INFINITE**, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> will wait until the object is signaled before returning.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies whether all objects waited on must become signaled at the same time before returning. If **FALSE**, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> will return when any one of the objects waited on is signaled.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies other conditions that are allowed to abort the wait. For a full list of the available options for this parameter, see [MsgWaitForMultipleObjects](http://msdn.microsoft.com/library/windows/desktop/ms684242) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> fails, it returns – 1. If successful, it returns one of the following values:  
  
-   Between **WAIT_OBJECT_0** and **WAIT_OBJECT_0** + (number of objects – 1)  
  
     If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is **TRUE**, all objects are signaled (available). If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is **FALSE**, the return value – **WAIT_OBJECT_0** is the index in the array of objects of the object that is signaled (available).  
  
-   **WAIT_OBJECT_0** + (number of objects)  
  
     An event specified in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is available in the thread's input queue.  
  
-   Between **WAIT_ABANDONED_0** and **WAIT_ABANDONED_0** + (number of objects – 1)  
  
     If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is **TRUE**, all objects are signaled, and at least one of the objects is an abandoned mutex object. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is **FALSE**, the return value – **WAIT_ABANDONED_0** is the index in the array of objects of the abandoned mutex object that satisfied the wait.  
  
-   **WAIT_TIMEOUT**  
  
     The timeout interval specified in *dwTimeOut* expired without the wait succeeding.  
  
## Remarks  
 If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is **TRUE**, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> will return successfully as soon as all the synchronization objects become signaled simultaneously. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is **FALSE**, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> will return as soon as one or more of the synchronization objects becomes signaled.  
  
 If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is not able to return immediately, it will wait for no more than the number of milliseconds specified in the *dwTimeOut* parameter before returning. If *dwTimeOut* is **INFINITE**, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> will not return until access to an object is gained or a condition specified in <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> was met. Otherwise, if <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> was able to acquire a synchronization object, it will return successfully; if not, it will return failure.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CMultiLock Class](../vs140/cmultilock-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)