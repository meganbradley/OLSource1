---
title: "IDebugEngineProgram2"
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
  - "IDebugEngineProgram2"
helpviewer_keywords: 
  - "IDebugEngineProgram2 interface"
ms.assetid: 151003a9-2e4d-4acf-9f4d-365dfa6b9596
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngineProgram2
This interface provides multi-threaded debugging support.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 A debug engine implements this interface to support simultaneous debugging of multiple threads. This interface is implemented on the same object that implements the [IDebugProgram2](../vs140/idebugprogram2.md) interface.  
  
## Notes for Callers  
 Use [QueryInterface](../vs140/queryinterface.md) to obtain this interface from an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface.  
  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[Stop](../vs140/idebugengineprogram2--stop.md)|Stops all threads running in this program.|  
|[WatchForThreadStep](../vs140/idebugengineprogram2--watchforthreadstep.md)|Watches for execution (or stop watching for execution) to occur on the given thread.|  
|[WatchForExpressionEvaluationOnThread](../vs140/idebugengineprogram2--watchforexpressionevaluationonthread.md)|Allows (or disallows) expression evaluation to occur on the given thread, even if the program is stopped.|  
  
## Remarks  
 Visual Studio calls this interface in response to an [IDebugProgramCreateEvent2](../vs140/idebugprogramcreateevent2.md) event and to set the "Watch for Thread Step" and "Watch for Expression Evaluation on Thread" states of the program. [IDebugEngineProgram2::Stop](../vs140/idebugengineprogram2--stop.md) is called whenever the program is to be stopped; this method gives the program a chance to terminate all threads.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [IDebugProgram2](../vs140/idebugprogram2.md)