---
title: "IDebugEngineLaunch2::TerminateProcess"
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
  - IDebugEngineLaunch2::TerminateProcess
helpviewer_keywords: 
  - IDebugEngineLaunch2::TerminateProcess
ms.assetid: f7039e7f-5f57-4222-9ad2-11a66b2da6e0
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugEngineLaunch2::TerminateProcess
Terminates a process.  
  
## Syntax  
  
```cpp#  
HRESULT TerminateProcess (   
   IDebugProcess2* pProcess  
);  
```  
  
```c#  
int TerminateProcess (   
   IDebugProcess2 pProcess  
);  
```  
  
#### Parameters  
 `pProcess`  
 [in] An [IDebugProcess2](../vs140/idebugprocess2.md) object that represents the process to be terminated.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns an error code.  
  
## Remarks  
 Call the [IDebugEngineLaunch2::CanTerminateProcess](../vs140/idebugenginelaunch2--canterminateprocess.md) method before calling this method.  
  
## See Also  
 [IDebugEngineLaunch2](../vs140/idebugenginelaunch2.md)   
 [IDebugProcess2](../vs140/idebugprocess2.md)   
 [IDebugEngineLaunch2::CanTerminateProcess](../vs140/idebugenginelaunch2--canterminateprocess.md)