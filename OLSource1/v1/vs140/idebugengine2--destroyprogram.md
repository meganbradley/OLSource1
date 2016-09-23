---
title: "IDebugEngine2::DestroyProgram"
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
  - IDebugEngine2::DestroyProgram
helpviewer_keywords: 
  - IDebugEngine2::DestroyProgram
ms.assetid: 0c9e2698-c70f-4770-a7bb-39650e9c3a1f
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugEngine2::DestroyProgram
Informs a debug engine (DE) that the program specified has been atypically terminated and that the DE should clean up all references to the program and send a program destroy event.  
  
## Syntax  
  
```cpp#  
HRESULT DestroyProgram(   
   IDebugProgram2* pProgram  
);  
```  
  
```cpp#  
int DestroyProgram(   
   IDebugProgram2 pProgram  
);  
```  
  
#### Parameters  
 `pProgram`  
 [in] An [IDebugProgram2](../vs140/idebugprogram2.md) object that represents the program that has been atypically terminated.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 After this method is called, the DE subsequently sends an [IDebugProgramDestroyEvent2](../vs140/idebugprogramdestroyevent2.md) event back to the session debug manager (SDM).  
  
 This method is not implemented (returns `E_NOTIMPL`) if the DE runs in the same process as the program being debugged. This method is implemented only if the DE runs in the same process as the SDM.  
  
## See Also  
 [IDebugEngine2](../vs140/idebugengine2.md)   
 [IDebugProgramDestroyEvent2](../vs140/idebugprogramdestroyevent2.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)