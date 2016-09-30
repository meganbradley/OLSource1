---
title: "IDebugEngineLaunch2::LaunchSuspended"
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
  - "IDebugEngineLaunch2::LaunchSuspended"
helpviewer_keywords: 
  - "IDebugEngineLaunch2::LaunchSuspended"
ms.assetid: 5dd2643e-c20a-470e-9024-2a423eb39856
caps.latest.revision: 21
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngineLaunch2::LaunchSuspended
This method launches a process by means of the debug engine (DE).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The name of the machine in which to launch the process. Use a null value to specify the local machine.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The [IDebugPort2](../vs140/idebugport2.md) interface representing the port that the program will run in.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The name of the executable to be launched.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The arguments to pass to the executable. May be a null value if there are no arguments.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] The name of the working directory used by the executable. May be a null value if no working directory is required.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] Environment block of NULL-terminated strings, followed by an additional NULL terminator.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] The options for the executable.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] Specifies the [LAUNCH_FLAGS](../vs140/launch_flags.md) for a session.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [in] Handle to an alternate input stream. May be 0 if redirection is not required.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 [in] Handle to an alternate output stream. May be 0 if redirection is not required.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 [in] Handle to an alternate error output stream. May be 0 if redirection is not required.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 [in] The [IDebugEventCallback2](../vs140/idebugeventcallback2.md) object that receives debugger events.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 [out] Returns the resulting [IDebugProcess2](../vs140/idebugprocess2.md) object that represents the launched process.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Normally, [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] launches a program using the [IDebugPortEx2::LaunchSuspended](../vs140/idebugportex2--launchsuspended.md) method and then attaches the debugger to the suspended program. However, there are circumstances in which the debug engine may need to launch a program (for example, if the debug engine is part of an interpreter and the program being debugged is an interpreted language), in which case [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] uses the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method.  
  
 The [IDebugEngineLaunch2::ResumeProcess](../vs140/idebugenginelaunch2--resumeprocess.md) method is called to start the process after the process has been successfully launched in a suspended state.  
  
## See Also  
 [IDebugEngineLaunch2](../vs140/idebugenginelaunch2.md)   
 [IDebugPort2](../vs140/idebugport2.md)   
 [LAUNCH_FLAGS](../vs140/launch_flags.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)   
 [IDebugProcess2](../vs140/idebugprocess2.md)   
 [IDebugPortEx2::LaunchSuspended](../vs140/idebugportex2--launchsuspended.md)   
 [IDebugEngineLaunch2::ResumeProcess](../vs140/idebugenginelaunch2--resumeprocess.md)