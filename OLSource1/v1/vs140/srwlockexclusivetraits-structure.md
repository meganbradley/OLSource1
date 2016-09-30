---
title: "SRWLockExclusiveTraits Structure"
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
  - "corewrappers/Microsoft::WRL::Wrappers::HandleTraits::SRWLockExclusiveTraits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SRWLockExclusiveTraits structure"
ms.assetid: 38a996ef-c2d7-4886-b413-a426ecee8f05
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SRWLockExclusiveTraits Structure
Describes common characteristics of the SRWLock class in exclusive lock mode.  
  
## Syntax  
  
```  
struct SRWLockExclusiveTraits;  
```  
  
## Members  
  
### Public Typedefs  
  
|Name|Description|  
|----------|-----------------|  
|`Type`|Synonym for a pointer to the [SRWLOCK](../vs140/srwlock-class.md) class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[SRWLockExclusiveTraits::GetInvalidValue Method](../vs140/srwlockexclusivetraits--getinvalidvalue-method.md)|Retrieves an SRWLockExclusiveTraits object that is always invalid.|  
|[SRWLockExclusiveTraits::Unlock Method](../vs140/srwlockexclusivetraits--unlock-method.md)|Releases exclusive control of the specified SRWLock object.|  
  
## Inheritance Hierarchy  
 `SRWLockExclusiveTraits`  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers::HandleTraits  
  
## See Also  
 [HandleTraits Namespace](../vs140/microsoft--wrl--wrappers--handletraits-namespace.md)