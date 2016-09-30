---
title: "IDebugBreakEvent2"
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
  - "IDebugBreakEvent2"
helpviewer_keywords: 
  - "IDebugBreakEvent2 interface"
ms.assetid: 57dfdbc2-4e68-4dbf-9579-006cd6fb1c62
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBreakEvent2
This interface tells the session debug manager (SDM) that an asynchronous break has been successfully completed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 The DE implements this interface to support user breaks in a program. The [IDebugEvent2](../vs140/idebugevent2.md) interface must be implemented on the same object as this interface (the SDM uses [QueryInterface](../vs140/queryinterface.md) to access the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface).  
  
## Notes for Callers  
 The SDM calls [IDebugProgram2::CauseBreak](../vs140/idebugprogram2--causebreak.md) when the user has requested the program being debugged to be paused. When the program has successfully been paused, the DE sends the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> event. This event is sent by using the [IDebugEventCallback2](../vs140/idebugeventcallback2.md) callback function supplied by the SDM when it attached to the program being debugged.  
  
## Remarks  
 For example, a user can select the **Break All** command on the **Debug** menu to break out of a program that is running an infinite loop. The SDM tells the program to stop by calling [CauseBreak](../vs140/idebugprogram2--causebreak.md). The DE sends <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> when the program finally stops.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [CauseBreak](../vs140/idebugprogram2--causebreak.md)   
 [IDebugEvent2](../vs140/idebugevent2.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)