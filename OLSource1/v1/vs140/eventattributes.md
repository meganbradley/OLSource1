---
title: "EVENTATTRIBUTES"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - EVENTATTRIBUTES
helpviewer_keywords: 
  - EVENTATTRIBUTES enumeration
ms.assetid: 04db10f7-df31-4464-98e8-b3777428179e
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# EVENTATTRIBUTES
Specifies the event attributes.  
  
## Syntax  
  
```cpp#  
enum enum_EVENTATTRIBUTES {   
   EVENT_ASYNCHRONOUS          = 0x0000,  
   EVENT_SYNCHRONOUS           = 0x0001,  
   EVENT_STOPPING              = 0x0002,  
   EVENT_ASYNC_STOP            = 0x0002,  
   EVENT_SYNC_STOP             = 0x0003,  
   EVENT_IMMEDIATE             = 0x0004,  
   EVENT_EXPRESSION_EVALUATION = 0x0008  
};  
typedef DWORD EVENTATTRIBUTES;  
```  
  
```c#  
public enum enum_EVENTATTRIBUTES {   
   EVENT_ASYNCHRONOUS          = 0x0000,  
   EVENT_SYNCHRONOUS           = 0x0001,  
   EVENT_STOPPING              = 0x0002,  
   EVENT_ASYNC_STOP            = 0x0002,  
   EVENT_SYNC_STOP             = 0x0003,  
   EVENT_IMMEDIATE             = 0x0004,  
   EVENT_EXPRESSION_EVALUATION = 0x0008  
};  
```  
  
## Members  
 EVENT_ASYNCHRONOUS  
 Indicates that the event is asynchronous and no reply to the event is needed.  
  
 EVENT_SYNCHRONOUS  
 Indicates that the event is synchronous; reply by means of [ContinueFromSynchronousEvent](../vs140/idebugengine2--continuefromsynchronousevent.md).  
  
 EVENT_STOPPING  
 Indicates that this is a stopping event. Must be combined with either `EVENT_ASYNCHRONOUS` or `EVENT_SYNCHRONOUS`.  
  
 EVENT_ASYNC_STOP  
 Indicates an asynchronous stopping event. There is currently no such event. This flag is only a placeholder.  
  
 EVENT_SYNC_STOP  
 Indicates a synchronous stopping event (a combination of `EVENT_SYNCHRONOUS` and `EVENT_STOPPING`). This value is used by a debug engine (DE) when it sends a stopping event. The reply is made by means of a call to [Execute](../vs140/idebugprogram2--execute.md), [Step](../vs140/idebugprogram2--step.md), or [Continue](../vs140/idebugprogram2--continue.md).  
  
 EVENT_IMMEDIATE  
 Indicates an event that is sent immediately and synchronously to the IDE. This flag is combined with other flags like `EVENT_ASYNCHRONOUS`, `EVENT_SYNCHRONOUS`, or `EVENT_SYNC_STOP` to indicate the type of event and the fact that the reply mechanism (if any) is known.  
  
 EVENT_EXPRESSION_EVALUATION  
 The event is a result of expression evaluation.  
  
## Remarks  
 These values are passed in the `dwAttrib` parameter of the [IDebugEventCallback2::Event](../vs140/idebugeventcallback2--event.md) method.  
  
 These values may be combined with a bitwise `OR`.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [ContinueFromSynchronousEvent](../vs140/idebugengine2--continuefromsynchronousevent.md)   
 [IDebugEventCallback2::Event](../vs140/idebugeventcallback2--event.md)