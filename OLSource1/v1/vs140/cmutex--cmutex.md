---
title: "CMutex::CMutex"
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
  - CMutex::CMutex
  - CMutex.CMutex
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMutex class, constructor
  - CMutex constructor
ms.assetid: 4bee3f91-eea4-4a89-8058-8c61bb74eb24
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMutex::CMutex
Constructs a named or unnamed `CMutex` object.  
  
## Syntax  
  
```  
  
      CMutex(  
   BOOL bInitiallyOwn = FALSE,  
   LPCTSTR lpszName = NULL,  
   LPSECURITY_ATTRIBUTES lpsaAttribute = NULL   
);  
```  
  
#### Parameters  
 `bInitiallyOwn`  
 Specifies if the thread creating the `CMutex` object initially has access to the resource controlled by the mutex.  
  
 `lpszName`  
 Name of the `CMutex` object. If another mutex with the same name exists, `lpszName` must be supplied if the object will be used across process boundaries. If **NULL**, the mutex will be unnamed. If the name matches an existing mutex, the constructor builds a new `CMutex` object which references the mutex of that name. If the name matches an existing synchronization object that is not a mutex, the construction will fail.  
  
 `lpsaAttribute`  
 Security attributes for the mutex object. For a full description of this structure, see [SECURITY_ATTRIBUTES](http://msdn.microsoft.com/library/windows/desktop/aa379560) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 To access or release a `CMutex` object, create a [CMultiLock](../vs140/cmultilock-class.md) or [CSingleLock](../vs140/csinglelock-class.md) object and call its [Lock](../vs140/csinglelock--lock.md) and [Unlock](../vs140/csinglelock--unlock.md) member functions. If the `CMutex` object is being used stand-alone, call its `Unlock` member function to release it.  
  
> [!IMPORTANT]
>  After creating the `CMutex` object, use [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360) to ensure that the mutex did not already exist. If the mutex did exist unexpectedly, it may indicate a rogue process is squatting and may be intending to use the mutex maliciously. In this case, the recommended security-conscious procedure is to close the handle and continue as if there was a failure in creating the object.  
  
## Requirements  
 **Header:** afxmt.h  
  
## See Also  
 [CMutex Class](../vs140/cmutex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)