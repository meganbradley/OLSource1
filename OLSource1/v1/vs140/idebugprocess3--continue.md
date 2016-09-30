---
title: "IDebugProcess3::Continue"
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
  - "IDebugProcess3::Continue"
helpviewer_keywords: 
  - "IDebugProcess3::Continue"
ms.assetid: 57506242-5763-4c08-adb9-8a78ce02cebb
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProcess3::Continue
Continues running this process from a stopped state. Any previous execution state (such as a step) is preserved, and the process starts executing again.  
  
> [!NOTE]
>  This method should be used instead of [IDebugProgram2::Continue](../vs140/idebugprogram2--continue.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugThread2](../vs140/idebugthread2.md) object representing the thread to be continued.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns error code.  
  
## Remarks  
 This method is called on this process regardless of how many processes are being debugged, or which process generated the stopping event. The implementation must retain the previous execution state (such as a step) and continue execution as though it had never stopped before completing its prior execution. That is, if a thread in this process was doing a step-over operation and was stopped because some other process stopped, and then <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> was called, the specified thread must complete the original step-over operation.  
  
 **Warning** Do not send a stopping event or an immediate (synchronous) event to [IDebugEventCallback2::Event](../vs140/idebugeventcallback2--event.md) while handling this call; otherwise the debugger may hang.  
  
## See Also  
 [IDebugProcess3](../vs140/idebugprocess3.md)   
 [IDebugThread2](../vs140/idebugthread2.md)   
 [IDebugEventCallback2::Event](../vs140/idebugeventcallback2--event.md)