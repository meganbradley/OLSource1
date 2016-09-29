---
title: "CSemaphore::CSemaphore"
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
  - "CSemaphore::CSemaphore"
  - "CSemaphore.CSemaphore"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSemaphore class, constructor"
ms.assetid: 023a0154-4c51-4f46-ab0e-8e92b06b0da7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSemaphore::CSemaphore
Constructs a named or unnamed `CSemaphore` object.  
  
## Syntax  
  
```  
  
      CSemaphore(  
   LONG lInitialCount = 1,  
   LONG lMaxCount = 1,  
   LPCTSTR pstrName = NULL,  
   LPSECURITY_ATTRIBUTES lpsaAttributes = NULL   
);  
```  
  
#### Parameters  
 *lInitialCount*  
 The initial usage count for the semaphore. Must be greater than or equal to 0, and less than or equal to `lMaxCount`.  
  
 `lMaxCount`  
 The maximum usage count for the semaphore. Must be greater than 0.  
  
 `pstrName`  
 The name of the semaphore. Must be supplied if the semaphore will be accessed across process boundaries. If `NULL,` the object will be unnamed. If the name matches an existing semaphore, the constructor builds a new `CSemaphore` object which references the semaphore of that name. If the name matches an existing synchronization object that is not a semaphore, the construction will fail.  
  
 *lpsaAttributes*  
 Security attributes for the semaphore object. For a full description of this structure, see [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 To access or release a `CSemaphore` object, create a [CMultiLock](../vs140/cmultilock-class.md) or [CSingleLock](../vs140/csinglelock-class.md) object and call its [Lock](../vs140/csinglelock--lock.md) and [Unlock](../vs140/csinglelock--unlock.md) member functions.  
  
> [!IMPORTANT]
>  After creating the `CSemaphore` object, use [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) to ensure that the mutex did not already exist. If the mutex did exist unexpectedly, it may indicate a rogue process is squatting and may be intending to use the mutex maliciously. In this case, the recommended security-conscious procedure is to close the handle and continue as if there was a failure in creating the object.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CSemaphore Class](../vs140/csemaphore-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMutex Class](../vs140/cmutex-class.md)   
 [CEvent Class](../vs140/cevent-class.md)   
 [CMultiLock Class](../vs140/cmultilock-class.md)   
 [CSingleLock Class](../vs140/csinglelock-class.md)