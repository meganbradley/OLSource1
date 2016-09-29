---
title: "SyncLockT Class"
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
  - "corewrappers/Microsoft::WRL::Wrappers::Details::SyncLockT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SyncLockT class"
ms.assetid: a967f6f7-3555-43d1-b210-2bb65d63d15e
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SyncLockT Class
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
template <  
   typename SyncTraits  
>  
class SyncLockT;  
```  
  
#### Parameters  
 `SyncTraits`  
 The type that can take ownership of a resource.  
  
## Remarks  
 Represents a type that can take exclusive or shared ownership of a resource.  
  
 The SyncLockT class is used, for example, to help implement the [SRWLock](../VS_csharp/srwlock-class.md) class.  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[SyncLockT::SyncLockT Constructor](../VS_csharp/synclockt--synclockt-constructor.md)|Initializes a new instance of the SyncLockT class.|  
|[SyncLockT::~SyncLockT Destructor](../VS_csharp/synclockt--~synclockt-destructor.md)|Deinitializes an instance of the SyncLockT class.|  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[SyncLockT::SyncLockT Constructor](../VS_csharp/synclockt--synclockt-constructor.md)|Initializes a new instance of the SyncLockT class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[SyncLockT::IsLocked Method](../VS_csharp/synclockt--islocked-method.md)|Indicates whether the current SyncLockT object owns a resource; that is, the SyncLockT object is *locked*.|  
|[SyncLockT::Unlock Method](../VS_csharp/synclockt--unlock-method.md)|Releases control of the resource held by the current SyncLockT object, if any.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[SyncLockT::sync_ Data Member](../VS_csharp/synclockt--sync_-data-member.md)|Holds the underlying resource represented by the SyncLockT class.|  
  
## Inheritance Hierarchy  
 `SyncLockT`  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers::Details  
  
## See Also  
 [Microsoft::WRL::Wrappers::Details Namespace](../VS_csharp/microsoft--wrl--wrappers--details-namespace.md)   
 [SRWLock Class](../VS_csharp/srwlock-class.md)