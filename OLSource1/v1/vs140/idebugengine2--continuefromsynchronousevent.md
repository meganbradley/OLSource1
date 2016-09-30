---
title: "IDebugEngine2::ContinueFromSynchronousEvent"
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
  - "IDebugEngine2::ContinueFromSynchronousEvent"
helpviewer_keywords: 
  - "IDebugEngine2::ContinueFromSynchronousEvent"
ms.assetid: 9a57dfcd-df8e-4be5-b1fe-bd853e3c6bb2
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugEngine2::ContinueFromSynchronousEvent
Called by the session debug manager (SDM) to indicate that a synchronous debug event, previously sent by the debug engine (DE) to the SDM, was received and processed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] An [IDebugEvent2](../vs140/idebugevent2.md) object that represents the previously sent synchronous event from which the debugger should now continue.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The DE must verify that it was the source of the event represented by the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that implements the [IDebugEngine2](../vs140/idebugengine2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugEngine2](../vs140/idebugengine2.md)   
 [IDebugEvent2](../vs140/idebugevent2.md)