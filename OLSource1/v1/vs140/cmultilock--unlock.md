---
title: "CMultiLock::Unlock"
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
  - CMultiLock.Unlock
  - CMultiLock::Unlock
dev_langs: 
  - C++
helpviewer_keywords: 
  - Unlock method
ms.assetid: 5da58e3c-2d72-4a95-a53d-448533e1fa78
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMultiLock::Unlock
Releases the synchronization object owned by `CMultiLock`.  
  
## Syntax  
  
```  
  
      BOOL Unlock( );   
BOOL Unlock(  
   LONG lCount,  
   LPLONG lPrevCount = NULL   
);  
```  
  
#### Parameters  
 `lCount`  
 Number of reference counts to release. Must be greater than 0. If the specified amount would cause the object's count to exceed its maximum, the count is not changed and the function returns **FALSE**.  
  
 `lPrevCount`  
 Points to a variable to receive the previous count for the synchronization object. If **NULL**, the previous count is not returned.  
  
## Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
## Remarks  
 This function is called by `CMultiLock`'s destructor.  
  
 The first form of `Unlock` tries to unlock the synchronization object managed by `CMultiLock`. The second form of `Unlock` tries to unlock the `CSemaphore` objects owned by `CMultiLock`. If `CMultiLock` does not own any locked `CSemaphore` object, the function returns **FALSE**; otherwise, it returns **TRUE**. `lCount` and `lpPrevCount` are exactly the same as the parameters of [CSingleLock::Unlock](../vs140/csinglelock--unlock.md). The second form of `Unlock` is rarely applicable to multilock situations.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CMultiLock Class](../vs140/cmultilock-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)