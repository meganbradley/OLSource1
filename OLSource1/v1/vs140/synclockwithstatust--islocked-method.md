---
title: "SyncLockWithStatusT::IsLocked Method"
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
  - "corewrappers/Microsoft::WRL::Wrappers::Details::SyncLockWithStatusT::IsLocked"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsLocked method"
ms.assetid: e1b75b7b-c145-471a-aa5d-71abf31f5990
caps.latest.revision: 8
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SyncLockWithStatusT::IsLocked Method
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
```  
bool IsLocked() const;  
```  
  
## Remarks  
 Indicates whether the current SyncLockWithStatusT object owns a resource; that is, the SyncLockWithStatusT object is *locked*.  
  
## Return Value  
 **true** if the SyncLockWithStatusT object is locked; otherwise, **false**.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers::Details  
  
## See Also  
 [SyncLockWithStatusT Class](../vs140/synclockwithstatust-class.md)