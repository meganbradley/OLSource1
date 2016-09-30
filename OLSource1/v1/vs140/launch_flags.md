---
title: "LAUNCH_FLAGS"
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
  - "LAUNCH_FLAGS"
helpviewer_keywords: 
  - "LAUNCH_FLAGS enumeration"
ms.assetid: f51aab02-d257-4302-bb79-b7d8ba9ac4e5
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# LAUNCH_FLAGS
Specifies the debug launch flags.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 LAUNCH_DEBUG  
 Launches the process for debugging.  
  
 LAUNCH_NODEBUG  
 Launches the process without debugging it.  
  
 LAUNCH_ENABLE_ENC  
 DEPRECATED, DO NOT USE.  
  
 LAUNCH_MERGE_ENV  
 Launches the process and merges the environment with the launching host.  
  
## Remarks  
 These values are passed as an argument to the [IDebugEngineLaunch2::LaunchSuspended](../vs140/idebugenginelaunch2--launchsuspended.md) method.  
  
 These flags may be combined with a bitwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [IDebugEngineLaunch2::LaunchSuspended](../vs140/idebugenginelaunch2--launchsuspended.md)