---
title: "IDebugEngine2::EnumPrograms"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IDebugEngine2::EnumPrograms
helpviewer_keywords: 
  - IDebugEngine2::EnumPrograms
ms.assetid: 56bf98eb-beec-4e5f-9ebe-46c922e54c56
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugEngine2::EnumPrograms
Retrieves a list of all programs being debugged by a debug engine (DE).  
  
## Syntax  
  
```cpp#  
HRESULT EnumPrograms(   
   IEnumDebugPrograms2** ppEnum  
);  
```  
  
```c#  
int EnumPrograms(   
   out IEnumDebugPrograms2 ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns an [IEnumDebugPrograms2](../vs140/ienumdebugprograms2.md) object that contains a list of all programs being debugged by a DE.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugEngine2](../vs140/idebugengine2.md)   
 [IEnumDebugPrograms2](../vs140/ienumdebugprograms2.md)