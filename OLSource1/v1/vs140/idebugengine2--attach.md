---
title: "IDebugEngine2::Attach"
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
  - "IDebugEngine2::Attach"
helpviewer_keywords: 
  - "IDebugEngine2::Attach"
ms.assetid: 173dcbda-5019-4c5e-bca9-a071838b5739
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngine2::Attach
Attaches a debug engine (DE) to a program or programs. Called by the session debug manager (SDM) when the DE is running in-process to the SDM.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An array of [IDebugProgram2](../vs140/idebugprogram2.md) objects that represent programs to be attached to. These are port programs.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] An array of [IDebugProgramNode2](../vs140/idebugprogramnode2.md) objects that represent program nodes, one for each program. The program nodes in this array represent the same programs as in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The program nodes are given so that the DE can identify the programs to attach to.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] Number of programs and/or program nodes in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> arrays.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [in] The [IDebugEventCallback2](../vs140/idebugeventcallback2.md) object to be used to send debug events to the SDM.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] A value from the [ATTACH_REASON](../vs140/attach_reason.md) enumeration that specifies the reason for attaching these programs. For more information, see the Remarks section.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 There are three reasons for attaching to a program, as follows:  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> indicates that the DE is attaching to the program because the user launched the process that contains it.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> indicates that the user has explicitly requested the DE to attach to a program (or the process that contains a program).  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> indicates the DE is attaching to a particular program because it is already debugging other programs in a particular process. This is also called auto-attach.  
  
 When this method is called, the DE needs to send these events in sequence:  
  
1.  [IDebugEngineCreateEvent2](../vs140/idebugenginecreateevent2.md) (if it has not already been sent for a particular instance of the debug engine)  
  
2.  [IDebugProgramCreateEvent2](../vs140/idebugprogramcreateevent2.md)  
  
3.  [IDebugLoadCompleteEvent2](../vs140/idebugloadcompleteevent2.md)  
  
 In addition, if the reason for attaching is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the DE needs to send the [IDebugEntryPointEvent2](../vs140/idebugentrypointevent2.md) event.  
  
 Once the DE gets the [IDebugProgramNode2](../vs140/idebugprogramnode2.md) object corresponding to the program being debugged, it can be queried for any private interface.  
  
 Before calling the methods of a program node in the array given by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, impersonation, if required, should be enabled on the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> interface that represents the program node. Normally, however, this step is not necessary. For more information, see [Security Issues](../vs140/security-issues.md).  
  
## See Also  
 [IDebugEngine2](../vs140/idebugengine2.md)   
 [IDebugProgramNode2](../vs140/idebugprogramnode2.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)   
 [ATTACH_REASON](../vs140/attach_reason.md)   
 [IDebugEngineCreateEvent2](../vs140/idebugenginecreateevent2.md)   
 [IDebugProgramCreateEvent2](../vs140/idebugprogramcreateevent2.md)   
 [IDebugLoadCompleteEvent2](../vs140/idebugloadcompleteevent2.md)   
 [IDebugEntryPointEvent2](../vs140/idebugentrypointevent2.md)