---
title: "IDebugEventCallback2::Event"
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
  - "IDebugEventCallback2::Event"
helpviewer_keywords: 
  - "IDebugEventCallback2::Event"
ms.assetid: e5a3345b-d460-4e40-8f5b-3111c56a2ed9
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEventCallback2::Event
Sends notification of debug events.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugEngine2](../vs140/idebugengine2.md) object that represents the debug engine (DE) that is sending this event. A DE is required to fill out this parameter.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] An [IDebugProcess2](../vs140/idebugprocess2.md) object that represents the process in which the event occurs. This parameter is filled in by the session debug manager (SDM). A DE always passes a null value for this parameter.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] An [IDebugProgram2](../vs140/idebugprogram2.md) object that represents the program in which this event occurs. For most events, this parameter is not a null value.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [in] An [IDebugThread2](../vs140/idebugthread2.md) object that represents the thread in which this event occurs. For stopping events, this parameter cannot be a null value as the stack frame is obtained from this parameter.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] An [IDebugEvent2](../vs140/idebugevent2.md) object that represents the debug event.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] GUID that identifies which event interface to obtain from the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [EVENTATTRIBUTES](../vs140/eventattributes.md) enumeration.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 When calling this method, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter must match the value returned from the [GetAttributes](../vs140/idebugevent2--getattributes.md) method as called on the event object passed in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter.  
  
 All debug events are posted asynchronously, regardless of whether an event itself is asynchronous or not. When a DE calls this method, the return value does not indicate whether the event was processed, only whether the event was received. In fact, under most circumstances, the event has not been processed when this method returns.  
  
## See Also  
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)   
 [IDebugEngine2](../vs140/idebugengine2.md)   
 [IDebugProcess2](../vs140/idebugprocess2.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)   
 [IDebugThread2](../vs140/idebugthread2.md)   
 [IDebugEvent2](../vs140/idebugevent2.md)   
 [EVENTATTRIBUTES](../vs140/eventattributes.md)