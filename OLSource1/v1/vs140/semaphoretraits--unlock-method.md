---
title: "SemaphoreTraits::Unlock Method"
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
  - corewrappers/Microsoft::WRL::Wrappers::HandleTraits::SemaphoreTraits::Unlock
dev_langs: 
  - C++
helpviewer_keywords: 
  - Unlock method
ms.assetid: 4e0ea808-b70d-43f7-81ef-998c3b34e3a0
caps.latest.revision: 7
translation.priority.ht: 
  - de-de
  - ja-jp
---
# SemaphoreTraits::Unlock Method
Releases control of a shared resource.  
  
## Syntax  
  
```  
inline static void Unlock(  
   _In_ Type h  
);  
```  
  
#### Parameters  
 `h`  
 Handle to a semaphore object.  
  
## Remarks  
 If the unlock operation is unsuccessful, Unlock() emits an error that indicates the cause of the failure.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers::HandleTraits  
  
## See Also  
 [SemaphoreTraits Structure](../vs140/semaphoretraits-structure.md)