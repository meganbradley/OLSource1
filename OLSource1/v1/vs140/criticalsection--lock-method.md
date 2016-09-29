---
title: "CriticalSection::Lock Method"
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
  - "corewrappers/Microsoft::WRL::Wrappers::CriticalSection::Lock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Lock method"
ms.assetid: 37cb184c-e13c-49ef-b6a0-13908a956414
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CriticalSection::Lock Method
Waits for ownership of the specified critical section object. The function returns when the calling thread is granted ownership.  
  
## Syntax  
  
```  
SyncLock Lock();  
  
   static SyncLock Lock(  
   _In_ CRITICAL_SECTION* cs  
);  
```  
  
#### Parameters  
 `cs`  
 A user-specified critical section object.  
  
## Return Value  
 A lock object that can be used to unlock the current critical section.  
  
## Remarks  
 The first **Lock** function affects the current critical section object. The second **Lock** function affects a user-specified critical section.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [CriticalSection Class](../vs140/criticalsection-class.md)