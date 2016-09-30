---
title: "IDebugPortEx2::LaunchSuspended"
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
  - "IDebugPortEx2::LaunchSuspended"
helpviewer_keywords: 
  - "IDebugPortEx2::LaunchSuspended"
ms.assetid: 34b2cf99-2e52-4757-8969-1d12ac517ec0
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugPortEx2::LaunchSuspended
Launches an executable file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The name of the executable to be launched. This can be a full path or relative to the working directory specified in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The arguments to pass to the executable. May be a null value if there are no arguments.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] The name of the working directory used by the executable. May be a null value if no working directory is required.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Environment block of null-terminated strings, followed by an additional NULL terminator.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] Handle to an alternate input stream. May be 0 if redirection is not required.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] Handle to an alternate output stream. May be 0 if redirection is not required.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] Handle to an alternate error output stream. May be 0 if redirection is not required.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md) object that represents the launched process.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method should launch the process so that it is suspended and not running any code. The [ResumeProcess](../vs140/idebugportex2--resumeprocess.md) method is called to resume the process.  
  
 A program can also be launched from a debug engine. For details, see [Launching a Program](../vs140/launching-a-program.md).  
  
## See Also  
 [IDebugPortEx2](../vs140/idebugportex2.md)   
 [IDebugPendingBreakpoint2](../vs140/idebugpendingbreakpoint2.md)   
 [ResumeProcess](../vs140/idebugportex2--resumeprocess.md)   
 [Launching a Program](../vs140/launching-a-program.md)