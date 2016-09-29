---
title: "SemaphoreTraits Structure"
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
  - "corewrappers/Microsoft::WRL::Wrappers::HandleTraits::SemaphoreTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SemaphoreTraits structure"
ms.assetid: eddb8576-d063-409b-9201-cc87ca5d111e
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SemaphoreTraits Structure
Defines common characteristics of a Semaphore object.  
  
## Syntax  
  
```  
struct SemaphoreTraits : HANDLENullTraits;  
```  
  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[SemaphoreTraits::Unlock Method](../vs140/semaphoretraits--unlock-method.md)|Releases control of a shared resource.|  
  
## Inheritance Hierarchy  
 `HANDLENullTraits`  
  
 `SemaphoreTraits`  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers::HandleTraits  
  
## See Also  
 [HandleTraits Namespace](../vs140/microsoft--wrl--wrappers--handletraits-namespace.md)