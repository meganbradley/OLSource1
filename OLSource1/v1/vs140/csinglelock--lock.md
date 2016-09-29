---
title: "CSingleLock::Lock"
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
  - "CSingleLock::Lock"
  - "CSingleLock.Lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lock method"
ms.assetid: 25ff38a9-06ba-4fee-ab1e-28fca2846735
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSingleLock::Lock
Call this function to gain access to the resource controlled by the synchronization object supplied to the `CSingleLock` constructor.  
  
## Syntax  
  
```  
  
      BOOL Lock(  
   DWORD dwTimeOut = INFINITE   
);  
```  
  
#### Parameters  
 *dwTimeOut*  
 Specifies the amount of time to wait for the synchronization object to be available (signaled). If **INFINITE**, `Lock` will wait until the object is signaled before returning.  
  
## Return Value  
 Nonzero if the function was successful; otherwise 0.  
  
## Remarks  
 If the synchronization object is signaled, `Lock` will return successfully and the thread now owns the object. If the synchronization object is nonsignaled (unavailable), `Lock` will wait for the synchronization object to become signaled up to the number of milliseconds specified in the *dwTimeOut* parameter. If the synchronization object did not become signaled in the specified amount of time, `Lock` returns failure.  
  
## Example  
 [!code[NVC_MFC_Utilities#21](../vs140/codesnippet/CPP/csinglelock--lock_1.h)]  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CSingleLock Class](../vs140/csinglelock-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)