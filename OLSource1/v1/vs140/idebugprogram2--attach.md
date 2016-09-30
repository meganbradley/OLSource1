---
title: "IDebugProgram2::Attach"
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
  - "IDebugProgram2::Attach"
helpviewer_keywords: 
  - "IDebugProgram2::Attach"
ms.assetid: de069fbf-a565-4905-b102-f5658c55aacd
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProgram2::Attach
Attaches to the program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugEventCallback2](../vs140/idebugeventcallback2.md) object to be used for debug event notification.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code. The following table shows some possible error codes.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The specified program is already attached to the debugger.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|A security violation occurred during the attach procedure.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|A desktop program cannot be attached to the debugger.|  
  
## Remarks  
 A debug engine (DE) never calls this method to attach to a program. If the DE runs in the program's address space, the [IDebugProgramNodeAttach2::OnAttach](../vs140/idebugprogramnodeattach2--onattach.md) method is called. If the DE runs in the session debug manager's (SDM) address space, the [Attach](../vs140/idebugengine2--attach.md) method is called.  
  
## See Also  
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)   
 [IDebugProgramNodeAttach2::OnAttach](../vs140/idebugprogramnodeattach2--onattach.md)   
 [Attach](../vs140/idebugengine2--attach.md)