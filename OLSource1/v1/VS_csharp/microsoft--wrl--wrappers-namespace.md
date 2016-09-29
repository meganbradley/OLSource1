---
title: "Microsoft::WRL::Wrappers Namespace"
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
  - "corewrappers/Microsoft::WRL::Wrappers"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Wrappers namespace"
ms.assetid: 36ac38c7-1fc3-42da-a879-5c68661dc9e1
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Microsoft::WRL::Wrappers Namespace
Defines Resource Acquisition Is Initialization (RAII) wrapper types that simplify the lifetime management of objects, strings, and handles.  
  
## Syntax  
  
```  
namespace Microsoft::WRL::Wrappers;  
```  
  
## Members  
  
### Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|`FileHandle`|`HandleT<HandleTraits::FileHandleTraits>`|  
  
### Classes  
  
|Name|Description|  
|----------|-----------------|  
|[CriticalSection Class](../VS_csharp/criticalsection-class.md)|Represents a critical section object.|  
|[Event Class](../VS_csharp/event-class--windows-runtime-c---template-library-.md)|Represents an event.|  
|[HandleT Class](../VS_csharp/handlet-class.md)|Represents a handle to an object.|  
|[HString Class](../VS_csharp/hstring-class.md)|Provides support for manipulating HSTRING handles.|  
|[HStringReference Class](../VS_csharp/hstringreference-class.md)|Represents an HSTRING that is created from an existing string.|  
|[Mutex Class](../VS_csharp/mutex-class.md)|Represents a synchronization object that exclusively controls a shared resource.|  
|[RoInitializeWrapper Class](../VS_csharp/roinitializewrapper-class.md)|Initializes the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].|  
|[Semaphore Class](../VS_csharp/semaphore-class.md)|Represents a synchronization object that controls a shared resource that can support a limited number of users.|  
|[SRWLock Class](../VS_csharp/srwlock-class.md)|Represents a slim reader/writer lock.|  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [Microsoft::WRL Namespace](../VS_csharp/microsoft--wrl-namespace.md)