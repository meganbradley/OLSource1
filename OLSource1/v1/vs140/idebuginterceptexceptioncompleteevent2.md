---
title: "IDebugInterceptExceptionCompleteEvent2"
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
  - "IDebugInterceptExceptionCompleteEvent2"
helpviewer_keywords: 
  - "IDebugInterceptExceptionCompleteEvent2"
ms.assetid: 8ebc256b-5428-4ed6-a505-6aedc8242b8e
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugInterceptExceptionCompleteEvent2
This interface is sent by the debug engine (DE) to the session debug manager (SDM) when the DE has completed the handling of an intercepted event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Notes for Implementers  
 The DE implements this interface to report that processing of an intercepted exception has been completed. The [IDebugEvent2](../vs140/idebugevent2.md) interface must be implemented on the same object as this interface. The SDM uses [QueryInterface](../vs140/queryinterface.md) to access the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface.  
  
## Notes for Callers  
 The DE creates and sends this event object to report the completion of an intercepted exception. The event is sent by using the [IDebugEventCallback2](../vs140/idebugeventcallback2.md) callback function that is supplied by the SDM when it attached to the program being debugged.  
  
## Methods in Vtable Order  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface implements the following methods.  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie](../vs140/idebuginterceptexceptioncompleteevent2--getinterceptcookie.md)|Returns the unique value associated with the handled exception.|  
  
## Remarks  
 This event will be sent by [IDebugStackFrame3::InterceptCurrentException](../vs140/idebugstackframe3--interceptcurrentexception.md) when that method has successfully completed handling an intercepted exception.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Core Interfaces](../vs140/core-interfaces.md)   
 [IDebugStackFrame3::InterceptCurrentException](../vs140/idebugstackframe3--interceptcurrentexception.md)