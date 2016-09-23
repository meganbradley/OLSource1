---
title: "CriticalSection::TryLock Method"
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
  - corewrappers/Microsoft::WRL::Wrappers::CriticalSection::TryLock
dev_langs: 
  - C++
helpviewer_keywords: 
  - TryLock method
ms.assetid: 504bb87c-2cd0-4f54-b458-b3efb9789053
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CriticalSection::TryLock Method
Attempts to enter a critical section without blocking. If the call is successful, the calling thread takes ownership of the critical section.  
  
## Syntax  
  
```  
SyncLock TryLock();  
  
static SyncLock TryLock(  
   _In_ CRITICAL_SECTION* cs  
);  
```  
  
#### Parameters  
 `cs`  
 A user-specified critical section object.  
  
## Return Value  
 A nonzero value if the critical section is successfully entered or the current thread already owns the critical section. Zero if another thread already owns the critical section.  
  
## Remarks  
 The first **TryLock** function affects the current critical section object. The second **TryLock** function affects a user-specified critical section.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [CriticalSection Class](../vs140/criticalsection-class.md)