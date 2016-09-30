---
title: "IDebugEntryPointEvent2"
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
  - "IDebugEntryPointEvent2"
helpviewer_keywords: 
  - "IDebugEntryPointEvent2 interface"
ms.assetid: a15d1cc3-97b7-438c-8d24-c23149708f42
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEntryPointEvent2
The debug engine (DE) sends this interface to the session debug manager (SDM) when the program is about to execute its first instruction of user code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 The DE implements this interface as part of its normal operations. The [IDebugEvent2](../vs140/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](../vs140/queryinterface.md) to access the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface.  
  
## Notes for Callers  
 The DE creates and sends this event object when the program being debugged has been loaded and is ready to execute the first instruction of user code. The event is sent by using the [IDebugEventCallback2](../vs140/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.  
  
## Remarks  
 [IDebugLoadCompleteEvent2](../vs140/idebugloadcompleteevent2.md) is sent when the program is about to execute the very first instruction. For example, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is sent when the program is about to execute the user's <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function.  
  
 When the DE sends <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the current code position should be at the first instruction of user code, like <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugEvent2](../vs140/idebugevent2.md)   
 [IDebugLoadCompleteEvent2](../vs140/idebugloadcompleteevent2.md)