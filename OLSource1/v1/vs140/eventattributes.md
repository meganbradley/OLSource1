---
title: "EVENTATTRIBUTES"
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
  - "EVENTATTRIBUTES"
helpviewer_keywords: 
  - "EVENTATTRIBUTES enumeration"
ms.assetid: 04db10f7-df31-4464-98e8-b3777428179e
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# EVENTATTRIBUTES
Specifies the event attributes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Members  
 EVENT_ASYNCHRONOUS  
 Indicates that the event is asynchronous and no reply to the event is needed.  
  
 EVENT_SYNCHRONOUS  
 Indicates that the event is synchronous; reply by means of [ContinueFromSynchronousEvent](../vs140/idebugengine2--continuefromsynchronousevent.md).  
  
 EVENT_STOPPING  
 Indicates that this is a stopping event. Must be combined with either <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 EVENT_ASYNC_STOP  
 Indicates an asynchronous stopping event. There is currently no such event. This flag is only a placeholder.  
  
 EVENT_SYNC_STOP  
 Indicates a synchronous stopping event (a combination of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>). This value is used by a debug engine (DE) when it sends a stopping event. The reply is made by means of a call to [Execute](../vs140/idebugprogram2--execute.md), [Step](../vs140/idebugprogram2--step.md), or [Continue](../vs140/idebugprogram2--continue.md).  
  
 EVENT_IMMEDIATE  
 Indicates an event that is sent immediately and synchronously to the IDE. This flag is combined with other flags like <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to indicate the type of event and the fact that the reply mechanism (if any) is known.  
  
 EVENT_EXPRESSION_EVALUATION  
 The event is a result of expression evaluation.  
  
## Remarks  
 These values are passed in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter of the [IDebugEventCallback2::Event](../vs140/idebugeventcallback2--event.md) method.  
  
 These values may be combined with a bitwise <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [ContinueFromSynchronousEvent](../vs140/idebugengine2--continuefromsynchronousevent.md)   
 [IDebugEventCallback2::Event](../vs140/idebugeventcallback2--event.md)