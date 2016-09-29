---
title: "IDebugEngineLaunch2::CanTerminateProcess"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugEngineLaunch2::CanTerminateProcess"
helpviewer_keywords: 
  - "IDebugEngineLaunch2::CanTerminateProcess"
ms.assetid: 7973454d-c957-4123-a0ee-80ebcdbbd2d1
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngineLaunch2::CanTerminateProcess
Determines if a process can be terminated.  
  
## Syntax  
  
```cpp#  
HRESULT CanTerminateProcess (   
   IDebugProcess2* pProcess  
);  
```  
  
```c#  
int CanTerminateProcess (   
   IDebugProcess2 pProcess  
);  
```  
  
#### Parameters  
 `pProcess`  
 [in] An [IDebugProcess2](../vs140/idebugprocess2.md) object that represents the process to be terminated.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns an error code. Returns `S_FALSE` if the engine cannot terminate the process, for example, because access is denied.  
  
## Remarks  
 If this method returns `S_OK`, then it the [IDebugEngineLaunch2::TerminateProcess](../vs140/idebugenginelaunch2--terminateprocess.md) method can be called to actually terminate the process.  
  
## See Also  
 [IDebugEngineLaunch2](../vs140/idebugenginelaunch2.md)   
 [IDebugProcess2](../vs140/idebugprocess2.md)   
 [IDebugEngineLaunch2::TerminateProcess](../vs140/idebugenginelaunch2--terminateprocess.md)