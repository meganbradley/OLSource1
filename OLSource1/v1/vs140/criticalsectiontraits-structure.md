---
title: "CriticalSectionTraits Structure"
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
  - "corewrappers/Microsoft::WRL::Wrappers::HandleTraits::CriticalSectionTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CriticalSectionTraits structure"
ms.assetid: c515a1b5-4eb0-40bc-9035-c4d9352c9de7
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CriticalSectionTraits Structure
Specializes a CriticalSection object to support either an invalid critical section or a function to release a critical section.  
  
## Syntax  
  
```  
struct CriticalSectionTraits;  
```  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|`Type`|A `typedef` that defines a pointer to a critical section. `Type` is defined as `typedef CRITICAL_SECTION* Type;`.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CriticalSectionTraits::GetInvalidValue Method](../vs140/criticalsectiontraits--getinvalidvalue-method.md)|Specializes a CriticalSection template so that the template is always invalid.|  
|[CriticalSectionTraits::Unlock Method](../vs140/criticalsectiontraits--unlock-method.md)|Specializes a CriticalSection template so that it supports releasing ownership of the specified critical section object.|  
  
## Inheritance Hierarchy  
 `CriticalSectionTraits`  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers::HandleTraits  
  
## See Also  
 [HandleTraits Namespace](../vs140/microsoft--wrl--wrappers--handletraits-namespace.md)