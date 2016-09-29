---
title: "IDebugEngineLaunch2::ResumeProcess"
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
  - "IDebugEngineLaunch2::ResumeProcess"
helpviewer_keywords: 
  - "IDebugEngineLaunch2::ResumeProcess"
ms.assetid: 61ccc14e-75c6-44e7-aae4-57a9aac52089
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngineLaunch2::ResumeProcess
Resumes process execution.  
  
## Syntax  
  
```cpp#  
HRESULT ResumeProcess (   
   IDebugProcess2* pProcess  
);  
```  
  
```c#  
int ResumeProcess (   
   IDebugProcess2 pProcess  
);  
```  
  
#### Parameters  
 `pProcess`  
 [in] An [IDebugProcess2](../vs140/idebugprocess2.md) object that represents the process to be resumed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise returns an error code.  
  
## Remarks  
 This method is called after a process has been launched with a call to the [IDebugEngineLaunch2::LaunchSuspended](../vs140/idebugenginelaunch2--launchsuspended.md) method.  
  
## See Also  
 [IDebugEngineLaunch2](../vs140/idebugenginelaunch2.md)   
 [IDebugProcess2](../vs140/idebugprocess2.md)   
 [IDebugEngineLaunch2::LaunchSuspended](../vs140/idebugenginelaunch2--launchsuspended.md)