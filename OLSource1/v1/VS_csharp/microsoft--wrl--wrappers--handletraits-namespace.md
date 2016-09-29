---
title: "Microsoft::WRL::Wrappers::HandleTraits Namespace"
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
  - "corewrappers/Microsoft::WRL::Wrappers::HandleTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HandleTraits namespace"
ms.assetid: 2fb5c6d1-bfc2-4e09-91eb-31705064ffb3
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Microsoft::WRL::Wrappers::HandleTraits Namespace
Describes characteristics of common handle-based resource types.  
  
## Syntax  
  
```  
namespace Microsoft::WRL::Wrappers::HandleTraits;  
```  
  
## Members  
  
### Structures  
  
|Name|Description|  
|----------|-----------------|  
|[CriticalSectionTraits Structure](../VS_csharp/criticalsectiontraits-structure.md)|Specializes a `CriticalSection` object to support either an invalid critical section or a function to release a critical section.|  
|[EventTraits Structure](../VS_csharp/eventtraits-structure.md)|Defines characteristics of an `Event` class handle.|  
|[FileHandleTraits Structure](../VS_csharp/filehandletraits-structure.md)|Defines characteristics of a file handle.|  
|[HANDLENullTraits Structure](../VS_csharp/handlenulltraits-structure.md)|Defines common characteristics of an uninitialized handle.|  
|[HANDLETraits Structure](../VS_csharp/handletraits-structure.md)|Defines common characteristics of a handle.|  
|[MutexTraits Structure](../VS_csharp/mutextraits-structure.md)|Defines common characteristics of the [Mutex](../VS_csharp/mutex-class.md) class.|  
|[SemaphoreTraits Structure](../VS_csharp/semaphoretraits-structure.md)|Defines common characteristics of a Semaphore object.|  
|[SRWLockExclusiveTraits Structure](../VS_csharp/srwlockexclusivetraits-structure.md)|Describes common characteristics of the `SRWLock` class in exclusive lock mode.|  
|[SRWLockSharedTraits Structure](../VS_csharp/srwlocksharedtraits-structure.md)|Describes common characteristics of the `SRWLock` class in shared lock mode.|  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [Wrappers Namespace](../VS_csharp/microsoft--wrl--wrappers-namespace.md)